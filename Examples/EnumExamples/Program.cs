namespace EnumExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Name = "Jalal Uddin";
            user.Email = "jalal.exe@gmail.com";
            user.Status = UserStatus.Deleted;

            Console.WriteLine(user.Status);
            Console.WriteLine((int)user.Status);
        }
    }
}