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
        Standards st = new Standards();

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
    }
}
