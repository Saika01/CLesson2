﻿bool IsSquare(int num1, int num2){
    return num1 == num2*num2 || num2 == num1*num1;
}

int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if (IsSquare(number1,number2))
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");
