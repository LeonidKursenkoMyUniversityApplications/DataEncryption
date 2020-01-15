using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gr
{
    public class GMath
    {
        private static int maxVal = 300;

        public static int MaxVal { get => maxVal; set => maxVal = value; }

        public static List<int> SimpleNumbers()
        {
            var sNumbers = new List<int>();
            
            for (int i = 1; i < MaxVal; i++)
            {
                bool isSimple = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isSimple = false;
                        break;
                    }
                }
                if(isSimple == true) sNumbers.Add(i);
            }
            return sNumbers;
        }

        public static int RandomNumber(List<int> numbers)
        {
            Random rnd = new Random();
            int i = rnd.Next(0, numbers.Count);
            return numbers[i];
        }

        public static int RandomNearNumber(List<int> numbers, int number)
        {
            int range = MaxVal / 10;
            Random rnd = new Random();
            int index = numbers.IndexOf(number);
            int min = index - range;
            min = (min > 0) ? min : 0;
            int max = index + range;
            max = (max < numbers.Count) ? max : numbers.Count;
            int i = rnd.Next(min, max);
            return numbers[i];
        }

        // without 1
        public static List<int> GetDivisors(int number)
        {
            var divisors = new List<int>();
            for (int i = 2; i <= number; i++)
            {
                if(number % i == 0) divisors.Add(i);
            }
            return divisors;
        }
    }
}
