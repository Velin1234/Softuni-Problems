using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLenght = int.Parse(Console.ReadLine());
            int cakeArea = cakeWidth * cakeLenght;
            int piecesSize = 0;

            while (cakeArea > piecesSize)
            {
                var pieceSize = Console.ReadLine();
                if (pieceSize == "STOP")
                {
                    break;
                }
                piecesSize += Convert.ToInt32(pieceSize);

            }

            if (cakeArea > piecesSize)
            {
                int leftPieces = cakeArea - piecesSize;
                Console.WriteLine($"{leftPieces} pieces are left.");
            }
            else
            {
                int neededPieces = piecesSize - cakeArea;
                Console.WriteLine($"No more cake left! You need {neededPieces} pieces more.");
            }
        }
    }
}
