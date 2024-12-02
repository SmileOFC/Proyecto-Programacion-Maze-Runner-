using Spectre.Console;

public class Interfaz
{
    public static Dictionary<int, bool> TrampaVisibleF = new Dictionary<int, bool>();
    public static Dictionary<int, bool> TrampaVisibleC = new Dictionary<int, bool>();

    public static string Tabs(string s)
    {
        int a = s.Count();
        string Tab = s;

        for (int x = 0; x < 22 - a; x++)
            Tab += " ";
        Tab += "|";

        return Tab;
    }

    public static void Imprimir(int Player)
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

                if (
                    Tablero.laberinto[i, j] == 1 || Tablero.laberinto[i, j] == 1112
                    && Tablero.niebla[i, j] == false
                    && Tablero.Puntero[i, j] == false
                )
                {
                    AnsiConsole.Markup("[rosybrown]██[/]");
                }
                if (
                    Tablero.laberinto[i, j] == 0
                    || Tablero.laberinto[i, j] == 1111
                        && Tablero.niebla[i, j] == false
                        && Tablero.Puntero[i, j] == false
                )
                {
                    AnsiConsole.Markup("[darkgreen]██[/]");
                }

                // META

                if (
                    Tablero.laberinto[i, j] == 111
                    && Tablero.niebla[i, j] == false
                    && Tablero.Puntero[i, j] == false
                )
                {
                    AnsiConsole.Markup("[orange4_1]█[/]" + "[blue3]█[/]");
                }

                if (
                    Tablero.laberinto[i, j] == 121
                    && Tablero.niebla[i, j] == false
                    && Tablero.Puntero[i, j] == false
                )
                {
                    AnsiConsole.Markup("[orange4_1]█[/]" + "[red1]█[/]");
                }

                if (
                    Tablero.laberinto[i, j] == 5
                    && Tablero.niebla[i, j] == false
                    && Tablero.Puntero[i, j] == false
                )
                {
                    AnsiConsole.Markup("[red1]█[/]" + $"[on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})] [/]"); 
                }


                // PLAYERS

                if (
                    Tablero.laberinto[i, j] == 20
                    && Tablero.niebla[i, j] == false
                    && Tablero.Puntero[i, j] == false
                )
                    AnsiConsole.Markup("[red1]█[/]" + "[blue3]█[/]");

                if (
                    Tablero.laberinto[i, j] == 21
                    && Tablero.niebla[i, j] == false
                    && Tablero.Puntero[i, j] == false
                )
                    AnsiConsole.Markup($"[on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})] [/]" + "[green3]█[/]");

                if (
                    Tablero.laberinto[i, j] == 22
                    && Tablero.niebla[i, j] == false
                    && Tablero.Puntero[i, j] == false
                )
                    AnsiConsole.Markup("[red1]█[/]" + $"[on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})] [/]");

                if (
                    Tablero.laberinto[i, j] == 23
                    && Tablero.niebla[i, j] == false
                    && Tablero.Puntero[i, j] == false
                )
                    AnsiConsole.Markup($"[on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})] [/]" + "[green1]█[/]");

                if (
                    Tablero.laberinto[i, j] == 24
                    && Tablero.niebla[i, j] == false
                    && Tablero.Puntero[i, j] == false
                )
                    AnsiConsole.Markup("[hotpink]█[/]" + "[yellow1]█[/]");

                if (
                    Tablero.laberinto[i, j] == 25
                    && Tablero.niebla[i, j] == false
                    && Tablero.Puntero[i, j] == false
                )
                    AnsiConsole.Markup("[red1]█[/]" + "[green3]█[/]");

                if (
                    Tablero.laberinto[i, j] == 26
                    && Tablero.niebla[i, j] == false
                    && Tablero.Puntero[i, j] == false
                )
                    AnsiConsole.Markup("[orange4_1]█[/]" + $"[on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})] [/]");

