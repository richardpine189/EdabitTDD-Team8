using System;
using System.Linq;

namespace EdabitTDD
{
    public class TDDAction
    {
        public TDDAction()
        {

        }

        public string Stuttering(string inputWord)
        {
            string tempString = inputWord.Substring(0, 2);
            return $"{tempString}... {tempString}... {inputWord}?";  
        }

        public int[] CountHashesAndPluses(string inputString)
        {
            int numberOfHashes = inputString.Count(Hashes => Hashes == '#');
            int numberOfPluses = inputString.Count(Pluses => Pluses == '+');

            return new int[]{numberOfHashes, numberOfPluses};
        }

        public int HowManyVowel(string finalString)
        {
            int vowelCount = finalString.ToLower().Count(letter => letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u');
            return vowelCount;
        }

        public int? NextMultipleOfB(int firstNumber, int secondNumber)
        {
            if  (secondNumber != 0)
            {
                int count = (firstNumber >= secondNumber ? firstNumber : secondNumber);

                while  (count % secondNumber != 0)
                {
                    count++;
                }

                return count;
            }

            return null;
        }
    }
}