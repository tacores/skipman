using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace skipman
{
    /// <summary>
    /// 音楽ファイルタグを表現するインターフェイス。
    /// 1曲の音楽ファイルに埋め込まれているタグ情報。
    /// </summary>
    public interface MusicTag : IDisposable
    {
        /// アルバムタイトル
        string AlbumTitle
        {
            get;
            set;
        }

        /// ディスク番号
        uint Disc
        {
            get;
            set;
        }

        /// アルバムのディスク数
        uint DiscCount
        {
            get;
            set;
        }

        /// トラック番号
        uint Track
        {
            get;
            set;
        }

        /// ディスクのトラック数
        uint TrackCount
        {
            get;
            set;
        }

        /// タイトル
        string Title
        {
            get;
            set;
        }

        /// アーティスト
        string Artist
        {
            get;
            set;
        }

        /// ファイルパス（ファイルに埋め込まれている情報ではない）
        string FilePath
        {
            get;
            set;
        }

        /// ファイル保存（ファイルに埋め込まれているタグ情報の上書き）
        void save();
    }
}
