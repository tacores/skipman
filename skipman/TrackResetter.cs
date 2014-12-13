﻿using System;
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

            for (uint i = 1; album != null && i <= album.DiscCount; ++i)
            {
                Disc disc = album.getDisc(i);
                for (uint j = 1; disc != null && j <= disc.TrackCount; ++j)
                {
                    Track track = disc.getTrack(j);
                    using (MusicTag tagFile = MusicTagFactory.create(track.Path))
                    {
                        tagFile.track = newTrack++;
                        tagFile.save();
                    }
                }
            }
        }
    }
}
