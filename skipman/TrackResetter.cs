using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace skipman
{
    /// <summary>
    /// トラック番号を再採番するクラス
    /// </summary>
    public class TrackResetter
    {
        /// <summary>
        /// トラック番号を再採番する。
        /// 第1ソートキーをディスク番号、第2ソートキーをトラック番号として1から順に再採番する。
        /// </summary>
        /// <param name="album">再採番するアルバム</param>
        public void reset(Album album)
        {
            uint newTrack = 1;

            for (uint i = 1; album != null && i <= album.DiscCount; ++i)
            {
                Disc disc = album.getDisc(i);
                for (uint j = 1; disc != null && j <= disc.TrackCount; ++j)
                {
                    Track track = disc.getTrack(j);
                    using (MusicTag tagFile = MusicTagFactory.create(track.FilePath))
                    {
                        tagFile.Track = newTrack++;
                        tagFile.save();
                    }
                }
            }
        }
    }
}
