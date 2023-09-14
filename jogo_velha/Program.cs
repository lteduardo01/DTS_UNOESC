using System;

class Program
{
    static char[,] board = new char[3, 3];
    static char currentPlayer = 'X';
    static bool gameOver = false;
    static int moves = 0;

    static void Main()
    {
        InitializeBoard();
        while (!gameOver)
        {
            PrintBoard();
            PlayMove();
            CheckForWin();
            CheckForDraw();
            ChangePlayer();
        }
        Console.ReadLine();
    }

    static void InitializeBoard()
    {
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                board[i, j] = ' ';
    }

    static void PrintBoard()
    {
        Console.Clear();
        Console.WriteLine("  0 1 2");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(i + " ");
            for (int j = 0; j < 3; j++)
            {
                Console.Write(board[i, j]);
                if (j < 2)
                    Console.Write("|");
            }
            Console.WriteLine();
            if (i < 2)
                Console.WriteLine("  -+-+-");
        }
    }

    static void PlayMove()
    {
        Console.WriteLine($"Jogador {currentPlayer}, é sua vez.");
        bool validMove = false;
        while (!validMove)
        {
            Console.Write("Informe a linha: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Informe a coluna: ");
            int col = int.Parse(Console.ReadLine());
            if (row >= 0 && row < 3 && col >= 0 && col < 3 && board[row, col] == ' ')
            {
                board[row, col] = currentPlayer;
                validMove = true;
                moves++;
            }
            else
            {
                Console.WriteLine("Movimento inválido. Tente novamente.");
            }
        }
    }

    static void CheckForWin()
    {
        if (CheckRows() || CheckColumns() || CheckDiagonals())
        {
            PrintBoard();
            Console.WriteLine($"Jogador {currentPlayer} venceu!");
            gameOver = true;
        }
    }

    static bool CheckRows()
    {
        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] == currentPlayer && board[i, 1] == currentPlayer && board[i, 2] == currentPlayer)
                return true;
        }
        return false;
    }

    static bool CheckColumns()
    {
        for (int j = 0; j < 3; j++)
        {
            if (board[0, j] == currentPlayer && board[1, j] == currentPlayer && board[2, j] == currentPlayer)
                return true;
        }
        return false;
    }

    static bool CheckDiagonals()
    {
        if ((board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer) ||
            (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer))
            return true;
        return false;
    }

    static void CheckForDraw()
    {
        if (moves == 9)
        {
            PrintBoard();
            Console.WriteLine("O jogo terminou em empate!");
            gameOver = true;
        }
    }

    static void ChangePlayer()
    {
        currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
    }
}
