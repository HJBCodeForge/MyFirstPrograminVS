// See https://aka.ms/new-console-template for more information
//Console.Write("Hey!");
//Console.WriteLine("Hello!");

////This is a comment
///*This is a
// * Multi line comment
// */
//Console.WriteLine("\tDude"); //Example of escape sequence

//Console.ReadKey(); //Keeps the console window open

//1. CREATING VARIABLES, 2 steps: Declaration and Initialization

//Data types: int, double, char, string, bool
//int x; //Declaration
//x = 123; //Initialization, can only store whole integers

//int age = 21; //Declaration + Initialization
//double pi = 3.14; //Can store decimal numbers
//bool isCSharpFun = true; //Can only store true or false
//char grade = 'A'; //Can only store a single character, must use single quotes
//string name = "John Doe"; //Can store multiple characters, must use double quotes

//Console.WriteLine(name + " age " +age + " recieved a grade of " + grade);

//const double gravity = 9.81; //Constant variable, cannot be changed

//2. TYPE CASTING = converting a variable from one data type to another
//              useful when we accept user input (string)

//double a = 3.14;
//int b = Convert.ToInt32(a);

//String i = "true";
//bool j = Convert.ToBoolean(i);

//Console.WriteLine(b.GetType());
//Console.WriteLine(j.GetType());


//3. USER INPUT

//Console.WriteLine("What's your name?");
//String name = Console.ReadLine();

//Console.WriteLine("What is your age?");
//int age = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Hello " + name + " your age is " + age);


//4. MATH OPERATIONS

//int friends = 5;
//double familyRatio = 1.5;

//friends = friends + 2; //Addition
//friends += 2; //Shorthand addition
//friends++; //Increment by 1

//friends = friends - 1; //Subtraction
//friends -= 1; //Shorthand subtraction
//friends--; //Decrement by 1

//friends = friends * 2; //Multiplication
//friends *= 2; //Shorthand multiplication

//friends = friends / 2; //Division
//friends /= 2; //Shorthand division
//familyRatio = familyRatio / 2; //Will show decimal 

//friends = friends % 2; //Modulus (Remainder)

//Console.WriteLine(friends);

//5. MATH METHODS
//double x = 3.14;
//double y = 5;

//double a = Math.Pow(x, 2); //Exponentiation, (x = base, 2 to the power of)
//double b = Math.Sqrt(x); //Square root
//double c = Math.Abs(x); //Absolute value, how far from zero
//double d = Math.Round(x); //Rounds to nearest whole number
//double e = Math.Ceiling(x); //Rounds up to nearest whole number
//double f = Math.Floor(x); //Rounds down to nearest whole number
//double g = Math.Max(x, y); //Returns the larger of the two values
//double h = Math.Min(x, y); //Returns the smaller of the two values

//Console.WriteLine(h);

//6. Random Rumbers
//Random random = new Random();
//int num = random.Next(1, 7); //Returns a random integer, between 1 and 6
//double num = random.NextDouble(); //Returns a random decimal between 0.0 and 1.0

//Console.WriteLine(num);


//7. Hypotenuse Calculator
//Console.WriteLine("Enter side A: ");
//double a = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Enter side B: ");
//double b = Convert.ToDouble(Console.ReadLine());

//double c = Math.Sqrt((a * a) + (b * b));

//Console.WriteLine("The Hypotenuse of side C is: " + c);

//8. String Methods
//String fullName = "John Doe";
//String phoneNumber = "123-456-7890";

//fullName = fullName.ToUpper(); //Converts to uppercase
//fullName = fullName.ToLower(); //Converts to lowercase
//phoneNumber = phoneNumber.Replace("-", "/"); //Replaces characters
//String userName = fullName.Insert(0, "@"); //Inserts characters at index position
//Console.WriteLine(fullName.Length); //Returns length of string
//String firstName = fullName.Substring(0, 4); //Extracts part of a string    

//9. If Statements = a basic form of decision making
//Console.WriteLine("Please enter your age: ");
//int age = Convert.ToInt32(Console.ReadLine());

//if (age >= 18)
//{
//    Console.WriteLine("You are an adult.");
//}
//else if (age < 0)
//{
//    Console.WriteLine("You haven't been born yet!");
//}
//else
//{
//    Console.WriteLine("You are a minor.");
//}
//Console.WriteLine("Please enter your name: ");
//String name = Console.ReadLine();

//if (name == "")
//{
//    Console.WriteLine("You did not enter a name!");
//} else
//{
//    Console.WriteLine("Hello " + name);
//}

//10. SWITCH STATEMENTS = an alternative to many "else if" statements
//Console.WriteLine("What day is it today?");
//String day = Console.ReadLine().ToLower();

//switch (day) {
//    case "monday":
//        Console.WriteLine("It's Monday");
//        break;
//    case "tuesday":
//        Console.WriteLine("It's Tuesday");
//        break;
//    case "wednesday":
//        Console.WriteLine("It's Wednesday");
//        break;
//    case "thursday":
//        Console.WriteLine("It's Thursday");
//        break;
//    case "friday":
//        Console.WriteLine("It's Friday");
//        break;
//    case "saturday":
//    case "sunday":
//        Console.WriteLine("It's the weekend!");
//        break;
//    default:
//        Console.WriteLine("That is not a day!");
//        break;
//}

//11. LOGICAL OPERATORS = used to determine the logic between variables or values
// && (AND), || (OR), ! (NOT)

//Console.WriteLine("What's the temperature outside: (C)");
//double temp = Convert.ToDouble(Console.ReadLine());

