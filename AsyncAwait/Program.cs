using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Program
    {
        public static async Task<int> AccessTheWebAsync()
        {
            //TWO
            HttpClient httpClient = new HttpClient();

            //THREE
            Task<string> getLengthTask = httpClient.GetStringAsync("https://www.google.com");

            //Five
            string urlContentLength = await getLengthTask;
            return urlContentLength.Length;

        }
        static void Main(string[] args)
        {
            MainAsync(args).GetAwaiter().GetResult();
        }
        static async Task MainAsync(string[] args)
        {
            //One
            Task<int> contentLengthTask = AccessTheWebAsync();

            DoIndependentWork();
            //Four
            int contentLength = await contentLengthTask;

            //SIX
            Console.WriteLine($"Content Length {contentLength}");
            Console.ReadKey();
        }
        static void DoIndependentWork()
        {
            Console.WriteLine("Do independent Work");
        }
    }
}
