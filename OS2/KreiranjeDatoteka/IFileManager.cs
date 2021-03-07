using System;
using System.Collections.Generic;
using System.Text;

namespace OS2
{
    public interface IFileManager
    {
        bool Write(string Line);
        bool Clear();
        void Create();
        string GetPath();
        bool Exists();
        string ReadAll();
    }
}
