using OOP;

public class Program
{
    public static void Main(string[] args)
    {
        WaterBottle bottle = new WaterBottle("red", 300);
        bottle.WaterAmount = 300;

        // Add water using Method
        bottle.AddWater(200);

        //bottle.color = "red"; // produce compilation error


        WaterBottle bottle2 = new WaterBottle("blue", 200);

        // assign value using variable / field
        //bottle2.waterAmount = 400;
        bottle2.AddWater(100);

        //bottle2.color = "blue"; // produce compilation error

        // Print the water amount of the bottle
        Console.WriteLine(bottle.WaterAmount);
        Console.WriteLine(bottle2.WaterAmount);

        // Print the color of bottle
        //Console.WriteLine(bottle.GetColor());
        //Console.WriteLine(bottle2.GetColor());

        // Get color using property
        Console.WriteLine(bottle.Color);
        Console.WriteLine(bottle2.Color);
    }
}