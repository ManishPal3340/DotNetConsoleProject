using System;
using System.Threading.Tasks;
class WaitRealLife
{
   
    
        static async Task Main()
        {
            Console.WriteLine("Start");

            await DownloadFile();

            Console.WriteLine("End");
        }

        static async Task DownloadFile()
        {
            Console.WriteLine("Downloading...");
            await Task.Delay(3000);
            Console.WriteLine("Download completed");
        }
    }




