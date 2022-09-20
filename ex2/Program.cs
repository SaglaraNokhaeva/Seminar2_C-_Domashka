//Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Clear();
Console.WriteLine("Введите число:");
string number=Console.ReadLine();

if (number.Length<3) 
{
    Console.WriteLine("Третьей цифры нет");
    }
else
 {
    char rezult=number[2];
    Console.WriteLine(rezult);
    }