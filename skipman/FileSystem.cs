using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace skipman
{
    interface FileSystem
    {
        string getWalkmanDriveName();

        string[] getAllFileNames(string folderName);
    }
}
