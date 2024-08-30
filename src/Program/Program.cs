using System;

namespace Ucu.Poo.GameOfLife
{
    /*Esta rama crea la parte lógica del juego, creando a partir de todas las especificaciones para una célula un nuevo tablero el cual
     luego se imprimirá*/
        bool[,] gameBoard =  /* contenido del tablero */;
        int boardWidth = gameBoard.GetLength(0); //obteiene las dimensiones del tablero
        int boardHeight = gameBoard.GetLength(1);

        bool[,] cloneboard = new bool[boardWidth, boardHeight]; //crea un nuevo board con las mismas medidas que el anterior
            
        for (int x = 0; x<boardWidth; x++) //recorre el tablero
        {
            for (int y = 0; y < boardHeight; y++)
            {
                int aliveNeighbors = 0;
                for (int i = x - 1; i <= x + 1; i++)
                {
                    for (int j = y - 1; j <= y + 1; j++)
                    {
                        if (i >= 0 && i < boardWidth && j >= 0 && j < boardHeight && gameBoard[i, j]) //calcula si tiene más vecinos vivos y los va sumando
                        {
                            aliveNeighbors++;
                        }
                    }
                }
                //a partir de acá es la lógica del juego:
                //resta 1 vecino:
                if (gameBoard[x, y]) 
                {
                    aliveNeighbors--;
                }

                //Celula muere por baja población
                if (gameBoard[x, y] && aliveNeighbors < 2)
                {
                    cloneboard[x, y] = false;
                }
                //Celula muere por sobrepoblación:
                else if (gameBoard[x, y] && aliveNeighbors > 3)
                {
                    cloneboard[x, y] = false;
                }
                //Celula nace por reproducción:
                else if (!gameBoard[x, y] && aliveNeighbors == 3)
                {
                    cloneboard[x, y] = true;
                }
                //Celula mantiene el estado que tenía:
                else
                {
                    cloneboard[x, y] = gameBoard[x, y];
                }
            }
        }
        gameBoard = cloneboard; //iguala el board original con el nuevo, con el juego
    }

