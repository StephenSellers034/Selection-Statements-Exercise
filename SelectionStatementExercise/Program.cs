namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int favNumber = 34;
            Console.WriteLine("Guess my favorite number between 1 and 1000:");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput >= 34)
            {
                Console.WriteLine("No, No, No your guess is to high");
            }
            else if (userInput == 34)
            {
                Console.WriteLine("Ding, Ding, Ding, You are Correct!!!");
            }
            else 
            {
                Console.WriteLine("Ah, Ah, Ah to low");
            }

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("What is your favorite school subject?");
            string favoriteSubject = Console.ReadLine();
            Console.WriteLine("--------------------------------------------");

            switch (favoriteSubject. ToLower())
            {
                case "math":
                    Console.WriteLine("Math is awesome, Lets count this money!!!");
                    break;
                case "biology":
                    Console.WriteLine("Biology is very intresting, I like being able to disect an animal and see how everything works.");
                    break;
                case "history":
                    Console.WriteLine("History sucks, most of what i learned was lies or contradictions.");
                    break;
                case "english":
                    Console.WriteLine("English is fun when your writing stories");
                    break;
                case "p.e":
                    Console.WriteLine("P.E is the best if you love to be active");
                    break;
                default:
                    Console.WriteLine("Great choice!");
                        break;
            }
        }
    }
}
