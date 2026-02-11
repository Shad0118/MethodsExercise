namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            StoryTeller();
            
        }

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
            
            Console.WriteLine($"{name} sits at {rest} dressed in {color}, relaxed and composed.\n{music}plays through headphones while a warm meal is enjoyed.Music, style, and flavor come together in a perfectly balanced moment.");
            
        }
    }
}
