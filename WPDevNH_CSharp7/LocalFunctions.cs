using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPDevNH_CSharp7
{
    class LocalFunctions
    {
        public static string FindFirstSubPathNameContaining(string parent, string substring)
        {
            var parentDir = new DirectoryInfo(parent);
            return SearchSubpath(parentDir);

            string SearchSubpath(DirectoryInfo info)
            {
                if (info.Name.Contains(substring))
                    return info.FullName;

                return info.EnumerateDirectories()
                    .Select(subdir => SearchSubpath(subdir))
                    .FirstOrDefault(result => !string.IsNullOrWhiteSpace(result));
            }
        }
    }
}
