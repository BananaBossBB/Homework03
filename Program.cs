using System;

public class Program
{
    public static void Main(string[] args)
    {
        string operation = Console.ReadLine();

        if(operation == "+" || operation == "-")
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            
            float[,] sizeMatrix1 = new float[m,n];

            for(int i = 0;i < m; i++)
            {
                for(int j = 0;j < n;j++)
                {
                    sizeMatrix1[i,j] = float.Parse(Console.ReadLine());
                }
            }

            float[,] sizeMatrix2 = new float[m,n];

            for(int i = 0;i < m; i++)
            {
                for(int j = 0;j < n;j++)
                {
                    sizeMatrix2[i,j] = float.Parse(Console.ReadLine());
                }
            }

            for(int i = 0;i < m; i++)
            {
                for(int j = 0;j < n;j++)
                {
                    if(operation == "+")
                    {
                        float matrix = sizeMatrix1[i,j] + sizeMatrix2[i,j];
                        Console.Write("{0} ",matrix);
                    }
                    else
                    {
                        float matrix = sizeMatrix1[i,j] - sizeMatrix2[i,j];
                        Console.Write("{0} ",matrix);
                    }
                }
                Console.WriteLine("");
            }
        }
        else
        {

        }
    }
}
