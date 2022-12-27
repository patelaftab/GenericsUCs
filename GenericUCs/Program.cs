using GenericUCs;
using System;
using System.IO;

namespace GeneicUCs
{
    class Program
    {
        public static void Main(string[] args)
        {
            string firstvalue = "Peach";
            string secondvalue = "Apple";
            string thirdvalue = "Banana";

            MaximumNumber maximumNumber = new MaximumNumber();
            string result = maximumNumber.MaximumIntergerNumber(firstvalue,secondvalue,thirdvalue);
            Console.WriteLine(result);
        }
    }
}