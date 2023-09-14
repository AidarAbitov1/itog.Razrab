sing System;
using static System.Console;

string[]array = {"Hello,",  "2,",  "world,",   "1234,",     "1567,", "123,", "qws", "+_)", "computer science,"};       
WriteLine();  //Создаём массив строк array содердажащий некоторые значения
MethodCreateInputArray(array); //Выводим метод первый 
WriteLine();
MethodCreateOutputArray(array);//Выводим метод второй 
WriteLine();//Результат работы выводится в консоль при dotnet new console 


void MethodCreateInputArray(string[] InputArray) // принимает массив строк 
{                                                //в качестве аргумента и выводит все его элементы на экран. Она 
    Write($"InputArray: ");                      //выводит каждый элемент строкой.
    for (int i = 0; i < InputArray.Length; i++)  
    {
        Write($"{InputArray[i]}");
    }
}