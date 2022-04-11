using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitTDD
{
    public class Methods
    {
        public static int Convert(int minutes)
        {
            return minutes * 60;
        }

        public static int RecursiveFactorial(int a)
        {
            if (a == 0) return 1;

            a = a * RecursiveFactorial(a - 1);
            return a;
        }

        //4 -> = 4 * (3 -> = 3* (2 -> = 2 * (1 = 1* (1)

        public static string[] ChangePosition(int position, string current)
        {
            int currentPosition = position;
            return  ChangePosition(currentPosition - 1, current); 

        }

        /*

       Find the Vertex of a Quadratic

       Every quadratic curve y = a x² + b x + c has a vertex point: the turning point where the curve stops heading down and starts going up.

       Given the values a, b and c, you need to return the coordinates of the vertex. Return your answers rounded to 2 decimal places.

       vertex x = -b / 2a

       */

        public static float[] GetQuadraticVertex(float a, float b, float c)
        {
            float expectedX = -b / (2 * a);
            float expectedY = a * (expectedX * expectedX) + b * expectedX + c;

            return new float[] { expectedX, expectedY };
        }

        public static float[] ApprochResult(float[] result)
        {
            result[0] = (float)Math.Round(result[0], 2);
            result[1] = (float)Math.Round(result[1], 2);

            return result;
        }

        /*
         
        Generate All String Character Permutations

        Create a function to generate all string character permutations.

        */

        public static string[] GetStringPermutationsArray(string inputString)
        {
            List<string> result = new List<string>();

            result.AddRange(GetStringPermutations(inputString, inputString.Length, result));

            result.Sort();

            return result.ToArray();
        }

        public static List<string> GetStringPermutations(string inputString, int position, List<string> list)
        {
            if (position == 0)
            {
                return list;
            }

            if (position == inputString.Length)
            {
                list = new List<string> { inputString[position - 1].ToString() };
                list = GetStringPermutations(inputString, position - 1, list);
                return list;
            }

            char newChar = inputString[position - 1];
            List<string> auxList = new List<string>();
            foreach (string aux in list)
            {
                for (int j = 0; j <= aux.Length; j++)
                {
                    auxList.Add(aux.Insert(j, newChar.ToString()));
                }
            }

            list = auxList;

            list = GetStringPermutations(inputString, position - 1, list);

            return list;

        }

        /*
         
        Is One String in the Other?

        Create a function that takes two strings and returns true if either of the strings appears at the very end of the other string.
        Return false otherwise. The character * is a wildcard, so it can take the place of any character.

        */
        public static bool ContainsEachOther(string firstString, string secondString)
        {
            string shorterString;
            string subString;

            if (firstString.Length < secondString.Length)
            {
                subString = secondString.Substring(secondString.Length - firstString.Length);
                shorterString = firstString;
            }
            else
            {
                subString = firstString.Substring(firstString.Length - secondString.Length);
                shorterString = secondString;
            }

            for (int c = 0; c < subString.Length; c++)
            {
                if (!(subString[c] == '*' || shorterString[c] == '*'))
                {
                    if (subString[c] != shorterString[c])
                    {
                        return false;
                    }
                }
            }


            return true;
        }

        /*

        Track the Robot (Part 2)

        This robot roams around a 2D grid. It starts at (0, 0) facing North. After each time it moves,
        the robot rotates 90 degrees clockwise.
        Given the amount the robot has moved each time, you have to calculate the robot's final position.

        */

        public static int[] GetFinalPosition(int[] movements)
        {
            int[] finalPosition = new int[] { 0, 0 };
            for (int i = 0; i < movements.Length; i++)
            {
                if (i % 4 == 0)
                {
                    finalPosition[1] += movements[i];
                }
                else if (i % 4 == 1)
                {
                    finalPosition[0] += movements[i];
                }
                else if (i % 4 == 2)
                {
                    finalPosition[1] -= movements[i];
                }
                else if (i % 4 == 3)
                {
                    finalPosition[0] -= movements[i];
                }
            }
            return finalPosition;
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

            return new int[] { numberOfHashes, numberOfPluses };
        }

        public int HowManyVowel(string finalString)
        {
            int vowelCount = finalString.ToLower().Count(letter => letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u');
            return vowelCount;
        }

        public int? NextMultipleOfB(int firstNumber, int secondNumber)
        {
            if (secondNumber != 0)
            {
                int count = (firstNumber >= secondNumber ? firstNumber : secondNumber);

                while (count % secondNumber != 0)
                {
                    count++;
                }

                return count;
            }

            return null;
        }
    }

}
