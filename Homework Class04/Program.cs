using System;

namespace Homework_Class04
{
    class Program
    {

        static void FunWithString(string inputString)
        {
            #region Reverse String
            Console.WriteLine("============= Reverse String =============");
            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                Console.Write(inputString[i]);
            }
            Console.WriteLine("\n============= Done =============");
            #endregion

            Console.WriteLine("-----------------------------------");

            #region Total number of vowels
            Console.WriteLine("============= Total number of vowels =============");

            char[] vowels = new char[]{'a', 'e', 'i', 'o', 'u'};
            string findVowels = inputString.ToLower();
            int counterVowels = 0;
            foreach (char character in findVowels)
            {
                foreach (char character1 in vowels)
                {
                    if (character == character1) counterVowels++;
                }

            }
            Console.WriteLine($"In this sentence: {findVowels}. Total number of vowels is: {counterVowels} ");
            
            Console.WriteLine("\n============= Done =============");
            #endregion
            Console.WriteLine("-----------------------------------");


            #region Check if string is palindrome
            Console.WriteLine("============= Check if string is palindrome =============");

            string strPalindrome = inputString;
            string reverse = string.Empty;

            for (int i = strPalindrome.Length - 1; i >= 0; i--)
            {
                reverse += strPalindrome[i];
            }

            if (strPalindrome == reverse)
            {
                Console.WriteLine($"{strPalindrome} is Palindrome.");
            }
            else
            {
                Console.WriteLine($"{strPalindrome} is not Palindrome");
            }

            Console.WriteLine("\n============= Done =============");
            #endregion
            Console.WriteLine("-----------------------------------");

            #region Print the largest word
            Console.WriteLine("============= Print the largest word =============");
            string[] arrayOfWordInSentence = inputString.Split();
            int wordLength = 0;
            string largestWord = "";
            foreach (string word in arrayOfWordInSentence)
            {
                if (word.Length > wordLength)
                {
                    wordLength = word.Length;
                    largestWord = word;
                }
                else continue;
            }
            Console.WriteLine(@$"The largest word in this sentence: {inputString} is: ""{largestWord}"" and have: {wordLength} characters.");


            Console.WriteLine("\n============= Done =============");
            #endregion
            Console.WriteLine("-----------------------------------");

            #region Print the smallest word
            Console.WriteLine("============= Print the smallest word =============");
            string[] arrayOfWordInSentence1 = inputString.Split(' ');
            int wordLength1 = 999999999;
            string smallestWord = "";
            foreach (string word in arrayOfWordInSentence1)
            {
                if (word.Length < wordLength1)
                {
                    wordLength1 = word.Length;
                    smallestWord = word;
                }
                else continue;
            }
            Console.WriteLine(@$"The smallest word in this sentence: {inputString} is: ""{smallestWord}"" and have: {wordLength1} characters.");


            Console.WriteLine("\n============= Done =============");
            #endregion
            Console.WriteLine("-----------------------------------");
            #region Print the count of words
            Console.WriteLine("============= Print the count of words =============");
            string[] arrayOfWordInSentence2 = inputString.Split(' ');
            
            Console.WriteLine(@$"The sentence has: {arrayOfWordInSentence2.Length} words.");


            Console.WriteLine("\n============= Done =============");
            #endregion

            Console.WriteLine("-----------------------------------");
            #region Print the most used character(not space obviously)
            Console.WriteLine("============= Print the most used character(not space obviously) =============");

            char mostUsedChar = ' ';
            int characterUsedCount = 0;
            for (int i = 0; i < inputString.Length; i++)
            {
                int countCharacter = 0;
                for (int j = 0; j < inputString.Length; j++)
                {
                    if (inputString[i] == inputString[j]) countCharacter++;
                    if (countCharacter > characterUsedCount && inputString[i] != ' ')
                    {
                        characterUsedCount = countCharacter;
                        mostUsedChar = inputString[i];
                    }
                    else continue;
                }
            }
            Console.WriteLine($"Most used char is '{mostUsedChar}' and is {characterUsedCount} times used.");

            Console.WriteLine("\n============= Done =============");
            #endregion

            
        }
        #region Task 2 Remove extra space characters
        static void RemoveExtraSpacesCharacter(string input)
        {
            string q = input.Trim();
            string a = String.Join(" ", q.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries));
            Console.WriteLine(a);

        }
        #endregion

        static void Main(string[] args)
        {
            FunWithString("learning csharp is really fun.");

            Console.WriteLine("-----------------------------------");

            RemoveExtraSpacesCharacter("  The    best  Lorem  Ipsum        Generator in all the  sea!   Heave this   scurvy copyfiller fer yar         next   adventure  and cajol yar clients   into walking the plank with ev'ry layout!    Configure       above, then get yer pirate ipsum...own the high seas,    argh!   ");

            Console.ReadLine();
        }
    }
}
