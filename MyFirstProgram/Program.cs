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
Console.WriteLine("Please enter your name: ");
String name = Console.ReadLine();

if (name == "")
{
    Console.WriteLine("You did not enter a name!");
} else
{
    Console.WriteLine("Hello " + name);
}





    Console.ReadKey();