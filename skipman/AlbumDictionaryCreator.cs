using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace skipman
{
    /// <summary>
    /// アルバム名 -> アルバムクラスのディクショナリを作成する
    /// </summary>
    interface AlbumDictionaryCreator
    {
        /// <summary>
        /// ディクショナリ作成
        /// </summary>
        /// <param name="files">ファイルパスの配列</param>
        Dictionary<string, Album> create(string[] files);
    }
}
