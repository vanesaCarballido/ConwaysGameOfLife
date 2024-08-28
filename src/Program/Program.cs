using System;

namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string content = Leer.LeerTablero("C:\Users\Isabela\Desktop\Repositorios\ConwaysGameOfLife\assets\board.txt");
            Matriz.CrearTablero(content);
            
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
