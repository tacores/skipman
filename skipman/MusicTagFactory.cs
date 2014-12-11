using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace skipman
{
    public class MusicTagFactory
    {
        public static MusicTag create(string filePath)
        {
            if (musicTag == null)
            {
                return new MusicTagLibImpl(filePath);
            }
            else
            {
                musicTag.path = filePath;
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
