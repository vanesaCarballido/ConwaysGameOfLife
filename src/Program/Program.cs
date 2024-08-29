using System;

namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string tablero01= Leer.LeerTablero("./board.txt");
            bool [,] tableroTrueFalse = Matriz.CrearTablero(tablero01);
            Imprimir.imprimirTablero(tableroTrueFalse);
            int width = tableroTrueFalse.GetLength(0);
            int height = tableroTrueFalse.GetLength(1);
            
            while (true)
            {
                tableroTrueFalse = Logica.Jugar(tableroTrueFalse);
                Imprimir.imprimirTablero(tableroTrueFalse);
            }

            /*
             * 1: Leo el archivo
             * 2: Creo el tablero
             * 3: Durante x tiradas
             *  4: Jugar
             *  5: Imprimir tablero
             */
        }
    }
}
