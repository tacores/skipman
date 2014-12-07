using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace skipman
{
    interface AlbumDictionaryCreator
    {
        Dictionary<string, Album> create(string[] files);
    }
}
