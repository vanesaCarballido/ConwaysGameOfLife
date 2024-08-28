using System;

namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string tablero01= Leer.LeerTablero("C:\Users\Isabela\Desktop\Repositorios\ConwaysGameOfLife\assets\board.txt");
            bool [,] tableroTrueFalse = Matriz.CrearTablero(tablero01);
            for (int i = 0; i <= 10; i++)
            {
                Lógica.Jugar(tableroTrueFalse);
                
                
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
