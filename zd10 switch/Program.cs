using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число:");
        int day = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите номер месяца:");
        int month = int.Parse(Console.ReadLine());

        int dayNumber = 0;

        switch (month)
        {
            case 12:
                dayNumber += 30;
                goto case 11;
            case 11:
                dayNumber += 31;
                goto case 10;
            case 10:
                dayNumber += 30;
                goto case 9;
            case 9:
                dayNumber += 31;
                goto case 8;
            case 8:
                dayNumber += 31;
                goto case 7;
            case 7:
                dayNumber += 30;
                goto case 6;
            case 6:
                dayNumber += 31;
                goto case 5;
            case 5:
                dayNumber += 30;
                goto case 4;
            case 4:
                dayNumber += 31;
                goto case 3;
            case 3:
                dayNumber += 28;
                goto case 2;
            case 2:
                dayNumber += 31;
                goto case 1;
            case 1:
                dayNumber += day;
                break;
            default:
                Console.WriteLine("Неправильный номер месяца.");
                return;
        }

        Console.WriteLine("Номер дня: " + dayNumber);
    }
}
