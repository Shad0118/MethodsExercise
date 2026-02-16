namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise - 1
            StoryTeller();
            
            //Exercise - 2
            Console.WriteLine($"\nSum of two numbers =  {Addition(8, 7)}");//15
            Console.WriteLine($"Subtraction of two numbers = {Subtraction(100,45)}");// 55
            Console.WriteLine($"Multiplication of two numbers = {Multiplication(5,8)}");// 40
            Console.WriteLine($"Division of two numbers = {Division(8, 2)}");    // 4
        }
        //Exercise - 1 method
        public static void StoryTeller()
                {
            
                    Console.WriteLine("What is your name ?");
                    string name = Console.ReadLine();
                    
                    Console.WriteLine("What is your favourite color ?");
                    string color = Console.ReadLine();
                    
                    Console.WriteLine("Name one favourite music band or artist of yours ");
                    string music = Console.ReadLine();
                    
                    Console.WriteLine("What is your favourite restaurant ?");
                    string rest = Console.ReadLine();
                    
                    Console.WriteLine($"{name} sits at {rest} dressed in {color}, relaxed and composed.\n{music} plays through headphones while a warm meal is enjoyed.Music, style, and flavor come together in a perfectly balanced moment.");
                    
                }
        //Exercise - 2 method
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

