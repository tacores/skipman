using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace skipman
{
    public class TrackResetter
    {
        public void reset(Album album)
        {
            uint newTrack = 1;

            for (uint i = 1; album != null && i <= album.discCount; ++i)
            {
                Disc disc = album.getDisc(i);
                for (uint j = 1; disc != null && j <= disc.trackCount; ++j)
                {
                    Track track = disc.getTrack(j);
                    using (TagLib.File tagFile = TagLib.File.Create(track.path))
                    {
                        tagFile.Tag.Track = newTrack++;
                        tagFile.Save();
                    }
                }
            }
        }
    }
}
