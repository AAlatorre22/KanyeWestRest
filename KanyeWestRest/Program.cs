using Newtonsoft.Json.Linq;
using static System.Net.WebRequestMethods;

namespace KanyeWestRest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Here is a conversation between a Ron Swanson API and a Kanye West API. Enjoy the nonsense!");
            Console.WriteLine("Press enter to start");
            Console.ReadLine();
            bool cont = true;
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Ron: {Quotes.RonQuote()}");
                Console.WriteLine();
                Console.ForegroundColor= ConsoleColor.Cyan;
                Console.WriteLine($"Kanye: \"{Quotes.KanyeQuote()}\"");
                Console.WriteLine();
                Console.ResetColor();
                Console.WriteLine("Continue? Y for yes, N for no.");
                var response = Console.ReadLine().ToLower();
                cont = (response == "y") ? true : false;
                Console.WriteLine();
            }
            while (cont);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Thanks for visiting!");
            Console.ResetColor();


        }

    }


    

}
