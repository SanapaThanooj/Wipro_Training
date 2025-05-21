System;
using System.Collections.Generic;


namespace Algorithm
{
    class NQueen
    {
        public static void NQueensAlgo(int n)
        {
            char[,] board = new char[n, n];
            for(int i=0; i<n; i++)
            {
               for(int j=0; j<n; j++)
                {
                    board[i, j] = '.';
                }
            }

            List<char[,]> solutions = new List<char[,]>();
            PlaceQueens(board, 0, n, solutions);

            Console.WriteLine($"Total Solutions for N = {n} : {solutions.Count}\n");

            foreach (var solution in solutions)
            {

                PrintBoard(solution, n);
                Console.WriteLine();
            }
        }

        public static void PlaceQueens(char[,] board, int row, int n, List<char[,]> solutions)
        {
            if(row == n)
            {
                Char[,] copy = new char[n, n];
                Array.Copy(board, copy, board.Length);
                solutions.Add(copy);
                return;

            }

            for(int col =0; col<n; col++)
            {
                if(IsSafe(board,row,col,n))
                {
                    board[row, col] = 'Q';
                    PlaceQueens(board, row + 1, n, solutions);
                    board[row, col] = '.';
                }
            }
        }

        public static bool IsSafe(char[,] board, int row,int col,int n)
        {
            for(int i=0;i<row; i++)
            {
                if (board[i, col] == 'Q')
                    return false;
            }

            for (int i = row - 1, j = col-1; i >= 0 && j >= 0; i--,j--)
            {
                if (board[i, j] == 'Q')
                    return false;
            }

            for (int i = row - 1, j = col+1; i >= 0 && j<n ; i--, j++)
            {
                if (board[i, j] == 'Q')
                    return false;
            }
            return true;
        }

        public static void PrintBoard(char[,] board, int n)
        {
            for(int i=0;i<n;i++)
            {
                for(int j=0; j<n; j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void Main()
        {
            Console.WriteLine("Enter Value of N:");
            int n = Convert.ToInt32(Console.ReadLine());
            NQueensAlgo(n);
        }
    }
}