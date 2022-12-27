using GenericUCs;

namespace GeneicUCs
{
    class Program
    {
        public static void Main(string[] args)
        {
            double firstvalue = 40.3;
            double secondvalue =20.10;
            double thirdvalue = 30.20;

            MaximumNumber maximumNumber = new MaximumNumber();
            double result = maximumNumber.MaximumIntergerNumber(firstvalue,secondvalue,thirdvalue);
            Console.WriteLine(result);
        }
    }
}