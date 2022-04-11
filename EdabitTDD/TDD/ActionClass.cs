namespace TDD
{
    internal class ActionClass
    {
        public static int MinutesToSeconds(int minutesValue)
        {
            return minutesValue * 60;
        }

        internal static bool LessThan100(int firstNumber, int secondNumber)
        {
            return (firstNumber + secondNumber < 100);
        }

        internal static bool FlipTheBoolean(bool myBool)
        {
            return !myBool;
        }

        internal static string ReturnSomethingToMe(string inputValue)
        {
            return $"something {inputValue}";
        }

        internal static int AgeToDaysIn365EachYear(int inputAgeValue)
        {
            return inputAgeValue * 365;
        }

        public static int? SumPolygon(int num)
        {
            if (num < 3)
                return null;
            else
                return (num - 2) * 180;
        }

        public static int[] MultiplyByLength(int[] arr)
        {
            int[] result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = arr[i] * arr.Length;
            }
            return result;
        }
    }
}