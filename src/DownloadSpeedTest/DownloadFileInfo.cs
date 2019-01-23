using Microsoft.Extensions.FileProviders;
using System;
using System.IO;

namespace DownloadSpeedTest
{
    public class DownloadFileInfo : IFileInfo
    {
        private static readonly byte[] bytes = new byte[10240000];

        public bool Exists => true;

        public long Length => bytes.Length;

        public string PhysicalPath => "/testfile";

        public string Name => "testfile.dat";

        public DateTimeOffset LastModified => DateTimeOffset.UtcNow;

        public bool IsDirectory => false;

        public Stream CreateReadStream()
        {
            return new MemoryStream(bytes);
        }
    }
}
