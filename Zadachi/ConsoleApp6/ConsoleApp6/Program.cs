using System;

namespace ConsoleApp6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the knapsack: ");
            int W = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the weights of the items: ");
            int[] weights = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Console.WriteLine("Enter the values of the items: ");
            int[] values = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int n = weights.Length;
            int[,] dp = new int[n + 1, W + 1];

            for (int i = 1; i <= n; i++)
            {
                for (int w = 1; w <= W; w++)
                {
                    if (weights[i - 1] <= w)
                    {
                        dp[i, w] = Math.Max(values[i - 1] + dp[i - 1, w - weights[i - 1]], dp[i - 1, w]);
                    }
                    else
                    {
                        dp[i, w] = dp[i - 1, w];
                    }
                }
            }

            int maxValue = dp[n, W];
            Console.WriteLine("Value: " + maxValue);

            int remainingSpace = W;
            Console.Write("Items: ");
            for (int i = n; i > 0 && maxValue > 0; i--)
            {
                if (maxValue != dp[i - 1, remainingSpace])
                {
                    Console.Write(i + " ");
                    maxValue -= values[i - 1];
                    remainingSpace -= weights[i - 1];
                }
            }
            
            Console.WriteLine("\nRemaining Space: " + remainingSpace);
        }
    }
}

