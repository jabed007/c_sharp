using Object.Oriented.Programming;
public class Program
{
    public static void Main(string[] args)
    {
        WaterBottle bottle = new WaterBottle("red", 300);
        bottle.WaterAmount = 300;

        // Add water using Method
        bottle.AddWater(200);

        bottle.IsOpen = true;

        Console.WriteLine(bottle.IsOpen);

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

        // Create a Parameter Less Object
        WaterBottle bottle3 = new WaterBottle();  // This object called the empty constructor()
        /*
        Dog bullDog = new Dog();

        // access breed of the Dog Class
        bullDog.breed = "Bull Dog";
        Console.WriteLine(bullDog.breed);

        // access method of the Dog
        bullDog.Bark();

        // Creating Multiple Objects of a Class
        // Create Employee Object
        Employee sheeran = new Employee();

        // Set department for sheeran
        sheeran.department = "Development";
        Console.WriteLine("Sheeran: " + sheeran.department);

        // Create second object of Employee
        Employee taylor = new Employee();

        // set department for taylor
        taylor.department = "Content Writer";
        Console.WriteLine("Taylor: " + taylor.department);

        // Creating objects in a different class
        */

    }
}