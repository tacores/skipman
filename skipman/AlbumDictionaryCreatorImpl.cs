using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace skipman
{
    public class AlbumDictionaryCreatorImpl : AlbumDictionaryCreator
    {
        private ProgressListener progressListener;
        public AlbumDictionaryCreatorImpl(ProgressListener progressListener)
        {
            this.progressListener = progressListener;
        }

        public Dictionary<string, Album> create(string[] files)
        {
            Dictionary<string, Album> dict = new Dictionary<string, Album>();
            int i = 1;
            foreach (string file in files)
            {
                progressListener.notifyProgress(files.Length, i++);
                try
                {
                    using (MusicTag tagFile = MusicTagFactory.create(file))
                    {
                        if (tagFile.Disc == 0 || tagFile.DiscCount == 0 || tagFile.Track == 0 || tagFile.TrackCount == 0)
                        {
                            continue;
                        }

                        Album al;
                        if (!dict.ContainsKey(tagFile.AlbumTitle))
                        {
                            dict[tagFile.AlbumTitle] = new Album(tagFile.AlbumTitle, tagFile.DiscCount);
                        }

                        al = dict[tagFile.AlbumTitle];
                        al.addTrack(tagFile.Disc, tagFile.Track, tagFile.TrackCount, tagFile.Title, file, tagFile.Artist);
                    }
                }
                catch (Exception)
                {
                    continue;
                }
            }
            return dict;
        }
    }
}
