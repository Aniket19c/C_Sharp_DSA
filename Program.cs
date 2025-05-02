using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Solutions
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the height values separated by spaces:");
            string input = Console.ReadLine();

            int[] height = input.Split(' ')
                                .Where(s => !string.IsNullOrWhiteSpace(s))
                                .Select(int.Parse)
                                .ToArray();

            TrappedWater solution = new TrappedWater();
            int result = solution.Trap(height);

            Console.WriteLine($"Trapped water: {result}");
        }
    }
}
