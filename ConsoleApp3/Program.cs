using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static async Task Main()
        {

            var url = $"https://imdb.iamidiotareyoutoo.com/search?q=Spiderman";

            using (var client = new HttpClient())
            {
                var response = await client.GetStringAsync(url);

                var result = JsonConvert.DeserializeObject<ImdbResponse>(response);

                if (result.Ok && result.Data != null && result.Data.Count > 0)
                {
                    foreach (var movie in result.Data)
                    {
                        Console.WriteLine($"Title: {movie.Title} ({movie.Year})");
                        Console.WriteLine($"IMDb ID: {movie.Id}");
                        Console.WriteLine($"Poster: {movie.Actors}");
                        Console.WriteLine(new string('-', 50));
                    }
                }
                else
                {
                    Console.WriteLine("No movies found.");
                }
            }
        }
    }
}
