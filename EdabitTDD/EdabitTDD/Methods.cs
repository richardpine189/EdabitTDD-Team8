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
    }

}
