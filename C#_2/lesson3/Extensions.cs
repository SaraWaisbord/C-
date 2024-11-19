using lesson3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    public static class Extensions
    {
        public static bool IsCapitalized(this string s)
        {
            if (s[0]== '\n')
                return false;
            return char.IsUpper(s[0]);
        }

        public static double GetAverageGrade(this StudentAdd s)
        {
            return s.ScoreArry.Average();
        }
        public static bool IsPassing( this StudentAdd s)
        {
            return GetAverageGrade(s) > 60;
        }
    }
}
