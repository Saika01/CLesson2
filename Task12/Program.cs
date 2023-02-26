int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

// int whatsLeft = number1 % number2;
// if (whatsLeft==0){
//     Console.WriteLine("Кратное");
// } else {
//     Console.WriteLine("Не кратное. Остаток от деления"+whatsLeft);
// }
// Console.WriteLine(whatsLeft == 0 ? "Кратно" : $"не кратно, остаток {whatsLeft}");
// string result=whatsLeft == 0 ? "Кратно" : $"не кратно, остаток {whatsLeft}";
// Console.WriteLine(result);

int WhatsLeft(int num1,int num2){
    return num1 % num2;
} ;
Console.WriteLine(WhatsLeft(number1,number2)==0? "Кратно" : $"не кратно, остаток {WhatsLeft(number1,number2)}");