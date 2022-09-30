/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/
Console.WriteLine("ADD number");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;

for (int number; i > 0; )
    {
        number = i % 10;
            i= i / 10;
        sum = sum + number;
    }

Console.WriteLine("sum numbers:= " + sum);

