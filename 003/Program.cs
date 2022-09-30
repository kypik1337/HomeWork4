/*Задача 29: Напишите программу, которая задаёт массив из 8 рандомных элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/
int[] mass = new int[8];
        mass[0] = new Random().Next(0, 10);
        Console.Write(mass[0]);
            mass[1] = new Random().Next(0, 10);
             Console.Write(mass[1]);
             mass[2] = new Random().Next(0, 10);
                 Console.Write(mass[2]);
                 mass[3] = new Random().Next(0, 10);
                     Console.Write(mass[3]);
                     mass[4] = new Random().Next(0, 10);
                         Console.Write(mass[4]);
                            mass[5] = new Random().Next(0, 10);
                             Console.Write(mass[5]);
                                mass[6] = new Random().Next(0, 10);
                                 Console.Write(mass[6]);
                                    mass[7] = new Random().Next(0, 10);
                                     Console.Write(mass[7]);
                                    
    