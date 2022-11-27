using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode.Videos;

namespace YouTubeExplore
{
    abstract class Command
    {
        public abstract Task<Video> Information();
        public abstract Task Download();
    }
}
