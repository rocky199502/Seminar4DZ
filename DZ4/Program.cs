using System;

namespace DZ4
{
    class Program
    {
        static int[] vvodRandom()
        {
          int[] massivRandom = new int[8];
         Random rand = new Random();
      for(int i =0;i<massivRandom.Length;i++)
      {
          massivRandom[i]= rand.Next(1,9);
          Console.WriteLine(massivRandom[i]);
      }
      return massivRandom;
  }
  static double srednee (int[] massiv)
  {
      double sum = 0;
      for(int i =0;i<massiv.Length;i++)
      {
          sum+=massiv[i];
      }
      double sr = Convert.ToDouble(sum/8);
      return sr;
  }
  static int max (int[] massiv)
  {
      int max = massiv[0];
      for(int i =0;i<massiv.Length;i++)
      {
          if (max<massiv[i])
          {
              max = massiv[i];
              
          }
      }
      return max;
  }
  static void chet (int[] massiv)
  {
      bool chet = false;
      for(int i =0;i<massiv.Length;i++)
      {
          if (massiv[i]%2==0)
          {
              chet = true;
          }
          else chet = false;
          if (chet == false)
          {
            Console.WriteLine("В массиве есть нечетное число!");
            break;
          }
          else if ((i == massiv.Length-1) & (chet==true)) 
          {
              Console.WriteLine("В массиве все числа четные!");
              
          }
      }
      
  } 
  static void sravn (int[] massiv)
  {
      bool sravn = false;
      for(int i =0;i < massiv.Length-1;i++)
      {
         if (massiv[i] < massiv[i+1])
                 {
                    sravn = true;
                 }
        else sravn = false;
        if (sravn == false)
          {
            Console.WriteLine("Числа идут не по возрастанию!");
            break;
          }
         else if ((i == massiv.Length-2) & (sravn==true)) 
          {
              Console.WriteLine("В массиве числа идут по возрастанию!");    
          }   
       }    
    }
        static void Main(string[] args)
        {
           int[] massiv = vvodRandom();
           double sredneeMassiva = srednee(massiv);
           Console.WriteLine("Среднее массива равно  "+sredneeMassiva);
           int maximum = max(massiv);
           Console.WriteLine("Максимальное число массива равно  "+maximum);
           chet(massiv);
           sravn(massiv);
        }
    }
}
