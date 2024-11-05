using System;

class Program
{
    static void Main()
    {
        //Task1

        //Console.WriteLine("Введите число от 1 до 100:");
        //if (int.TryParse(Console.ReadLine(), out int number))
        //{
        //    if (number < 1 || number > 100)
        //    {
        //        Console.WriteLine("Ошибка: число должно быть в диапазоне от 1 до 100.");
        //    }
        //    else
        //    {
        //        if (number % 3 == 0 && number % 5 == 0)
        //        {
        //            Console.WriteLine("Fizz Buzz");
        //        }
        //        else if (number % 3 == 0)
        //        {
        //            Console.WriteLine("Fizz");
        //        }
        //        else if (number % 5 == 0)
        //        {
        //            Console.WriteLine("Buzz");
        //        }
        //        else
        //        {
        //            Console.WriteLine(number);
        //        }
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("Ошибка: введите корректное целое число.");
        //}

        //Task2

        //Console.WriteLine("Введите число:");
        //double number = Convert.ToDouble(Console.ReadLine());

        //Console.WriteLine("Введите процент:");
        //double percent = Convert.ToDouble(Console.ReadLine());

        //double result = (number * percent) / 100;
        //Console.WriteLine($"{percent}% от {number} = {result}");

        //Task 3

        //Console.WriteLine("Введите четыре цифры:");


        //string digit1 = Console.ReadLine();
        //string digit2 = Console.ReadLine();
        //string digit3 = Console.ReadLine();
        //string digit4 = Console.ReadLine();


        //string numberString = digit1 + digit2 + digit3 + digit4;


        //int number = Convert.ToInt32(numberString);

        //Console.WriteLine($"Сформированное число: {number}");

        //Task 4

        //Console.WriteLine("Введите шестизначное число:");
        //string inputNumber = Console.ReadLine();

        //if (inputNumber.Length != 6)
        //{
        //    Console.WriteLine("Ошибка: введите корректное шестизначное число.");
        //    return;
        //}

        //Console.WriteLine("Введите номера разрядов для обмена (например, 1 и 6):");
        //int pos1 = int.Parse(Console.ReadLine()) - 1; 
        //int pos2 = int.Parse(Console.ReadLine()) - 1; 

        //if (pos1 >= 0 && pos1 < 6 && pos2 >= 0 && pos2 < 6)
        //{
        //    char[] numberArray = inputNumber.ToCharArray();

        //    (numberArray[pos1], numberArray[pos2]) = (numberArray[pos2], numberArray[pos1]);

        //    Console.WriteLine($"Результат после обмена: {numberArray}");
        //}
        //else
        //{
        //    Console.WriteLine("Ошибка: номера разрядов должны быть от 1 до 6.");
        //}

        //Task 5

        //Console.WriteLine("Введите дату (дд.мм.гггг):");
        //string input = Console.ReadLine();

        //if (DateTime.TryParse(input, out DateTime date))
        //{

        //    string dayOfWeek = date.ToString("dddd");


        //    string season;
        //    if (date.Month == 12 || date.Month <= 2)
        //        season = "Winter";
        //    else if (date.Month <= 5)
        //        season = "Spring";
        //    else if (date.Month <= 8)
        //        season = "Summer";
        //    else
        //        season = "Autumn";

        //    Console.WriteLine($"{season} {dayOfWeek}");
        //}
        //else
        //{
        //    Console.WriteLine("Ошибка: введите корректную дату.");
        //}

        //Task 6

        //Console.WriteLine("Введите температуру:");
        //double temperature = Convert.ToDouble(Console.ReadLine());

        //Console.WriteLine("Выберите направление преобразования:");
        //Console.WriteLine("1. Фаренгейт в Цельсий");
        //Console.WriteLine("2. Цельсий в Фаренгейт");
        //int choice = Convert.ToInt32(Console.ReadLine());

        //if (choice == 1)
        //{
        //    // Преобразование из Фаренгейта в Цельсий
        //    double celsius = (temperature - 32) * 5 / 9;
        //    Console.WriteLine($"Температура в Цельсии: {celsius}");
        //}
        //else if (choice == 2)
        //{
        //    // Преобразование из Цельсия в Фаренгейт
        //    double fahrenheit = (temperature * 9 / 5) + 32;
        //    Console.WriteLine($"Температура в Фаренгейте: {fahrenheit}");
        //}
        //else
        //{
        //    Console.WriteLine("Ошибка: выберите корректный вариант.");
        //}

        //Task 7

        //Console.WriteLine("Введите два числа:");
        //int start = Convert.ToInt32(Console.ReadLine());
        //int end = Convert.ToInt32(Console.ReadLine());

        //// Нормализация границ
        //if (start > end)
        //{
        //    int temp = start;
        //    start = end;
        //    end = temp;
        //}

        //Console.WriteLine("Четные числа в диапазоне:");
        //for (int i = start; i <= end; i++)
        //{
        //    if (i % 2 == 0)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
    }
}
