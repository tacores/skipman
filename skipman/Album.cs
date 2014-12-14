using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace skipman
{
    /// <summary>
    /// アルバム
    /// </summary>
    public class Album
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="title">アルバムタイトル</param>
        /// <param name="discCount">ディスク数</param>
        public Album(string title, uint discCount)
        {
            this.Title = title;
            this.DiscCount = discCount;
            discs = new Disc[discCount];
            dict = new Dictionary<uint, string>();
            AllTrackCount = 0;
            needCorrect = false;
        }

        /// <summary>
        /// トラック追加
        /// </summary>
        /// <param name="disc">ディスク番号</param>
        /// <param name="track">トラック番号</param>
        /// <param name="trackCount">トラック数</param>
        /// <param name="name">曲名</param>
        /// <param name="filePath">ファイルパス</param>
        /// <param name="artist">アーティスト</param>
        public void addTrack(uint disc, uint track, uint trackCount, string name, string filePath, string artist)
        {
            if (discs[disc - 1] == null)
            {
                discs[disc - 1] = new Disc(disc, trackCount);
            }
            discs[disc - 1].addTrack(track, name, filePath, artist);
            AllTrackCount++;

            if (dict.ContainsKey(track))
            {
                needCorrect = true;
            }
            else
            {
                dict[track] = "";
            }
        }

        /// <summary>
        /// アルバムタイトル
        /// </summary>
        public string Title
        {
            get;
            set;
        }

        /// <summary>
        /// ディスク数
        /// </summary>
        public uint DiscCount
        {
            get;
            set;
        }

        /// <summary>
        /// 全トラック数
        /// </summary>
        public uint AllTrackCount
        {
            get;
            set;
        }

        private Dictionary<uint, string> dict;
        /// <summary>
        /// 修正が必要かどうか
        /// </summary>
        public bool needCorrect
        {
            get;
            set;
        }

        /// <summary>
        /// ディスク取得
        /// </summary>
        /// <param name="disc">ディスク番号</param>
        /// <returns>ディスク</returns>
        public Disc getDisc(uint disc)
        {
            return discs[disc - 1];
        }

        private Disc[] discs;
    }
}
