using System.Text.RegularExpressions;

namespace RegexPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============== WELCOME TO REGEX PROGRAM ==============");

            string pattern = @"^[1-9]{1}[0-9]{5}";

             Regex rg = new Regex(pattern);
             bool result = rg.IsMatch("400088");
             Console.WriteLine("PIN : " + result);

             bool alphabet_SpecialChar = rg.IsMatch("A400088");
             Console.WriteLine("Alphabet : " + alphabet_SpecialChar);



        }
    }
}