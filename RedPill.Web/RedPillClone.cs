using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedPill.Web
{
        public static class RedPillClone
    {
        public static long FibonacciNumber(long number)
        {
            long current = 0;
            long next = 1;
            for (int i = 0; i < number; i++)
            {
                long temp = next;
                next += current;
                current = temp;
            }
            return current;
        }

        public static string ReverseWords(string words)
        {
            return words.Select(c => c.ToString()).Reverse().Aggregate((s1, s2) => s1 + s2);
        }

        public static Guid WhatIsYourToken()
        {
            return new Guid("a4b0d6fa-1545-4a05-b69c-37fee2b9cbc4");
        }

        public static TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            if ((a + b < c) || a + c < b || b + c < a) return TriangleType.Error;
            else if (a == b && a == c) return TriangleType.Equilateral;
            else if ((a == b && a != c) || (a == c && a != b) || (b == c && b != a)) return TriangleType.Isosceles;
            else if (a != b && b != c && c != a) return TriangleType.Scalene;
            else return TriangleType.Error;
        }
    }

}
