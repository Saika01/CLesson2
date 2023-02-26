int number = new Random().Next(100, 1000);
Console.WriteLine($"Random number from 100 to 999 -> {number}");
int result = TheNumber(number);
Console.WriteLine(result);

int TheNumber(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    return firstDigit*10+thirdDigit;
}
