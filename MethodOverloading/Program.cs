using System.Runtime.CompilerServices;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            int sum = Add(5, 5);
            Console.WriteLine(sum);

            Console.WriteLine(Add(4.2, 4.1));

            Console.WriteLine("enter true or false: ");
            bool userTrueFalse = bool.Parse(Console.ReadLine());
            Console.WriteLine(Add(3, 7, userTrueFalse));
;  

           

        }
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static double Add(double x, double y)
        {
            return x + y;
        }
        public static string Add(int x, int y, bool isDollar)

        {
            int sum= x + y;
            if(isDollar)
            {
                if(sum<10)
                {
                    return  $"{sum} dollar";
                }
                else
                {
                    return $"{sum} dollars";
                }
                
            }
            else
            {
                return sum.ToString();
            }
        }
    }
}