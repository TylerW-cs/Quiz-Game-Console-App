using System.Diagnostics.Contracts;

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
Console.WriteLine($"\nHello {playerName}, you can type 'skip' to pass a question or 'quit' to stop early.");

do
{
    int score = 0;

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

    int percentageScore = score * 100 / 5;
    string grade = score switch
    {
        5 => "A+",
        4 => "A",
        3 => "B",
        _ => "C"
    };
    string passFail = score >= 3 ? "Pass" : "Fail";
    Console.WriteLine($"\nYour final score is {score}/5\nYou got {percentageScore}% correct.\nThis gives you a grade of {grade}, which means you {passFail}!");
    
    Console.WriteLine("\nPlay again? (y/n)");
    playAgain = Console.ReadLine();
    if (playAgain == "n")
    {
        Console.WriteLine($"\nGoodbye {playerName}!");
    }
    else
    {
        continue;
    }
} while (playAgain == "y");