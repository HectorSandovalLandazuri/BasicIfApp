


bool isComplete  = true;

if (isComplete)
{
    Console.WriteLine("It's complete.");
} else
{
    Console.WriteLine("It's not complete.");
}

Console.Write("What is your name: ");
string firstName=Console.ReadLine();

if (firstName.ToLower() =="héctor")
{
    Console.WriteLine("It's me.");
} else
{
    Console.WriteLine($"Hello {firstName}.");
}

Console.WriteLine("End of Program.");