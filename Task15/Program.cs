int IsConverted(){
    return Convert.ToInt32(Console.ReadLine());
}

void Answer(int number){
    if (number>7 || number<1) 
        Console.Write("Pick another number");
    else {
        string[] arr = {"No", "No", "No", "No", "No", "Yes", "Yes"};
        Console.WriteLine(arr[number-1]);
    }
}

int digit = IsConverted();
Answer(digit);