                if (
                    Tablero.laberinto[i, j] == 27
                    && Tablero.niebla[i, j] == false
                    && Tablero.Puntero[i, j] == false
                )
                    AnsiConsole.Markup("[green1]█[/]" + $"[on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})] [/]");

                if (
                    Tablero.laberinto[i, j] == 28
                    && Tablero.niebla[i, j] == false
                    && Tablero.Puntero[i, j] == false
                )
                    AnsiConsole.Markup($"[on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})] [/]" + "[purple4]█[/]");

                if (
                    Tablero.laberinto[i, j] == 29
                    && Tablero.niebla[i, j] == false
                    && Tablero.Puntero[i, j] == false
                )
                    AnsiConsole.Markup("[yellow1]█[/]" + "[purple4]█[/]");

                // TRAMPAS

                if (
                    Tablero.laberinto[i, j] == 31
                    && Tablero.niebla[i, j] == false
                    && Tablero.Puntero[i, j] == false
                )
                {
                    if (TrampaVisibleF.Count == 0)
                    {
                        AnsiConsole.Markup("T1");
                    }
                    else
                    {
                        if (TrampaVisibleF.ContainsKey(i) && TrampaVisibleC.ContainsKey(j))
                        {
                            AnsiConsole.Markup("[red1]██[/]");
                        }
                        else
                            AnsiConsole.Markup("T1");
                    }
                }

                if (
                    Tablero.laberinto[i, j] == 32
                    && Tablero.niebla[i, j] == false
                    && Tablero.Puntero[i, j] == false
                )
                {
                    if (TrampaVisibleF.Count == 0)
                    {
                        AnsiConsole.Markup("T2");
                    }
                    else
                    {
                        if (TrampaVisibleF.ContainsKey(i) && TrampaVisibleC.ContainsKey(j))
                        {
                            AnsiConsole.Markup("[red1]██[/]");
                        }
                        else
                            AnsiConsole.Markup("T2");
                    }
                }

                if (
                    Tablero.laberinto[i, j] == 33
                    && Tablero.niebla[i, j] == false
                    && Tablero.Puntero[i, j] == false
                )
                {
                    if (TrampaVisibleF.Count == 0)
                    {
                        AnsiConsole.Markup("T3"); 
                    }
                    else
                    {
                        if (TrampaVisibleF.ContainsKey(i) && TrampaVisibleC.ContainsKey(j))
                        {
                            AnsiConsole.Markup("[red1]██[/]");
                        }
                        else
                            AnsiConsole.Markup("T3");
                    }
                }

                if (
                    Tablero.laberinto[i, j] == 35
                    && Tablero.niebla[i, j] == false
                    && Tablero.Puntero[i, j] == false
                )
                    AnsiConsole.Markup("[black on rosybrown]■■[/]"); // █

                // BUFF

                if (
                    Tablero.laberinto[i, j] == 41
                    && Tablero.niebla[i, j] == false
                    && Tablero.Puntero[i, j] == false
                )
                {
                    AnsiConsole.Markup("[on rosybrown]  [/]");
                }
                if (
                    Tablero.laberinto[i, j] == 42
                    && Tablero.niebla[i, j] == false
                    && Tablero.Puntero[i, j] == false
                )
                {
                    AnsiConsole.Markup("[on rosybrown]  [/]");
                }
                if (
                    Tablero.laberinto[i, j] == 43
                    && Tablero.niebla[i, j] == false
                    && Tablero.Puntero[i, j] == false
                )
                {
                    AnsiConsole.Markup("[on rosybrown]  [/]");
                }

                // Coins

                if (
                    Tablero.laberinto[i, j] == 2
                    && Tablero.niebla[i, j] == false
                    && Tablero.Puntero[i, j] == false
                )
                {
                    AnsiConsole.Markup("[yellow1]█[/]" + "[yellow1]█[/]");
                }
                //Llaves

