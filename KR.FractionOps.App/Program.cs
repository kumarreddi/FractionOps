using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using KR.FractionOps.BusinessLayer.BusinessEntity;
using KR.FractionOps.BusinessLayer.BusinessComponent;

namespace KR.FractionOps.App
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args == null || args.Length < 3 || args.Length > 3)
            {
                Console.WriteLine("Unexpected Arguments. Program is quitting..");
                Environment.Exit(1);
            }

            try
            {
                ProcessInput pi = new ProcessInput();
                Console.WriteLine(pi.ReadAndProcessInput(args));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Exception has occurred and Program is quitting.. See the message below for details. \n");
                Console.WriteLine("**" + ex.Message + "**\n");
            }
        }
        
    }
}


