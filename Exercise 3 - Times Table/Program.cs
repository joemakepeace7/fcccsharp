/*
 * Ask user for a number for the times table, then print the times table for that number up to the given number
 */

Console.Write("Enter a number for the times table: ");
string numInput = Console.ReadLine();

/*
 * Take numInput and try parsing as an integer. If that works, then output that integer into the integer 'result', which is initialised directly in the if statement
 * If anything other than an integer is entered, the else statement will execute.
 */
if (int.TryParse(numInput, out int result))
{
    for (int i = 1; i <= result; i++)
    {
        Console.WriteLine($"{i * result} Tigers");
        /*
         * $" is required for string interpolation, allowing for inserting variables into strings.
         */
    };

}
else
{
    Console.WriteLine("Enter a valid number");
}


Console.ReadLine();

