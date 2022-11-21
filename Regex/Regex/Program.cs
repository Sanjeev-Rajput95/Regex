﻿using System.Text.RegularExpressions;

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

             string pattern1 = @"^[1-9]{6}[A-Z]{7}$";
             
             Regex rgobj = new Regex(pattern1);
             bool result1 = rgobj.IsMatch("400088B");
             Console.WriteLine("Check not last alphabet " + result1);

             string pattern2 = @"^[1-9]{1}[0-9]{2}\s{0,1}[0-9]{3}";
             
             Regex rgSpaces = new Regex(pattern2);
             bool result2 = rgSpaces.IsMatch("400088");
             Console.WriteLine("Spaces between number " + result2);
             
             Console.WriteLine("\n\n============== WELCOME TO REGEX EMAIL PROGRAM ==============\n\n");

             string emailPattern = @"^[a-z A-Z]+([.][a-z A-Z]+)*@[a-z A-Z]+.[a-z A-Z]{0,3}([.][a-z A-Z]{2,3})?$";

            Regex em = new Regex(emailPattern);
             bool emresult = em.IsMatch("abc.xyz@bridgelabz.in");
             bool emresult1 = em.IsMatch("abc@bridgelabz.co");
             Console.WriteLine("Email is : " + emresult);
             Console.WriteLine("Without used Manadatory : " + emresult1);
            string emailPattern1 = @"^[a-z A-Z]+[.]{0,1}([a-z A-Z]+)*@[a-z A-Z]+.[a-z A-Z]{2,10}([.][a-z A-Z]{0,3})?$";
            //Console.WriteLine("\n UC3 : " + emresult1);
            Regex em3 = new Regex(emailPattern1);
            bool emresult3 = em3.IsMatch("abc.@Bridgelabz.co");
            Console.WriteLine("UC3 : " + emresult3);

            string empattern4 = @"^[a-zA-Z]+([._+-][a-z A-Z]+)*@[a-zA-Z]+.[a-zA-Z]{2,4}([.][a-zA-Z]{2,3})?$";
            Regex em4 = new Regex(empattern4);
            bool emresult4 = em4.IsMatch("abc_xyz@bridgelabz.co.in");
            Console.WriteLine("UC4 : " + emresult4);







        }
    }
}