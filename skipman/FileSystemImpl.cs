using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace skipman
{
    class FileSystemImpl
    {
        public string getWalkmanDriveName()
        {
            //現在のコンピュータの論理ドライブを取得
            System.IO.DriveInfo[] drives = System.IO.DriveInfo.GetDrives();
            foreach (System.IO.DriveInfo d in drives)
            {
                try
                {
                    if (d.VolumeLabel == "WALKMAN")
                    {
                        return d.Name;
                    }
                }
                catch (Exception)
                {
                    //ドライブ名を取得できない場合がある
                }
            }
            throw new Exception();
        }

        public string[] getAllFileNames()
        {
            return null;
        }
    }
}
