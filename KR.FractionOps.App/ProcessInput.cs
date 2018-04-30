using KR.FractionOps.BusinessLayer.BusinessComponent;
using KR.FractionOps.BusinessLayer.BusinessEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.FractionOps.App
{
    public class ProcessInput
    {

        public string ReadAndProcessInput(string[] args)
        {

            string firstNumber = args[0];
            string strOperator = args[1];
            string secondNumber = args[2];
            
            MixedNumber m1 = ConvertArgumentToValidFraction(firstNumber);
            MixedNumber m2 = ConvertArgumentToValidFraction(secondNumber);
            return PerformArithmetic(m1, m2, strOperator);

        }

        /// <summary>
        /// This method takes two mixed numbers and an operator as input parameters and performs type of arithmetic as indicated by the operator
        /// </summary>
        /// <param name="m1"> First Mixed Number</param>
        /// <param name="m2"> Second Mixed Number</param>
        /// <param name="strOperator">Operator</param>

        string PerformArithmetic(MixedNumber m1, MixedNumber m2, string strOperator)
        {
            
            MixedNumber m3 = new MixedNumber();

            if (strOperator == "*")
            {
                FractionOperationsBC fractionOps = new FractionOperationsBC();
                m3 = fractionOps.Mulitply(m1, m2);
            }
            else if (strOperator == "+")
            {
                FractionOperationsBC fractionOps = new FractionOperationsBC();
                m3 = fractionOps.Add(m1, m2);
            }
            else if (strOperator == "-")
            {
                FractionOperationsBC fractionOps = new FractionOperationsBC();
                m3 = fractionOps.Subtract(m1, m2);
            }
            else if (strOperator == "/")
            {
                FractionOperationsBC fractionOps = new FractionOperationsBC();
                m3 = fractionOps.Divide(m1, m2);
            }
            else
            {
                throw new ArgumentException("Invalid Operator detected!. Only +,-,*,/ are allowed as operators");
            }

            return m3.ToString();

        }


        /// <summary>
        /// This method will convert valid input fractions (string) into a MixedNumber
        /// The example valid fractions would be 1_1/3, 3/5, 6, -4/5, -3_7/8, +4_7/9, -6, 8, 5_3
        /// The example invalid fractions would be _1/3, +_6/8,7/0,-+6/7, 7/, 3_4/ in addtion to any other non-numeric characters in the string
        /// If the fraction turned out to be invalid, an ArgumentException would be raised
        /// </summary>
        /// <param name="strInput"> Input fraction (string)</param>
        /// <returns></returns>

        MixedNumber ConvertArgumentToValidFraction(string strInput)
        {

            MixedNumber m = new MixedNumber();

            int startPos = 0;

            if (strInput[0] != '-' && strInput[0] != '+' && !Char.IsDigit(strInput[0]))
            {
                throw new ArgumentException("One of the input operand is invalid!");
            }

            if (strInput[0] == '-' || strInput[0] == '+')
            {
                m.IsNegative = strInput[0] == '-' ? true : false;
                startPos = 1;
            }

            try
            {
                int wholeSeparatorPos = strInput.IndexOf('_');

                if (wholeSeparatorPos > 0)
                {
                    m.Integral = Convert.ToInt32(strInput.Substring(startPos, wholeSeparatorPos-startPos));
                    startPos = wholeSeparatorPos + 1;
                }


                int divisionPos = strInput.IndexOf('/');
                if (divisionPos > 0)
                {
                    m.Numerator = Convert.ToInt32(strInput.Substring(startPos, divisionPos - startPos));
                    m.Denominator = Convert.ToInt32(strInput.Substring(divisionPos + 1, strInput.Length - divisionPos - 1));

                    if (m.Denominator == 0)
                    {
                        throw new ArgumentException("Invalid input.. One of the input parameter has 0 in the denominator");
                    }
                }
                else
                {
                    m.Numerator = Convert.ToInt32(strInput.Substring(startPos, strInput.Length - startPos ));
                    m.Denominator = 1;
                }

                return m;
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException("One of the input operand is not a valid fraction/number", ex);
            }


        }
    }
}
