//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//
//3, 5 -> 243 (3⁵)
//
//2, 4 -> 16

int Exponentiation(int firstValue, int secondValue) {
    int count = 0;
    int result = 1;
        while(count != secondValue) {
            result *= firstValue;
            count++;
        }
    System.Console.WriteLine(result);
    return result;
}


