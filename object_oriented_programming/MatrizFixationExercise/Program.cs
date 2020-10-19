using System;

namespace MatrizFixationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = Console.ReadLine().Split(' ');
            int M = int.Parse(vect[0]);
            int N = int.Parse(vect[1]);

            int[,] mat = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                vect = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(vect[j]);
                }
            }

            int chosenNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (mat[i, j] == chosenNumber)
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);

                        }
                        if (j < N - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);

                        }
                        if (i < M-1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);

                        }
                    }
                }
            }
        }
    }
}
