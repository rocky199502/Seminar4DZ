using System;
//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
namespace DZ1
{
    class Program
    {
        static double[] vvod()
        {
            Console.WriteLine("Введите числа А и В через запятую: ");
            string[] massiv =Console.ReadLine().Split(',');
            double[] massivInt = new double[2];
            for (int i =0;i<massiv.Length;i++)
            {
               massivInt[i]=double.Parse(massiv[i]);
            }
            return massivInt; 
        }
        static double degree (double[] massiv)
        {
             double result = Math.Pow(massiv[0],massiv[1]);
             return result;
        }
        static void Main(string[] args)
        {
             double[] mas = vvod();
             double Res = degree(mas);
             Console.WriteLine("Число А в степени В равно: "+Res);
        }
    }
}
