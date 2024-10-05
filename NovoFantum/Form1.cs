using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using WindowsInput;

using CefSharp.DevTools.Network;
using static System.Net.WebRequestMethods;
using CefSharp.DevTools.Storage;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NovoFantum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hwndParent, IntPtr hwndNewChild);

        public string GetWebpage()
        {

            try
            {
                string[] pages = {

"https://cookie-cdn.cookiepro.com/scripttemplates/otSDKStub.js",
"https://accounts.google.com/gsi/client",
"https://images.habbo.com/habbo-web/america/en/app.77047271.css",
"https://images.habbo.com/habbo-web/america/en/vendor.40069316.js",
"https://images.habbo.com/habbo-web/america/en/scripts.c8b10458.js",
"https://appleid.cdn-apple.com/appleauth/static/jsapi/appleid/1/en_US/appleid.auth.js",
"https://cookie-cdn.cookiepro.com/consent/9a83bf35-71d7-4c89-9101-77220edee470/9a83bf35-71d7-4c89-9101-77220edee470.json",
"https://images.habbo.com/habbo-web-l10n/com.json",
"https://images.habbo.com/habbo-web/america/en/assets/images/sprite.a51705e3.png",
"https://images.habbo.com/habbo-web/america/en/assets/images/sprite@2x.7942f80a.png",
"https://images.habbo.com/habbo-web/america/en/assets/images/backgrounds/hotel.5e0e63d8.png",
"https://images.habbo.com/habbo-web/america/en/assets/fonts/UbuntuRegular-latin.dae8c8b9.woff2",
"https://images.habbo.com/habbo-web/america/en/assets/fonts/UbuntuBold-latin.d6b93445.woff2",
"https://images.habbo.com/habbo-web/america/en/assets/fonts/UbuntuCondensed-latin.51eab248.woff2",
"https://connect.facebook.net/en_US/sdk.js",
"https://images.habbo.com/habbo-web-l10n/com.json",
"https://images.habbo.com/habbo-web-news/en/production/front.html",
"https://images.habbo.com/habbo-web/america/en/assets/images/sprite.a51705e3.png",
"https://cookie-cdn.cookiepro.com/scripttemplates/202311.1.0/otBannerSdk.js",
"https://connect.facebook.net/en_US/sdk.js?hash=976b077a61117c3c39cdf711149d1f4c",
"https://images.habbo.com/web_images/habbo-web-articles/lpromo_Aug24.png",
"https://images.habbo.com/web_images/habbo-web-articles/lpromo_Aug24_thumb.png",
"https://images.habbo.com/web_images/habbo-web-articles/lpromo_collectibles.png",
"https://images.habbo.com/web_images/habbo-web-articles/lpromo_collectibles_thumb.png",
"https://images.habbo.com/web_images/habbo-web-articles/lpromo_gen15_10.png",
"https://images.habbo.com/web_images/habbo-web-articles/lpromo_gen15_10_thumb.png",
"https://images.habbo.com/web_images/habbo-web-articles/lpromo_aug24_messenger.png",
"https://images.habbo.com/web_images/habbo-web-articles/lpromo_aug24_messenger_thumb.png",
"https://images.habbo.com/web_images/habbo-web-articles/lpromo_07082024-1.png",
"https://images.habbo.com/web_images/habbo-web-articles/lpromo_07082024-1_thumb.png",
"https://images.habbo.com/web_images/habbo-web-articles/lpromo_07082024.png",
"https://images.habbo.com/web_images/habbo-web-articles/lpromo_07082024_thumb.png",
"https://images.habbo.com/web_images/habbo-web-articles/lpromo_Bratz_Jul24.png",
"https://images.habbo.com/web_images/habbo-web-articles/lpromo_Bratz_Jul24_thumb.png",
"https://images.habbo.com/habbo-web-pages/production/common/box_learn_how_to_stay_safe.en.html",
"https://images.habbo.com/habbo-web-pages/production/common/box_parents_guide.en.html",
"https://js.hcaptcha.com/1/api.js?onload=hCaptchaOnloadCallback&render=explicit&recaptchacompat=off&hl=en",
"https://images.habbo.com/habbo-web/america/en/assets/images/landing/bg_topleft.c16c9d63.png",
"https://images.habbo.com/habbo-web/america/en/assets/images/landing/bg_topright.00cd59c5.png",
"https://images.habbo.com/habbo-web/america/en/assets/images/landing/bg_bottomleft.61999d1b.png",
"https://images.habbo.com/habbo-web/america/en/assets/images/landing/bg_bottomright.0bb434c7.png",
"https://images.habbo.com/habbo-web/america/en/assets/images/landing/h_pic.9e3bb5d3.png",
"https://images.habbo.com/habbo-web/america/en/assets/images/landing/h_logo.09606b0e.png",
"https://images.habbo.com/habbo-web/america/en/assets/images/landing/coll_pic.a26ac6d2.png",
"https://images.habbo.com/habbo-web/america/en/assets/images/landing/coll_logo.db970961.png",
"https://images.habbo.com/habbo-web/america/en/assets/images/landing/orig_pic.852d257e.png",
"https://images.habbo.com/habbo-web/america/en/assets/images/landing/orig_logo.147d68e0.png",
"https://www.habbo.com/api/public/authentication/captcha?action=login",
"https://cookie-cdn.cookiepro.com/consent/9a83bf35-71d7-4c89-9101-77220edee470/96dc850a-6664-4e15-915a-4e65cb823eec/en.json",
"https://rpxnow.com/js/lib/login.habbo.com/engage.js",
"https://www.habbo.com/api/public/authentication/captcha",
"https://d29usylhdk1xyu.cloudfront.net/load/login.habbo.com",
"https://cookie-cdn.cookiepro.com/scripttemplates/202311.1.0/assets/otFlat.json",
"https://cookie-cdn.cookiepro.com/scripttemplates/202311.1.0/assets/v2/otPcTab.json",
"https://cookie-cdn.cookiepro.com/scripttemplates/202311.1.0/assets/otCommonStyles.css",
"https://cookie-cdn.cookiepro.com/logos/static/cookiepro_logo.png",
"https://cookie-cdn.cookiepro.com/logos/static/poweredBy_cp_logo.svg",
"https://cookie-cdn.cookiepro.com/logos/static/ot_guard_logo.svg",
"https://newassets.hcaptcha.com/captcha/v1/33a3ef8/static/hcaptcha.html",
"https://d29usylhdk1xyu.cloudfront.net/manifest/login?version=final",
"https://quilt-cdn.janrain.com/HEAD/providers.css",
"https://docj27ko03fnu.cloudfront.net/rel/img/17c96fc4b9c8464d1c95cd785dd3120b.png",
"https://api2.hcaptcha.com/checksiteconfig?v=33a3ef8&host=www.habbo.com&sitekey=edc4ce89-8903-4906-80b1-7440ad9a69c8&sc=1&swa=1&spst=1",
            "https://images.habbo.com/habbo-web/america/en/assets/images/favicon.08c747be.ico",
"https://newassets.hcaptcha.com/c/520747fed0ff7b5e472b5ddf58e58cfa893b30e2002fbeb8a6dee14b12c3190e/hsw.js"};
                try
                {
                    for (int i = 0; i < pages.Length; i++)
                    {
                        richTextBox1.Text += pages[i].ToString();

                        WebRequest GetReq = (HttpWebRequest)WebRequest.Create(pages[i]);
                        GetReq.Method = "GET";
                        Stream objstreamreader = GetReq.GetResponse().GetResponseStream();
                        StreamReader SR = new StreamReader(objstreamreader);

                        string result = SR.ReadToEnd().ToString();
                        richTextBox1.Text = SR.ReadToEnd().ToString();

                        listView1.Items.Add(result);

                        WebBrowser SetDoc = new WebBrowser();
                        SetDoc.DocumentText += result.ToString();

                        for (int x = 0; x < 1040221; x++)
                        {
                            var elem = SetDoc.Document.GetElementById("");
                            elem.InvokeMember("click");
                            Console.WriteLine(elem.InvokeMember("click"));
                        }
                    }
                }
                catch (Exception ex)
                {

                    // listView1_Click(sender, e);


                    richTextBox1.Text += ex.Message.ToString();
                    Console.ReadLine();


                    listView1.Items.Add(ex.Message.ToString());
                }
            }
            catch (WebException webex)
            {
                richTextBox1.Text += webex.Message.ToString() + "exception web";

                Console.ReadLine();


            }
            return "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendKeys.SendWait("@@@@@");
            SendKeys.SendWait("{ENTER}");
            foreach (Client c in ClientForms)
            {

                SetParent(c.Handle, panel4.Handle);
                SetParent(c.Handle, IntPtr.Zero);
                Thread.Sleep(1000);
                SetParent(c.Handle, panel5.Handle);
                SetParent(c.Handle, IntPtr.Zero);
                SetParent(c.Handle, panel1.Handle);
                SetParent(c.Handle, IntPtr.Zero);
            }

            timer1.Stop();
        }
        private static WebBrowser ClientBrowser;
        public static IntPtr HandleBrowser;
        private void GetBrowser(Object Sender, EventArgs e)
        {
            ClientBrowser = webBrowser1;
            HandleBrowser = webBrowser1.Handle;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            timer1.Interval = int.Parse(textBox1.Text.ToString());
            timer1.Start();


        }
        List<Client> ClientForms = new List<Client>();
        public IntPtr FormHandle { get; set; }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Client C = new Client();
            C.TopLevel = false;
            C.TopMost = false;

            ClientForms.Add(C);
            panel1.Controls.Add(C);
            listView1.Items.Add(C.Handle.ToString());

            C.Show();
        }

        public event RecieveHandler Recieve;
        public delegate void RecieveHandler(object sender, EventArgs e);
        public static void OpenMessage(object Sender, EventArgs e)
        {






        }
        [DllImport("user32.dll", SetLastError = true)]
        static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        public const int KEYEVENTF_KEYDOWN = 0x0000; // New definition
        public const int KEYEVENTF_EXTENDEDKEY = 0x0001; //Key down flag
        public const int KEYEVENTF_KEYUP = 0x0002; //Key up flag
        public const int VK_LCONTROL = 0xA2; //Left Control key code
        public const int A = 0x41; //A key code
        public const int C = 0x43; //C key code

        public static string PressKeys()
        {
            // Hold Control down and press A
            // keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(A, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(A, 0, KEYEVENTF_KEYUP, 0);
            // keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYUP, 0);

            // Hold Control down and press C
            //keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(0x0D, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(0x0D, 0, KEYEVENTF_KEYUP, 0);
            // keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYUP, 0);
            return PressKeys();
        }
        static uint DOWN = 0x0002;
        static uint UP = 0x0004;
        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, int dwExtraInfo);
        public byte[] FileBuffer;

        public string Click()
        {
            mouse_event(DOWN, 800, 800, 0, 0);
            Thread.Sleep(100);
            mouse_event(UP, 800, 800, 0, 0);
            foreach(Client c in ClientForms)
            {
                c.Dock = DockStyle.Fill;
                c.DialogResult = DialogResult.OK;

            }

            // keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(A, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(A, 0, KEYEVENTF_KEYUP, 0);
            // keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYUP, 0);

            // Hold Control down and press C
            //keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(0x0D, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(0x0D, 0, KEYEVENTF_KEYUP, 0);
            // keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYUP, 0);
            return Click();

        }

        public IntPtr OnClick(object sender, EventArgs e, string RoomID)
        {
            try
            {




                WebRequest GetReq = (HttpWebRequest)WebRequest.Create("https://www.habbo.com/api/public/rooms/" + RoomID + "/forward");
                GetReq.Method = "POST";
                using (var Stream = GetReq.GetResponse().GetResponseStream())
                {

                    StreamReader SR = new StreamReader(Stream);
                    string result = SR.ReadToEnd().ToString();
                    foreach (Client c in ClientForms)
                    {
                        byte[] Hwnd = new byte[] { (byte)int.Parse(c.BrowserClient.Handle.ToString()), (byte)int.Parse(Encoding.ASCII.GetBytes(result).ToString()), 0x0D };
                        using (var memStream = new MemoryStream(Hwnd))
                        {
                            HttpClient Client_ = new HttpClient();
                            Client_.BaseAddress = c.BrowserClient.Source;
                            using (var HttpReqMsg = new HttpRequestMessage(HttpMethod.Post, c.BrowserClient.Source))
                            {
                                {
                                    var quote = '"';
                                    var scrit = "window.location=" + quote + "https://www.habbo.com/room/" + RoomID + quote + ";";
                                    c.BrowserClient.CoreWebView2.ExecuteScriptAsync(scrit);
                                    var RoomIDData = "https://www.habbo.com/room/" + RoomID + "";
                                    c.BrowserClient.Source = new Uri(RoomIDData);
                                    var Content = "\r\nvar xhr = new XMLHttpRequest(); xhr.open(\"POST\",\"https://www.habbo.com/api/public/rooms/" + RoomID + "/forward\");\r\nxhr.send(null);\r\nlet event = new Event(\"click\", {\r\n    bubbles: true, // only bubbles and cancelable\r\n    cancelable: true, // work in the Event constructor\r\n    clientX: 100,\r\n    clientY: 100\r\n  }); var room_enterbtn = document.getElementsByClassName('room__enter-button__text');\r\n  room_enterbtn[0].dispatchEvent(event);\r\n  ";
                                    var Msg = "\r\nvar xhr = new XMLHttpRequest(); xhr.open(\"POST\",\"https://www.habbo.com/api/public/rooms/" + RoomID + "/forward\");\r\nvar data = Opensend();\r\nxhr.send(data);\r\nfunction Opensend()\r\n{\r\n\r\n\r\nlet event = new Event(\"click\", {\r\n    bubbles: true, // only bubbles and cancelable\r\n    cancelable: true, // work in the Event constructor\r\n    clientX: 100,\r\n    clientY: 100\r\n  }); var room_enterbtn = document.getElementsByClassName('room__enter-button__text');\r\n  room_enterbtn[0].dispatchEvent(event);\r\n  window.location = \"https://www.habbo.com/client\";\r\n  window.location = \"https://www.habbo.com/\"\r\n}";
                                    var ObjAsync = c.BrowserClient.CoreWebView2.ExecuteScriptAsync(Msg).ToString();
                                    var Encode = Newtonsoft.Json.JsonConvert.SerializeObject(ObjAsync + Content + Msg);
                                    var ContentData = new StringContent(Encode, Encoding.UTF8, "application/json");
                                    HttpReqMsg.Content = ContentData;
                                    var Sendasync = Client_.SendAsync(HttpReqMsg);
                                    c.BrowserClient.CoreWebView2.ExecuteScriptAsync(Sendasync.ToString());
                                    byte[] MsgSend = Encoding.ASCII.GetBytes(Sendasync.ToString());
                                    byte[] WebMessage = new byte[] { (byte)int.Parse(Sendasync.ToString()), 0x01 };
                                    memStream.Write(WebMessage, 0, WebMessage.Length);
                                    WebClient WC = new WebClient();
                                    WC.BaseAddress = "http://localhost:443";
                                    using (var stream = WC.OpenWrite("POST", c.BrowserClient.Source.ToString()))
                                    {
                                        while (true)
                                        {

                                            Console.WriteLine(Sendasync);
                                            Client_.SendAsync(HttpReqMsg).Wait(0);
                                            Client_.SendAsync(HttpReqMsg).Wait();


                                            stream.Write(WebMessage, 0, WebMessage.Length);
                                        }

                                    }


                                }
                            }

                        }
                    }
                }

            }
            catch (Exception ex)
            {
                richTextBox1.Text += ex.Message.ToString();
                foreach (Client c in ClientForms)
                {
                    var Content = "\r\nvar xhr = new XMLHttpRequest(); xhr.open(\"POST\",\"https://www.habbo.com/api/public/rooms/79561500/forward\");\r\nxhr.send(null);\r\nlet event = new Event(\"click\", {\r\n    bubbles: true, // only bubbles and cancelable\r\n    cancelable: true, // work in the Event constructor\r\n    clientX: 100,\r\n    clientY: 100\r\n  }); var room_enterbtn = document.getElementsByClassName('room__enter-button__text');\r\n  room_enterbtn[0].dispatchEvent(event);\r\n  ";
                    var Msg = "\r\nvar xhr = new XMLHttpRequest(); xhr.open(\"POST\",\"https://www.habbo.com/api/public/rooms/79561500/forward\");\r\nvar data = Opensend();\r\nxhr.send(data);\r\nfunction Opensend()\r\n{\r\n\r\n\r\nlet event = new Event(\"click\", {\r\n    bubbles: true, // only bubbles and cancelable\r\n    cancelable: true, // work in the Event constructor\r\n    clientX: 100,\r\n    clientY: 100\r\n  }); var room_enterbtn = document.getElementsByClassName('room__enter-button__text');\r\n  room_enterbtn[0].dispatchEvent(event);\r\n  window.location = \"https://www.habbo.com/client\";\r\n  window.location = \"https://www.habbo.com/\"\r\n}";
                    c.BrowserClient.CoreWebView2.ExecuteScriptAsync(Msg).ToString();
                    c.BrowserClient.ExecuteScriptAsync(Content);
                    Click();
                    GetWebpage();

                }
            }
            SendKeys.SendWait("{ENTER}");

            return IntPtr.Zero;
        }
        public IntPtr XPanel { get; set; }
        public IntPtr YPnael { get; set; }
        public void PointerClick()
        {
            Click();

        }
        public List<Client> WebData = new List<Client>();

        private void Form1_Load(object sender, EventArgs e)
        {

            Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Server.Bind(new IPEndPoint(IPAddress.Any, 30001));
            Server.Listen(0);
            while (true)
            {
                try
                {

                    Socket Accepted = Server.Accept();
                    Client W = new Client();
                    foreach (Process p in Client.ClientHabboProcs)

                    {
                        string FilepATH = "C:\\Users\\akpoj\\AppData\\Roaming\\Habbo Launcher\\downloads\\air\\179\\Habbo.exe";
                        byte[] Buffer = System.IO.File.ReadAllBytes(FilepATH);

                        var hwnd = p.MainWindowHandle.ToString() == Accepted.Receive(Buffer, 0, Buffer.Length, 0).ToString();
                        if (hwnd = true)
                        {
                            while (true)
                            {

                                Array.Resize(ref Buffer, (int)(IntPtr)p.MainWindowHandle);
                            }
                        }
                        int recv = Accepted.Receive(Buffer);

                        Array.Resize(ref Buffer, (int)(IntPtr)p.MainWindowHandle);
                        foreach (byte b in Buffer)
                        {
                            byte[] Hwnd = Encoding.ASCII.GetBytes(p.MainWindowHandle.ToString());
                            using (var Memstream = new MemoryStream(Hwnd))
                            {
                                WebRequest GetReq = (HttpWebRequest)WebRequest.Create("http://www.pastebin.com/raw/TF9MauVK");
                                GetReq.Method = "GET";
                                byte[] memBytes = Encoding.ASCII.GetBytes(Memstream.ToString());
                                foreach (byte bx in memBytes)
                                {
                                    Stream DataStream = new MemoryStream(new byte[] { (byte)bx, (byte)int.Parse(GetReq.GetResponse().ToString()), (byte)int.Parse(PressKeys()) });
                                    StreamReader SR = new StreamReader(DataStream);
                                    string Result = Encoding.ASCII.GetString(Buffer, 0, int.Parse(hwnd.ToString()));
                                    if (Result != null)
                                    {
                                        while (SR.ReadToEnd().ToString() != null)
                                        {
                                            using (var SR_ = new StreamReader(DataStream))
                                            {
                                                byte[] DecodeBuffer = Encoding.ASCII.GetBytes(SR_.ReadToEnd().ToString());

                                                foreach (byte Buf in DecodeBuffer)
                                                {
                                                    StreamWriter SW = new StreamWriter(DataStream);
                                                    StreamWriter Msw = new StreamWriter(Memstream);
                                                    BinaryWriter BW = new BinaryWriter(Memstream);
                                                    SW.Write(Buf);
                                                    Msw.Write(Buf);
                                                    BW.Write(Buf);
                                                    SW.Write(DecodeBuffer);
                                                    Msw.Write(DecodeBuffer);
                                                    BW.Write(DecodeBuffer);
                                                    Memstream.Read(DecodeBuffer, 0, DecodeBuffer.Length);



                                                }
                                            }
                                        }
                                    }


                                }

                            }
                        }
                    }

                }

                catch (SocketException ex)
                {
                }
            }
        }
        private IntPtr ClickPointer()
        {
            string Path = "C:\\Users\\akpoj\\source\\repos\\win32APIAuto\\win32APIAuto\\bin\\Debug\\net8.0-windows\\win32APIAuto.exe";
            OpenFileDialog Clicker = new OpenFileDialog();
            Clicker.FileName = Path;
            var ClickProc = new Process();
            ClickProc.StartInfo.UseShellExecute = false;
            ClickProc.StartInfo.RedirectStandardError = false;
            ClickProc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            ClickProc.StartInfo.FileName = Clicker.FileName;

            ClickProc.Start();
            SetParent(ClickProc.MainWindowHandle, panel1.Handle);


            return IntPtr.Zero;
        }
        public IntPtr SetReqHeader()
        {
            try

            {
                WebRequest Getreq = (HttpWebRequest)WebRequest.Create("http://localhost:443");
                Getreq.Method = "GET";
                Stream objStreamReader = Getreq.GetResponse().GetResponseStream();
                StreamReader s_ = new StreamReader(objStreamReader);

                string result = s_.ReadToEnd().ToString();
                while (result != null)
                {
                    Client x = new Client();
                    x.OpenMessage(IntPtr.Zero, IntPtr.Zero, textBox4.Text);

                    foreach (Client c in ClientForms)
                    {

                        
                            c.OpenMessage(IntPtr.Zero, IntPtr.Zero, textBox4.Text);

                        
                    }



                }
            }
            catch(Exception ex)
            {
                

            }

            return IntPtr.Zero;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //  WebRequest HttpReq = (HttpWebRequest)WebRequest.Create("https://habboemulatornetwork.000webhostapp.com/");
            string[] pages = {

"https://cookie-cdn.cookiepro.com/scripttemplates/otSDKStub.js",
"https://accounts.google.com/gsi/client",
"https://images.habbo.com/habbo-web/america/en/app.77047271.css",
"https://images.habbo.com/habbo-web/america/en/vendor.40069316.js",
"https://images.habbo.com/habbo-web/america/en/scripts.c8b10458.js",
"https://appleid.cdn-apple.com/appleauth/static/jsapi/appleid/1/en_US/appleid.auth.js",
"https://cookie-cdn.cookiepro.com/consent/9a83bf35-71d7-4c89-9101-77220edee470/9a83bf35-71d7-4c89-9101-77220edee470.json",
"https://images.habbo.com/habbo-web-l10n/com.json",
"https://images.habbo.com/habbo-web/america/en/assets/images/sprite.a51705e3.png",
"https://images.habbo.com/habbo-web/america/en/assets/images/sprite@2x.7942f80a.png",
"https://images.habbo.com/habbo-web/america/en/assets/images/backgrounds/hotel.5e0e63d8.png",
"https://images.habbo.com/habbo-web/america/en/assets/fonts/UbuntuRegular-latin.dae8c8b9.woff2",
"https://images.habbo.com/habbo-web/america/en/assets/fonts/UbuntuBold-latin.d6b93445.woff2",
"https://images.habbo.com/habbo-web/america/en/assets/fonts/UbuntuCondensed-latin.51eab248.woff2",
"https://connect.facebook.net/en_US/sdk.js",
"https://images.habbo.com/habbo-web-l10n/com.json",
"https://images.habbo.com/habbo-web-news/en/production/front.html",
"https://images.habbo.com/habbo-web/america/en/assets/images/sprite.a51705e3.png",
"https://cookie-cdn.cookiepro.com/scripttemplates/202311.1.0/otBannerSdk.js",
"https://connect.facebook.net/en_US/sdk.js?hash=976b077a61117c3c39cdf711149d1f4c",
"https://images.habbo.com/web_images/habbo-web-articles/lpromo_Aug24.png",
"https://images.habbo.com/web_images/habbo-web-articles/lpromo_Aug24_thumb.png",
"https://images.habbo.com/web_images/habbo-web-articles/lpromo_collectibles.png",
"https://images.habbo.com/web_images/habbo-web-articles/lpromo_collectibles_thumb.png",
"https://images.habbo.com/web_images/habbo-web-articles/lpromo_gen15_10.png",
"https://images.habbo.com/web_images/habbo-web-articles/lpromo_gen15_10_thumb.png",
"https://images.habbo.com/web_images/habbo-web-articles/lpromo_aug24_messenger.png",
"https://images.habbo.com/web_images/habbo-web-articles/lpromo_aug24_messenger_thumb.png",
"https://images.habbo.com/web_images/habbo-web-articles/lpromo_07082024-1.png",
"https://images.habbo.com/web_images/habbo-web-articles/lpromo_07082024-1_thumb.png",
"https://images.habbo.com/web_images/habbo-web-articles/lpromo_07082024.png",
"https://images.habbo.com/web_images/habbo-web-articles/lpromo_07082024_thumb.png",
"https://images.habbo.com/web_images/habbo-web-articles/lpromo_Bratz_Jul24.png",
"https://images.habbo.com/web_images/habbo-web-articles/lpromo_Bratz_Jul24_thumb.png",
"https://images.habbo.com/habbo-web-pages/production/common/box_learn_how_to_stay_safe.en.html",
"https://images.habbo.com/habbo-web-pages/production/common/box_parents_guide.en.html",
"https://js.hcaptcha.com/1/api.js?onload=hCaptchaOnloadCallback&render=explicit&recaptchacompat=off&hl=en",
"https://images.habbo.com/habbo-web/america/en/assets/images/landing/bg_topleft.c16c9d63.png",
"https://images.habbo.com/habbo-web/america/en/assets/images/landing/bg_topright.00cd59c5.png",
"https://images.habbo.com/habbo-web/america/en/assets/images/landing/bg_bottomleft.61999d1b.png",
"https://images.habbo.com/habbo-web/america/en/assets/images/landing/bg_bottomright.0bb434c7.png",
"https://images.habbo.com/habbo-web/america/en/assets/images/landing/h_pic.9e3bb5d3.png",
"https://images.habbo.com/habbo-web/america/en/assets/images/landing/h_logo.09606b0e.png",
"https://images.habbo.com/habbo-web/america/en/assets/images/landing/coll_pic.a26ac6d2.png",
"https://images.habbo.com/habbo-web/america/en/assets/images/landing/coll_logo.db970961.png",
"https://images.habbo.com/habbo-web/america/en/assets/images/landing/orig_pic.852d257e.png",
"https://images.habbo.com/habbo-web/america/en/assets/images/landing/orig_logo.147d68e0.png",
"https://www.habbo.com/api/public/authentication/captcha?action=login",
"https://cookie-cdn.cookiepro.com/consent/9a83bf35-71d7-4c89-9101-77220edee470/96dc850a-6664-4e15-915a-4e65cb823eec/en.json",
"https://rpxnow.com/js/lib/login.habbo.com/engage.js",
"https://www.habbo.com/api/public/authentication/captcha",
"https://d29usylhdk1xyu.cloudfront.net/load/login.habbo.com",
"https://cookie-cdn.cookiepro.com/scripttemplates/202311.1.0/assets/otFlat.json",
"https://cookie-cdn.cookiepro.com/scripttemplates/202311.1.0/assets/v2/otPcTab.json",
"https://cookie-cdn.cookiepro.com/scripttemplates/202311.1.0/assets/otCommonStyles.css",
"https://cookie-cdn.cookiepro.com/logos/static/cookiepro_logo.png",
"https://cookie-cdn.cookiepro.com/logos/static/poweredBy_cp_logo.svg",
"https://cookie-cdn.cookiepro.com/logos/static/ot_guard_logo.svg",
"https://newassets.hcaptcha.com/captcha/v1/33a3ef8/static/hcaptcha.html",
"https://d29usylhdk1xyu.cloudfront.net/manifest/login?version=final",
"https://quilt-cdn.janrain.com/HEAD/providers.css",
"https://docj27ko03fnu.cloudfront.net/rel/img/17c96fc4b9c8464d1c95cd785dd3120b.png",
"https://api2.hcaptcha.com/checksiteconfig?v=33a3ef8&host=www.habbo.com&sitekey=edc4ce89-8903-4906-80b1-7440ad9a69c8&sc=1&swa=1&spst=1",
            "https://images.habbo.com/habbo-web/america/en/assets/images/favicon.08c747be.ico",
"https://newassets.hcaptcha.com/c/520747fed0ff7b5e472b5ddf58e58cfa893b30e2002fbeb8a6dee14b12c3190e/hsw.js"};
            try
            {
                foreach (string page in pages)
                {
                    WebRequest Getreq = (HttpWebRequest)WebRequest.Create(page);
                    Getreq.Method = "GET";
                    Stream objStreamReader = Getreq.GetResponse().GetResponseStream();
                    StreamReader s_ = new StreamReader(objStreamReader);

                    string result = s_.ReadToEnd().ToString();


                    listView1.Items.Add(result);
                    richTextBox1.Text += result.ToString() + "Habbo";
                    WebBrowser SetDoc = new WebBrowser();
                   // SetDoc.Navigate("http://localhost:443");
                   // webView21.Source = new Uri("http://localhost:443");

                    SetDoc.DocumentText += result.ToString();

                    for (int x = 0; x < 1040221; x++)
                    {
                        var elem = SetDoc.Document.GetElementById("");
                        elem.InvokeMember("click");
                        Console.WriteLine(elem.InvokeMember("click"));
                        if (result != null)
                        {

                            try
                            {

                                foreach (Client c in ClientForms)
                                {
                                    // c.OpenMessage(panel4.Handle, panel5.Handle, textBox4.Text.ToString());

                                    SetParent(c.Handle, panel4.Handle);
                                    SetParent(c.Handle, IntPtr.Zero);

                                    SetParent(c.Handle, panel5.Handle);

                                    SetParent(c.Handle, IntPtr.Zero);

                                    SetParent(c.Handle, panel4.Handle);
                                    SetParent(c.Handle, IntPtr.Zero);

                                    SetParent(c.Handle, panel5.Handle);

                                    SetParent(c.Handle, IntPtr.Zero);
                                    timer1.Stop();



                                }
                            }
                            catch(Exception ex)
                            {
                                timer2.Interval = 502;
                                timer2.Start();
                                timer1.Start();

                            }

                        }

                      
                        }
                    }
                
                }
            catch(Exception ex)
            {
                richTextBox1.Text += ex.Message.ToString();

                foreach (Process p in Client.ClientHabboProcs)
                {
                    SetParent(p.MainWindowHandle, panel4.Handle);
                    SetParent(p.Handle, IntPtr.Zero);

                    SetParent(p.Handle, panel5.Handle);

                    SetParent(p.Handle, IntPtr.Zero);

                    SetParent(p.Handle, panel4.Handle);
                    SetParent(p.Handle, IntPtr.Zero);
                    SetParent(IntPtr.Zero, panel3.Handle);
                    SetParent(IntPtr.Zero, panel4.Handle);

                    // SetParent(OpenMessage(sender, e, textBox4.Text.ToString()));





                }
            }
            }
        private void button2_Click(object sender, EventArgs e)
        {
            Client C = new Client();
            C.TopLevel = false;
            C.TopMost = false;


            panel1.Controls.Add(C);
            listView1.Items.Add(C.Handle.ToString() + "form handle");
            listView1.Items.Add(panel5.Handle.ToString() + "hwnd");
            listView1.Items.Add(panel4.Handle.ToString() + "hwnd");

            C.Show();
            ClientForms.Add(C);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //  WebRequest HttpReq = (HttpWebRequest)WebRequest.Create("https://habboemulatornetwork.000webhostapp.com/");
            foreach (Client c in ClientForms)
            {
                SetParent(c.Handle, IntPtr.Zero);
                var script = "\r\nvar xhr = new XMLHttpRequest(); xhr.open(\"POST\",\"https://www.habbo.com/api/public/rooms/" + textBox4.Text.ToString()+ "/forward\");\r\nvar data = Opensend();\r\nxhr.send(data);\r\nfunction Opensend()\r\n{\r\n\r\n\r\nlet event = new Event(\"click\", {\r\n    bubbles: true, // only bubbles and cancelable\r\n    cancelable: true, // work in the Event constructor\r\n    clientX: 100,\r\n    clientY: 100\r\n  }); var room_enterbtn = document.getElementsByClassName('room__enter-button__text');\r\n  room_enterbtn[0].dispatchEvent(event);\r\n  window.location = \"https://www.habbo.com/client\";\r\n  window.location = \"https://www.habbo.com/\"\r\n}";
                c.BrowserClient.Source = new Uri("https://www.habbo.com/room/" + textBox4.Text);

                c.BrowserClient.ExecuteScriptAsync(script);

              
            }
            foreach (Client c in ClientForms)
            {
                // c.OpenMessage(panel4.Handle, panel5.Handle, textBox4.Text.ToString());

                SetParent(c.Handle, panel4.Handle);
                SetParent(c.Handle, IntPtr.Zero);

                SetParent(c.Handle, panel5.Handle);

                SetParent(c.Handle, IntPtr.Zero);

                SetParent(c.Handle, panel4.Handle);
                SetParent(c.Handle, IntPtr.Zero);

                SetParent(c.Handle, panel5.Handle);

                SetParent(c.Handle, IntPtr.Zero);


            }
            foreach (Process p in Client.ClientHabboProcs)
            {
            //    SetParent(SetReqHeader(), p.MainWindowHandle);

            }


        }
            private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 304; i++)
            {
                for (int x = 0; x < tabControl3.TabCount; x++)
                {
                    tabControl3.SelectedTab = tabControl3.TabPages[x];

                    SendKeys.SendWait(richTextBox1.Text.ToString());
                    SendKeys.SendWait("{ENTER}");

                    Socket Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    Client.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 30001));
                    Client.Send(Encoding.ASCII.GetBytes(GetWebpage()));
                    App.Form1 f = new App.Form1();
                    byte[] MessageSend = Encoding.Default.GetBytes(f.PostMessageClient());
                    Client.Send(MessageSend, 0, MessageSend.Length, 0);

                    //  Client.Disconnect(true);
                }

            }

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl3_TabIndexChanged(object sender, EventArgs e)
        {
            foreach (Client c in ClientForms)
            {

                SetParent(c.Handle, panel4.Handle);
                SetParent(c.Handle, IntPtr.Zero);
                Thread.Sleep(1000);
                SetParent(c.Handle, panel5.Handle);
                SetParent(c.Handle, IntPtr.Zero);
            }
        }

        private void Form1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            InputSimulator wm_char = new InputSimulator();

            wm_char.Keyboard.TextEntry("hg");
            wm_char.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.RETURN);
        }

        private void tabControl3_Selected(object sender, TabControlEventArgs e)
        {
            foreach (Client c in ClientForms)
            {

                SetParent(c.Handle, panel4.Handle);
                SetParent(c.Handle, IntPtr.Zero);
                Thread.Sleep(1000);
                SetParent(c.Handle, panel5.Handle);
                SetParent(c.Handle, IntPtr.Zero);
            }

        }

        private void tabControl3_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Client c in ClientForms)
            {

                SetParent(c.Handle, panel4.Handle);
                SetParent(c.Handle, IntPtr.Zero);
                Thread.Sleep(1000);
                SetParent(c.Handle, panel5.Handle);
                SetParent(c.Handle, IntPtr.Zero);
            }
        }

        private void tabControl3_Selecting(object sender, TabControlCancelEventArgs e)
        {
            foreach (Client c in ClientForms)
            {

                SetParent(c.Handle, panel4.Handle);
                SetParent(c.Handle, IntPtr.Zero);
                Thread.Sleep(1000);
                SetParent(c.Handle, panel5.Handle);
                SetParent(c.Handle, IntPtr.Zero);
            }

        }

        private void tabControl4_Selected(object sender, TabControlEventArgs e)
        {
            foreach (Client c in ClientForms)
            {

                SetParent(c.Handle, panel4.Handle);
                SetParent(c.Handle, IntPtr.Zero);
                Thread.Sleep(1000);
                SetParent(c.Handle, panel5.Handle);
                SetParent(c.Handle, IntPtr.Zero);
            }

        }

        private void tabControl4_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Client c in ClientForms)
            {

                SetParent(c.Handle, panel4.Handle);
                SetParent(c.Handle, IntPtr.Zero);
                Thread.Sleep(1000);
                SetParent(c.Handle, panel5.Handle);
                SetParent(c.Handle, IntPtr.Zero);
            }

        }

        private void tabControl5_Selected(object sender, TabControlEventArgs e)
        {
            foreach (Client c in ClientForms)
            {

                SetParent(c.Handle, panel4.Handle);
                SetParent(c.Handle, IntPtr.Zero);
                Thread.Sleep(1000);
                SetParent(c.Handle, panel5.Handle);
                SetParent(c.Handle, IntPtr.Zero);
            }
        }

        private void tabControl5_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Client c in ClientForms)
            {

                SetParent(c.Handle, panel4.Handle);
                SetParent(c.Handle, IntPtr.Zero);
                Thread.Sleep(1000);
                SetParent(c.Handle, panel5.Handle);
                SetParent(c.Handle, IntPtr.Zero);
            }
        }

        private void tabControl6_Selected(object sender, TabControlEventArgs e)
        {
            foreach (Client c in ClientForms)
            {

                SetParent(c.Handle, panel4.Handle);
                SetParent(c.Handle, IntPtr.Zero);
                Thread.Sleep(1000);
                SetParent(c.Handle, panel5.Handle);
                SetParent(c.Handle, IntPtr.Zero);
            }
        }

        private void tabControl6_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Client c in ClientForms)
            {

                SetParent(c.Handle, panel4.Handle);
                SetParent(c.Handle, IntPtr.Zero);
                Thread.Sleep(1000);
                SetParent(c.Handle, panel5.Handle);
                SetParent(c.Handle, IntPtr.Zero);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        public Panel ActiveWindowPanel = new Panel();
        public int TabIndex;
        public TabPage WindowModule;

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            var page = new TabPage();
            page.Text = "Client";
            SetParent(page.Handle, tabControl7.Handle);

            tabControl7.TabPages.Add(page);




        }
        public void InputThread()
        {
            while (true)
            {
                foreach (Client c in ClientForms)
                {
                    try
                    {
                        webView21.CoreWebView2.ExecuteScriptAsync(WebMessage().ToString());


                        SetParent(c.Handle, panel4.Handle);
                        SetParent(c.Handle, IntPtr.Zero);

                        SetParent(c.Handle, panel5.Handle);

                        SetParent(c.Handle, IntPtr.Zero);

                        SetParent(c.Handle, panel4.Handle);
                        SetParent(c.Handle, IntPtr.Zero);

                        SetParent(c.Handle, panel5.Handle);

                        SetParent(c.Handle, IntPtr.Zero);
                        SetParent(c.panelHandle.Handle, IntPtr.Zero); SetParent(c.panelHandle.Handle, panel4.Handle);
                        SetParent(c.panelHandle.Handle, panel5.Handle);



                    }
                    catch (Exception ex)
                    {
                        richTextBox1.Text += ex.Message.ToString();

                        SetParent(c.Handle, panel4.Handle);
                        SetParent(c.Handle, IntPtr.Zero);

                        SetParent(c.Handle, panel5.Handle);

                        SetParent(c.Handle, IntPtr.Zero);

                        SetParent(c.Handle, panel4.Handle);
                        SetParent(c.Handle, IntPtr.Zero);

                        SetParent(c.Handle, panel5.Handle);

                        SetParent(c.Handle, IntPtr.Zero);
                        SetParent(IntPtr.Zero, panel4.Handle);
                        SetParent(IntPtr.Zero, panel5.Handle);

                    }
                }
            }
            }
        public string WebMessage()
        {
            Thread ShowForm = new Thread(InputThread);
            ShowForm.Start();
            Thread.Sleep(1000);

            InputSimulator Input = new InputSimulator();
            Input.Keyboard.ModifiedKeyStroke(WindowsInput.Native.VirtualKeyCode.LCONTROL, WindowsInput.Native.VirtualKeyCode.VK_V);
            Input.Keyboard.ModifiedKeyStroke(WindowsInput.Native.VirtualKeyCode.RETURN, WindowsInput.Native.VirtualKeyCode.RETURN);
            Input.Keyboard.ModifiedKeyStroke(WindowsInput.Native.VirtualKeyCode.LCONTROL, WindowsInput.Native.VirtualKeyCode.VK_V);
            Input.Keyboard.ModifiedKeyStroke(WindowsInput.Native.VirtualKeyCode.RETURN, WindowsInput.Native.VirtualKeyCode.RETURN);
            var script = "";
            char quote = '"';
            script = "window.location=" + quote + "https://wwww.localhost:443" + quote + ";";
            webView21.Source = new Uri("https://www.localhost:443");
            using (var HttpClientClient = new HttpClient())
            {
                HttpClientClient.BaseAddress = webView21.Source;
                using (var HttpReqmsg = new HttpRequestMessage(HttpMethod.Post, webView21.Source))
                {
                    var Content = Newtonsoft.Json.JsonConvert.SerializeObject(script);
                    var StringContent = new StringContent(Content, Encoding.UTF8, "application/json");
                    HttpReqmsg.Content = StringContent;
                    HttpClientClient.SendAsync(HttpReqmsg).Wait();
                    webView21.ExecuteScriptAsync(script);
                    webView21.ExecuteScriptAsync(Content);
                    webView21.CoreWebView2.ExecuteScriptAsync(StringContent.ToString());
                    Socket Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    Client.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 443));
                    byte[] Message = Encoding.ASCII.GetBytes(WebMessage());
                    try
                    {
                        WebRequest GetReq = (HttpWebRequest)WebRequest.Create("https://www.pastebin.com/TF9MauVK");
                        GetReq.Method = "GET";

                        Stream OBJ = GetReq.GetResponse().GetResponseStream();
                        StreamReader sr = new StreamReader(OBJ);
                        string Result = sr.ReadToEnd().ToString();
                        if (Result != null)
                        {
                            GetReq = (HttpWebRequest)WebRequest.Create("https://www.localhost:443");
                            GetReq.Method = "GET";
                            while (Result != null)
                            {

                                Message = Encoding.ASCII.GetBytes(WebMessage().ToString() + Result.ToString());
                                Client.Send(Message, 0, Message.Length, 0);


                                {

                                }
                            }
                        }

                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
            return WebMessage();

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            foreach (Client c in ClientForms)
            {
                try
                {
                    for(int i = 0; i <tabControl3.TabPages.Count;i++)
                    {
                        foreach(TabPage p in tabControl3.TabPages)
                        {
                            tabControl3.SelectedTab=tabControl3.TabPages[i];
                            tabControl3.SelectedTab.Equals(tabControl3.TabPages[i]);

                        }
                    }
                    //webView21.CoreWebView2.ExecuteScriptAsync(WebMessage().ToString());


                    SetParent(c.Handle, panel4.Handle);
                    SetParent(c.Handle, IntPtr.Zero);

                    SetParent(c.Handle, panel5.Handle);

                    SetParent(c.Handle, IntPtr.Zero);

                    SetParent(c.Handle, panel4.Handle);
                    SetParent(c.Handle, IntPtr.Zero);

                    SetParent(c.Handle, panel5.Handle);

                    SetParent(c.Handle, IntPtr.Zero);
                    SetParent(c.panelHandle.Handle, IntPtr.Zero); SetParent(c.panelHandle.Handle, panel4.Handle);
                    SetParent(c.panelHandle.Handle, panel5.Handle);



                }
                catch (Exception ex)
                {
                    richTextBox1.Text += ex.Message.ToString();

                    SetParent(c.Handle, panel4.Handle);
                    SetParent(c.Handle, IntPtr.Zero);

                    SetParent(c.Handle, panel5.Handle);

                    SetParent(c.Handle, IntPtr.Zero);

                    SetParent(c.Handle, panel4.Handle);
                    SetParent(c.Handle, IntPtr.Zero);

                    SetParent(c.Handle, panel5.Handle);

                    SetParent(c.Handle, IntPtr.Zero);
                    SetParent(IntPtr.Zero, panel4.Handle);
                    SetParent(IntPtr.Zero, panel5.Handle);

                }
                // SetReqHeader();
                foreach (Client x in ClientForms)
                {
                    SetParent(x.Handle, IntPtr.Zero);
                    var script = "\r\nvar xhr = new XMLHttpRequest(); xhr.open(\"POST\",\"https://www.habbo.com/api/public/rooms/" + textBox4.Text.ToString() + "/forward\");\r\nvar data = Opensend();\r\nxhr.send(data);\r\nfunction Opensend()\r\n{\r\n\r\n\r\nlet event = new Event(\"click\", {\r\n    bubbles: true, // only bubbles and cancelable\r\n    cancelable: true, // work in the Event constructor\r\n    clientX: 100,\r\n    clientY: 100\r\n  }); var room_enterbtn = document.getElementsByClassName('room__enter-button__text');\r\n  room_enterbtn[0].dispatchEvent(event);\r\n  window.location = \"https://www.habbo.com/client\";\r\n  window.location = \"https://www.habbo.com/\"\r\n}";
                    x.BrowserClient.Source = new Uri("https://www.habbo.com/room/"+textBox4.Text.ToString());//
                    foreach (Client cxc in ClientForms)
                    {
                        SetParent(cxc.Handle, IntPtr.Zero);
                        //     var script = "\r\nvar xhr = new XMLHttpRequest(); xhr.open(\"POST\",\"https://www.habbo.com/api/public/rooms/" + textBox4.Text.ToString() + "/forward\");\r\nvar data = Opensend();\r\nxhr.send(data);\r\nfunction Opensend()\r\n{\r\n\r\n\r\nlet event = new Event(\"click\", {\r\n    bubbles: true, // only bubbles and cancelable\r\n    cancelable: true, // work in the Event constructor\r\n    clientX: 100,\r\n    clientY: 100\r\n  }); var room_enterbtn = document.getElementsByClassName('room__enter-button__text');\r\n  room_enterbtn[0].dispatchEvent(event);\r\n  window.location = \"https://www.habbo.com/client\";\r\n  window.location = \"https://www.habbo.com/\"\r\n}";
                       // cxc.BrowserClient.Source = new Uri("https://localhost:30001");


                        cxc.BrowserClient.ExecuteScriptAsync(script);




                    }
               

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Interval = int.Parse(textBox1.Text.ToString());
            timer1.Start();
            timer2.Interval = 7381;
            timer2.Start();
            timer3.Interval = 893;
            timer3.Start();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

            Click();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            string filepath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            DirectoryInfo d = new DirectoryInfo(filepath);

            foreach (var _file in d.GetFiles("*.swf"))
            {
                OpenFileDialog OFD = new OpenFileDialog();
                OFD.FileName = _file.ToString();



                byte[] FileData = System.IO.File.ReadAllBytes(OFD.FileName);
                using (var Memstream = new MemoryStream(FileData))
                {
                    BinaryWriter BW = new BinaryWriter(Memstream);
                    byte[] Data = Encoding.Default.GetBytes(Click());
                    BW.Write(Data);
                    foreach (byte b in Data)
                    {
                       for(int i = 0; i < Data.Length;i++)
                        {
                            Memstream.Read(new byte[] { Data[i] }, 0, Data.Length);
                            Memstream.Write(new byte[] { Data[i] }, 0, Data.Length);

                            BW.Write(new byte[] { Data[i] }, 0, Data.Length);
                            Memstream.Write(new byte[] { Data[i] }, 0, Data.Length);
                            BinaryReader BR = new BinaryReader(Memstream);

                            BR.Read(new byte[] { Data[i] }, 0, Data.Length);
                            Memstream.Read(new byte[] { Data[i] }, 0, Data.Length);






                        }

                        BW.Write(b);
                       

                    }


                }


            }
        }
        public TabControl T = new TabControl();


        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        foreach(TabPage p in tabControl7.TabPages)
            {
                Client C = new Client();
                C.TopMost = false;
                C.Show();
                ClientForms.Add(C);

                SetParent(C.Handle, p.Handle);


            }


        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i <tabControl7.TabCount;i++)
            {
                tabControl7.SelectedTab = tabControl7.TabPages[i];

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer4.Interval = int.Parse(textBox5.Text.ToString());
            timer4.Start();
           

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            timer4.Stop();

        }

        private void tabPage12_Click(object sender, EventArgs e)
        {

        }
    }
}