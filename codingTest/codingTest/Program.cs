// See https://aka.ms/new-console-template for more information
void calculateGst(decimal price)
{
    Console.WriteLine("price with gst " + price + "$");
    Console.WriteLine("gst difference " + Math.Round(price * 0.15m, 2) + "$");
    Console.WriteLine("Price without gst " +  Math.Round(price * 0.85m, 2) + "$");
};

calculateGst(11.50m);

