using System.ComponentModel.Design;

namespace endrimApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("zehmet olmasa alish-verish meblegini daxil edin");
            double mebleg = Convert.ToDouble(Console.ReadLine());
            double endrimlimebleg;
            if (mebleg < 100)
            {
                Console.WriteLine("tebrikler siz 5% endrim elde etdiniz");
                endrimlimebleg = mebleg - mebleg * 5 / 100;
                Console.WriteLine("endrimden sonra odemeli oldugunuz mebleg:" + endrimlimebleg);
            }
            else if (mebleg > 100 && mebleg < 1000)
            {
                Console.WriteLine("TEBRIKLER siz 8% endrim elde etdiniz");
                endrimlimebleg = mebleg - mebleg * 8 / 100;
                Console.WriteLine("endrimden sonra odemeli oldugunuz mebleg :" + endrimlimebleg);
            }
            else
            {
                Console.WriteLine("TEBRIKLER SIZ 10% ENDRIM QAZANDINIZ");
                endrimlimebleg = mebleg - mebleg * 10 / 100;
                Console.WriteLine("endrimden sonra odemeli oldugunuz mebleg:" + endrimlimebleg);
            }



        }
    }
}