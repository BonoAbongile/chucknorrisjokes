using ChuckNorrisJokesLibrary;
using System;
using System.Threading.Tasks;

namespace ChuckNorrisJokeConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //CHUCK NORRIS JOKE
            var joke = new JokeGenerator();
            string randomJoke = await joke.GetRandomJ();
            Console.WriteLine(randomJoke);


            // ANIMALS CATEGORY
            string[] categories = await joke.GetCategories();
            for (int index = categories.Length - 1; index >= 0; index--)
            {
                Console.WriteLine(categories[index]);
            }
        }
    }
}
