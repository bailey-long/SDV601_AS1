//Write an application to display the multiplication table vertically from 1 to 10.
//Optional ask the user for the maximum value. Ensure that the number align in columns.

void displayMultiplcationTable()
{
    while (true)
    {
        Console.WriteLine("Input the highest number you want to see multiplied up to ten.");
        int maxValue = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= maxValue; i++)
        {
            for (int j = 1; j <= maxValue; j++)
            {
                Console.WriteLine(j * i);
            }
        }
    }
}

displayMultiplcationTable();