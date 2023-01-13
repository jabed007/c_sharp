// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// variable can have alphabet, digit or underscore and it must start with either alphabet or underscore.
int student_age = 23;
string studentName = "Md. Jabed Hossain";
bool isAdmitted = true;
double weight = 83.5;
char initial = 'A';

string line =  Console.ReadLine();

//int size = line.Length;
//Console.WriteLine(size);

string[] lineParts = line.Split(' ');
for (int i = 0; i < lineParts.Length; i++)
{
    Console.WriteLine(lineParts[i]);
}