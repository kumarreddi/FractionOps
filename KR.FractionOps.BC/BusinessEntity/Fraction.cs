using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.FractionOps.BusinessLayer.BusinessEntity
{
    /// <summary>
    /// This Class represents a fraction number as numerator and denominator
    /// This structure simplies the arithmetic calculations
    /// </summary>
    class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }
        public bool IsNegative { get; set; } = false;
    }
}
