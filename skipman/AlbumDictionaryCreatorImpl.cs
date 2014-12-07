using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace skipman
{
    class AlbumDictionaryCreatorImpl : AlbumDictionaryCreator
    {
        public Dictionary<string, Album> create(string[] files)
        {
            Dictionary<string, Album> dict = new Dictionary<string, Album>();
            foreach (string file in files)
            {
                try
                {
                    using (TagLib.File tagFile = TagLib.File.Create(file))
                    {
                        if (tagFile.Tag.Disc == 0 || tagFile.Tag.DiscCount == 0 || tagFile.Tag.Track == 0 || tagFile.Tag.TrackCount == 0)
                        {
                            continue;
                        }

                        Album al;
                        if (!dict.ContainsKey(tagFile.Tag.Album))
                        {
                            dict[tagFile.Tag.Album] = new Album(tagFile.Tag.Album, tagFile.Tag.DiscCount);
                        }

                        al = dict[tagFile.Tag.Album];
                        al.addTrack(tagFile.Tag.Disc, tagFile.Tag.Track, tagFile.Tag.TrackCount, tagFile.Tag.Title, file);
                    }
                }
                catch (TagLib.CorruptFileException)
                {
                    continue;
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
