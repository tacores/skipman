using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace skipman
{
    /// <summary>
    /// ディスクを表現するクラス。CD1枚に対応する。ディスクには1曲以上のトラックが含まれる。
    /// </summary>
    public class Disc
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="disk">ディスク番号</param>
        /// <param name="trackCount">トラック数</param>
        public Disc(uint disk, uint trackCount)
        {
            TrackCount = trackCount;
            tracks = new Track[trackCount];
            DiskNum = disk;
        }

        /// <summary>
        /// トラック追加
        /// </summary>
        /// <param name="track">トラック番号</param>
        /// <param name="title">曲名</param>
        /// <param name="filePath">ファイルパス</param>
        /// <param name="artist">アーティスト</param>
        public void addTrack(uint track, string title, string filePath, string artist)
        {
            tracks[track - 1] = new Track(track, title, filePath, artist);
        }

        /// <summary>
        /// トラック番号からトラックを取得する。
        /// </summary>
        /// <param name="track">トラック番号</param>
        /// <returns>トラック</returns>
        public Track getTrack(uint track)
        {
            return tracks[track - 1];
        }

        /// <summary>
        /// ディスクのトラック数
        /// </summary>
        public uint TrackCount
        {
            get;
            set;
        }

        /// <summary>
        /// ディスク番号
        /// </summary>
        public uint DiskNum
        {
            get;
            set;
        }

        private Track[] tracks;
    }
}
