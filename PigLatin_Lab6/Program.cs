using System;
using System.Linq;

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
                int beginEnd = 0;

                //check if first letter is a vowel
                char firstLetterOnly = word[0];
                bool v = IsVowel(firstLetterOnly);
                if (v == true)
                {
                    string vowelWord = word + "way";
                    Console.WriteLine(vowelWord);
                }
                else
                {
                    //find where first vowel exists
                    char[] letters = word.ToCharArray();
                    foreach (char l in letters)
                    {
                        bool b = IsVowel(l);

                        if (b == true)
                        {
                            PigLatin(word, beginEnd);
                            break;
                        }
                        else
                        {
                            beginEnd++;
                        }
                    }
                }
                run = Continue();
            }
        }
        public static string PigLatin(string s, int i)
        {
            string wordBegin = s.Substring(0, i);
            string restOfWord = s.Substring(i, s.Length - i);
            string pigWord = restOfWord + wordBegin + "ay";
            Console.WriteLine(pigWord);
            return pigWord;
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
       
        //determine which index has the first vowel
       public static bool IsVowel(char c)
        {
            string vowels = "AEIOUaeiou";
            char[] listedVowels = vowels.ToCharArray();
            
            if (listedVowels.Contains(c))
            {
                return true;
             }
            else
            {
                return false;
            }
         }
    }
}
