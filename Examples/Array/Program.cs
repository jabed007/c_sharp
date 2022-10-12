// See https://aka.ms/new-console-template for more information

// Provide us various Method to use in array
using System.Linq;

// ************************
// ****** C# Arrays *******
// ************************

// An Array is a collection of similar types of data
// Suppose we need to record the age of 5 students. Instead of creating 5 separate variables, we can simply create an array

// 1. C# Array Declaration

// declare an array
int[] age;

// allocate memory for array
age = new int[5];

//int[] num = new int[5];

// Array initializations in c#
//int[] numbers = {1, 2, 3, 4, 5};

// initializing array
age[0] = 24;
age[1] = 4;
age[2] = 6;
age[3] = 7;
age[4] = 8;

// Example C# Array

// Create an Array
int[] numbers = {30, 31, 94, 86, 55};

// access first element
Console.WriteLine("Element in first index: " + numbers[0]);

// access second element
Console.WriteLine("Element in second index: " + numbers[1]);

// access third number
Console.WriteLine("Element in third index: " + numbers[2]);

// 4. Change Array Elements
//Console.WriteLine("Old value at index 0: " + numbers[0]);

//numbers[0] = 11;
//Console.WriteLine("New value at index 0: " + numbers[0]);
//Console.WriteLine();

//Console.ReadLine();

// 5. Iterating C# Array using Loops
// Example: Using for loop

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine("Elements in index " + i + ": " + numbers[i]);
}

Console.WriteLine();

// Example: Using foreach loop

Console.WriteLine("Array Elements: ");

foreach(int num in numbers)
{
    Console.WriteLine(num);
}

// 6. C# Array Operations using System.Linq
// Example: Find Minimum and Maximum Element

Console.WriteLine();

// Min() returns the minimum number in array
Console.WriteLine("Smallest Element: " + numbers.Min());

// Max() returns the largest number in array
Console.WriteLine("Largest Element: " + numbers.Max());

// Example: Find the Average of an Array

// Get the sum of all array elements
float sum = numbers.Sum();  

// Get total number of elements are present in the array
int count = numbers.Count();

// Find the average of the array
float average = sum / count;

Console.WriteLine("Average: " + average);

// Compute the average
Console.WriteLine("Average using average function: " + numbers.Average());
Console.WriteLine();

// ****************************************
// ****** C# Multidimensional Array *******
// ****************************************

// In this tutorial we lesrn about the multidimensional array in C# using the example of two-dimensinal array

int[,] x =
{
    { 1, 2, 3 },
    { 4, 5, 6 }
};

int[,] array2D = new int[2, 3];
int[,] arrayTwoDimension = new int[2, 3] { {1, 2, 3 }, {4, 5, 6 } };

// Example: C# 2D Array

// Initializing 2D Array
int[,] numbers2D = { { 2, 3 }, { 4, 5 } };

// access first element from the first row
Console.WriteLine("Element at index [0, 0] : " + numbers2D[0, 0]);

// access the first element from the second row
Console.WriteLine("Element at index [1, 0] : " + numbers2D[1, 0]);
Console.WriteLine();

// Change Array Elements

// Old Element
Console.WriteLine("Old element at index [0, 0] : " + numbers2D[0, 0]);

// assigning new value at index[0, 0]
numbers2D[0, 0] = 222;

// Print new element at index [0, 0]
Console.WriteLine("New element at index[0, 0]: " + numbers2D[0, 0]);