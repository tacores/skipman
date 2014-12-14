using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace skipman
{
    /// <summary>
    /// アルバム名→アルバムクラスの辞書クリエイタ
    /// </summary>
    interface AlbumDictionaryCreator
    {
        /// <summary>
        /// 辞書作成
        /// </summary>
        /// <param name="files">ファイルパスの配列</param>
        Dictionary<string, Album> create(string[] files);
    }
}
