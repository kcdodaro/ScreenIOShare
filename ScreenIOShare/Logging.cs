using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ScreenIOShare
{
    class Logging
    {
        public bool checkDirectory(string path, bool shouldCreateDirectory)
        {
            if (shouldCreateDirectory)
            {
                createDirectory(path);
                return true;
            }
            else
            {
                if (Directory.Exists(path))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool checkFile(string path, bool shouldCreateFile)
        {
            if (shouldCreateFile)
            {
                createFile(path);
                return true;
            }
            else
            {
                if (File.Exists(path))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void createDirectory(string path)
        {
            Directory.CreateDirectory(path);
        }

        public void createFile(string path)
        {
            File.Create(path);
        }

        public void logEvent(string Description)
        {
            string path = Standards.errorFileLocation;
            Description = DateTime.Now + ": " + Description;

            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite))
            {
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(Description);
                sw.Close();
            }
        }
    }
}
