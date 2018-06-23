

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataArgs
{
    public class ARGS
    {
        public bool hasLogin;
        public bool hasPort;
        public int port;
        public bool hasDirectory;
        public string directory;

        public void main(string[] args)
        {
            if (args.Length > 0)
                hasLogin = args[0] == "-l";

            hasPort = false;
            hasDirectory = false;

            SeePort(args);
            SeeDirectory(args);


        }
        void SeePort(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] == "-p" && i + 1 < args.Length)
                {
                    hasPort = int.TryParse(args[i + 1], out port);
                    i++;
                    continue;
                }
            }

        }
        void SeeDirectory(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {

                if (args[i] == "-d" && i + 1 < args.Length)
                {
                    hasDirectory = true;
                    directory = args[i + 1];
                    i++;
                    continue;
                }

            }
        }
        static void Main(String[] args)
        {

        }
    }
}