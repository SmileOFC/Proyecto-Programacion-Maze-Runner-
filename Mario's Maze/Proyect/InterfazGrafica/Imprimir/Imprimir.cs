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

    public static void Imprimir(int x)
    {

        Console.WriteLine("");



        for (int i = 0; i < Tablero.filas; i++)
        {
            Console.Write("    ");

            for (int j = 0; j < Tablero.columnas; j++)
            {

                // PLAYERS

                if (Tablero.laberinto[i, j] == 20 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                    AnsiConsole.Markup("[red1]█[/]" + "[blue3]█[/]");

                if (Tablero.laberinto[i, j] == 21 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                    AnsiConsole.Markup("█" + "[green3]█[/]");

                if (Tablero.laberinto[i, j] == 22 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                    AnsiConsole.Markup("[red1]█[/]" + "█");

                if (Tablero.laberinto[i, j] == 23 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                    AnsiConsole.Markup("█" + "[green1]█[/]");

                if (Tablero.laberinto[i, j] == 24 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                    AnsiConsole.Markup("[hotpink]█[/]" + "[yellow1]█[/]");



                if (Tablero.laberinto[i, j] == 25 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                    AnsiConsole.Markup("[red1]█[/]" + "[green3]█[/]");

                if (Tablero.laberinto[i, j] == 26 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                    AnsiConsole.Markup("[orange4_1]█[/]" + "█");

                if (Tablero.laberinto[i, j] == 27 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                    AnsiConsole.Markup("[green1]█[/]" + "█");

                if (Tablero.laberinto[i, j] == 28 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                    AnsiConsole.Markup("█" + "[purple4]█[/]");

                if (Tablero.laberinto[i, j] == 29 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                    AnsiConsole.Markup("[yellow1]█[/]" + "[purple4]█[/]");

                // TRAMPAS

                if (Tablero.laberinto[i, j] == 31 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                {
                    if (TrampaVisibleF.Count == 0)
                    {

                        Console.Write("T1");
                    }
                    else
                    {

                        if (TrampaVisibleF.ContainsKey(i) && TrampaVisibleC.ContainsKey(j))
                        {

                            AnsiConsole.Markup("[red1]█[/]" + "[red1]█[/]");

                        }
                        else Console.Write("  ");

                    }
                }

                if (Tablero.laberinto[i, j] == 32 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                {
                    if (TrampaVisibleF.Count == 0)
                    {

                        Console.Write("T2");
                    }
                    else
                    {

                        if (TrampaVisibleF.ContainsKey(i) && TrampaVisibleC.ContainsKey(j))
                        {

                            AnsiConsole.Markup("[red1]█[/]" + "[red1]█[/]");

                        }
                        else Console.Write("  ");

                    }
                }

                if (Tablero.laberinto[i, j] == 33 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                {
                    if (TrampaVisibleF.Count == 0)
                    {

                        Console.Write("T3");
                    }
                    else
                    {

                        if (TrampaVisibleF.ContainsKey(i) && TrampaVisibleC.ContainsKey(j))
                        {

                            AnsiConsole.Markup("[red1]█[/]" + "[red1]█[/]");

                        }
                        else Console.Write("  ");

                    }
                }

                if (Tablero.laberinto[i, j] == 35 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                    AnsiConsole.Markup("[grey on black]▌▌[/]");

                // BUFF

                if (Tablero.laberinto[i, j] == 41 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                {
                    Console.Write("B1");
                }
                if (Tablero.laberinto[i, j] == 42 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                {
                    Console.Write("B2");
                }
                if (Tablero.laberinto[i, j] == 43 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                {
                    Console.Write("B3");
                }

                // LABERINTO

                if (Tablero.laberinto[i, j] == 1 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                {
                    AnsiConsole.Markup("[rosybrown]██[/]");
                }
                if (Tablero.laberinto[i, j] == 0 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                {
                    AnsiConsole.Markup("[darkgreen]██[/]");
                }

                // META

                if (Tablero.laberinto[i, j] == 111 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                {

                    AnsiConsole.Markup("[orange4_1]█[/]" + "[blue3]█[/]");

                }

                if (Tablero.laberinto[i, j] == 121 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                {

                    AnsiConsole.Markup("[orange4_1]█[/]" + "[red1]█[/]");

                }

                if (Tablero.laberinto[i, j] == 5 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                {
                    AnsiConsole.Markup("[red1]█[/]" + "█");
                }


                // Coins 

                if (Tablero.laberinto[i, j] == 2 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                {

                    AnsiConsole.Markup("[yellow1]█[/]" + "[yellow1]█[/]");

                }
                //Llaves

                if (Tablero.laberinto[i, j] == 323 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                {

                    AnsiConsole.Markup("[red1]█[/]" + "[yellow1]█[/]");

                }

                if (Tablero.laberinto[i, j] == 313 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                {

                    AnsiConsole.Markup("[blue3]█[/]" + "[yellow1]█[/]");

                }

                //Cofres

                if (Tablero.laberinto[i, j] == 6 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false) // comun
                {

                    AnsiConsole.Markup("[blue3]██[/]");

                }

                if (Tablero.laberinto[i, j] == 7 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false) // epico
                {

                    AnsiConsole.Markup("[purple4]██[/]");

                }

                if (Tablero.laberinto[i, j] == 8 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false) // legendario
                {

                    AnsiConsole.Markup("[red1]██[/]");

                }

                // Puentes

                if (Tablero.laberinto[i, j] == 51 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false) 
                {

                    AnsiConsole.Markup("[orange4_1]██[/]");

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

            // Layout Pendiente //////////////

            Console.WriteLine();
        }
    }
}