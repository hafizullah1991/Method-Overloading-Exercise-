using System.Runtime.CompilerServices;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            int sum = Add(5 , 5);
            Console.WriteLine(sum);

            Console.WriteLine(Add(4.2, 4.1));

            Console.WriteLine(Add(3, 2 ,true));
        }
        public static int Add(int x , int y)
        {
            return x + y;
        }

        public static double Add(double x , double y)
        {
            return x + y;
        }
        public static string Add(int x, int y, bool Plus)

        {

            int sum= x+ y;
           
            if (Plus)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }
        }
    }
}
