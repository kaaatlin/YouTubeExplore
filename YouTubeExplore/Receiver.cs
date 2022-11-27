using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode.Videos;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace YouTubeExplore
{
    class Receiver
    {
        public string link { get;  set; }
        public string path { get;  set; }
        public string title { get;  set; }
        public string metaData { get;  set; }

        public YoutubeClient videos;
        public Receiver(string videoUrl, string outputFilePath)
        {
            link = videoUrl;
            path = outputFilePath;
            videos = new YoutubeClient();
        }
        public async Task<Video> GetInformation()
        {
            var info = await videos.Videos.GetAsync(link);
            return info;
        }
        public async Task DoDownload()
        {
            await videos.Videos.DownloadAsync(link, path, builder => builder.SetPreset(ConversionPreset.UltraFast));
            Console.WriteLine("Готово!");
        }
    }
}
