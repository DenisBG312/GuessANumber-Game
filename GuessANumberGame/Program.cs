namespace GuessANumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int computerNumber = randomNumber.Next(1, 101);
            int unsuccsessfulTries = 0;
            while(computerNumber > 0)
            {
                Console.Write("Guess a number (1-100): ");
                string playerNum = Console.ReadLine();
                bool isValid = int.TryParse(playerNum, out int playerNumber);
                if (isValid )
                {
                    if (playerNumber == computerNumber)
                    {
                        Console.WriteLine("Congratulations! You guessed it!");
                        Console.WriteLine($"Total unsuccessful tries: {unsuccsessfulTries}");
                        break;
                    }
                    else if (playerNumber > computerNumber)
                    {
                        Console.WriteLine("Too High");
                        unsuccsessfulTries++;
                        Console.WriteLine($"Unsuccessful tries: {unsuccsessfulTries}");
                    }
                    else
                    {
                        Console.WriteLine("Too Low");
                        unsuccsessfulTries++;
                        Console.WriteLine($"Unsuccessful tries: {unsuccsessfulTries}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
        }
    }
}