                if (
                    Tablero.laberinto[i, j] == 323
                    && Tablero.niebla[i, j] == false
                    && Tablero.Puntero[i, j] == false
                )
                {
                    AnsiConsole.Markup("[red1]█[/]" + "[yellow1]█[/]");
                }

                if (
                    Tablero.laberinto[i, j] == 313
                    && Tablero.niebla[i, j] == false
                    && Tablero.Puntero[i, j] == false
                )
                {
                    AnsiConsole.Markup("[blue3]█[/]" + "[yellow1]█[/]");
                }

                //Cofres

                if (
                    Tablero.laberinto[i, j] == 6
                    && Tablero.niebla[i, j] == false
                    && Tablero.Puntero[i, j] == false
                ) // comun
                {
                    AnsiConsole.Markup("[blue3]██[/]");
                }

                if (
                    Tablero.laberinto[i, j] == 7
                    && Tablero.niebla[i, j] == false
                    && Tablero.Puntero[i, j] == false
                ) // epico
                {
                    AnsiConsole.Markup("[purple4]██[/]");
                }

                if (
                    Tablero.laberinto[i, j] == 8
                    && Tablero.niebla[i, j] == false
                    && Tablero.Puntero[i, j] == false
                ) // legendario
                {
                    AnsiConsole.Markup("[red1]██[/]");
                }

                // Escalera arriba

                if (
                    Tablero.laberinto[i, j] == 151
                    && Tablero.niebla[i, j] == false
                    && Tablero.Puntero[i, j] == false
                )
                {
                    AnsiConsole.Markup("[orange4_1 on rosybrown]▀▀[/]");
                }

                // escalera abajo

                if (
                    Tablero.laberinto[i, j] == 252
                    && Tablero.niebla[i, j] == false
                    && Tablero.Puntero[i, j] == false
                )
                {
                    AnsiConsole.Markup("[orange4_1 on rosybrown]▄▄[/]");
                }

                // escalera izquierda

                if (
                    Tablero.laberinto[i, j] == 353
                    && Tablero.niebla[i, j] == false
                    && Tablero.Puntero[i, j] == false
                )
                {
                    AnsiConsole.Markup("[orange4_1 on rosybrown]▌ [/]");
                }

                // escalera derecha

                if (
                    Tablero.laberinto[i, j] == 454
                    && Tablero.niebla[i, j] == false
                    && Tablero.Puntero[i, j] == false
                )
                {
                    AnsiConsole.Markup("[orange4_1 on rosybrown] ▐[/]");
                }

                // NIEBLA

                if (Tablero.niebla[i, j] && Tablero.Puntero[i, j] == false)
                    AnsiConsole.Markup("[grey53]██[/]"); 

                // PUNTERO

                if (Tablero.Puntero[i, j])
                {
                    AnsiConsole.Markup("[red1]█[/]" + "[red1]█[/]");
                }
            }

            // Layout Pendiente ////////////// i => fila

            if (i < 5 || i > 24)
            {

                for (int x = 80; x < Ancho; x++)
                {

                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.Write(" ");

                }
                Console.WriteLine("");

            }
            else
            {

                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.WriteLine("                                        ");

            }
        }

        // Label

        for (int x = 7; x <= 24; x++) // fila
        {
            for (int y = 122; y < Ancho; y++ ) // columna
            {

                Console.SetCursorPosition(y,x);
                AnsiConsole.Markup($"[on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})] [/]");

            }
        }

        for (int x = 0; x < Ancho; x++)
        {

            Console.SetCursorPosition(x, 32);
            AnsiConsole.Markup("[on green] [/]");

        }
        for (int x = 0; x < Ancho; x++)
        {
            for (int y = 33; y < Alto - 10; y++)
            {

                Console.SetCursorPosition(x, y);
                AnsiConsole.Markup("[on orange4_1] [/]");

            }
        }


        /////////////////////////////////////////////////////////////////////////////////////////////


        /////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
