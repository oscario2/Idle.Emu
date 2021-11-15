using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace Cocos.Zip.Services
{
    public static class ZipService
    {
        /// <summary>
        /// read each file in zip file
        /// </summary>
        /// <param name="zipPath"></param>
        /// <param name="filter"></param>
        public static Dictionary<string, byte[]> ReadFiles(string zipPath, string filter = "")
        {
            return ReadFiles(zipPath, new List<string>() {filter});
        }

        public static Dictionary<string, byte[]> ReadFiles(string zipPath, List<string> filter = null)
        {
            var entries = new Dictionary<string, byte[]>();
            using var zipFile = ZipFile.OpenRead(zipPath);

            foreach (var entry in zipFile.Entries)
            {
                var name = entry.FullName;

                // directory
                if (name.EndsWith("/")) continue;

                // filter, if provided
                if (!ExistsInFilter(name, filter)) continue;

                using var outputStream = new MemoryStream();
                entry.Open().CopyTo(outputStream);

                outputStream.Position = 0;
                entries.Add(name, outputStream.ToArray());
            }

            return entries;
        }

        private static bool ExistsInFilter(string name, IEnumerable<string> filter)
        {
            return filter == null || filter.Any(name.Contains);
        }
    }
}