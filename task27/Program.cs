//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//
//452 -> 11
//
//82 -> 10
//
//9012 -> 12

int CountingDigits(int inputValue) {
    int result = 0;
    string parseNumber =  inputValue.ToString();
    for (int i = 0; i < parseNumber.Length; i++) {
        result += Convert.ToInt32(Convert.ToString(parseNumber[i]));
    }
    
    System.Console.WriteLine(result);
    return result;
}

CountingDigits(1234);