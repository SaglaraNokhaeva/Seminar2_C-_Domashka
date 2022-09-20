//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет


Console.Clear();

Console.WriteLine("Введите номер дня недели:");
int number=int.Parse(Console.ReadLine());


if (number>0&&number<6) 
{
    Console.WriteLine("Этот день не выходной.");
    }
else
 {
    if (number>5&&number<8) 
    {
    Console.WriteLine("Этот день выходной!");
    }
    else 
    {
        Console.WriteLine("Дня недели под таким номером нет.");
    }
    }