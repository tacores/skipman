using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace skipman
{
    /// <summary>
    /// 音楽ファイルタグのファクトリクラス
    /// </summary>
    public class MusicTagFactory
    {
        /// <summary>
        /// 音楽ファイルタグクラス生成
        /// </summary>
        public static MusicTag create(string filePath)
        {
            if (musicTag == null)
            {
                // newしたものをmusicTagに保存してはいけない。
                return new MusicTagLibImpl(filePath);
            }
            else
            {
                // ユニットテストの都合でファイルパスを保存している。
                musicTag.FilePath = filePath;
                return musicTag;
            }
        }

        /// <summary>
        /// 音楽ファイルタグクラス設定（For Test Only）
        /// </summary>
        public static void FTO_set(MusicTag musicTag)
        {
            MusicTagFactory.musicTag = musicTag;
        }
        static private MusicTag musicTag;   //テスト用
    }
}
