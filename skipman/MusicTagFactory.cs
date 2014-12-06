using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace skipman
{
    class MusicTagFactory
    {
        public static MusicTag create(string filePath)
        {
            if (musicTag == null)
            {
                return new MusicMetaTagLibImpl(filePath);
            }
            else
            {
                return musicTag;
            }
        }

        public static void set(MusicTag musicTag)
        {
            MusicTagFactory.musicTag = musicTag;
        }

        static private MusicTag musicTag;
    }
}
