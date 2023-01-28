//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//
//6, 1, 33 -> [6, 1, 33]

int[] ArrayGeneration() {
    
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++) {
        int generationValue = new Random().Next(0,20);
        array[i] = generationValue;
    }
    System.Console.WriteLine(string.Join(", ", array));
    return array;
}

ArrayGeneration();