//if (temp >= 10 && temp <= 25)
//{
//    Console.WriteLine("It's warm outside");
//}
//else if (temp <= -50 || temp >= 50)
//{
//    Console.WriteLine("Do not go outside!");
//} else
//{
//    Console.WriteLine("The temp is reasonable");
//}

//12. While Loops = repeat a block of code while a certain condition is true
//String name = "";

//while (name == "")
//{
//    Console.Write("Enter your name: ");
//    name = Console.ReadLine();
//};
//Console.WriteLine("Hello " + name);

//13. for loop = repeats some code a Finite amount of times
/*
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Count: " + i);
}
*/
/*for (int i = 10; i >= 0; i--)
{
    Console.WriteLine("New Years Count down: " + i);
}
Console.WriteLine("Happy New Year!");
*/


//14. Nested Loops = loops inside of other loops
//                  Uses vary. Used a lot in sorting algorithms
//Console.Write("How many rows? ");
//int rows = Convert.ToInt32(Console.ReadLine());
//Console.Write("How many columns? ");
//int columns = Convert.ToInt32(Console.ReadLine());
//Console.Write("What symbole or character? ");
//String sym = Console.ReadLine();

//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < columns; j++)
//    {
//        Console.Write(sym);
//    }
//    Console.WriteLine();
//}

//18. Number guessing game
//Random random = new Random();
//bool playAgain = true;
//int min = 1;
//int max = 100;
//int guess;
//int number;
//int guesses;
//String responce;

//while (playAgain)
//{
//    guess = 0;
//    guesses = 0;
//    responce = "";
//    number = random.Next(min, max + 1);

//    while (guess != number)
//    {
//        Console.WriteLine("Guess a number between" + min + " - " + max + "?");
//        guess = Convert.ToInt32(Console.ReadLine());
//        guesses++;

//        Console.WriteLine("Guess: " + guess);

//        if (guess > number)
//        {
//            Console.WriteLine("You guessed to much, go lower");
//        }
//        else if (guess < number)
//        {
//            Console.WriteLine("You guessed to small, go higher");
//        }
//        else
//        {
//            Console.WriteLine("That guess is correct! You guessed: " + guesses + " times.");
//        }
//    }
//    Console.WriteLine("Do you want to play again? (Y/N): ");
//    responce = Console.ReadLine().ToUpper();

//    if (responce == "Y")
//    {
//        playAgain = true;
//    }
//    else if (responce == "N")
//    {
//        playAgain = false;
//    }
//}
//Console.WriteLine("Thanks for playing... i guess");

//19.Rock Paper Scissors

//Random random = new Random();
//bool playagain = true;
//String player;
//String computor;

//while (playagain)
//{
//    player = "";
//    computor = "";

//    while (player != "ROCK" && player != "PAPER" && player != "SCISSORS") {
//        Console.Write("Choose Rock, Paper or Scissors: ");
//        player = Console.ReadLine().ToUpper();
//    }

//    switch (random.Next(1, 4))
//    {
//        case 1:
//            computor = "ROCK";
//            break;
//        case 2:
//        computor = "PAPER";
//            break;
//        case 3:
//        computor = "SCISSORS";
//            break;
//    }

//    Console.WriteLine("Your Choice is: " + player);
//    Console.WriteLine("The Computor chose: " + computor);

//    if ((player == "ROCK" && computor == "SCISSORS") || (player == "PAPER" && computor == "ROCK") || (player == "SCISSORS" && computor == "PAPER"))
//    {
//        Console.WriteLine("You Win!");
//    } else if((computor == "ROCK" && player == "SCISSORS") || (computor == "PAPER" && player == "ROCK") || (computor == "SCISSORS" && player == "PAPER"))
//    {
//        Console.WriteLine("You Lose!");
//    } else
//    {
//        Console.WriteLine("It is a tie!");
//    }

//    Console.WriteLine("Do you want to play again? (Y/N)");
//    String play = Console.ReadLine().ToLower();
//    if (play == "y")
//    {
//        playagain = true;
//    }
//    else
//    {
//        playagain = false;
//    }
//}

//Console.WriteLine("Thank for playing");

//19. Calculator Program

do {
    double num1 = 0;
    double num2 = 0;
    double result = 0;

    Console.WriteLine("------------------");
    Console.WriteLine("Calculator Program");
    Console.WriteLine("------------------");

    Console.Write("Enter number 1: ");
    num1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter number 2: ");
    num2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter an option: ");
    Console.WriteLine("\t+ : Add");
    Console.WriteLine("\t- : Minus");
    Console.WriteLine("\t* : Multiply");
    Console.WriteLine("\t/ : Divide");

    Console.Write("Enter an option: ");
    switch (Console.ReadLine())
    {
        case "+":
            result = num1 + num2;
            Console.WriteLine($"The Result is: {num1} + {num2} = " + result);
            break;

        case "-":
            result = num1 - num2;
            Console.WriteLine($"The Result is: {num1} - {num2} = " + result);
            break;
        case "*":
            result = num1 * num2;
            Console.WriteLine($"The Result is: {num1} * {num2} = " + result);
            break;
        case "/":
            result = num1 / num2;
            Console.WriteLine($"The Result is: {num1} / {num2} = " + result);
            break;
        default:
            Console.WriteLine("That was not a valid option.");
            break;
    }
    Console.WriteLine("Would you like to continue? (Y)es, (N)o");
} while (Console.ReadLine().ToUpper() == "Y");

Console.WriteLine("Bye");








Console.ReadKey();