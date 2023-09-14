using System;
using static System.Console;

string[]array = {"Hello,",  "13",  "cat",   "1234,",     "55555,", "123,", "qwerty", "-=09", "itog"};       
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

void MethodCreateOutputArray(string[] OutputArray) 
{                                                  
    Write($"Output array: ");                      
    string[] newarr = new string[OutputArray.Length];
    for (int i = 0; i < OutputArray.Length; i++)    
    {                                               
        if (OutputArray[i].Length <=3)
        {
            newarr[i] = OutputArray[i];
            Write($"{newarr[i]}");
        }
    }
    WriteLine();
}
