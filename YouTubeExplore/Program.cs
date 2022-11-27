using System;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;

/*
 * Используя паттерн Команда и созданный выше шаблон, напишите консольную программу, которая будет:
 * Принимать на вход ссылку на  Youtube-видео. 
 * Выводить в консоль информацию: название видео и описание.
 * Скачивать видео.
 * У вас должно быть две команды: на получение информации о видео и на скачивание.
 */
namespace YouTubeExplore
{    
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string link = "https://www.youtube.com/watch?v=ZhlMYkqOK4U";
            string path = "C:\\Users\\admin\\Desktop\\SkillFactory\\YouTubeExplore\\YouTubeExplore\\bin\\Debug\\result.mp4";
            //

            // создадим отправителя
            var sender = new Sender();

            // создадим получателя
            var receiver = new Receiver(link, path);

            // инициализация команды
            sender.SetCommand(new CommandOne(receiver));

            var information = sender.Information();
            Console.WriteLine($"Название: {information}");
            Console.WriteLine($"Описание видео: {information}");
            Console.WriteLine("У меня не получается вывести информацию о видео, объяснение в скачанном видео, спасибо!");

            await sender.Download();

        }
    }
}
