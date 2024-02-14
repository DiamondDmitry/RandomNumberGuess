﻿using System.Text;

class RandomNumberGenerator
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.Unicode;
        
        Console.WriteLine("Добро пожаловать в игру 'Угадай число'!");
        Console.WriteLine("Я загадал число между: 1 и 100.");
        Console.WriteLine("Попробуйте угадать.");

        // Создаем объект для генерации чисел
        Random rnd = new Random();

        // Создаем переменную для хранения случайного числа
        var secret = rnd.Next(1, 100);

        // Создаем переменную для хранения числа попыток
        int tryCount = 0;

        // 1. Создаем цикл, который будет выполняться до тех пор, пока не будет угадано число
        do
        {   // 2. В теле цикла:
            int guess;

            // 2.1. Увеличиваем счетчик попыток на 1
            tryCount++;
            while (true)
            {
                Console.WriteLine("\nВведите число целое число от 1 до 100: ");

                // 2.2. Считываем число с клавиатуры и сохраняем в переменную
                string text = Console.ReadLine();
                if (int.TryParse(text, out guess))
                {
                    if (guess < 1)
                    {
                        Console.WriteLine("Число должно быть больше 0");
                    }
                    else if (guess > 100)
                    {
                        Console.WriteLine("Число должно быть не более 100");
                    }
                    else if (guess % 1 != 0)
                    {
                        Console.WriteLine("Число должно быть целое");
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
                }

             }

            // 2.3. Сравниваем загаданное число с введенным пользователем
            if (guess == secret)
            {
                // 2.4. Если числа равны, то выводим сообщение о победе и о количестве попыток
                Console.WriteLine("Вы угадали с " + tryCount + " попытки!");
                break;
            }
            else if (guess < secret)
            {
                // 2.5. Если число пользователя больше загаданного, то выводим сообщение, что число больше загаданного
                Console.WriteLine("Загаданное число больше");
            }
            else if (guess > secret)
            {
                // 2.6. Если число пользователя меньше загаданного, то выводим сообщение, что число меньше загаданного
                Console.WriteLine("Загаданное число меньше");
            }
            if (tryCount > 9)
            {
                // 2.7. Если число попыток равно 10, то выводим сообщение о проигрыше и загаданное число
                Console.WriteLine("Вы проиграли! Загаданное число:" + secret);
            }
        }
        while (tryCount < 10);


        // Так же помним что надо проверять ввод пользователя на корректность
        // Если пользователь ввел не число, то выводим сообщение об ошибке и просим ввести число еще раз
        // Число джолжно быть в диапазоне от 1 до 100 и целое

    }
}
