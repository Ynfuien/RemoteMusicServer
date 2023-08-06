using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace RemoteMusicServer
{
    internal class CommandListener
    {
        private Thread listenerThread;
        private Socket listener;
        private bool closing = false;

        public CommandListener() { }

        public void Start(int port)
        {
            closing = false;
            listenerThread = new Thread(() => { StartServer(port); });
            listenerThread.Start();
        }

        public void Stop()
        {
            closing = true;
            listener.Close();
        }

        private void StartServer(int port)
        {
            IPAddress ipAddress = IPAddress.Any;
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, port);

            listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                listener.Bind(localEndPoint);
            }
            catch (SocketException e)
            {
                string message = e.Message;

                if (e.SocketErrorCode == SocketError.AddressAlreadyInUse)
                {
                    message = "Port is already in use!\nProbably another instance of this app is already running. So either kill it, or do nothing.";
                    
                }

                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
                return;
            }
            listener.Listen(10);


            while (!closing)
            {
                try
                {
                    Socket client = listener.Accept();

                    byte[] bytes = new byte[1024];
                    string message = null;

                    while (true)
                    {
                        int numByte = client.Receive(bytes);
                        message += Encoding.ASCII.GetString(bytes, 0, numByte);

                        if (message.IndexOf("<EOF>") > -1)
                            break;
                    }

                    message = message.Substring(0, message.Length - 5);
                    //Console.WriteLine("Message: " + message);
                    PerformAction(message);

                    client.Shutdown(SocketShutdown.Both);
                    client.Close();
                }
                catch (Exception e)
                {
                    if (e is SocketException) break;
                    Console.WriteLine(e);
                }
            }
        }

        private void PerformAction(string action)
        {
            switch (action)
            {
                case "volume-up":
                    AppCommand.Send(AppCommands.VolumeUp);
                    break;
                case "volume-down":
                    AppCommand.Send(AppCommands.VolumeDown);
                    break;
                case "volume-mute":
                    AppCommand.Send(AppCommands.VolumeMute);
                    break;
                case "play-pause":
                    AppCommand.Send(AppCommands.MediaPlayPause);
                    break;
                case "next-track":
                    AppCommand.Send(AppCommands.MediaNext);
                    break;
                case "previous-track":
                    AppCommand.Send(AppCommands.MediaPrevious);
                    break;
            }
        }
    }
}
