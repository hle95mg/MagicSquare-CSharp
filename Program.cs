using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int m = 1; m < 12; m++)
            {
                int odd = (2 * m) - 1;
                int retVal = createMagicSquareOdd(odd);
            }
        }

        static int createMagicSquareOdd(int n)
        {
            if (n <= 0) return -1;  // n <= 0 is invalid

            if (!(n % 2 == 1)) return -1;   //not odd

            int[,] arr = new int[n, n];

            //Now populate it
            int cells = n * n;
            int count = 0;

            int row = 0;
            int col = n / 2;

            int rowNext = 0;
            int colNext = 0;

            int val = 1;

            do
            {
                arr[row, col] = val++;
                count++;

                rowNext = row - 1;
                colNext = col + 1;

                if (rowNext < 0) rowNext = n + rowNext;
                if (colNext == n) colNext = 0;
                if (arr[rowNext,colNext] > 0)
                {
                    row = row + 1;  //go to next row
                }
                else
                {
                    row = rowNext;
                    col = colNext;
                }
            } while (count < cells);

            int sum = 0;
            for (int r = 0; r < n; r++)
            {
                string sRowMsg = "";
                for (int c = 0; c < n; c++)
                {
                    if (sRowMsg.Length > 0) sRowMsg += ",";
                   sRowMsg += arr[r, c];
                    if (r == 0) sum += arr[r, c];   //just do sum of cols in first row
                }
                Console.WriteLine(" {0}", sRowMsg);
            }

            Console.WriteLine("Sum of each row or column in above Magic Square {0}x{1} is {2}", n, n, sum);
            Console.WriteLine("");

            return 0;
        }
    }
}
