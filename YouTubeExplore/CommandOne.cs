using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode.Videos;

namespace YouTubeExplore
{
    class CommandOne : Command
    {
        Receiver receiver;
        public CommandOne(Receiver receiver)
        {
            this.receiver = receiver;
        }
        public override async Task<Video> Information()
        {
            var info = receiver.GetInformation();
            return await info;
        }
        public override async Task Download()
        {
            await Task.Run(() => receiver.DoDownload());
        }
    }
}
