namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Addition(8, 7));//15
            Console.WriteLine(Subtraction(100,45));// 55
            Console.WriteLine(Multiplication(5,8));// 40
            Console.WriteLine(Division(8, 2));    // 4
        }

        public static int Addition(int a, int b)
        {
            return a + b;
        }

        public static int Subtraction(int a, int b)
        {
            return a - b;
        }

        public static int Multiplication(int a, int b)
        {
            return a * b;
        }

        public static double Division(double a, double b)
        {
            return a / b;
        }
    }
}
