// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Task 1
string name = "John Doe";
int age = 25;
bool isAdmin = true;

Console.WriteLine("Name: " + name);
Console.WriteLine("Age: " + age);
Console.WriteLine("Is Admin: " + isAdmin);

//Task 2
Console.WriteLine("Enter any number");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0)
{
    Console.WriteLine($"{number} is an even number");
}

else 
{
    Console.WriteLine($"{number} is an odd number");
}

// Task 3
for (int num = 1; num <=10; num++)
{
    Console.WriteLine(num);
}

//Task 4
int[] numbers = { 2, 4, 6, 8, 10 };
int sum = 0;
foreach(int num in numbers)
{
    Console.WriteLine(num);
    sum += num;
}

Console.WriteLine($"\nSum of all elements in array is: {sum}");

//Task 5
static void Greet(string name)
{
    Console.WriteLine($"Hello, {name}!");
}

Greet("Alice");

Console.ReadKey();






