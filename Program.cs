string[] questions = 
{ 
    "What keyword declares a whole number?", 
    "What symbol is the modulo operator?",
    "What is the name of a container that groups related code together?",
    "What is the logical NOT operator that flips a boolean value?",
    "What is 10 + 2?"
};

string[] answers =
{
    "int",
    "%",
    "class",
    "!",
    "12"
};

string? playAgain;

Console.WriteLine("What is your name?");

string? playerName = Console.ReadLine();
do
{
    int score = 0;
    Console.WriteLine($"\nHello {playerName}, you can type 'skip' to pass a question or 'quit' to stop early.");

    for (int i = 0; i < questions.Length; i++)
    {
        Console.WriteLine($"\nQuestion {i + 1}: {questions[i]}");
        string? answer = Console.ReadLine();

        if (answer == answers[i])
        {
            score++;
            Console.WriteLine("\nCorrect!");
        }
        else if (answer == "skip")
        {
            continue;
        }
        else if (answer == "quit")
        {
            break;
        }
        else
        {
            Console.WriteLine($"\nIncorrect! The answer was {answers[i]}.");
        }
    }

    int percentageScore = score * 100 / questions.Length;
    string grade = score switch
    {
        5 => "A+",
        4 => "A",
        3 => "B",
        _ => "C"
    };
    string passFail = score >= 3 ? "Pass" : "Fail";
    Console.WriteLine($"\nYour final score is {score}/{questions.Length}");
    Console.WriteLine($"\nYou got {percentageScore}% correct.");
    Console.WriteLine($"\nThis gives you a grade of {grade}, which means you {passFail}!");
    
    Console.WriteLine("\nPlay again? (y/n)");
    playAgain = Console.ReadLine();
} while (playAgain == "y");

Console.WriteLine($"\nGoodbye {playerName}!");