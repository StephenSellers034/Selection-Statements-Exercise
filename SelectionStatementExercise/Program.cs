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


        }
    }
}
