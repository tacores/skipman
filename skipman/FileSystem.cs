using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace skipman
{
    /// <summary>
    /// ファイルシステムの機能をまとめたインターフェイス。
    /// </summary>
    interface FileSystem
    {
        /// <summary>
        /// walkmanドライブのドライブ名を返す。
        /// </summary>
        /// <returns>ドライブ名。（例「F:\」）</returns>
        string getWalkmanDriveName();

        /// <summary>
        /// フォルダ内の全ファイルのファイルパスを返す。
        /// </summary>
        /// <param name="folderName"></param>
        /// <returns>ファイルパスの配列</returns>
        string[] getAllFileNames(string folderName);
    }
}
