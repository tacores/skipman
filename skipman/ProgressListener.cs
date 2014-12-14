using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace skipman
{
    /// <summary>
    /// スキャン処理の進捗リスナー
    /// </summary>
    public interface ProgressListener
    {
        /// <summary>
        /// 進捗通知
        /// </summary>
        /// <param name="all">全体の件数</param>
        /// <param name="done">実行済みの件数</param>
        void notifyProgress(int all, int done);
    }
}
