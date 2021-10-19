using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            List<string> versionList = new List<string> { "-v", "--v", "/v", "--version" };
            List<string> sizeList = new List<string> { "-s", "--s", "/s", "--size" };

            FileDetails fileDetails = new FileDetails();
            if (args.Length > 0)
            {
                if (versionList.Contains(args[0]))
                {
                    Console.WriteLine(fileDetails.Version(args[0]));
                }
                else if (sizeList.Contains(args[0]))
                {
                    Console.WriteLine(fileDetails.Size(args[0]));
                }
            }
        }
    }
}
