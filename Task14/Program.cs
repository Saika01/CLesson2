﻿Console.WriteLine("Input number");
int number = Convert.ToInt32(Console.ReadLine());
// if (number % 7 == 0 && number % 23 == 0)
// {
//     Console.WriteLine("Yes");
// }
// else
// {
//     Console.WriteLine("No");
// }
bool IsDivided(int num)
{
    return number % 7 == 0 && number % 23 == 0;
}

if (IsDivided(number))
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
