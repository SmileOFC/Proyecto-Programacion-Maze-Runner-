using Spectre;
public class Interfaz
{

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
        Console.WriteLine("");

        for (int i = 0; i < Tablero.filas; i++)
        {
            Console.Write("     ");

            for (int j = 0; j < Tablero.columnas; j++)
            {



                // PLAYERS

                if (Tablero.laberinto[i, j] == 21 && Tablero.niebla[i, j] == false)
                {
                    Console.Write("P1");
                }
                if (Tablero.laberinto[i, j] == 22 && Tablero.niebla[i, j] == false)
                {
                    Console.Write("P2");
                }
                if (Tablero.laberinto[i, j] == 23 && Tablero.niebla[i, j] == false)
                {
                    Console.Write("P3");
                }
                if (Tablero.laberinto[i, j] == 24 && Tablero.niebla[i, j] == false)
                {
                    Console.Write("P4");
                }
                if (Tablero.laberinto[i, j] == 25 && Tablero.niebla[i, j] == false)
                {
                    Console.Write("P5");
                }
                if (Tablero.laberinto[i, j] == 26 && Tablero.niebla[i, j] == false)
                {
                    Console.Write("P6");
                }
                if (Tablero.laberinto[i, j] == 27 && Tablero.niebla[i, j] == false)
                {
                    Console.Write("P7");
                }
                if (Tablero.laberinto[i, j] == 28 && Tablero.niebla[i, j] == false)
                {
                    Console.Write("P8");
                }
                if (Tablero.laberinto[i, j] == 29 && Tablero.niebla[i, j] == false)
                {
                    Console.Write("P9");
                }
                if (Tablero.laberinto[i, j] == 20 && Tablero.niebla[i, j] == false)
                {
                    Console.Write("PP");
                }

                // TRAMPAS

                if (Tablero.laberinto[i, j] == 31 && Tablero.niebla[i, j] == false)
                    Console.Write("T1");



                if (Tablero.laberinto[i, j] == 32 && Tablero.niebla[i, j] == false)
                    Console.Write("T2");

                if (Tablero.laberinto[i, j] == 33 && Tablero.niebla[i, j] == false)
                    Console.Write("T3");

                if (Tablero.laberinto[i, j] == 34 && Tablero.niebla[i, j] == false)
                    Console.Write("T4");


                // BUFF

                if (Tablero.laberinto[i, j] == 41 && Tablero.niebla[i, j] == false)
                {
                    Console.Write("B1");
                }
                if (Tablero.laberinto[i, j] == 42 && Tablero.niebla[i, j] == false)
                {
                    Console.Write("B2");
                }
                if (Tablero.laberinto[i, j] == 43 && Tablero.niebla[i, j] == false)
                {
                    Console.Write("B3");
                }

                // LABERINTO

                if (Tablero.laberinto[i, j] == 1 && Tablero.niebla[i, j] == false)
                {
                    Console.Write("  ");
                }
                if (Tablero.laberinto[i, j] == 0 && Tablero.niebla[i, j] == false)
                {
                    Console.Write("██");
                }

                // META

                if (Tablero.laberinto[i, j] == 5 && Tablero.niebla[i, j] == false)
                {
                    Console.Write("  ");
                }
                if (Tablero.laberinto[i, j] == 55 && Tablero.niebla[i, j] == false)
                {
                    Console.Write("[]");
                }

                // NIEBLA

                if (Tablero.niebla[i, j] == true)
                    Console.Write("██");
            }

            // Layout Pendiente //////////////

            Console.WriteLine();
        }
    }
}