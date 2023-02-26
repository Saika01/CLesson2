int IsConverted(){
    return Convert.ToInt32(Console.ReadLine());
}

void CheckThree(int num){
    if (num/100==0){
        Console.WriteLine("Pick another number");
    } else {
        while(num/1000 != 0){ 
        num=num/10;
        }
        num=num%10;
        Console.WriteLine(num);
    }
}

Console.WriteLine("Write a number");
int number = IsConverted();
CheckThree(number);
