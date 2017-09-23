using System;

/*prompt the user for a word
application will translate the text to Pig Latin and display on console
application asks user if he/she wants to translate another word*/

namespace PigLatin_Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pig Latin Translator!");

            bool run = true;
            while (run == true)
            {
                Console.WriteLine("Enter a word to be translated:");
                string word = (Console.ReadLine());
                word = word.ToLower();
                //string pigLatin = ToPigLatin(word);

                string firstLetter = word.Substring(0, 1);
                string restOfWord = word.Substring(1, word.Length - 1);
                string pigWord = restOfWord + firstLetter + "ay";

                Console.WriteLine(pigWord);
                run = Continue();
            }
        }
        public static bool Continue()
        {
            Console.WriteLine("Translate another line? y/n");
            string input = Console.ReadLine();
            input = input.ToLower();
            bool goOn;
            if (input == "y")
            {
                goOn = true;
            }
            else if (input == "n")
            {
                goOn = false;
            }
            else
            {
                Console.WriteLine("I don't understand that, let's try again");
                goOn = Continue();
            }

            return goOn;
        }
        /* {
             //string vowels = "AEIOUaeiou";
             char[] pigArray = new char[input.Length];

             foreach (char i in input)
             {
                 string firstLetter = input.Substring(0, 1);
                 string restOfWord = input.Substring(1, input.Length - 1);

                 string pigWord = restOfWord + firstLetter + "ay";
                 return pigWord;

             }
         }*/

        /*try
            {
            Console.WriteLine("Enter a word to be translated:");
            string word = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(word))
            {
                throw new ArgumentException("A word must be entered.");
            }
            if (word.Length > 35)
            {
                throw new ArgumentException("Name cannot be longer than 35 characters");
            }

            foreach (char item in word)
                {
                if (!char.IsLetter(item))
                {
                    return false;
                }
            }
        }
        catch(ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
         }*/
    }
}
