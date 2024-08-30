
using System;
using System.Text;
using System.Threading;
namespace Ucu.Poo.GameOfLife;

public class Imprimir
{
    /*Esta clase imprime el tablero luego de que este ya se haya ejecturado, es decir, limpia la consola, va imprimiento cada
     parte del tablero construido en lógica y tiene el tiempo en el que lo hace. Todo lo que es imprimir el tablero está acá, 
     la parte de crearlo y de jugarlo no*/
    public static void imprimirTablero(bool[,] board)
    {
        int width = board.GetLength(0); //obtiene el tamaño del tablero
        int height = board.GetLength(1);
        Console.Clear(); //limpia la consola
        StringBuilder s = new StringBuilder();
        for (int y = 0; y<height;y++) //recorre el board, y según lo que haya en esa posición es lo que imprime, si "|x|" o "___"
        {
            for (int x = 0; x<width; x++)
            {
                if(board[x,y])
                {
                    s.Append("|X|");
                }
                else
                {
                    s.Append("___");
                }
            }
            s.Append("\n"); //esta linea lo que hace es ir separando para que quede del tamaño del tablero y no en una sola linea"
        }

        Console.WriteLine(s.ToString());
        Thread.Sleep(300); //detiene el codigo cuando ya pasó ese tiempo
      
    }
}