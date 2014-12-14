using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace skipman
{
    /// <summary>
    /// トラック
    /// </summary>
    public class Track
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="track">トラック番号</param>
        /// <param name="title">曲名</param>
        /// <param name="filePath">ファイルパス</param>
        /// <param name="artist">アーティスト</param>
        public Track(uint track, string title, string filePath, string artist)
        {
            TrackNum = track;
            Title = title;
            FilePath = filePath;
            Artist = artist;
        }

        /// <summary>
        /// ファイルパス
        /// </summary>
        public string FilePath
        {
            get;
            set;
        }

        /// <summary>
        /// 曲名
        /// </summary>
        public string Title
        {
            get;
            set;
        }

        /// <summary>
        /// トラック番号
        /// </summary>
        public uint TrackNum
        {
            get;
            set;
        }

        /// <summary>
        /// アーティスト
        /// </summary>
        public string Artist
        {
            get;
            set;
        }
    }
}
