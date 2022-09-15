using System;
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
namespace DZ3
{
    class Program
    {
        static int vvod()
        {
           Console.WriteLine("Введите число: ");
           int numberVvod = int.Parse(Console.ReadLine());
           return numberVvod;
        }
       static void vivod (int number)
       {
           int sum = 0;
           while (number > 0)
             {
                sum = sum + number % 10;
                number = number /10 ;
             }
          Console.Write("Сумма чисел = "+sum+";");       
       }
        static void Main(string[] args)
        {
            int number = vvod();
            vivod(number);
        }
    }
}
