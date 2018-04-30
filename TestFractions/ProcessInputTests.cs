using Microsoft.VisualStudio.TestTools.UnitTesting;
using KR.FractionOps.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.FractionOps.App.Tests
{
    [TestClass()]
    public class ProcessInputTests
    {
        [TestMethod()]
        public void ReadAndProcessInputTest_Subtract_Full_Fraction_With_WholeNumber_Part()
        {
            ProcessInput pi = new ProcessInput();
                        
            Assert.AreEqual("-14_233/405",  pi.ReadAndProcessInput(new[] { "11_31/15", "-", "27_52/81" }));
        }

        [TestMethod()]
        public void ReadAndProcessInputTest_Subtract_Fraction_Without_WholeNumber_Part()
        {
            ProcessInput pi = new ProcessInput();

            Assert.AreEqual("-1/40", pi.ReadAndProcessInput(new[] { "3/5", "-", "5/8" }));
        }

        [TestMethod()]
        public void ReadAndProcessInputTest_Subtract_Fraction_Just_WholeNumber_Part()
        {
            ProcessInput pi = new ProcessInput();

            Assert.AreEqual("-3", pi.ReadAndProcessInput(new[] { "5", "-", "8" }));
        }

        [TestMethod()]
        public void ReadAndProcessInputTest_Subtract_Two_Negative_Full_Fraction_With_WholeNumber_Part()
        {
            ProcessInput pi = new ProcessInput();

            Assert.AreEqual("6_1/40", pi.ReadAndProcessInput(new[] { "-1_3/5", "-", "-7_5/8" }));
        }

        [TestMethod()]
        public void ReadAndProcessInputTest_Subtract_Two_Negative_Fraction_Without_WholeNumber_Part()
        {
            ProcessInput pi = new ProcessInput();

            Assert.AreEqual("1/40", pi.ReadAndProcessInput(new[] { "-3/5", "-", "-5/8" }));
        }

        [TestMethod()]
        public void ReadAndProcessInputTest_Subtract_Two_Negative_Just_WholeNumber_Part()
        {
            ProcessInput pi = new ProcessInput();

            Assert.AreEqual("3", pi.ReadAndProcessInput(new[] { "-5", "-", "-8" }));
        }

        [TestMethod()]
        public void ReadAndProcessInputTest_Add_Full_Fraction_With_WholeNumber_Part()
        {
            ProcessInput pi = new ProcessInput();

            Assert.AreEqual("40_287/405", pi.ReadAndProcessInput(new[] { "11_31/15", "+", "27_52/81" }));
        }

        [TestMethod()]
        public void ReadAndProcessInputTest_Add_Fraction_Without_WholeNumber_Part()
        {
            ProcessInput pi = new ProcessInput();

            Assert.AreEqual("1_9/40", pi.ReadAndProcessInput(new[] { "3/5", "+", "5/8" }));
        }

        [TestMethod()]
        public void ReadAndProcessInputTest_Add_Fraction_Just_WholeNumber_Part()
        {
            ProcessInput pi = new ProcessInput();

            Assert.AreEqual("13", pi.ReadAndProcessInput(new[] { "5", "+", "8" }));
        }

        [TestMethod()]
        public void ReadAndProcessInputTest_Add_Two_Negative_Full_Fraction_With_WholeNumber_Part()
        {
            ProcessInput pi = new ProcessInput();

            Assert.AreEqual("-9_9/40", pi.ReadAndProcessInput(new[] { "-1_3/5", "+", "-7_5/8" }));
        }

        [TestMethod()]
        public void ReadAndProcessInputTest_Add_Two_Negative_Fraction_Without_WholeNumber_Part()
        {
            ProcessInput pi = new ProcessInput();

            Assert.AreEqual("-1_9/40", pi.ReadAndProcessInput(new[] { "-3/5", "+", "-5/8" }));
        }

        [TestMethod()]
        public void ReadAndProcessInputTest_Add_Two_Negative_Just_WholeNumber_Part()
        {
            ProcessInput pi = new ProcessInput();

            Assert.AreEqual("-13", pi.ReadAndProcessInput(new[] { "-5", "+", "-8" }));
        }

        [TestMethod()]
        public void ReadAndProcessInputTest_multiply_Full_Fraction_With_WholeNumber_Part()
        {
            ProcessInput pi = new ProcessInput();

            Assert.AreEqual("361_229/1215", pi.ReadAndProcessInput(new[] { "11_31/15", "*", "27_52/81" }));
        }

        [TestMethod()]
        public void ReadAndProcessInputTest_multiply_Fraction_Without_WholeNumber_Part()
        {
            ProcessInput pi = new ProcessInput();

            Assert.AreEqual("3/8", pi.ReadAndProcessInput(new[] { "3/5", "*", "5/8" }));
        }

        [TestMethod()]
        public void ReadAndProcessInputTest_multiply_Fraction_Just_WholeNumber_Part()
        {
            ProcessInput pi = new ProcessInput();

            Assert.AreEqual("-40", pi.ReadAndProcessInput(new[] { "5", "*", "-8" }));
        }

        [TestMethod()]
        public void ReadAndProcessInputTest_multiply_Two_Negative_Full_Fraction_With_WholeNumber_Part()
        {
            ProcessInput pi = new ProcessInput();

            Assert.AreEqual("12_1/5", pi.ReadAndProcessInput(new[] { "-1_3/5", "*", "-7_5/8" }));
        }

        [TestMethod()]
        public void ReadAndProcessInputTest_multiply_Two_Negative_Fraction_Without_WholeNumber_Part()
        {
            ProcessInput pi = new ProcessInput();

            Assert.AreEqual("3/8", pi.ReadAndProcessInput(new[] { "-3/5", "*", "-5/8" }));
        }

        [TestMethod()]
        public void ReadAndProcessInputTest_multiply_Two_Negative_Just_WholeNumber_Part()
        {
            ProcessInput pi = new ProcessInput();

            Assert.AreEqual("40", pi.ReadAndProcessInput(new[] { "-5", "*", "-8" }));
        }

        [TestMethod()]
        public void ReadAndProcessInputTest_divide_Full_Fraction_With_WholeNumber_Part()
        {
            ProcessInput pi = new ProcessInput();

            Assert.AreEqual("5292/11195", pi.ReadAndProcessInput(new[] { "11_31/15", "/", "27_52/81" }));
        }

        [TestMethod()]
        public void ReadAndProcessInputTest_divide_Fraction_Without_WholeNumber_Part()
        {
            ProcessInput pi = new ProcessInput();

            Assert.AreEqual("24/25", pi.ReadAndProcessInput(new[] { "3/5", "/", "5/8" }));
        }

        [TestMethod()]
        public void ReadAndProcessInputTest_divide_Fraction_Just_WholeNumber_Part()
        {
            ProcessInput pi = new ProcessInput();

            Assert.AreEqual("-5/8", pi.ReadAndProcessInput(new[] { "5", "/", "-8" }));
        }

        [TestMethod()]
        public void ReadAndProcessInputTest_divide_Two_Negative_Full_Fraction_With_WholeNumber_Part()
        {
            ProcessInput pi = new ProcessInput();

            Assert.AreEqual("64/305", pi.ReadAndProcessInput(new[] { "-1_3/5", "/", "-7_5/8" }));
        }

        [TestMethod()]
        public void ReadAndProcessInputTest_divide_Two_Negative_Fraction_Without_WholeNumber_Part()
        {
            ProcessInput pi = new ProcessInput();

            Assert.AreEqual("24/25", pi.ReadAndProcessInput(new[] { "-3/5", "/", "-5/8" }));
        }

        [TestMethod()]
        public void ReadAndProcessInputTest_divide_Two_Negative_Just_WholeNumber_Part()
        {
            ProcessInput pi = new ProcessInput();

            Assert.AreEqual("5/8", pi.ReadAndProcessInput(new[] { "-5", "/", "-8" }));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ReadAndProcessInputTest_InvalidOperator()
        {
            ProcessInput pi = new ProcessInput();
            var result = pi.ReadAndProcessInput(new[] { "5/2", "&", "7" });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ReadAndProcessInputTest_InvalidArguments()
        {
            ProcessInput pi = new ProcessInput();
            var result = pi.ReadAndProcessInput(new[] { "&4_5/2", "*", "7" ,"fhg"});
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ReadAndProcessInputTest_InvalidOperands()
        {
            ProcessInput pi = new ProcessInput();
            var result = pi.ReadAndProcessInput(new[] { "&4_5/2", "*", "7/" });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ReadAndProcessInputTest_InvalidOperand_InvalidSign()
        {
            ProcessInput pi = new ProcessInput();
            var result = pi.ReadAndProcessInput(new[] { "&4_5/2", "*", "7" });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ReadAndProcessInputTest_InvalidOperand_ZeroDenominator()
        {
            ProcessInput pi = new ProcessInput();
            var result = pi.ReadAndProcessInput(new[] { "4_5/2", "*", "7/0" });
        }
    }
}