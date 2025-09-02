List<string> gameHistory = new List<string>();
Console.WriteLine("What math operation do you want to practice? Input the corresponding number.");
bool key = true;
do
{
    Console.WriteLine("1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n5. View previous games\n6. Exit menu");
    string? gameType = Console.ReadLine();

    switch (int.Parse(gameType!))
    {
        case 1:
            Console.WriteLine("Let's do addition!");
            playAddition();
            Console.WriteLine("Thanks for playing!");
            break;
        case 2:
            Console.WriteLine("Let's do subtraction!");
            break;
        case 3:
            Console.WriteLine("Let's do multiplication!");
            break;
        case 4:
            Console.WriteLine("Let's do division!");
            break;
        case 5:
            for (int i = 0; i < gameHistory.Count; i++)
            {
                Console.WriteLine($"Game number {i + 1}: {gameHistory[i]}");
            }
            break;
        case 6:
            key = false;
            break;
        default:
            Console.WriteLine("Please enter a valid input.");
            break;
    }
} while (key == true);

// Addition Method
void playAddition()
{
    Random random = new Random();
    Console.WriteLine("You have 5 questions to answer?");
    int correctAnswers = 0;
    int questionNumber = 0;

    for (int i = 0; i < 5; i++)
    {

        int firstNumber = random.Next(1000);
        int secondNumber = random.Next(1000);
        int sum = firstNumber + secondNumber;
        int userAnswer = 0;
        correctAnswers = 0;
        questionNumber = i + 1;

        Console.WriteLine($"Question #{questionNumber}\n");
        Console.WriteLine($"What is the sum of {firstNumber} and {secondNumber}?");

        key = false;
        do
        {
            try
            {
                userAnswer = int.Parse(Console.ReadLine()!);
                key = true;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Please enter a valid input.");
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Please enter a number.");
            }
        } while (key == false);

        if (userAnswer == sum)
        {
            Console.WriteLine("Yes! That's correct");
            correctAnswers++;
        }

        else
        {
            Console.WriteLine($"That was incorrect. The correct answer was {sum}");
        }

        if (i == 4)
            Console.WriteLine($"\nFinal score: {correctAnswers}/{questionNumber}");


    }

    string gameRecord = $"Addition game: {correctAnswers}/{questionNumber}";
    gameHistory.Add(gameRecord);
}
// next is the division/ multiplication and subtraction modes; just copy past the addition method and make changessss