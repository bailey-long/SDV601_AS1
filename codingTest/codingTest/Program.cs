// See https://aka.ms/new-console-template for more information
void calculateGst()
{
    while (true) //allow the app to keep running after a calculation
    {
        Console.WriteLine("Enter a price (gst inclusive) to convert or type \"exit\" to close the app");
        string input = Console.ReadLine();
        decimal convertUserInputToDecimal;

        if (input == "exit")
        {
            //allow user to close the terminal
            return;
        }
        else if (decimal.TryParse(input, out convertUserInputToDecimal)) //detect if user input can be converted to decimal
        {
            decimal price = convertUserInputToDecimal; //
            
            Console.WriteLine("price with gst " + price + "$");
            Console.WriteLine("gst difference " + Math.Round(price * .15m, 2) + "$");
            Console.WriteLine("Price without gst " + Math.Round(price / 1.15m, 2) + "$" + Environment.NewLine);
        }
        else
        {
            Console.WriteLine("incorrect format, please enter a price in decimal");
        }
    }
};

calculateGst();

