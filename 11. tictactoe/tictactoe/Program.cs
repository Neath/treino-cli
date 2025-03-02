using System;

namespace tictactoe
{
    class Program
    {
        static string Player;
        static string Num = "";
        static string[,] aux = new string[3, 3];
        static bool IsValid;

        static void Init()
        {
            Player = "X";
            int cont = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    aux[i, j] = cont.ToString();
                    cont++;
                }
            }
        }

        static void SetPlayer()
        {
            if (Player == "X")
            {
                Player = "O";
            }
            else
            {
                Player = "X";
            }
        }

        static void DrawBoard()
        {
            Console.WriteLine("+---+---+---+");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("|  " + aux[i, j]);
                }
                Console.Write("|");
                Console.WriteLine();
                Console.WriteLine("+---+---+---+");
            }
        }

        static bool ValidCheck(string number)
        {
            bool changed = false;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (aux[i, j] == number)
                    {
                        aux[i, j] = Player;
                        changed = true;
                    }
                }
            }
            return changed;
        }

        static bool FinishGame()
        {
            bool end = false;
            int num = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    //Ganhar na vertical
                    if (aux[i, 0] == aux[i, 1] && aux[i, 1] == aux[i, 2])
                        end = true;

                    //Ganhar na horizontal
                    if (aux[0, j] == aux[1, j] && aux[1, j] == aux[2, j])
                        end = true;

                    //Ganhar na diagonal
                    if (aux[0, 0] == aux[1, 1] && aux[1, 1] == aux[2, 2])
                        end = true;
                    if (aux[0, 2] == aux[1, 1] && aux[1, 1] == aux[2, 0])
                        end = true;

                    //VELHA (Empate)
                    if (aux[i, j] != "X" && aux[i, j] != "O")
                        num++;
                }
            }

            if (num == 0)
                end = true;

            return end;
        }

        static void Main(string[] args)
        {
            Init();
            DrawBoard();

            do
            {
                do
                {
                    Console.WriteLine("Vai jogar [" + Player + "] em qual posição?");
                    Num = Console.ReadLine();
                    IsValid = ValidCheck(Num);
                    if (IsValid == false)
                        Console.WriteLine("POSIÇÃO INVÁLIDA!");
                } while (IsValid == false);
                SetPlayer();
                Console.Clear();
                DrawBoard();

            } while (FinishGame() == false);
            Console.WriteLine("JOGO FINALIZADO! ");
        }
    }
}
