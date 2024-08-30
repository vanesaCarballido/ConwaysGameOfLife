/*Clases y responsabilidades:
Distribuimos las responsabilidades en cuatro clases diferentes: "Leer", "Matriz", "Lógica" e "Imprimir". 
La clase Leer tiene la responsabilidad de leer el archivo que contiene los valores iniciales de las células. 
Esta clase cumple con el principio SRP al tener una sola razón de cambio. Si tuviera distintos tipos de archivos
para leer podríamos editar esa clase y no afectaría a las demás. También cumpe con Expert porque conoce el url del 
archivo a leer por lo que es la clase óptima para cumplir esta responsabilidad. No colabora con ninguna clase.
La clase Matriz tiene la responsabilidad de crear el tablero a partir del archivo que retornó la clase Leer, por lo que
colabora con ella. Tiene una sola razón de cambio por lo que cumple con SRP y con Expert. Tiene la información 
necesaria que le permite cumplir con su responsabilidad (conocer el archivo que debe transformar).
La clase Lógica se encarga únicamente de calcular las nuevas generaciones (una única responsabilidad y razón de cambio). 
Colabora con la clase Matriz y tiene la información necesaria para cumplir su responsabilidad (conoce el tablero que 
se creó en la clase Matriz).
Por úlitmo la clase Imprimir se encarga de mostrar el tablero en consola. Hacer esta clase nos permite que si
tuviéramos que implementar nuevas formas de impresión podemos cambiar la clase con nuevos métodos o 
inventar nuevas clases (si es necesario por SRP) sin afectar el resto del funcionamiento de las clases restantes.
Cumple con Expert porque es la clase ideal para realizar esta responsabilidad ya que conoce cada tablero de cada
generación que va calculando la clase Lógica (por lo que colabora con ella).
*/

using System;

namespace Ucu.Poo.GameOfLife
{
    class Program 
    /*La clase Program ejecuta todas las responsabilidades de las clases en una sola.
     Primero lee el archivo (en clase Leer), luego crea el tablero (en clase Matriz), ejecuta el juego (en clase Lógica) y finalmente imprime el tablero para que se pueda visualizar (enn clase Imprimir).
    Estas últimas dos responsabilidades en un bucle while para que se puedan ir calculando las nuevas generaciones y mostrarlas en consola.*/
    
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Game of Life");
            string tablero01= Leer.LeerTablero("./board.txt"); //Lee el archivo board que es el que tiene el tablero de 0´s y 1´s
            bool [,] tableroTrueFalse = Matriz.CrearTablero(tablero01); //Crea el tablero a partir de los 0´s y 1´s cambiándolos por True o False           
            while (true)
            {
                tableroTrueFalse = Logica.Jugar(tableroTrueFalse);  //Calcula la nueva generación 
                Imprimir.imprimirTablero(tableroTrueFalse); //Imprime el tablero para que se puedan visualizar los ciclos de vida
            }

            
        }
    }
}
