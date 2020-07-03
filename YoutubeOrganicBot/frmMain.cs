using IniParser;
using IniParser.Model;
using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using UHWID;
using YoutubeOrganicBot.Helper;

namespace YoutubeOrganicBot
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {        
        IWebDriver driver;

        public frmMain()
        {
            InitializeComponent();

            LoadProfiles();

            activeUsersList.EditValue = cbActiveUsersList.Items[0].ToString();

            InitPaths();

            if (File.Exists(YTGlobalSettings.SETTING_PATH))
            {
                var strJson = File.ReadAllText(YTGlobalSettings.SETTING_PATH);
                Settings settingTime = JsonConvert.DeserializeObject<Settings>(strJson);
                YTGlobalSettings.settingTime = settingTime;
            }
            YTGlobalSettings.prelogData.Columns.Add(new DataColumn("Islem", typeof(string)));
            YTGlobalSettings.prelogData.Columns.Add(new DataColumn("KanalAdi", typeof(string)));
            YTGlobalSettings.prelogData.Columns.Add(new DataColumn("KanalUri", typeof(string)));            
            grdLog.DataSource = YTGlobalSettings.prelogData;
        }

        private void InitPaths()
        {
            YTGlobalSettings.CHANNELS_FILE_PATH = $"{Application.StartupPath}\\Profiles\\{YTGlobalSettings.selectedProfile}\\kanallar.txt";
            YTGlobalSettings.COMMENTS_FILE_PATH = $"{Application.StartupPath}\\Profiles\\{YTGlobalSettings.selectedProfile}\\yorumlar.txt";
            YTGlobalSettings.USEDCHANNELS_FILE_PATH = $"{Application.StartupPath}\\Profiles\\{YTGlobalSettings.selectedProfile}\\gecmiskanallar.txt";
            YTGlobalSettings.ATASOZLERI_FILE_PATH = $"{Application.StartupPath}\\Profiles\\sozler.txt";
            YTGlobalSettings.SETTING_PATH = $"{Application.StartupPath}\\\\Profiles\\settings.json";
        }

        #region Functions

        private string GetLastVideo()
        {
            if (IsElementPresent(By.CssSelector("#items a[id='thumbnail']")))
            {
                var itemsDiv = driver.FindElement(By.CssSelector("#items a[id='thumbnail']"));

                return itemsDiv.GetAttribute("href");
            }

            return string.Empty;
        }

        public void GetFFExecutePath()
        {
            RegistryKey browserKeys;
            browserKeys =   Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\Clients\StartMenuInternet");
            if (browserKeys == null)
                browserKeys = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Clients\StartMenuInternet");

            string[] browserNames = browserKeys.GetSubKeyNames();

            foreach (var item in browserNames)
            {
                var commandKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Clients\StartMenuInternet\" + item + @"\shell\open\command");
                if (commandKey != null)
                {
                    var brwPath = commandKey.GetValue("");
                    if (brwPath.ToString().Contains("firefox.exe"))
                    {
                        YTGlobalSettings.FFExecutePath = brwPath.ToString();
                    }
                }
            }
        }

        protected void WaitForPageLoad(IWebDriver driver)
        {
            try
            {
                IJavaScriptExecutor javaScriptExecutor = (IJavaScriptExecutor)driver;
                WebDriverWait webDriverWait = new WebDriverWait(driver, new TimeSpan(0, 0, 15));
                webDriverWait.Until<bool>((IWebDriver wd) => javaScriptExecutor.ExecuteScript("return document.readyState").Equals("complete"));
            }
            catch (Exception){}
        }

        protected void RunJSCommand(IWebDriver driver, string jsCommand, object[] options = null)
        {
            IJavaScriptExecutor javaScriptExecutor = (IJavaScriptExecutor)driver;
            if (options != null)
            {
                javaScriptExecutor.ExecuteScript(jsCommand, options);
            }
            else
            {
                javaScriptExecutor.ExecuteScript(jsCommand);
            }
            
        }

        public double GetScrollPosition(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            var value = js.ExecuteScript("return window.pageYOffset");
            return Convert.ToDouble(value);
        }

        public void GotoTop(IWebDriver driver)
        {
            RunJSCommand(driver, "window.scrollTo(0,700)");
        }

        public void GotoButtom(IWebDriver driver)
        {
            RunJSCommand(driver, $"window.scrollTo(100,500);");

            Thread.Sleep(2000);

            while (!IsElementPresent(By.CssSelector("yt-next-continuation.ytd-item-section-renderer")))
            {
                break;
            }
        }
        public List<string> GetCommenders()
        {
            List<string> commenders = new List<string>();

            try
            {
                var commenderItems = driver.FindElements(By.CssSelector("#author-text"));
                foreach (var item in commenderItems)
                {
                    commenders.Add(item.GetAttribute("href"));
                }

                return commenders;
            }
            catch (Exception err)
            {
                LogManager.LogToFile(err.StackTrace);
                return commenders;
            }
        }

        private bool IsElementPresent(By by)
        {
            bool Founded = false;
            Stopwatch sw = null;
            if ((bool)btnActiveDebug.EditValue)
            {
                sw = new Stopwatch();
                sw.Start();
                ToLog(new YTLog
                {
                    KanalAdi = "",
                    YTUri = "",
                    Islem = "Waiting Element For 20 Second"
                });
            }

            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
                IWebElement element = wait.Until(driver => driver.FindElement(by));
                if (element.Displayed)
                {
                    Founded = true;
                }
                else
                {
                    Founded = false;
                }
            }
            catch (Exception err) { /*LogManager.LogToFile(err.StackTrace);*/ }
            if ((bool)btnActiveDebug.EditValue)
            {
                sw.Stop();
                ToLog(new YTLog
                {
                    KanalAdi = "",
                    YTUri = "",
                    Islem = $"Waiting Element Finish {sw.Elapsed.TotalSeconds}"
                });
            }
            return Founded;
        }

        public string ExtractYTVideoID(string url)
        {
            var uri = new Uri(url);
            
            var query = HttpUtility.ParseQueryString(uri.Query);

            var videoId = string.Empty;

            if (query.AllKeys.Contains("v"))
            {
                videoId = query["v"];
            }

            return videoId;
        }

        public async Task<object> GetLicenseDetail(string channeld)
        {
            var formContent = new FormUrlEncodedContent(new[]
            {
                    new KeyValuePair<string, string>("yturi", channeld),
                    new KeyValuePair<string, string>("hwid",UHWIDEngine.AdvancedUid)
            });

            HttpClient client = new HttpClient();

            var response = await client.PostAsync($"{YTGlobalSettings.BASE_SERVER_URI}/license/ReqDemo", formContent);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<Lisans>(await response.Content.ReadAsStringAsync());
            }

            return new JArray();
        }

        public void ScroolToElement(IWebElement element)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }

        int licCounter = 0;
        int needLicRefreshCounter = 0;
        public async void LicenseCheck()
        {
            try
            {
                string channelUri = string.Empty;
                if (needLicRefreshCounter > 10 || needLicRefreshCounter == 0)
                {
                    driver.Navigate().GoToUrl("https://www.youtube.com/account_advanced");

                    WaitForPageLoad(driver);

                }
                else
                {
                    return;
                }

                Match ytCHID = Regex.Match(driver.PageSource, "\"UC(.*?)\"");

                if (!ytCHID.Success)
                {
                    backTask.CancelAsync();
                    if (driver != null)
                    {
                        driver.Quit();
                    }
                    ToLog(new YTLog
                    {
                        KanalAdi = "",
                        YTUri = "",
                        Islem = "Kanal ID si bulunamadı. Satıcı ile iletişime geçiniz."
                    });
                    isStartted = false;
                    return;
                }

                YTGlobalSettings.FIRST_RECIEVED_CHANNELID = ytCHID.Value.Replace("\"", "").Replace("\\", "");

                var response = await GetLicenseDetail(ytCHID.Value.Replace("\"", "").Replace("\\", ""));

                if (response is Lisans)
                {
                    DateTime bitisTarihi = DateTime.Parse(((Lisans)response).bitistarihi);
                    DateTime suan = DateTime.Parse(((Lisans)response).now);

                    if ((suan == bitisTarihi || suan > bitisTarihi) || ((Lisans)response).aktif == 0)
                    {
                        if (driver != null)
                        {
                            driver.Quit();
                        }
                        backTask.CancelAsync();
                        ToLog(new YTLog
                        {
                            KanalAdi = "",
                            YTUri = "",
                            Islem = "Lisans süreniz dolmuştur. Lütfen satıcınız ile irtibata geçiniz."
                        });
                        isStartted = false;
                        StoppedButtons();
                        return;
                    }
                    else
                    {
                        //lblLicText.Text = $"Kişi Adı = {((Lisans)response).kisiadi} Bitiş Zamanı = {((Lisans)response).bitistarihi} Lisans Kodu = {((Lisans)response).licenseKey}";
                        txtLicenseOwner.Caption = ((Lisans)response).kisiadi;
                        if (needLicRefreshCounter > 10)
                            needLicRefreshCounter = 0;
                    }
                }
                else
                {
                    if (licCounter <= 4)
                    {
                        licCounter++;

                        await Task.Delay(5000);
                        LicenseCheck();
                    }
                    else
                    {
                        backTask.CancelAsync();
                        if (driver != null)
                        {
                            driver.Quit();
                        }
                        ToLog(new YTLog
                        {
                            KanalAdi = "",
                            YTUri = "",
                            Islem = "Lisans alınamadı. Lütfen internet bağlantınızı kontrol edip tekrar deneyiniz."
                        });
                        isStartted = false;
                        return;
                    }
                }
            }
            catch (Exception err)
            {
                LogManager.LogToFile(err.StackTrace);
            }
        }

        void StartedButtons()
        {
            btnStopJob.Enabled = true;
            btnStartJob.Enabled = false;
            btnStartJob.Enabled = false;
            btnProfileManager.Enabled = false;
            btnRefreshActiveUsers.Enabled = false;
            btnInitActiveUser.Enabled = false;
        }

        void StoppedButtons()
        {
            isStartted = false;
            backTask.CancelAsync();
            btnStopJob.Enabled = false;
            btnStartJob.Enabled = true;
            btnProfileManager.Enabled = true;
            btnRefreshActiveUsers.Enabled = true;
            btnInitActiveUser.Enabled = true;
        }

        public async void StartJob()
        {
            StartedButtons();

            try
            {
                if (File.Exists(YTGlobalSettings.CHANNELS_FILE_PATH) && 
                    File.Exists(YTGlobalSettings.COMMENTS_FILE_PATH) && 
                    File.Exists(YTGlobalSettings.USEDCHANNELS_FILE_PATH))
                {
                    if (YTGlobalSettings.settingTime == null)
                    {
                        MessageBox.Show("Ayarlar kısmından zaman ayarlarını tanımlamalısınız.");
                        backTask.CancelAsync();
                        StoppedButtons();
                        return;
                    }

                    isStartted = true;
                    bool isStoppedNextVideo = false;
                    int rowNumber = 0;
                    YTGlobalSettings.lstUsedChannels.AddRange(File.ReadAllLines(YTGlobalSettings.USEDCHANNELS_FILE_PATH));
                    List<string> FETCHED_CHANNELS = new List<string>();
                    FETCHED_CHANNELS.AddRange(File.ReadAllLines(YTGlobalSettings.CHANNELS_FILE_PATH));
                    txtTotalChannels.Caption = $"Toplam kanal {FETCHED_CHANNELS.Count.ToString()} adet.{Environment.NewLine}";
                    var result = GotoYoutubePage();

                    if (!result)
                    {
                        return;
                    }

                    do
                    {
                        LicenseCheck();

                        //Phishing();

                        txtUsedChannelsCount.Caption = rowNumber.ToString();
                        string ChannelName = string.Empty;

                        try
                        {
                            if (rowNumber > FETCHED_CHANNELS.Count)
                            {
                                backTask.CancelAsync();
                                ToLog(new YTLog
                                {
                                    KanalAdi = ChannelName,
                                    YTUri = FETCHED_CHANNELS[rowNumber],
                                    Islem = "Kanallar Bitti."
                                });
                                if (driver != null)
                                {
                                    driver.Quit();
                                }
                                StoppedButtons();
                                break;
                            }

                            if (!isStartted)
                            {
                                backTask.CancelAsync();
                                ToLog(new YTLog
                                {
                                    KanalAdi = "",
                                    YTUri = "",
                                    Islem = "İşlem durduruldu."
                                });
                                if (driver != null)
                                {
                                    driver.Quit();
                                }
                                StoppedButtons();
                                break;
                            }

                            try
                            {
                                driver.Navigate().GoToUrl($"{FETCHED_CHANNELS[rowNumber]}/videos");

                                WaitForPageLoad(driver);

                                if (IsElementPresent(By.CssSelector("yt-formatted-string.style-scope.ytd-channel-name")))
                                {
                                    ChannelName = driver.FindElement(By.CssSelector("yt-formatted-string.style-scope.ytd-channel-name")).Text;
                                }
                            }
                            catch (ArgumentOutOfRangeException err)
                            {
                                LogManager.LogToFile(err.StackTrace);
                                ToLog(new YTLog
                                {
                                    KanalAdi = "",
                                    YTUri = "",
                                    Islem = $"Kanal bitti {FETCHED_CHANNELS.Count} - {rowNumber}"
                                });
                                
                                backTask.CancelAsync();
                                if (driver != null)
                                {
                                    driver.Quit();
                                }
                                StoppedButtons();
                                break;
                            }

                            //son videoyu getir
                            string lastVideo = GetLastVideo();

                            if (!String.IsNullOrEmpty(lastVideo))
                            {//son video var

                                if (YTGlobalSettings.lstUsedChannels.Contains(ExtractYTVideoID(lastVideo)))
                                {
                                    //daha önce kullanılmış
                                    ToLog(new YTLog
                                    {
                                        KanalAdi = ChannelName,
                                        YTUri = FETCHED_CHANNELS[rowNumber],
                                        Islem = $"{lastVideo} daha önce kullanılmış."
                                    });
                                    rowNumber++;
                                    needLicRefreshCounter++;
                                    continue;
                                }

                                //son videoya git
                                driver.Navigate().GoToUrl(lastVideo);

                                //sayfanın yüklenmesini bekle
                                WaitForPageLoad(driver);

                                //sonraki videoya geçişi kontrol et
                                var nextVideo = IsElementPresent(By.Id("toggleButton"));
                                if (nextVideo && !isStoppedNextVideo)
                                {
                                    var stopNextVideo = driver.FindElement(By.Id("toggleButton"));
                                    stopNextVideo.Click();
                                    ToLog(new YTLog
                                    {
                                        KanalAdi = ChannelName,
                                        YTUri = FETCHED_CHANNELS[rowNumber],
                                        Islem = "Sonraki Videoya Geçiş Duraklatıldı"
                                    });
                                    isStoppedNextVideo = true;
                                }

                                //videonun sesini kıs
                                RunJSCommand(driver, "videos = document.querySelectorAll(\"video\"); for(video of videos) {video.muted = true}");

                                await Task.Delay(new Random().Next(YTGlobalSettings.settingTime.RandomWaitMin, YTGlobalSettings.settingTime.RandomWaitMax));

                                //yorum alanına git
                                GotoButtom(driver);

                                //yorum alanı varmı kontrol et
                                var txtCommentFind = IsElementPresent(By.Id("placeholder-area"));
                                if (!txtCommentFind)
                                {
                                    ToLog(new YTLog
                                    {
                                        KanalAdi = ChannelName,
                                        YTUri = FETCHED_CHANNELS[rowNumber],
                                        Islem = "Yoruma Kapalı"
                                    });
                                    AddToUsedVideos(lastVideo);
                                    rowNumber++;
                                    needLicRefreshCounter++;
                                    continue;
                                }

                                //videoyu izle
                                await WatchVideo();

                                //videoyu beğen
                                await ClickLikeButton(rowNumber, FETCHED_CHANNELS);

                                //yorum gönder
                                var isCommended = await SendComment(lastVideo, txtCommentFind, ChannelName);

                                if (isCommended)
                                {
                                    //gönderildi ise işlem görenlere ekle
                                    AddToUsedVideos(lastVideo);
                                }
                                else
                                {
                                    ToLog(new YTLog
                                    {
                                        KanalAdi = ChannelName,
                                        YTUri = FETCHED_CHANNELS[rowNumber],
                                        Islem = "Yorum alanı bulunamadı"
                                    });
                                }
                                //abone ol
                                await ClickSubscribe(rowNumber, FETCHED_CHANNELS);
                                //yorumcuları çek
                                await WaitCommenders(FETCHED_CHANNELS);

                                rowNumber++;// bir sonraki video için sıra numarası
                                needLicRefreshCounter++;//bu er 10 videoda bir lisans kontrolü için gerekli
                                await Task.Delay(new Random().Next(YTGlobalSettings.settingTime.AfterVideoMinWait, YTGlobalSettings.settingTime.AfterVideoMaxWait));
                            }
                            else
                            {
                                //video yok
                                ToLog(new YTLog
                                {
                                    KanalAdi = ChannelName,
                                    YTUri = FETCHED_CHANNELS[rowNumber],
                                    Islem = "Bu kanalda video yok"
                                });
                                rowNumber++;
                                needLicRefreshCounter++;
                                continue;
                            }
                        }
                        catch (Exception err)
                        {
                            LogManager.LogToFile(err.StackTrace);
                            ToLog(new YTLog
                            {
                                KanalAdi = "",
                                YTUri = "",
                                Islem = $"Hata var = {err.StackTrace}"
                            });
                            
                        }

                        if ((rowNumber % 10) == 0)
                        {
                            await Task.Delay(new Random().Next(YTGlobalSettings.settingTime.AfterVideoMinWait, YTGlobalSettings.settingTime.AfterVideoMaxWait));
                        }

                        if ((rowNumber % 80) == 0)
                        {
                            YTGlobalSettings.prelogData.Rows.Clear();
                        }
                    } while (isStartted);
                }
                else
                {
                    MessageBox.Show("Ayarlar kısmından kanal ve yorumları doldurmanız gerekiyor.");
                    backTask.CancelAsync();
                    StoppedButtons();
                }
            }
            catch (Exception err)
            {
                LogManager.LogToFile(err.StackTrace);
                ToLog(new YTLog
                {
                    KanalAdi = "",
                    YTUri = "",
                    Islem = err.Message
                });
                
            }
        }

        private void AddToUsedVideos(string lastVideo)
        {
            YTGlobalSettings.lstUsedChannels.Add(ExtractYTVideoID(lastVideo));
            Console.WriteLine(ExtractYTVideoID(lastVideo));
            File.AppendAllLines(YTGlobalSettings.USEDCHANNELS_FILE_PATH, new[] { ExtractYTVideoID(lastVideo) });
        }

        private async Task<bool> SendComment(string lastVideo, bool txtCommentFind,string channelName)
        {
            if (txtCommentFind)
            {
                try
                {
                    if (!File.Exists(YTGlobalSettings.COMMENTS_FILE_PATH))
                    {
                        MessageBox.Show("Yorumlar dosyası yok.");
                        return false;
                    }else if (!File.Exists(YTGlobalSettings.ATASOZLERI_FILE_PATH))
                    {
                        MessageBox.Show("Sözler dosyası yok.");
                        return false;
                    }

                    var comments = File.ReadAllLines(YTGlobalSettings.COMMENTS_FILE_PATH);//yorumları çek
                    var sozler = File.ReadAllLines(YTGlobalSettings.ATASOZLERI_FILE_PATH);//sözleri çek

                    //yorum alanına tıkla
                    driver.FindElement(By.Id("placeholder-area")).Click();
                    string[] icons = { "👍", "🌹", "🔔", "👋", "✔️", "👍", "🔔", "🍀", "✨", "👉", "💎", "💫", "🙋", "👌", "🔔", "☆", "🔔", "✋", "😎", "✌" };
                    string prepIcon = string.Concat(Enumerable.Repeat(icons[new Random().Next(icons.Count())],3));
                    var commentArea = driver.FindElement(By.Id("contenteditable-root"));
                    string prepCommend = $"{channelName} {prepIcon} ";

                    //özel yazı etkinmi kontrol et
                    if (YTGlobalSettings.settingTime.IsCustomTextActive)
                    {
                        if (!String.IsNullOrEmpty(YTGlobalSettings.settingTime.PreCaption))
                        {
                            //ön yazı etkin se yazdır Örn : Özlü Söz , Atasözü gibi
                            prepCommend += $"{YTGlobalSettings.settingTime.PreCaption} ";
                        }
                        prepCommend += $"{sozler[new Random().Next(sozler.Count())]}. ";
                    }
                    prepCommend += $"{comments[new Random().Next(comments.Count())]} {prepIcon}";

                    //Yorumu gönder
                    commentArea.SendKeys(prepCommend);
                    await Task.Delay(new Random().Next(YTGlobalSettings.settingTime.RandomWaitMin, YTGlobalSettings.settingTime.RandomWaitMax));
                    driver.FindElement(By.XPath("//ytd-button-renderer[@id='submit-button']/a/paper-button")).Click();
                    
                    ToLog(new YTLog
                    {
                        KanalAdi = channelName,
                        YTUri = lastVideo,
                        Islem = "Yorum Gönderildi"
                    });
                    await Task.Delay(new Random().Next(YTGlobalSettings.settingTime.RandomWaitMin, YTGlobalSettings.settingTime.RandomWaitMax));
                    return true;
                }
                catch (Exception err)
                {
                    LogManager.LogToFile(err.StackTrace);
                    ToLog(new YTLog
                    {
                        KanalAdi = channelName,
                        YTUri = lastVideo,
                        Islem = $"Yorum hatası = {err.Message}"
                    });
                    
                    return false;
                }
            }

            return false;
        }

        private async Task ClickLikeButton(int rowNumber, List<string> FETCHED_CHANNELS)
        {
            var btnLikeFind = IsElementPresent(By.CssSelector(".ytd-menu-renderer:nth-child(1) > .yt-simple-endpoint > #button"));
            if (btnLikeFind)
            {
                var btnLike = driver.FindElement(By.CssSelector(".ytd-menu-renderer:nth-child(1) > .yt-simple-endpoint > #button"));
                btnLike.Click();
                ToLog(new YTLog
                {
                    KanalAdi = "",
                    YTUri = "",
                    Islem = "Like Atıldı "
                });
            }

            await Task.Delay(new Random().Next(YTGlobalSettings.settingTime.RandomWaitMin, YTGlobalSettings.settingTime.RandomWaitMax));
        }

        private async Task WaitCommenders(List<string> FETCHED_CHANNELS)
        {
            ToLog(new YTLog
            {
                KanalAdi = "",
                YTUri = "",
                Islem = "Yorumcular bekleniyor"
            });
            
            var commenders = GetCommenders();

            for (int i = 0; i < commenders.Count; i++)
            {
                if (!FETCHED_CHANNELS.Contains(commenders[i]))
                {
                    FETCHED_CHANNELS.Add(commenders[i]);
                }
            }
            ToLog(new YTLog
            {
                KanalAdi = "",
                YTUri = "",
                Islem = $"Yorumcular çekildi .Toplam kanal {FETCHED_CHANNELS.Count.ToString()} adet"
            });
            
            txtTotalChannels.Caption = $"Toplam kanal {FETCHED_CHANNELS.Count.ToString()} adet.{Environment.NewLine}";
            await Task.Delay(new Random().Next(YTGlobalSettings.settingTime.RandomWaitMin, YTGlobalSettings.settingTime.RandomWaitMax));
        }
        private async Task ClickSubscribe(int rowNumber, List<string> FETCHED_CHANNELS)
        {
            try
            {
                var btnSubscribeFind = IsElementPresent(By.XPath("//div[@id='subscribe-button']/ytd-subscribe-button-renderer/paper-button"));
                //abone ol butonunu bul
                if (btnSubscribeFind)
                {
                    //bulunca tıkla
                    var subscribeButton = driver.FindElement(By.XPath("//div[@id='subscribe-button']/ytd-subscribe-button-renderer/paper-button"), 5);
                    subscribeButton.Click();
                    ToLog(new YTLog
                    {
                        KanalAdi = "",
                        YTUri = FETCHED_CHANNELS[rowNumber],
                        Islem = "Abone Ol Tıklandı"
                    });

                    await Task.Delay(new Random().Next(YTGlobalSettings.settingTime.RandomWaitMin, YTGlobalSettings.settingTime.RandomWaitMax));

                    //daha önce abone olmuşmu kontrol et
                    if (IsElementPresent(By.XPath("//yt-confirm-dialog-renderer")))//Daha önce abone olunmuş
                    {
                        if (IsElementPresent(By.XPath("//yt-button-renderer[@id='cancel-button']/a/paper-button")))
                        {
                            ToLog(new YTLog
                            {
                                KanalAdi = "",
                                YTUri = FETCHED_CHANNELS[rowNumber],
                                Islem = "Cancel button found"
                            });
                            driver.FindElement(By.XPath("//yt-button-renderer[@id='cancel-button']/a/paper-button")).Click();
                        }
                        ToLog(new YTLog
                        {
                            KanalAdi = "",
                            YTUri = FETCHED_CHANNELS[rowNumber],
                            Islem = "Daha önce abone olunmuş"
                        });
                    }
                    else if (IsElementPresent(By.XPath("//ytd-modal-with-title-and-button-renderer")))
                    {
                        //eğer abone olma sınırına ulaşıldıysa
                        try
                        {
                            driver.FindElement(By.CssSelector("#button > .ytd-button-renderer > #button")).Click();
                        }
                        catch (Exception) { }
                        ToLog(new YTLog
                        {
                            KanalAdi = "",
                            YTUri = FETCHED_CHANNELS[rowNumber],
                            Islem = "Abone Olma Sınırına Ulaşılmış."
                        });
                    }
                    else
                    {
                        ToLog(new YTLog
                        {
                            KanalAdi = "",
                            YTUri = "",
                            Islem = "Abone Olundu"
                        });
                    }
                }
            }
            catch (Exception err)
            {
                LogManager.LogToFile("Abone Ol Hatası = " + Environment.NewLine +err.StackTrace);
            }
        }

        private async Task WatchVideo()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            ToLog(new YTLog
            {
                KanalAdi = "",
                YTUri = "",
                Islem = "Video izlemek için bekleniliyor"
            });

            await Task.Delay(new Random().Next(YTGlobalSettings.settingTime.WatchTimeMin, YTGlobalSettings.settingTime.WatchTimeMax));
            stopwatch.Stop();
            ToLog(new YTLog
            {
                KanalAdi = "",
                YTUri = "",
                Islem = String.Format("Video İzleme Süresi : {0:hh\\:mm\\:ss}", stopwatch.Elapsed)
            });

            ToLog(new YTLog
            {
                KanalAdi = "",
                YTUri = "",
                Islem = "Video izleme bitti"
            });
        }

        #endregion
        private bool GotoYoutubePage()
        {
            try
            {
                FirefoxDriverService ffService = FirefoxDriverService.CreateDefaultService();
                ffService.HideCommandPromptWindow = true;
               
                FirefoxOptions ffOptions = new FirefoxOptions();
                ffOptions.AddArguments(new[] { "--disable-web-security", "--user-data-dir", "--allow-running-insecure-content" });

                string pathToCurrentUserProfiles = Environment.ExpandEnvironmentVariables("%APPDATA%") + @"\Mozilla\Firefox\Profiles";
                string[] pathsToProfiles = Directory.GetDirectories(pathToCurrentUserProfiles, $"*.{activeUsersList.EditValue}", SearchOption.TopDirectoryOnly);
                string profilePath = string.Empty;
                if (pathsToProfiles.Length != 0)
                {
                    profilePath = pathsToProfiles[0];
                }
                else
                {
                    MessageBox.Show("Profil bulunamadı");
                }

                if (!File.Exists(profilePath + "\\cookies.sqlite"))
                {
                    backTask.CancelAsync();
                    if (driver != null)
                    {
                        driver.Quit();
                    }
                    MessageBox.Show("Firefox profili oluşturulmamış. Profil Yöneticisinden profil oluşturup profil hazırla diyerek önce profilinizi hazırlayıp. Sisteme gmail ile giriş yapmalısınız.");
                    return false;
                }

                FirefoxProfile ffProfile = new FirefoxProfile(profilePath);
                ffProfile.SetPreference("media.autoplay.default", 0);
                ffOptions.Profile = ffProfile;

                if (driver != null)
                {
                    driver.Quit();
                }

                driver = new FirefoxDriver(ffService, ffOptions);

                driver.Url = "https://www.youtube.com";

                driver.Manage().Window.Maximize();

                return true;
            }
            catch (Exception err)
            {
                LogManager.LogToFile(err.StackTrace);
                ToLog(new YTLog
                {
                    KanalAdi = "",
                    YTUri = "",
                    Islem = err.StackTrace
                });
                return false;
            }
        }

        void ToLog(YTLog log)
        {
            DataRow row = YTGlobalSettings.prelogData.NewRow();
            row["KanalAdi"] = log.KanalAdi;
            row["KanalUri"] = log.YTUri;
            row["Islem"] = log.Islem;
            YTGlobalSettings.prelogData.Rows.Add(row);
        }

        void CheckFFAndClose()
        {
            Process.GetProcesses()
                               .Where(x => (x.ProcessName.ToLower().Contains("firefox"))
                                    && (x.ProcessName.ToLower().Contains("gecko"))
                                    && (x.ProcessName.ToLower().Contains("conhost")))
                               .ToList()
                               .ForEach(x => x.Kill());
        }

        bool isStartted = false;
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (driver != null)
                driver.Quit();

            Application.OpenForms["frmSplash"].Close();
        }

        private void backTask_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            StartJob();
        }

        private void LoadProfiles()
        {
            GetFFExecutePath();
            cbActiveUsersList.Items.Clear();

            string APP_DATA = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string localFFProfiles = APP_DATA + "\\Mozilla\\Firefox\\profiles.ini";

            if (File.Exists(localFFProfiles))
            {
                var parser = new FileIniDataParser();
                IniData data = parser.ReadFile(localFFProfiles);
                foreach (var item in data.Sections.Where(x => x.SectionName.StartsWith("Profile")))
                {
                    if (!data[item.SectionName]["Name"].Contains("default"))
                        cbActiveUsersList.Items.Add(data[item.SectionName]["Name"]);
                }
            }
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {

        }
        private void btnProfileManager_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmProfileManager fpm = new frmProfileManager();
            fpm.ShowDialog();
            LoadProfiles();
        }

        private void btnStopJob_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            StoppedButtons();
            if (driver != null)
            {
                driver.Quit();
            }
            ToLog(new YTLog
            {
                KanalAdi = "",
                YTUri = "",
                Islem = "İşlem Durduruldu"
            });
        }

        private void btnAbout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }

        private void activeUsersList_EditValueChanged(object sender, EventArgs e)
        {

            YTGlobalSettings.selectedProfile = activeUsersList.EditValue.ToString();
            if (!String.IsNullOrEmpty(YTGlobalSettings.selectedProfile))
            {
                if (!Directory.Exists($"{YTGlobalSettings.PROFILE_DIR}\\{YTGlobalSettings.selectedProfile}"))
                {
                    MessageBox.Show($"Profil dosyası lokalde bulunamadığı için silinmesi gerekiyor.Profil adı {YTGlobalSettings.selectedProfile}");
                    Process.Start(YTGlobalSettings.FFExecutePath, "-p");
                    return;
                }
            }
            InitPaths();
        }

        private void btnStartJob_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (String.IsNullOrEmpty(YTGlobalSettings.selectedProfile))
            {
                MessageBox.Show("Önce Profil oluşturmalısınız.");
                return;
            }

            CheckForIllegalCrossThreadCalls = false;

            isStartted = true;

            CheckFFAndClose();
            ToLog(new YTLog
            {
                KanalAdi = "",
                YTUri = "",
                Islem = "Başladı"
            });

            backTask.RunWorkerAsync();
        }

        private void btnRefreshActiveUsers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadProfiles();
        }

        private void btnInitActiveUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (activeUsersList.EditValue != null)
            {
                string param = $"-P \"{activeUsersList.EditValue}\" -new-window \"accounts.google.com\"";
                Process.Start(YTGlobalSettings.FFExecutePath, param);
            }
        }

        private void btnYTSettings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmYTSettings ytSettings = new frmYTSettings();
            ytSettings.ShowDialog();
        }
    }

    public static class WebDriverExtensions
    {
        public static IWebElement FindElement(this IWebDriver driver, By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(ExpectedConditions.ElementToBeClickable(by));
            }
            return driver.FindElement(by);
        }
    }
}
