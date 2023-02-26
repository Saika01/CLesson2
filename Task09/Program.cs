int number = new Random().Next(10, 100);
Console.WriteLine($"Random number from 10 to 99 -> {number}");
int firstDigit = number/10;
int secondDigit = number%10;
if (firstDigit>secondDigit){
    Console.WriteLine(firstDigit);
} else if (secondDigit>firstDigit){
    Console.WriteLine(secondDigit);
} else {
    Console.WriteLine("Errore");
}