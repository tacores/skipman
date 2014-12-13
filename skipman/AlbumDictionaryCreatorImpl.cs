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
                        if (tagFile.disc == 0 || tagFile.discCount == 0 || tagFile.track == 0 || tagFile.trackCount == 0)
                        {
                            continue;
                        }

                        Album al;
                        if (!dict.ContainsKey(tagFile.album))
                        {
                            dict[tagFile.album] = new Album(tagFile.album, tagFile.discCount);
                        }

                        al = dict[tagFile.album];
                        al.addTrack(tagFile.disc, tagFile.track, tagFile.trackCount, tagFile.title, file);
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
