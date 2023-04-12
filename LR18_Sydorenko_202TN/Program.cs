using System;

namespace LR18_Sydorenko_202TN
{
    class Program
    {
        static void Main(string[] args)
        {
            // одновимірний масив 
            // заповнюємо його з клавіатури
            Console.Write("Введіть кількість елементів масива:\t");
            int element = int.Parse(Console.ReadLine());

            int[] myArray = new int[element];
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"\nВведіть елемент масива під індексом {i}:\t");
                myArray[i] = int.Parse(Console.ReadLine());   
                


            }
            Console.WriteLine("\nВивід масива:\t");
            for (int i = 0; i < myArray.Length; i++)
            {               
                Console.WriteLine(myArray[i]);
            }
            // знаходимо суму від'ємних елементів
            int result = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] < 0)
                {
                    result += myArray[i];
                }
            }
            Console.WriteLine($"Сума від'ємних елементів{result}:\t");
            // знаходимо Добуток елементів розташованих між максимальним і мінімальним елементом
            int max = myArray[0];
            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] > max)
                {
                    max = myArray[i];
                }
            }
            Console.WriteLine($"Максимальний елемент{max}:\t");
            int min = myArray[0];
            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] < min)
                {
                    min = myArray[i];
                }
            }
            Console.WriteLine($"Мінімальний елемент{min}:\t");
            int dobutok = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] != max && myArray[i] != min)
                {
                    dobutok = dobutok * myArray[i];
                }
            }
            Console.WriteLine($"Добуток елементів розташованих між максимальним і мінімальним елементом{dobutok}:\t");
            int temp;
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if (myArray[i] > myArray[j])
                    {
                        temp = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = temp;
                    }
                }
            }            
            Console.WriteLine("Виведення відсортованого масиву");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            // Двовимірний масив 
            // створюємо і виводимо на екран
            int[,] twiseArray = new int[3, 5]
            {
                {2,65,2,9,15 },
                {5,15,96,31,17 },
                {12,6,24,9,15 }
            };
            Console.WriteLine("Виведення двовимірного масиву");
            int height = twiseArray.GetLength(0);
            int width = twiseArray.GetLength(1);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(twiseArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
            //Вивести на екран елемент, розміщений у правому верхньому куті масиву
            Console.WriteLine($"Єлемент, розміщений у правому верхньому куті масиву{twiseArray[0,4]}:\t");
            //Вивести на екран елемент, розміщений у лівому нижньому куті масиву.
            Console.WriteLine($"Єлемент, розміщений у лівому нижньому куті масиву{twiseArray[2, 0]}:\t");
        }
    }
}
