/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
Console.WriteLine ("add number A");
int A = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine ("add number B");
int B = Convert.ToInt32(Console.ReadLine()!);
//Console.WriteLine($"A^B= " + Math.Pow(A,B));

/*int metod (int A, int B)
    {
     int i = Convert.ToInt32(Math.Pow(A,B));  
     return i;    
    }
    int Stepen = metod (A, B);
Console.WriteLine($"значение {A} в степени {B} = {Stepen}");*/


int metod (int A, int B)
{
  int result = 1;
  for(int i=1; i <= B; i++)
  {
    result = result * A;
   
  }
  return result;
}
 int Stepen = metod(A, B);
Console.WriteLine(Stepen);