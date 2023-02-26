int IsConverted(){
    return Convert.ToInt32(Console.ReadLine());
}

int SecondDigit(int num){
    return num/10%10;
}

Console.WriteLine("Write a number");
int number = IsConverted();
if (number/1000 == 0 && number/100 != 0) 
    Console.WriteLine(SecondDigit(number));
else
    Console.WriteLine("Pick another number");


