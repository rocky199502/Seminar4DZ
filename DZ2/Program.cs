using System;
//Пользователь вводит 8 чисел. Поместите их в массив и распечатайте.
namespace DZ2
{
    class Program
    {
        static int[] vvod()
        {
            Console.WriteLine("Введите 8 чисел через запятую: ");
            string[] massiv =Console.ReadLine().Split(',');
            int[] massivInt = new int[8];
            for (int i =0;i<massiv.Length;i++)
              {
                 massivInt[i]=int.Parse(massiv[i]);
              }
            return massivInt; 
        }
        static void vivod (int[] massiv)
        {
          Console.Write("Массив: [");
          for (int i =0;i<massiv.Length;i++)
            {
               Console.Write(massiv[i]);
               if (i == massiv.Length-1)
                {
                   Console.Write("]");  
                }
               else Console.Write(", ");  
            }
        }
        static void Main(string[] args)
        {
            int[] mas = vvod();
            vivod(mas);
        }
    }
}
