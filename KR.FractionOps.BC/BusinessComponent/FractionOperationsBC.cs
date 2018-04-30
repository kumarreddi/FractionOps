using KR.FractionOps.BusinessLayer.BusinessEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.FractionOps.BusinessLayer.BusinessComponent
{
   public class FractionOperationsBC
    {
        /// <summary>
        /// This method takes two mixed numbers as input and returns a third mixed number, which is a summation of the first and second mixed numbers 
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public MixedNumber Add(MixedNumber m1, MixedNumber m2)
        {
            Fraction f1 = ConvertMixedNumberToFraction(m1);
            Fraction f2 = ConvertMixedNumberToFraction(m2);  

            Fraction sum = new Fraction();
            //if the fraction is negative, the result is multiplied by -1, so we can preserve the appropriate sign of the result
            sum.Numerator = (f1.IsNegative == true? -1: 1) * f1.Numerator * f2.Denominator + (f2.IsNegative == true ? -1 : 1) * f1.Denominator * f2.Numerator;
            sum.Denominator = f1.Denominator * f2.Denominator;

            if(sum.Numerator <0)
            {
                sum.IsNegative = true;
                sum.Numerator = -1 * sum.Numerator;
            }

            return ConvertFractionToMixedNumber(sum);
        }

        /// <summary>
        /// This method takes two mixed numbers as input and returns a third mixed number, which is a difference between first and second mixed numbers
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public MixedNumber Subtract(MixedNumber m1, MixedNumber m2)
        {

            Fraction f1 = ConvertMixedNumberToFraction(m1);
            Fraction f2 = ConvertMixedNumberToFraction(m2);

            Fraction diff = new Fraction();
            //if the fraction is negative, the result is multiplied by -1, so we can preserve the appropriate sign of the result
            diff.Numerator = (f1.IsNegative == true ? -1 : 1) * f1.Numerator * f2.Denominator - (f2.IsNegative == true ? -1 : 1) * f1.Denominator * f2.Numerator;
            diff.Denominator = f1.Denominator * f2.Denominator;

            if (diff.Numerator < 0)
            {
                diff.IsNegative = true;
                diff.Numerator = -1 * diff.Numerator;
            }

            return ConvertFractionToMixedNumber(diff);
        }

        /// <summary>
        /// This method takes two mixed numbers as input and returns a third mixed number, which is a product of the two input mixed numbers
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public MixedNumber Mulitply(MixedNumber m1, MixedNumber m2)
        {
            Fraction f1 = ConvertMixedNumberToFraction(m1);
            Fraction f2 = ConvertMixedNumberToFraction(m2);

            Fraction product = new Fraction();
            //if the fraction is negative, the result is multiplied by -1, so we can preserve the appropriate sign of the result
            product.Numerator = (f1.IsNegative == true ? -1 : 1) * f1.Numerator * (f2.IsNegative == true ? -1 : 1) * f2.Numerator;
            product.Denominator = f1.Denominator * f2.Denominator;

            //if the result numerator is negative, then the mixed number would be negative too
            if (product.Numerator < 0)
            {
                product.IsNegative = true;
                product.Numerator = -1 * product.Numerator;
            }

            return ConvertFractionToMixedNumber(product);
        }

        /// <summary>
        /// This method takes two mixed numbers and applies the divide operator and returs a new mixed number
        /// </summary>
        /// <param name="m1"> First Mixed Number</param>
        /// <param name="m2">Second Mixed Number</param>
        /// <returns>Returns a mixed number</returns>
        public MixedNumber Divide(MixedNumber m1, MixedNumber m2)
        {
            Fraction f1 = ConvertMixedNumberToFraction(m1);
            Fraction f2 = ConvertMixedNumberToFraction(m2);

            Fraction rem = new Fraction();
            rem.Numerator = f1.Numerator * f2.Denominator;
            rem.Denominator = f1.Denominator * f2.Numerator;

            //if one of the fractions were negative, the result would be negative too
            //But if both of the fractions are negative or positive, then the result would be positive
            if ((!f1.IsNegative && f2.IsNegative) || (f1.IsNegative && !f2.IsNegative))
                rem.IsNegative = true;
           
            return ConvertFractionToMixedNumber(rem);
        }

        MixedNumber ConvertFractionToMixedNumber(Fraction f)
        {
            int gcd = 1;
            int wholeNumber = 0;

            do
            {
                if (f.Numerator > f.Denominator)
                {
                    gcd = GetGCD(f.Numerator, f.Denominator);
                }
                else
                {
                    gcd = GetGCD(f.Denominator, f.Numerator);
                }

                f.Numerator = f.Numerator / gcd;
                f.Denominator = f.Denominator / gcd;
            } while (gcd != 1);

            if (f.Numerator > f.Denominator)
            {
                wholeNumber = f.Numerator / f.Denominator;
                f.Numerator = f.Numerator % f.Denominator;
            }


            MixedNumber m = new MixedNumber(wholeNumber, f.Numerator, f.Denominator, f.IsNegative);

            return m;
        }

        Fraction ConvertMixedNumberToFraction(MixedNumber m)
        {
            Fraction f = new Fraction();
            if (m.Integral != 0)
            {
                f.Numerator = m.Integral * m.Denominator + m.Numerator;
            }
            else
            {
                f.Numerator = m.Numerator;
            }

            f.Denominator = m.Denominator;
            f.IsNegative = m.IsNegative;

            return f;
        }

        /// <summary>
        /// This method finds the greatest common denominator
        /// The method is taken from this url, https://codereview.stackexchange.com/questions/69548/converting-fractions-to-mixed-numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private int GetGCD(int a, int b)
        {
            return b == 0 ? a : GetGCD(b, a % b);
        }

    }
}
