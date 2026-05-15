int loop = 15;

for (int i = 0; i <= loop; i++)
{
    if (i % 3 == 0 && i % 5 ==0)
    {
        Console.WriteLine("BeeWasp");

    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Bee");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Wasp");
    }

};


double number = 15.04033555;
Console.WriteLine(string.Format("{0:0}", number));
Console.WriteLine(string.Format("{0:0.00000}", number));


Console.WriteLine("{1}, {0}", "Fossa", "Tree Frog");




Console.ReadLine();




