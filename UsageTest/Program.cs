
namespace UsageTest
{


    class Program
    {


        // Textile from dotnetprojects 
        // https://github.com/dotnetprojects/textile.net
        // Tests from John Radke 
        // https://github.com/johnradke/NTextile
        static void Main(string[] args)
        {
            string input = "This _text_ is going to be *formatted* using %{color=#f00;}Textile.NET%.";
            string result = Textile.TextileFormatter.FormatString(input);
            System.Console.WriteLine(result);


            System.Console.WriteLine(" --- Press any key to continue --- ");
            System.Console.ReadKey();
        }


    }


}
