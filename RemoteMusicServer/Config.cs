using System;
using System.IO;

namespace RemoteMusicServer
{
    internal class Config
    {
        private string filePath;

        private int port = 41502;
        private bool startupHide = false;

        public Config(string filePath)
        {
            this.filePath = filePath;
        }

        public void Load()
        {
            if (!File.Exists(filePath))
            {
                Directory.GetParent(filePath).Create();
                return;
            }


            string[] content = File.ReadAllLines(filePath);
            try
            {
                Int32.TryParse(content[0], out port);
                Boolean.TryParse(content[1], out startupHide);
            } catch { }
        }

        public void Save()
        {
            File.WriteAllLines(filePath, new string[] { port.ToString(), startupHide.ToString()});
        }


        public int GetPort()
        {
            return port;
        }
        public void SetPort(int port)
        {
            this.port = port;
        }

        public bool GetStartupHide()
        {
            return startupHide;
        }
        public void SetStartupHide(bool hide)
        {
            startupHide = hide;
        }
    }
}
