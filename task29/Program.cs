// **Задача 29:** Напишите программу, которая задаёт массив из 8 
// элементов и выводит их на экран.

// 1,  2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6,  1, 33 -> [6, 1, 33]

 Console.WriteLine("В диапазоне 0-A будет создан случайный массив из А элементов");
            Console.Write("Введите любое число (A): ");
            int numberA = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[numberA];

            for (int i = 0; i < numberA; i++)
            {
                array[i] = new Random().Next(numberA+1);
            }
void Method1(string msg)
{
     Console.WriteLine($"[{String.Join("; ", array)}]");
}
Method1("");


