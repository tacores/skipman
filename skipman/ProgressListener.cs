using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace skipman
{
    public interface ProgressListener
    {
        void notifyProgress(int all, int done);
    }
}
