namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Name = "Tareq Ahmed";

            //student1.cgpa = 3.4;
            //student1.UpdateCgpa(3.4);
            student1.Cgpa = 3.4;

            student1.Address = "Dhaka, Bangladesh";
            student1.DateOfBirth = new DateTime(1990, 1, 1);

            //student1.UpdateCgpa(3.74);

            Console.WriteLine(student1.Cgpa);

            //student1.UpdateCgpa(3.9);

            Student student2 = new Student();
            student2.Name = "Rafiq";

            //student2.cgpa = 2.5;
            student2.Cgpa = 2.5;

            //student2.cgpa += 2;
            student2.Cgpa += 2;

             Console.WriteLine(student2.Cgpa);
        }
    }
}