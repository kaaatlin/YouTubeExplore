using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode.Videos;

namespace YouTubeExplore
{
    class Sender
    {
        Command command;
        public void SetCommand(Command command)
        {
            this.command = command;
        }

        public async Task<Video> Information()
        {
            return await Task.Run(() => this.command.Information());
        }
        public async Task Download()
        {
            await this.command.Download();
        }

    }
}
