using System;
using System.IO;

namespace SolverEngines
{
    public static class FileUtil
    {
        /// <summary>
        /// Generate and MD5 hash for a particular file
        /// </summary>
        /// <param name="filename">File to generate hash for</param>
        /// <returns>Hash as a hexidecimal string separated by dashes</returns>
        public static string FileHash(string filename)
        {
            byte[] hash = null;
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                using (FileStream stream = File.OpenRead(filename))
                {
                    hash = md5.ComputeHash(stream);
                }
            }

            return BitConverter.ToString(hash);
        }
    }
}
