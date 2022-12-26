using System;
namespace Prog_TwoSum
{
    class Program
    {
        static void Main()
        {
            int[] mass = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int target = 8;
            for (int i = 0; i < mass.Length; i++)
            { for (int j = i+1; j < mass.Length; j++)
                {
                    if (mass[i] + mass[j] == target)
                        Console.WriteLine(mass[i]+ " ," + mass[j]);
                }    
            
            }
            Console.ReadLine();
        }
    }

}