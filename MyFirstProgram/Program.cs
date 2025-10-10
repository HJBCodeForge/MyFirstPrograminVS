using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace MyFirstProgram
{
    //class Program
    //{

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

    //do {
    //    double num1 = 0;
    //    double num2 = 0;
    //    double result = 0;

    //    Console.WriteLine("------------------");
    //    Console.WriteLine("Calculator Program");
    //    Console.WriteLine("------------------");

    //    Console.Write("Enter number 1: ");
    //    num1 = Convert.ToDouble(Console.ReadLine());

    //    Console.Write("Enter number 2: ");
    //    num2 = Convert.ToDouble(Console.ReadLine());

    //    Console.WriteLine("Enter an option: ");
    //    Console.WriteLine("\t+ : Add");
    //    Console.WriteLine("\t- : Minus");
    //    Console.WriteLine("\t* : Multiply");
    //    Console.WriteLine("\t/ : Divide");

    //    Console.Write("Enter an option: ");
    //    switch (Console.ReadLine())
    //    {
    //        case "+":
    //            result = num1 + num2;
    //            Console.WriteLine($"The Result is: {num1} + {num2} = " + result);
    //            break;

    //        case "-":
    //            result = num1 - num2;
    //            Console.WriteLine($"The Result is: {num1} - {num2} = " + result);
    //            break;
    //        case "*":
    //            result = num1 * num2;
    //            Console.WriteLine($"The Result is: {num1} * {num2} = " + result);
    //            break;
    //        case "/":
    //            result = num1 / num2;
    //            Console.WriteLine($"The Result is: {num1} / {num2} = " + result);
    //            break;
    //        default:
    //            Console.WriteLine("That was not a valid option.");
    //            break;
    //    }
    //    Console.WriteLine("Would you like to continue? (Y)es, (N)o");
    //} while (Console.ReadLine().ToUpper() == "Y");

    //Console.WriteLine("Bye");

    //20. Arrays = a variable that can store multiple value. fixed size.
    //String[] cars2 = new String[3]; //Declare an array, specify size with [ ]
    //String[] cars = { "BMW", "Mustang", "Corvette" }; //Add [ ] and { }, make it an array.

    //cars[0] = "Tesla"; //You can change array items by accessing them with their index.
    //Console.WriteLine(cars[0]); //to access array item, add [] and index.

    //for(int i=0; i < cars.Length; i++) //.Length = property that returns the length of the array
    //{
    //    Console.WriteLine(cars[i]); //Prints all array items
    //}

    ////21. FOREACH LOOP = easy way to iterate through an array
    //String[] fruits = { "Apple", "Banana", "Orange" };
    //foreach (String fruit in fruits) //for each item in array, do something with it
    //{
    //    Console.WriteLine(fruit);
    //}

    //22. METHODS = a block of code that performs a certain task
    //          benefit: Let's us reuse code witout writing it multiple times
    //String name = "John";
    //int age = 21;

    //signHappyBirthday(name, age); //Call the method, pass argument (name)

    //static void signHappyBirthday(String name, int age) //Method declaration, specify parameter (name)
    //{ 
    //    Console.WriteLine("Happy Birthday to you");
    //    Console.WriteLine("Happy Birthday to you");
    //    Console.WriteLine("Happy Birthday dear " + name);
    //    Console.WriteLine("Happy Birthday to you");
    //    Console.WriteLine("You are " + age + " years old!");
    //}

    //23. Return = used to return a value back to the place where the method was called

    //double x;
    //double y;
    //double result;

    //Console.WriteLine("Enter number 1: ");
    //x = Convert.ToDouble(Console.ReadLine());

    //Console.WriteLine("Enter number 2: ");
    //y = Convert.ToDouble(Console.ReadLine());

    //result = Multiply(x, y); //Call the method and store the return value in result
    //Console.WriteLine("The result is: " + result);
    //static double Multiply(double x, double y) //Specify return type instead of void
    //{
    //    return x * y;
    //}

    //24. method overloading = multiple methods with the same name but different parameters
    //                         name + parameters = signature
    //                         methods must have unique signatures
    //internal class Program
    //{
    //    private static void Main(string[] args)
    //    {
    //        double total;
    //        total = Multiply(2, 3, 4); //Calls first Add method

    //        Console.WriteLine(total);
    //        Console.ReadKey();

    //    }
    //    static double Multiply(double x, double y) //First Add method
    //    {
    //        return x * y;
    //    }
    //    static double Multiply(double x, double y, double z) //Second Add method
    //    {
    //        return x * y * z;
    //    }
    //}

    //25. Params keyword = allows us to pass a variable number of arguments to a method
    //                     The parameter type must be a single dimensional array
    //static void Main(string[] args)
    //{
    //    double total = CheckOut(3.99, 5.75, 15);

    //    Console.WriteLine(total);
    //    Console.ReadKey();
    //}
    //static double CheckOut(params double[] prices)
    //{
    //    double total = 0;
    //    foreach (double price in prices)
    //    {
    //        total += price;
    //    }
    //    return total;
    //}

    //26. Exceptions = errors that occur during runtime
    //              try = try some code that is considered "dangerous"
    //              catch = catches the error and handles it
    //              finally = executes code after try/catch regardless of result

    //static void Main(string[] args)
    //{
    //    double x;
    //    double y;
    //    double result;

    //    try
    //    {
    //        Console.WriteLine("Enter number 1: ");
    //        x = Convert.ToDouble(Console.ReadLine());

    //        Console.WriteLine("Enter number 2: ");
    //        y = Convert.ToDouble(Console.ReadLine());

    //        result = x / y;
    //        Console.WriteLine("result: " + result);
    //    } catch (FormatException e){
    //        Console.WriteLine("Enter only numbers please!");
    //    } catch (Exception e)
    //    {
    //        Console.WriteLine("Something went wrong!");
    //    } finally
    //    {
    //        Console.WriteLine("Thanks for visiting");
    //    }
    //    Console.ReadKey();
    //}

    //27. conditional (ternary) operator = a shorthand way of writing an if-else statement
    //                                     used in conditional assignments of a condition is true or false
    //                                     variable = (condition) ? value if true : value if false;

    //static void Main(string[] args)
    //{
    //    Console.WriteLine("What's your age?");
    //    int age = Convert.ToInt32(Console.ReadLine());
    //    String canDrive = (age >= 16) ? "You can drive" : "You cannot drive";
    //    Console.WriteLine(canDrive);

    //    Console.ReadKey();

    //}

    //28. string interpolation = allows us to insert variables into a string literal
    //                            place $ before string literal, use { } to insert variable

    //static void Main(string[] args)
    //{
    //    String firstName = "Bro";
    //    String lastName = "Code";
    //    int age = 21;

    //    Console.WriteLine($"Hello {firstName} {lastName}, you are {age, 5} years old!"); 
    //    // add a comma and number {age, 5} to add spaces, negative for spaces after.

    //    Console.ReadKey();

    //29. multidimensional arrays = an array of arrays, i.e. a grid
    //static void Main(string[] args)
    //{
    //    String[,] fruits = { {"Apple", "Banana", "Orange" },
    //                         {"Pineapple", "Mango", "Papaya" },
    //                         {"Kiwi", "Peach", "Grapes" } };
    //    fruits[1, 2] = "Watermelon"; //Changing item in 2D array

    //    //foreach (String fruit in fruits) {
    //    //    Console.WriteLine(fruit); //Prints all items in 2D array
    //    //}
    //    //Displaying as grid
    //    for (int i = 0; i < fruits.GetLength(0); i++) //GetLength(0) gets number of rows
    //    {
    //        for (int j = 0; j < fruits.GetLength(1); j++) //GetLength(1) gets number of columns
    //        {
    //            Console.Write(fruits[i, j] + "\t"); //\t adds a tab space between items
    //        }
    //        Console.WriteLine(); //Adds a new line after each row
    //    }


    //    Console.ReadKey();
    //}

    //30. Classes = a class is a blueprint for an object
    //              A bundle of related code

    //static void Main(string[] args)
    //{
    //    Math.Round(3.14);
    //    Math.Abs(-3.14);
    //    Math.Pow(2, 3);

    //    Messages.Hello(); //Calling method from Messages class
    //    Messages.Waiting();
    //    Messages.Bye();

    //    Console.ReadKey();
    //}

    //31. Objects = an instance of a class
    //              A class can be used as a blueprint to create objects (OOP)
    //              Objects can have fields and methods (characteristics and behaviors)

    //static void Main(string[] args)
    //{
    //    Human human1 = new Human();
    //    human1.name = "Rick";
    //    human1.age = 65;

    //    human1.Eat();
    //    human1.Sleep();

    //    Console.ReadKey();
    //}

    //32. Constructors = special method in a class
    //                   Same name as the class
    //                   Can be used to assign values to fields when an object is created

    //static void Main(string[] args)
    //{
    //    Human human1 = new Human("Rick", 65);
    //    Human human2 = new Human("Morty", 14);
    //    human1.Eat();
    //    human2.Sleep();

    //    Car car1 = new Car("Ford", "Mustang", 2024, "Red");
    //    Car car2 = new Car("Chevy", "Corvette", 2023, "Blue");

    //    car1.Drive();
    //    car2.Drive();

    //    Console.ReadKey();
    //}

    //33. Static modifier = modifier that makes a member belong to the class itself instead of to a specific object
    //    static void Main(String[] args)
    //    {
    //        Car car1 = new Car("Ford", "Mustang", 2024, "Red");
    //        Car car2 = new Car("Chevy", "Corvette", 2023, "Blue");
    //        Car car3 = new Car("Dodge", "Challenger", 2022, "Black");

    //        Console.WriteLine(Car.numberOfCars);
    //        Car.StartRace();

    //        //car1.Drive();
    //        //car2.Drive();
    //        Console.ReadKey();
    //    }

    //}
    //class Human
    //{
    //    public String name;
    //    public int age;

    //    public Human(String name, int age) //Constructor, called when object is created
    //    {
    //        this.name = name;
    //        this.age = age;
    //    }

    //    public void Eat()
    //    {
    //        Console.WriteLine(name + " is eating");
    //    }
    //    public void Sleep()
    //    {
    //        Console.WriteLine(name + " is sleeping");
    //    }
    //}
    //class Car
    //{
    //    String make;
    //    String model;
    //    int year;
    //    String color;
    //    public static int numberOfCars; //Static variable to keep track of number of cars
    //    public Car(String make, String model, int year, String color)
    //    {
    //        this.make = make;
    //        this.model = model;
    //        this.year = year;
    //        this.color = color;
    //        numberOfCars++; //Increment number of cars when a new car is created
    //    }
    //    public static void StartRace() //Static method, can be called without an object
    //    {
    //        Console.WriteLine("The race has begun!");
    //    }

    //    public void Drive()
    //    {
    //        Console.WriteLine($"I am driving a {year} {make} {model} with a color of {color}");
    //    }
    //    }

    //34. Overloaded constructors = technique to create multiple constructors
    //                              with different set of parameters
    //                              name + parameters = signature

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Pizza pizza = new Pizza("stuffed crust", "red sauce", "mozzirella", "pepperoni"); //Calls default constructor
    //        Pizza pizza2 = new Pizza("thin crust", "bbq sauce", "cheddar"); //Calls overloaded constructor
    //        Pizza pizza3 = new Pizza("thick crust", "pesto sauce"); //Calls overloaded constructor

    //        Console.ReadKey();
    //    }
    //}
    //class Pizza
    //{
    //    String bread;
    //    String sauce;
    //    String cheese;
    //    String topping;

    //    public Pizza(String bread, String sauce)
    //    {
    //        this.bread = bread;
    //        this.sauce = sauce;
    //        this.cheese = cheese;
    //        this.topping = topping;
    //    }
    //    public Pizza(String bread, String sauce, String cheese)
    //    {
    //        this.bread = bread;
    //        this.sauce = sauce;
    //        this.cheese = cheese;
    //        this.topping = topping;
    //    }
    //    public Pizza(String bread, String sauce, String cheese, String topping)
    //    {
    //        this.bread = bread;
    //        this.sauce = sauce;
    //        this.cheese = cheese;
    //        this.topping = topping;
    //    }
    //}

    //35. inheritance = when a class (child) inherits the fields and methods of another class (parent)
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Car car = new Car();
    //        Bicycle bike = new Bicycle();
    //        Boat boat = new Boat();

    //        Console.WriteLine(car.speed);
    //        Console.WriteLine(car.wheels);
    //        car.go();

    //        Console.WriteLine(boat.speed);
    //        Console.WriteLine(boat.wheels);
    //        boat.go();

    //        Console.ReadKey();
    //    }
    //}
    //class Vehicle
    //{

    //    public int speed = 0;

    //    public void go()
    //    {
    //        Console.WriteLine("Go go!");
    //    }
    //}
    //class  Car : Vehicle
    //{
    //    public int wheels = 4;
    //}
    //class Bicycle : Vehicle
    //{
    //    public int wheels = 2;
    //}
    //class Boat : Vehicle
    //{
    //    public int wheels = 0;
    //}

    //36. Abstract classes = modifier that indicates missing components or incomplete implementation
    //class Program
    //{
    //    public void Main(String[] args)
    //    {
    //        Car car = new Car();
    //        Bicycle bycycle = new Bicycle();
    //        Boat boat = new Boat();
    //        Vehicle vehicle = new Vehicle(); //Cannot create object from abstract class


    //        Console.ReadKey();
    //    }
    //}

    //abstract class Vehicle //Cannot create objects from abstract class, add abstract before class
    //{
    //    public int speed = 0;

    //    public void go()
    //    {
    //        Console.WriteLine("This vihicle is moving!");
    //    }
    //}
    //class Car : Vehicle
    //{
    //    public int wheels = 4;
    //    int maxSpeed = 500;
    //}
    //class Bicycle : Vehicle
    //{
    //    public int wheels = 2;
    //    int maxSpeed = 50;
    //}
    //class Boat : Vehicle
    //{
    //    public int wheels = 0;
    //    int maxSpeed = 100;
    //}

    //37. array of objects = an array that can store multiple objects of the same class

    //class Program
    //{
    //    static void Main(String[] args)
    //    {
    //        //Car[] garage = new Car[3]; //Array of Car objects, size 3

    //        //Car car1 = new Car("Mustang");
    //        //Car car2 = new Car("Corvette");
    //        //Car car3 = new Car("Challenger");

    //        //garage[0] = car1; //Add car1 to array at index 0
    //        //garage[1] = car2; //Add car2 to array at index 1
    //        //garage[2] = car3; //Add car3 to array at index 2

    //        Car[] garage = {new Car("Mustang"), new Car("Corvette"), new Car("Challenger")}; //Array of Car objects, no size limit
    //                                                                                         //Fewer lines of code than previous method

    //        foreach (Car car in garage)
    //        {
    //            Console.WriteLine(car.model);
    //        }

    //        Console.ReadKey();
    //    }
    //}
    //class Car
    //{
    //    public String model;

    //    public Car(String model)
    //    {
    //        this.model = model;
    //    }
    //}

    //38. Pass and object as an argument = passing an object to a method as a parameter

    //class Program
    //{
    //    static void Main(String[] args)
    //    {
    //        Car car1 = new Car("Mustang", "red");

    //        Car car2 = Copy(car1); //Create a copy of car1 and store it in car2

    //        //ChangeColor(car1, "Silver");

    //        Console.WriteLine(car2.color + " " + car2.model);

    //        Console.ReadKey();
    //    }
    //    //public static void ChangeColor(Car car, String color)
    //    //{
    //    //    car.color = color;
    //    //}

    //    public static Car Copy(Car car)
    //    {
    //        return new Car(car.model, car.color);
    //    }
    //}
    //class Car
    //{
    //    public String model;
    //    public String color;

    //    public Car(String model, String color)
    //    {
    //        this.model = model;
    //        this.color = color;
    //    }
    //}

    //39. method overriding = provides a new version of a method inherited from a parent class
    //                        inherted method must be: virtual, abstract or already overridden
    //                        used with ToString(), polymorphism

    //class Program 
    //{ 
    //    static void Main(String[] args)
    //    {
    //        Dog dog = new Dog();
    //        Cat cat = new Cat();
    //        dog.Speak();
    //        cat.Speak();

    //        Console.ReadKey();
    //    }
    //}
    //class Animal
    //{
    //    public virtual void Speak() //Add virtual to enable it to be over ridden.
    //    {
    //        Console.WriteLine("The Animal goes *brrr*");
    //    }
    //}
    //class Dog : Animal
    //{
    //    public override void Speak() //Need to have override, void (same type as orriginal), Speak() (Same name and signature)
    //    {
    //        Console.WriteLine("The Dog goes *wooff*");
    //    }
    //}
    //class Cat : Animal
    //{
    //    public override void Speak()
    //    {
    //        Console.WriteLine("The Cat goes *meaww*");
    //    }
    //}

    //40. ToString() method = converts an object to its string representation so that it is suitable for display

    //class Program
    //{
    //    static void Main(string[] args) 
    //    {
    //        Car car = new Car("Ford", "Mustang", 2024, "Red");

    //        Console.WriteLine(car.ToString());

    //        Console.ReadKey();
    //    }
    //}
    //class Car
    //{
    //    String make;
    //    String model;
    //    int year;
    //    String color;

    //    public Car(String make, String model, int year, String color)
    //    {
    //        this.make = make;
    //        this.model = model;
    //        this.year = year;
    //        this.color = color;
    //    }
    //    public override string ToString()
    //    {
    //        return "This is a " + make + " " + model;
    //    }
    //}

    //41. Polymorphism = Greek wordthat means to "have many forms"
    //                   Objects can be identified by more than one type
    //                   Ex. A Dog is also: Canine, Animal, Organism

    //class Program
    //{
    //    static void Main(String[] args)
    //    {
    //        Car car = new Car();
    //        Bicycle bicycle = new Bicycle();
    //        Boat boat = new Boat();

    //        Vehicle[] vehicles = { car, bicycle, boat }; //Array of Vehicle objects, can store any object that inherits from Vehicle

    //        foreach (Vehicle vehicle in vehicles) 
    //        {
    //            vehicle.Go();
    //        }

    //        Console.ReadKey();
    //    }
    //}
    //class Vehicle
    //{
    //    public virtual void Go()
    //    {

    //    }
    //}
    //class Car: Vehicle
    //{
    //    public override void Go()
    //    {
    //        Console.WriteLine("The Car is moving");
    //    }
    //}
    //class Bicycle : Vehicle 
    //{
    //    public override void Go()
    //    {
    //        Console.WriteLine("The Bicycle is moving");
    //    }
    //}
    //class Boat : Vehicle
    //{
    //    public override void Go()
    //    {
    //        Console.WriteLine("The Boat is moving");
    //    }
    //}

    //42. interface = defines a "contract" that all classes inheriting from should follow
    //                An interface "what a class should have"
    //                An inheriting class defines "how it should do it"
    //                Benefit = security + multiple inheritance + "plug-and-play"

    //class Public
    //{
    //    static void Main(String[] args)
    //    {
    //        Rabbit rabbit = new Rabbit();
    //        Hawk hawk = new Hawk();
    //        Fish fish = new Fish();

    //        rabbit.Flee();
    //        hawk.Hunt();
    //        fish.Hunt();
    //        fish.Flee();

    //        Console.ReadKey();
    //    }
    //}
    //interface IPrey
    //{
    //    void Flee();
    //}
    //interface IPredator
    //{
    //    void Hunt();
    //}
    //class Rabbit : IPrey
    //{
    //    public void Flee()
    //    {
    //        Console.WriteLine("The Rabbit runs away!");
    //    }
    //}
    //class Hawk :IPredator
    //{
    //    public void Hunt()
    //    {
    //        Console.WriteLine("The Hawk is hunting!");
    //    }
    //}
    //class Fish : IPrey, IPredator
    //{
    //    public void Flee()
    //    {
    //        Console.WriteLine("The Fish swims away!");
    //    }
    //    public void Hunt()
    //    {
    //        Console.WriteLine("The Fish is looking for food!");
    //    }
    //}

    //43. List = data structure that represents a list of objects that can be accessed by index.
    //           Similar to array, but can dynamically increase/decrease in size
    //           using System.Collections.Generic;

    //class Public
    //{
    //    static void Main(String[] args)
    //    {
    //        List<string> food = new List<String>();

    //        food.Add("fries");
    //        food.Add("pizza");      //Not limit to items that can be added.
    //        food.Add("hamburger");
    //        food.Add("hotdog");
    //        food.Add("fries");

    //        Console.WriteLine("Access an item in the array: " + food[0]);

    //        //Some usefull List methods

    //        //food.Remove("fries");
    //        //food.Insert(0,"sushi");
    //        //Console.WriteLine(food.Count);
    //        //Console.WriteLine(food.IndexOf("pizza"));
    //        //Console.WriteLine(food.LastIndexOf("fries"));
    //        //Console.WriteLine(food.Contains("pizza"));
    //        //food.Sort();
    //        //food.Reverse();
    //        //food.Clear();
    //        //String[] foodArray = food.ToArray();

    //        foreach (String item in food)
    //        {
    //            Console.WriteLine(item);
    //        }

    //        Console.ReadKey();
    //    }
    //}

    //44. List of object from custom class

    //class Program
    //{
    //    static void Main(String[] args)
    //    {
    //        List<Player> players = new List<Player>();

    //        //Player player1 = new Player("Chad");
    //        //Player player2 = new Player("Peet");
    //        //Player player3 = new Player("Sam");

    //        //Adding new players, less code

    //        players.Add(new Player("Chad"));
    //        players.Add(new Player("Peet"));
    //        players.Add(new Player("Sam"));

    //        foreach (Player player in players)
    //        {
    //            //Console.WriteLine(player.username); //normal way
    //            Console.WriteLine(player); //override ToString()
    //        }


    //        Console.ReadKey();
    //    }
    //}
    //class Player
    //{
    //    public String username;

    //    public Player(String username)
    //    {
    //        this.username = username;
    //    }
    //    public override String ToString() 
    //    { 
    //        return username;
    //    }
    //}

    //45. getters & setters = add security to fields by encapsulation
    //                        They're accessors found within properties
    // properties = combine aspects of both fields and methods (share name with a field)
    // get accessor = used to return a property value
    // get accessor = used to asign anew value
    // value keyword = defines the value being assigned by the set (parameter)

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Car car = new Car(400);

    //        car.Speed = 1000000;

    //        Console.WriteLine(car.Speed);

    //        Console.ReadKey();
    //    }
    //}
    //class Car
    //{
    //    public int speed;

    //    public Car(int speed)
    //    {
    //        Speed = speed;
    //    }
    //    public int Speed
    //    {
    //        get { return speed; } //read
    //        set                   //writable
    //        {
    //            if (value > 500)
    //            {
    //                speed = 500;
    //            } else
    //            {
    //                speed = value;
    //            }
    //        }
    //    }
    //}

    //46. Auto-Impremented properties = shortcuts when no additional logic is required in the property
    //                                  you do not have to define a fiel for a property,
    //                                  you only have to write get; abnd/or set; inside the property

    //class Program 
    //{ 
    //    static void Main(String[] args)
    //    {
    //        Car car = new Car("Mazda");

    //        Console.WriteLine(car.Model);

    //        Console.ReadKey();
    //    }
    //}
    //class Car
    //{
    //    public String Model { get; set; }

    //    public Car(String model)
    //    {
    //        this.Model = model;
    //    }
    //}

    //47. enums = special "class" that represents a group of constants (unchangeable/read-only variables)
    //            use enums when you have values that you know will not change, such as days, months, colors, etc.
    //            To get integer vlaues from an item, you must explicitly cast it to an int
    //            name = integer

    //class Program
    //{
    //    static void Main(String[] args)
    //    {
    //        Console.WriteLine(Planets.Pluto + " is a planet"); //Accessing enum item name
    //        Console.WriteLine(Planets.Saturn + " is planet #" + (int)Planets.Saturn);//Accessing enum item value, need to cast to int

    //        String name = PlanetRaduis.Earth.ToString(); //Convert enum item to string
    //        int radius = (int)PlanetRaduis.Earth; //Get enum item value, need to cast to int
    //        Console.WriteLine("Platen: " + name + " has a radius of " + radius + " km");
    //        Console.WriteLine("Radius: " + radius + " km");

    //        double volume = Volume(PlanetRaduis.Earth);
    //        Console.WriteLine("Volume: " + volume +"km^3");

    //        Console.ReadKey();
    //    }
    //    public static double Volume(PlanetRaduis radius)
    //    {
    //        double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3); //Volume of sphere formula
    //        return volume;
    //    }
    //}
    //enum Planets 
    //{ 
    //    Mercury = 1, //Assigning integer values to enum items, rest will continue incrementing
    //    Venus, 
    //    Earth, 
    //    Mars, 
    //    Jupiter, 
    //    Saturn, 
    //    Uranus, 
    //    Neptune,
    //    Pluto
    //}
    //enum PlanetRaduis
    //    {
    //    Mercury = 2439,
    //    Venus = 6051,
    //    Earth = 6371,
    //    Mars = 3389,
    //    Jupiter = 69911,
    //    Saturn = 58232,
    //    Uranus = 25362,
    //    Neptune = 24622,
    //    Pluto = 1188
    //}

    //48. generic = "not specific to a particular data type"
    //              add <T> to: classes, methods, fields, etc.
    //              allows for code reusability for different data types
    //class Progrma
    //{
    //    static void Main(String[] args)
    //    {
    //        int[] intArray = { 1, 2, 3 };
    //        double[] doubleArray = { 1.0, 2.0, 3.0 };
    //        String[] stringArray = {"1", "2", "3" };

    //        displayElements(intArray);
    //        displayElements(doubleArray);
    //        displayElements(stringArray);

    //        Console.ReadKey();
    //    }
    //    public static void displayElements<T>(T[] array) //Add <T> to make it generic
    //    {
    //        foreach (T item in array)
    //        {
    //            Console.Write(item + " ");
    //        }
    //        Console.WriteLine();
    //    }
    //}

    //49. Multi Threading = an execution path of a program
    //                      Wecan use multiple threads to perform,
    //                      different tasks of our program at the same time.
    //                      Current thread running is "main" thread
    //                      using System.Threading;

    class Program
    {
        static void Main(String[] args)
        {
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";

            //Console.WriteLine(mainThread.Name);

            Thread thread1 = new Thread(CountDown); //Create a new thread, pass in a method
            Thread thread2 = new Thread(() => CountUp("Time #2")); //Using lambda expression to pass in a method with parameters
            thread1.Start();
            thread2.Start();

            Console.WriteLine(mainThread.Name + " has completed!");
            Console.ReadKey();
        }
        public static void CountDown()
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Time #1 : " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Time #1 is complete!");
        }
        public static void CountUp(String name)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Time #2 : " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Time #2 is complete!");
        }
    }  
}
