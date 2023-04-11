using Newtonsoft.Json.Linq;
using static System.Net.WebRequestMethods;

namespace KanyeWestRest
{
    internal class Program
    {
        static void Main(string[] args)
        {


            bool cont = true;
            do
            {
                Console.WriteLine($"Ron: {Quotes.RonQuote()}");
                Console.WriteLine($"Kanye: \"{Quotes.KanyeQuote()}\"");
                Console.WriteLine();
                Console.WriteLine("continue? Y for yes, N for no.");
                var response = Console.ReadLine().ToLower();
                cont = (response == "y") ? true : false;
            }
            while (cont);


        }

    }


    

}
