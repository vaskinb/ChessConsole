using System;

namespace DemoChess
{
    class Program
    {
        //Implementation of a chess game
        static void Main(string[] args)
        {
            ChessRules.Chess chess = new ChessRules.Chess();
            while (true)
            {
                Console.WriteLine(chess.fen);
                Print(ChessToAscii(chess));
                foreach (string moves in chess.GetAllMoves())
                    Console.Write(moves + "\t");
                Console.WriteLine();
                Console.Write(">");
                string move = Console.ReadLine();
                if (move == " ") break;
                chess = chess.Move(move);
            }
        }

        //Drawing board in console
        static string ChessToAscii (ChessRules.Chess chess)
        {
            string text = "  +-----------------+\n";
            for (int y = 7; y >= 0; y--)
            {
                text += y + 1;
                text += " | ";
                for (int x = 0; x < 8; x++)
                    text += chess.GetFigureAt(x, y) + " ";
                text += "|\n";
            }
            text += "  + -----------------+\n";
            text += "    a b c d e f g h\n";
            return text;
        }

        //Painting chess symbols
        static void Print(string text)
        {
            ConsoleColor oldForeColor = Console.ForegroundColor;
            foreach (char x in text)
            {
                if (x >= 'a' && x <= 'z')
                    Console.ForegroundColor = ConsoleColor.Red;
                else if (x >= 'A' && x <= 'Z')
                    Console.ForegroundColor = ConsoleColor.White;
                else
                    Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(x);
            }
            Console.ForegroundColor = oldForeColor;
        }
    }
}
