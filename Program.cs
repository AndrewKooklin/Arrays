using System;

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1

            Console.WriteLine("Случайчая матрица");

            Console.WriteLine("Введите количество строк матрицы");
            int numberRow = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов матрицы");
            int numberCol = int.Parse(Console.ReadLine());

            int[,] mass = new int[numberRow, numberCol];
            int sumElem = 0;

            Random rnd = new Random();

            for (int i = 0; i < numberRow; i++)
            {
                for (int j = 0; j < numberCol; j++)
                {
                    mass[i, j] = rnd.Next(1, 10);
                    sumElem += mass[i, j];
                    Console.Write($"{mass[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Сумма всех элементов матрицы равна : {sumElem}\n");

            // Задание 2

            Console.WriteLine("Наименьший элемент в последовательности");
            Console.WriteLine("Введите количество элементов");
            int elem = int.Parse(Console.ReadLine());
            int[] mass1 = new int[elem];

            Console.WriteLine($"Введите элементы последовательности ( положительные или отрицательные целые числа )");

            for (int i = 0; i < elem; i++)
            {
                int num = int.Parse(Console.ReadLine());

                mass1[i] = num;
            }

            int maxInt = int.MaxValue;
            int minimum = 0;

            for (int j = 0; j < mass1.Length; j++)
            {
                if (mass1[j] < maxInt)
                {
                    maxInt = mass1[j];
                    minimum = maxInt;
                }
            }

            Console.WriteLine($"Минимальное введенное число {minimum}\n");

            // Задание 3

            Console.WriteLine("Игра \"Угадай число\"");
            Console.WriteLine("Введите верхнюю границу диапазона положительных целых чисел");
            int number = int.Parse(Console.ReadLine());

            Random range = new Random();
            int secret = range.Next(0, number+1);

            Console.WriteLine($"Угадайте число выбранное программой от 0 до {number}");
            Console.WriteLine("Если устали играть, то введите пробел");

            var userInput = Console.ReadLine();
            
            if(userInput==" ")
            {
                Console.WriteLine($"Загаданное число {secret}");
            }
            else {
                var userInput1 = int.Parse(userInput);

                while (true) { 
                    if (userInput1 < secret)
                    {
                        Console.WriteLine("Введенное число меньше загаданного");
                        var userinput2 = Console.ReadLine();
                        if (userinput2 == " ")
                        {
                            Console.WriteLine($"Загаданное число {secret}");
                            break;
                        }
                        else
                        {
                            userInput1 = int.Parse(userinput2);
                        }

                    }
                    else if (userInput1 > secret)
                    {
                        Console.WriteLine("Введенное число больше загаданного");
                        var userInput2=Console.ReadLine();
                        if(userInput2==" ")
                        {
                            Console.WriteLine($"Загаданное число {secret}");
                            break;
                        }
                        else
                        {
                            userInput1 = int.Parse(userInput2);
                        }
                    }
                    else if(userInput1==secret)
                    {
                        Console.WriteLine($"Вы угадали, загаданное число : {secret}");
                        break;
                    }

                }
            }

            Console.ReadLine();

        }
    }
}
