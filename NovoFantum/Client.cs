using CefSharp;
using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NovoFantum
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }
        public Process ClientConsole()
        {
            while (ClientConsole().MainWindowHandle != IntPtr.Zero)
            {
                Thread.Sleep(1000);
            }

            return ClientConsole();
        }
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr Hwnd, IntPtr HwndParent);
        public Panel panelHandle;
        public WebView2 BrowserClient;
        public TabPage ClientPage;
        private void toolStripButton1_Click(object sender, EventArgs e)
        {


            int PID = int.Parse(toolStripTextBox1.Text.ToString());
            Process Console = Process.GetProcessById(PID);
            if (Console.MainWindowHandle != IntPtr.Zero)
            {
                SetParent(Console.MainWindowHandle, panel1.Handle);
            }

        }

        private void Client_Load(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.habbo.com/");

            ClientPage = tabControl1.TabPages[1];
            BrowserClient = webView21;

        }
        public static List<Process> ClientHabboProcs = new List<Process>();

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string path = "C:\\Users\\akpoj\\AppData\\Roaming\\Habbo Launcher\\downloads\\air\\179\\Habbo.exe";

            FileStream FS = new FileStream(path, FileMode.Open, FileAccess.Read);

            var Proc = new Process();
            Proc.StartInfo.UseShellExecute = false;
            Proc.StartInfo.RedirectStandardOutput = false;
            Proc.StartInfo.RedirectStandardInput = false;
            Proc.StartInfo.FileName = FS.Name;
            Proc.Start();
            Process[] Clients = Process.GetProcessesByName(Proc.ProcessName.ToString());
            foreach (Process p in Clients)
            {
                SetParent(p.MainWindowHandle, panel1.Handle);
                ClientHabboProcs.Add(p);
                panelHandle = panel1;

            }



        }

        public byte[] Message_packet;

        public bool OpenMessage(IntPtr xpanel, IntPtr yPanel, string _roomID)
        {

            roomID = _roomID;
            webView21.Source = new Uri("https://www.habbo.com/room/"+roomID);
          

            var script = "\r\nvar xhr = new XMLHttpRequest(); xhr.open(\"POST\",\"https://www.habbo.com/api/public/rooms/" + roomID + "/forward\");\r\nvar data = Opensend();\r\nxhr.send(data);\r\nfunction Opensend()\r\n{\r\n\r\n\r\nlet event = new Event(\"click\", {\r\n    bubbles: true, // only bubbles and cancelable\r\n    cancelable: true, // work in the Event constructor\r\n    clientX: 100,\r\n    clientY: 100\r\n  }); var room_enterbtn = document.getElementsByClassName('room__enter-button__text');\r\n  room_enterbtn[0].dispatchEvent(event);\r\n  window.location = \"https://www.habbo.com/client\";\r\n  window.location = \"https://www.habbo.com/\"\r\n}";
            webView21.CoreWebView2.ExecuteScriptAsync(Newtonsoft.Json.JsonConvert.SerializeObject(script));
            var Encode = Newtonsoft.Json.JsonConvert.SerializeObject(script);
            var stringContent_ = new StringContent(Encode, Encoding.UTF8, "application/json");
            try

            {
                Socket S = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                S.Connect(new IPEndPoint(IPAddress.Parse("69.172.200.161"), 30001));
                // var Data = 
                var Data = webView21.ExecuteScriptAsync(stringContent_.ToString());
                byte[] ReadFile = Encoding.ASCII.GetBytes(Data.ToString());
                byte[] OpenFile = Encoding.UTF8.GetBytes(Data.Result.ToString());
                List<byte[]> MessagePacket = new List<byte[]>();
                while (S.Connected)
                {
                    MessagePacket.Add(ReadFile);
                    MessagePacket.Add(OpenFile);
                    foreach (byte[] Buffer in MessagePacket)
                    {
                        Message_packet = Buffer;
                        S.Send(Buffer, 0, Buffer.Length, 0);
                        S.Send(Buffer);
                        WebView2 BrowserH = new WebView2();
                        BrowserH.Source = new Uri("https://www.localhost:443");
                        HttpClient ClientHttp = new HttpClient();
                        ClientHttp.BaseAddress = BrowserH.Source;
                        using (var HttpeqMsg = new HttpRequestMessage(HttpMethod.Post, BrowserH.Source))
                        {
                            {
                                var Data_ = checkBox2.Checked = true;
                                var FalseDta_ = checkBox2.Checked = false;
                                var Encode_ = Newtonsoft.Json.JsonConvert.SerializeObject(Data_ + FalseDta_.ToString());
                                var String_conteont = new StringContent(Encode_, Encoding.UTF8, "application/json");
                                HttpeqMsg.Content = String_conteont;
                                WebClient HClient = new WebClient();
                                HClient.BaseAddress = "https://www.localhost:30001";
                                using (var stream = HClient.OpenWrite("http://localhost:443", "POST"))
                                {
                                    // stream.Write(Buffer);
                                    stream.Write(Buffer, 0, Buffer.Length);
                                    stream.Close();
                                    stream.Dispose();
                                    ClientHttp.SendAsync(HttpeqMsg).Wait();


                                }
                            }
                        }

                    }
                }
                if (!S.Connected)
                {
                    MessagePacket.Add(ReadFile);
                    MessagePacket.Add(OpenFile);
                    WebClient HClient = new WebClient();
                    HClient.BaseAddress = "https://www.localhost:30001";
                    using (var stream = HClient.OpenWrite("http://localhost:443", "POST"))
                    {
                        // stream.Write(Buffer);
                        foreach (byte[] _Buffer in MessagePacket)
                        {

                            stream.Write(_Buffer, 0, _Buffer.Length);

                            stream.Close();
                            stream.Dispose();

                        }
                    }
                }

            }
            catch (Exception ex)
            {

                WebClient HClient = new WebClient();
                HClient.BaseAddress = "https://www.localhost:30001";
                using (var stream = HClient.OpenWrite("http://localhost:443", "POST"))
                {
                    // stream.Write(Buffer);
                    foreach (byte b in Message_packet)
                    {

                        stream.Write(Message_packet, 0, Message_packet.Length);


                        stream.Close();
                        stream.Dispose();
                        string pathData = "C:\\Users\\akpoj\\AppData\\Roaming\\Habbo Launcher\\downloads\\air\\179\\Habbo.exe";

                        byte[] Memstream = File.ReadAllBytes(pathData);
                        using (var BSstream = new MemoryStream(Memstream, 0, Memstream.Length))
                        {
                            foreach (Process P in ClientHabboProcs)
                            {
                                while (P.MainWindowHandle != IntPtr.Zero)
                                {
                                    BSstream.Read(Message_packet, 0, Message_packet.Length);

                                    BinaryWriter BW = new BinaryWriter(new MemoryStream(Memstream));
                                    BW.Write(b);
                                    BW.Write(Message_packet, 0, Message_packet.Length);
                                    BW.Flush();
                                    Form1 Main = new Form1();
                                    foreach (Client x in Main.WebData)
                                    {

                                        byte[] browserHwnd = Encoding.ASCII.GetBytes(x.BrowserClient.CoreWebView2.ToString());
                                        using (var Memory_stream = new MemoryStream(browserHwnd))
                                        {
                                            Memory_stream.Write(Message_packet, 0, Message_packet.Length);


                                            BW.Close();
                                            BW.Dispose();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }




            return false;

        }
        public string roomID;
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            var script = "\r\nvar xhr = new XMLHttpRequest(); xhr.open(\"POST\",\"https://www.habbo.com/api/public/rooms/" + roomID + "/forward\");\r\nvar data = Opensend();\r\nxhr.send(data);\r\nfunction Opensend()\r\n{\r\n\r\n\r\nlet event = new Event(\"click\", {\r\n    bubbles: true, // only bubbles and cancelable\r\n    cancelable: true, // work in the Event constructor\r\n    clientX: 100,\r\n    clientY: 100\r\n  }); var room_enterbtn = document.getElementsByClassName('room__enter-button__text');\r\n  room_enterbtn[0].dispatchEvent(event);\r\n  window.location = \"https://www.habbo.com/client\";\r\n  window.location = \"https://www.habbo.com/\"\r\n}";
            webView21.CoreWebView2.ExecuteScriptAsync(Newtonsoft.Json.JsonConvert.SerializeObject(script));
            var Encode = Newtonsoft.Json.JsonConvert.SerializeObject(script);

        }
    }
}
            

           