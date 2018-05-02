using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.FractionOps.BusinessLayer.BusinessEntity
{
    /// <summary>
    /// This class represents a fraction number as a mixed number with whole and fraction part
    /// A Fraction can also have positive or negative sign
    /// </summary>
    public class MixedNumber
    {
        public int Integral { get; set; }
        public int Numerator { get; set; }
        public int Denominator { get; set; }
        public bool IsNegative { get; set; } = false;

        public MixedNumber()
        { }

        public MixedNumber(int integral, int numerator, int denominator, bool isNegative)
        {
            this.Integral = integral;
            this.Numerator = numerator;
            this.Denominator = denominator;
            this.IsNegative = isNegative;
        }

        /// <summary>
        /// This method overrides the ToString method, so the mixed number can be displayed in a user friendly manner
        /// The idea for this method came from this url: https://codereview.stackexchange.com/questions/69548/converting-fractions-to-mixed-numbers
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (this.Numerator == 0)
            {
                return string.Format("{0}{1}", this.IsNegative == true ? "-" : "", this.Integral);
            }
            else if (Integral == 0)
            {
                return string.Format("{0}{1}/{2}", this.IsNegative == true?"-":"", this.Numerator, this.Denominator);
            }
            else {
                return string.Format("{0}{1}_{2}/{3}", this.IsNegative == true ? "-" : "", this.Integral, this.Numerator, this.Denominator);
            }
        }
    }
}
