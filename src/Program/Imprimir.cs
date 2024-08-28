using System.Text;
namespace Ucu.Poo.GameOfLife;

public class Imprimir
{
   public static void ImprimirTablero()
   {
      bool[,] b = //variable que representa el tablero
      int width = //variabe que representa el ancho del tablero
      int height = //variabe que representa altura del tablero
      while (true)
      {
         Console.Clear();
         StringBuilder s = new StringBuilder();
         for (int y = 0; y<height;y++)
         {
            for (int x = 0; x<width; x++)
            {
               if(b[x,y])
               {
                  s.Append("|X|");
               }
               else
               {
                  s.Append("___");
               }
            }
            s.Append("\n");
         }
         Console.WriteLine(s.ToString());
         Lógica.Jugar();
         Thread.Sleep(300);
      }
   }
}