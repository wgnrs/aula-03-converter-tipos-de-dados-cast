﻿int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1

int result1;
decimal result2;
float result3;

// Hint: You need to round the result to nearest integer (don't just truncate)
// result1 = value1 / (int)value2;
result1 = Convert.ToInt32(value1 / value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");