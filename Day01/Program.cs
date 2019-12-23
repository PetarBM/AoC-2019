using System;

namespace DedMraz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines("../input.txt");
            int[] moduleFueles = new int[lines.Length];         
            int[] totalFuels = new int[lines.Length];
            int sum = 0;
            int totalSum = 0;

            for(int i = 0; i < lines.Length ;i++)
            {
                int fuel = int.Parse(lines[i]);             
                moduleFueles[i] = fuel / 3 - 2;
                totalFuels[i] = CalculateTotalFueles(fuel);
            }

            foreach (int moduleFuel in moduleFueles)
            {
                sum += moduleFuel; 
            }
      
            foreach(int totalFuel in totalFuels)
            {
                totalSum += totalFuel;
            }
         
            Console.WriteLine(sum);
            Console.WriteLine(totalSum);
        }
       
        static int CalculateTotalFueles(int fuel)
        {
            fuel = fuel / 3 - 2;
            if(fuel <= 0)
            {
                return 0;
            }
            return fuel + CalculateTotalFueles(fuel);
        }
    }
}
