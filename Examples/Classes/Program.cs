namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Class
            Student student1 = new Student("Tareq Ahmed", "Dhaka", new DateTime(1995, 1, 1));
            student1.Name = "Tareq Ahmed";

            //student1.cgpa = 3.4;
            //student1.UpdateCgpa(3.4);
            student1.Cgpa = 3.4;

            student1.Address = "Dhaka, Bangladesh";
            student1.DateOfBirth = new DateTime(1990, 1, 1);

            student1.UpdateDetails("Jalal Uddin", DateTime.Now);
            student1.UpdateDetails("Jalal Uddin", "Dhaka");
            student1.UpdateDetails("Dhaka", "Jalal Uddin");

            //student1.UpdateCgpa(3.74);

            Console.WriteLine(student1.Cgpa);

            //student1.UpdateCgpa(3.9);

            Student student2 = new Student();
            student2.Name = "Rafiq";

            //student2.cgpa = 2.5;
            student2.Cgpa = 2.5;

            student2.UpdateDetails(DateTime.Now, "Mr. Jala Uddin");

            //student2.cgpa += 2;
            student2.Cgpa += 2;

            Console.WriteLine(student2.Cgpa);
            #endregion

            #region static keyword (static method, static class, static variable)
            AreaCalculator areaCalculator = new AreaCalculator();
            //var circleArea = areaCalculator.GetCircleArea(20.5); // this line generate error
            //var rectangleArea = areaCalculator.GetRectangleArea(5, 10); // this line generate error
            // when we declare a static method then this method we can use without creating any instance or object of a class by only use the class name followed by dot
            var circleArea = AreaCalculator.GetCircleArea(20.5);
            var rectangleArea = AreaCalculator.GetRectangleArea(5, 10);

            // Use of static variable
            AreaCalculator.count = 10;
            AreaCalculator.Name = "Geometry Tool";

            // Note: If a class have non static variable or method then we can create an instance to use those type of member of the class

            // Note: If a class have static variable or property or method then we can use those member directly by using the class name followed by a dot directly without creating any object or instance of this class

            //areaCalculator.Print("This is non static method thats why we use it by an instance but if it is a static method then we should use it by class");

            areaCalculator.Print();

            AreaCalculator rectangleCalculator = new AreaCalculator();
            rectangleCalculator.Print();
            #endregion
        }
    }
}