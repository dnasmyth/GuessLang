using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAlpha
{
   public class Letter
    {

        double frequency;
        int count;
        char alphaChar;

        public Letter(char w, double f)
        {
            AlphaChar = w;
            frequency = f;
            count = default;
        }

        public Letter()
        {
            Count = 0;
        }

        public char AlphaChar
        {
            get { return alphaChar; }
            set
            {
                alphaChar = value;
            }
        }


        public int Count
        {
            get { return count; }
            set
            {
                count = value;
            }
        }

        
        public double Frequency
        {
            get { return frequency; }
            set
            {
                frequency = value;
            }
        }

        public override string ToString()
        {
            return $"{AlphaChar} occurred {Count} time and {Frequency.ToString("0.00")} percent";
        }

    }
}
