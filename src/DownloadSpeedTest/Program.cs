using Microsoft.AspNetCore.Hosting;
using System;

namespace DownloadSpeedTest
{
    public class Program
    {
        private static byte[] downloadBytes;

        internal static byte[] DownloadBytes
        {
            get
            {
                //var bytes = new byte[downloadBytes.Length];
                //Buffer.BlockCopy(downloadBytes, 0, bytes, 0, bytes.Length);
                //return bytes;
                return downloadBytes;
            }
        }

        public static void Main(string[] args)
        {
            downloadBytes = new byte[1024000000];

            for(int i=0;i< downloadBytes.Length; i++)
            {
                downloadBytes[i] = (byte)0;
            }

            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            var builder = new WebHostBuilder();
            builder
                .UseKestrel()
                .UseStartup<Startup>();
            return builder;
        }
    }
}
