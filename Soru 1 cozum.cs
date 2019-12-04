using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevAkademi2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] matrix = {{'a','a','a','b','a' },
                              { 'a','b','a','b','a' },
                              { 'a','a','a','c','a' } };
            int[,] colored = new int[3, 5];
            int n = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine(matrix[i, j]);

                    if (colored[i, j] == 0)
                    {
                        n++;
                        Console.WriteLine("n=" + n.ToString());
                        color(matrix, colored, i, j,n);
                    }
                }
            }

            Console.WriteLine(n);
            Console.ReadKey();
        }

        public static void color(char[,] matrix, int[,] colored, int i, int j,int n)
        {
            if (colored[i, j] == 1) return;
            colored[i, j] = 1;

            if (check(matrix,i,j,'r')) color(matrix, colored, i, j + 1,n);
            if (check(matrix, i, j, 'b')) color(matrix, colored, i + 1, j,n);

            if (check(matrix, i, j, 't')) color(matrix, colored, i - 1, j,n);
            if (check(matrix, i, j, 'l')) color(matrix, colored, i, j - 1,n);

            
            for (int m = 0; m < 3; m++)
            {
                for (int k = 0; k < 5; k++)
                {
                    Console.Write(colored[m, k]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("------");
        }

        public static bool check(char[,] matrix, int i,int j,char s)
            {
            if (i == 0 && s == 't') return false;
            else if (j == 0 && s == 'l') return false;
            else if (i == 2 && s == 'b') return false;
            else if (j == 4 && s == 'r') return false;

            else
            {
                switch (s)
                {
                    case 'r':
                        if (matrix[i, j] == matrix[i, j + 1]) return true;
                        break;
                    case 'l':
                        if (matrix[i, j] == matrix[i, j - 1])return true;
                        break;
                    case 't':
                        if (matrix[i, j] == matrix[i - 1, j]) return true;
                        break;
                    case 'b':
                        if (matrix[i, j] == matrix[i + 1, j]) return true;
                        break;


                }
                return false;
                
            }

        }
    }
}
