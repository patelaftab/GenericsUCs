using GenericUCs;

namespace GeneicUCs
{
    class Program
    {
        public static void Main(string[] args)
        {
            int firstvalue = 40;
            int secondvalue =20;
            int thirdvalue = 30;

            MaximumNumber maximumNumber = new MaximumNumber();
            int result = maximumNumber.MaximumIntergerNumber(firstvalue,secondvalue,thirdvalue);
            Console.WriteLine(result);
        }
    }
}