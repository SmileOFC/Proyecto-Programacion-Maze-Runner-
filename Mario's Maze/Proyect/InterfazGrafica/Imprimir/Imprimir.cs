using Spectre.Console;

public class Interfaz
{
    public static void Imprimir()
    {
        // Definir el color blanco en RGB 
        var whiteColor = new Color(255, 255, 255);
        int Ancho = Console.WindowWidth;
        int Alto = Console.WindowHeight;

        for (int x = 0; x < Ancho; x++)
        {

            Console.SetCursorPosition(x, 0);
            AnsiConsole.Markup("[on cyan] [/]\n");

        }

        for (int i = 0; i < Tablero.filas; i++)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write("                  ");

            for (int j = 0; j < Tablero.columnas; j++)
            {

                // LABERINTO

                if (Tablero.laberinto[i, j] == 1 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                {
                    AnsiConsole.Markup("[lightsalmon3]██[/]");
                }

                if (Tablero.laberinto[i, j] == 1112 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                {
                    AnsiConsole.Markup("[lightsalmon3]██[/]");
                }




                if (Tablero.laberinto[i, j] == 0 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                {
                    AnsiConsole.Markup("[green on darkgreen]░░[/]");
                }

                if (Tablero.laberinto[i, j] == 1111 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                {
                    AnsiConsole.Markup("[green on darkgreen]░░[/]");
                }

                // META

                if (Tablero.laberinto[i, j] == 111 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                {
                    AnsiConsole.Markup("[orange4_1 on blue3]◘◘[/]");
                }

                if (Tablero.laberinto[i, j] == 121 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                {
                    AnsiConsole.Markup("[orange4_1 on red1]◘◘[/]");
                }

                if (Tablero.laberinto[i, j] == 5 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                {
                    AnsiConsole.Markup("[red1 on lightsalmon3]🚩[/]");
                }


                // PLAYERS

                if (Tablero.laberinto[i, j] == 20 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                    AnsiConsole.Markup("[red1]█[/]" + "[blue3]█[/]");

                if (Tablero.laberinto[i, j] == 21 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                    AnsiConsole.Markup($"[on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})] [/]" + "[green3]█[/]");

                if (Tablero.laberinto[i, j] == 22 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                    AnsiConsole.Markup("[red1]█[/]" + $"[on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})] [/]");

                if (Tablero.laberinto[i, j] == 23 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                    AnsiConsole.Markup($"[on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})] [/]" + "[green1]█[/]");

                if (Tablero.laberinto[i, j] == 24 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                    AnsiConsole.Markup("[hotpink]█[/]" + "[yellow1]█[/]");

                if (Tablero.laberinto[i, j] == 25 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                    AnsiConsole.Markup("[red1]█[/]" + "[green3]█[/]");

                if (Tablero.laberinto[i, j] == 26 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                    AnsiConsole.Markup("[orange4_1]█[/]" + $"[on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})] [/]");

                if (Tablero.laberinto[i, j] == 27 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                    AnsiConsole.Markup("[green1]█[/]" + $"[on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})] [/]");

                if (Tablero.laberinto[i, j] == 28 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                    AnsiConsole.Markup($"[on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})] [/]" + "[purple4]█[/]");

                if (Tablero.laberinto[i, j] == 29 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                    AnsiConsole.Markup("[yellow1]█[/]" + "[purple4]█[/]");

                // TRAMPAS

                if (Tablero.laberinto[i, j] == 31 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                {
                    AnsiConsole.Markup("[on lightsalmon3]  [/]");
                }

                if (Tablero.laberinto[i, j] == 32 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                {
                    AnsiConsole.Markup("[on lightsalmon3]  [/]");
                }

                if (Tablero.laberinto[i, j] == 33 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                {
                    AnsiConsole.Markup("[on lightsalmon3]  [/]");
                }

                // Reja

                if (Tablero.laberinto[i, j] == 35 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                    AnsiConsole.Markup("[black on lightsalmon3]■■[/]");

                // BUFF

                if (Tablero.laberinto[i, j] == 41 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                {
                    AnsiConsole.Markup("[black on lightsalmon3]🍄[/]");
                }
                if (Tablero.laberinto[i, j] == 42 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                {
                    AnsiConsole.Markup("[yellow on lightsalmon3]★ [/]");
                }
                if (Tablero.laberinto[i, j] == 43 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                {
                    AnsiConsole.Markup("[red1 on lightsalmon3]✿ [/]");
                }

                // Coins

                if (Tablero.laberinto[i, j] == 2 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                {
                    AnsiConsole.Markup("[yellow1 on lightsalmon3]💲[/]");
                }
                //Llaves

                if (Tablero.laberinto[i, j] == 323 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                {
                    AnsiConsole.Markup("[red1 on lightsalmon3]🔑[/]");
                }

                if (Tablero.laberinto[i, j] == 313 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                {
                    AnsiConsole.Markup("[blue3 on lightsalmon3]🔑[/]");
                }

                //Cofres

                if (Tablero.laberinto[i, j] == 6 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false) // comun
                {
                    AnsiConsole.Markup("[blue3 on orange4_1]▀▀[/]");
                }

                if (Tablero.laberinto[i, j] == 7 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false) // epico
                {
                    AnsiConsole.Markup("[purple4 on orange4_1]▀▀[/]");
                }

                if (Tablero.laberinto[i, j] == 8 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false) // legendario
                {
                    AnsiConsole.Markup("[red1 on orange4_1]▀▀[/]");
                }

                // Escalera arriba

                if (Tablero.laberinto[i, j] == 151 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                {
                    AnsiConsole.Markup("[orange4_1 on rosybrown]▀▀[/]");
                }

                // escalera abajo

                if (Tablero.laberinto[i, j] == 252 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                {
                    AnsiConsole.Markup("[orange4_1 on rosybrown]▄▄[/]");
                }

                // escalera izquierda

                if (Tablero.laberinto[i, j] == 353 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                {
                    AnsiConsole.Markup("[orange4_1 on rosybrown]▌ [/]");
                }

                // escalera derecha

                if (Tablero.laberinto[i, j] == 454 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                {
                    AnsiConsole.Markup("[orange4_1 on rosybrown] ▐[/]");
                }

                // NIEBLA

                if (Tablero.niebla[i, j] && Tablero.Puntero[i, j] == false)
                    AnsiConsole.Markup("[grey35 on grey70]░░[/]");

                // PUNTERO

                if (Tablero.Puntero[i, j])
                {
                    AnsiConsole.Markup($"[rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) on red1]✖️[/]");
                }
            }

            ////////////////////////// LAYOUT //////////////////////////

            if (i <= 5 || i > 24)
            {
                if (i == 3 || i == 4 || i == 5 || i == 2)
                {
                    if (i == 2)
                    {

                        for (int x = 80; x < Ancho; x++)
                        {
                            if (x >= 128)
                            {

                                AnsiConsole.Markup($"[on grey35] [/]");

                            }
                            else
                            {
                                Console.BackgroundColor = ConsoleColor.Cyan;
                                Console.Write(" ");
                            }


                        }
                        Console.WriteLine("");

                    }
                    else
                    {
                        for (int x = 80; x < Ancho; x++)
                        {
                            if (x == 135 || x == 136 || x == 145 || x == 146)
                            {
                                AnsiConsole.Markup($"[on grey50] [/]");
                            }
                            else
                            {
                                Console.BackgroundColor = ConsoleColor.Cyan;
                                Console.Write(" ");
                            }


                        }
                        Console.WriteLine("");
                    }

                }
                else
                {
                    for (int x = 80; x < Ancho; x++)
                    {

                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.Write(" ");

                    }
                    Console.WriteLine("");
                }
            }
            else
            {

                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.WriteLine("                                        ");

            }

        }



        //Centro
        for (int x = 7; x <= 24; x++) // fila
        {
            Console.SetCursorPosition(120, x);
            AnsiConsole.Markup($"[on orange4_1]  [/]");

            for (int y = 122; y < Ancho; y++) // columna //                                  //
            {

                Console.SetCursorPosition(y, x);
                if (y < 158)
                    AnsiConsole.Markup($"[on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})] [/]");
                else
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(" ");
                }
                if (y == 158)
                {
                    Console.SetCursorPosition(y, x);
                    AnsiConsole.Markup($"[on orange4_1]  [/]");
                    y++;
                }
            }

        }
        // Arriba
        for (int x = 120; x < Ancho; x++)
        {
            Console.SetCursorPosition(x, 6);
            if (x < 160)
            {

                AnsiConsole.Markup($"[on orange4_1] [/]");
            }
            else
            {

                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" ");
            }
        }
        // Abajo
        for (int x = 120; x < Ancho; x++)
        {
            Console.SetCursorPosition(x, 25);
            if (x < 160)
            {

                AnsiConsole.Markup($"[on orange4_1] [/]");
            }
            else
            {

                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" ");
            }
        }


        for (int x = 0; x < Ancho; x++)
        {

            Console.SetCursorPosition(x, 32);
            AnsiConsole.Markup("[on green] [/]");

        }
        for (int x = 0; x < Ancho;)
        {

            Console.SetCursorPosition(x, 33);
            AnsiConsole.Markup("[green on orange4_1] ▀[/]");
            x += 2;
        }
        for (int x = 0; x < Ancho; x++)
        {
            for (int y = 34; y < Alto - 10; y++)
            {

                Console.SetCursorPosition(x, y);
                AnsiConsole.Markup("[on orange4_1] [/]");

            }
        }
    }
}
