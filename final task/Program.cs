// *Задача:* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.


using System;
using static System.Console;

Clear();

string[] array1 = AskArray();
string[] array2 = FindLessThan(array1, 3);
WriteLine($"[{string.Join(", ", array1)}] -> [{string.Join(", ", array2)}]");

string[] FindLessThan(string[] input, int number) {
    string[] output = new string[CountLessThan(input, number)];

    for(int ar1 = 0, ar2 = 0; ar1 < input.Length; ar1++) {
        if(input[ar1].Length <= number) {
            output[ar2] = input[ar1];
            ar2++;
        }
    }

    return output;
}

int CountLessThan(string[] input, int number) {
    int counter = 0;

    for(int ar1 = 0; ar1 < input.Length; ar1++) {
        if(input[ar1].Length <= number) {
            counter++;
        }
    }

    return counter;
}

string[] AskArray() {
    Write("Введите значения массива через пробел: ");
    return ReadLine().Split(" ");
}