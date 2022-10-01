/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.WriteLine("ADD number");
int number = Convert.ToInt32(Console.ReadLine());

int sum (int number)
    {
        int converter = Convert.ToInt32(number);
        int resultat = 0 ;
        for (int d = 1;d <= converter; d++)
        {
            resultat += d;
            
        }
       return resultat;
    }
int Summa = sum (number);
Console.WriteLine(Summa);

