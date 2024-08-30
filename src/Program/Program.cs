using System;

namespace Ucu.Poo.GameOfLife
{
    class Program 
    /*La clase program sirve para ir comunicandose con las otras clases y ramas,
     así puede ejecutar  el código sin tenerlo todo en la misma clase, primero lee el archivo, luego crea el tablero
     usando la clase tablero !!!!!!!!!1, luego invoca a la clase lógica y luego a la de imprimir para que se pueda visualizar*/
    
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Game of Life");
            string tablero01= Leer.LeerTablero("./board.txt"); //lee el archivo board que es el que tiene el tablero de 0´s y 1´s
            bool [,] tableroTrueFalse = Matriz.CrearTablero(tablero01); //crea el tablero a partir de los 0´s y 1´s cambiándolos por True o False
            int width = tableroTrueFalse.GetLength(0); //obtiene el ancho (dimensión 0) del tablero
            int height = tableroTrueFalse.GetLength(1);//obtiene la altura (dimensión 1) del tablero
            
            while (true)
            {
                tableroTrueFalse = Logica.Jugar(tableroTrueFalse);  //acá invoca a la clase lógica del juego para que comience
                Imprimir.imprimirTablero(tableroTrueFalse); //imprime el tablero para que se pueda visualizar el juego
            }

            
        }
    }
}
