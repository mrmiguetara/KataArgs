using System;


public static class Program
{
    public static bool logging;
    public static bool hasPort;
    public static int port;
    public static bool hasDirectory;
    public static string directory;

    static void Main(string[] args)
    {
        if (args.Length > 0)
            logging = args[0] == "-l";

        hasPort = false;
        hasDirectory = false;

        for (int i = 0; i < args.Length; i++)
        {
            if (args[i] == "-p" && i + 1 < args.Length)
            {
                hasPort = int.TryParse(args[i + 1], out port);
                i++;
                continue;
            }
            if (args[i] == "-d" && i + 1 < args.Length)
            {
                hasDirectory = true;
                directory = args[i + 1];
                i++;
                continue;
            }

        }
        Console.WriteLine("Logging state: {0}", logging);
        Console.WriteLine("Port state: {0}", hasPort);
        if (hasPort)
            Console.WriteLine("Port Value: {0}", port);
        Console.WriteLine("Directory state: {0}", hasDirectory);
        if (hasDirectory)
            Console.WriteLine("Directory Value {0}", directory);
    }
}