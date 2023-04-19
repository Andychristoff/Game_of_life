using System;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
           bool[,] tablero= Importador.importatablero(@"../../assets/board.txt");
           Impresortablero.impresortablero(tablero);
        }
    }
}
