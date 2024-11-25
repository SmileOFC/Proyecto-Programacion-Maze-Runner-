
public class Tablero
{
    public static Random rand = new Random();
    public static int filas = 31, columnas = 31;

    public static bool[,] Puntero = new bool[filas, columnas];
    public static int[,] laberinto = new int[filas, columnas];

    public static bool[,] niebla = new bool[filas, columnas];

    static List<(int, int, int, int)> paredes = new List<(int, int, int, int)>();

    public static void GenerarTablero()
    {
        int x = 1, y = 1;
        laberinto[x, y] = 1;
        AgregarParedes(x, y);

        while (paredes.Count > 0)
        {
            int indice = rand.Next(paredes.Count);
            var (px, py, cx, cy) = paredes[indice];
            paredes.RemoveAt(indice);

            if (laberinto[cx, cy] == 0)
            {
                laberinto[px, py] = 1;
                laberinto[cx, cy] = 1;
                AgregarParedes(cx, cy);
            }
        }

        //WIN
        laberinto[15, 15] = 55;
        laberinto[14, 14] = 5;
        laberinto[14, 15] = 5;
        laberinto[14, 16] = 5;
        laberinto[15, 14] = 5;
        laberinto[15, 16] = 5;
        laberinto[16, 14] = 5;
        laberinto[16, 15] = 5;
        laberinto[16, 16] = 5;

        //Players

        List<int> Fichas = new List<int>(Picks.Fichas.ToArray());
        int Cont = 0;

        // modo 1v1 
        if (Modo.Juego)
        {

            while (Picks.Fichas.Count > 0)
            {

                if (Cont != 6)
                {
                    if (Cont == 0)
                        laberinto[1, 1] = Fichas[Cont];

                    if (Cont == 1)
                        laberinto[1, 15] = Fichas[Cont];

                    if (Cont == 2)
                        laberinto[1, 29] = Fichas[Cont];

                    if (Cont == 3)
                        laberinto[29, 1] = Fichas[Cont];

                    if (Cont == 4)
                        laberinto[29, 15] = Fichas[Cont];

                    if (Cont == 5)
                        laberinto[29, 29] = Fichas[Cont];
                    Cont++;
                }
                else break;

            }

        }
        else
        { // modo 2vs2

            while (Picks.Fichas.Count > 0)
            {

                if (Cont < 8)
                {
                    if (Cont == 0)
                        laberinto[1, 1] = Fichas[Cont];

                    if (Cont == 1)
                        laberinto[1, 15] = Fichas[Cont];

                    if (Cont == 2)
                        laberinto[1, 29] = Fichas[Cont];

                    if (Cont == 3)
                        laberinto[15, 1] = Fichas[Cont];

                    if (Cont == 4)
                        laberinto[29, 1] = Fichas[Cont];

                    if (Cont == 5)
                        laberinto[29, 15] = Fichas[Cont];

                    if (Cont == 6)
                        laberinto[29, 29] = Fichas[Cont];

                    if (Cont == 7)
                        laberinto[15, 29] = Fichas[Cont];
                    Cont++;
                }
                else break;
            }
        }

        // Trampas

        for (int i = 1; i < filas; i++)
        {
            for (int j = 1; j < columnas; j++)
            {

                if (laberinto[i, j] == 1)
                {
                    Cont++;
                    if (Cont == 20)
                    {
                        int a = rand.Next(31, 34);
                        laberinto[i, j] = a;
                        Cont = 0;
                    }
                }


            }
        }

        //Buff

        for (int i = 1; i < filas; i++)
        {
            for (int j = 1; j < columnas; j++)
            {

                if (laberinto[i, j] == 1)
                {
                    Cont++;
                    if (Cont == 30)
                    {
                        int a = rand.Next(41, 44);
                        laberinto[i, j] = a;
                        Cont = 0;
                    }
                }


            }
        }

        // Generar Niebla

        for (int i = 1; i < 30; i++)
        {
            for (int j = 1; j < 30; j++)
                if (Tablero.laberinto[i, j] != 21 || Tablero.laberinto[i, j] != 22 || Tablero.laberinto[i, j] != 23 || Tablero.laberinto[i, j] != 24 || Tablero.laberinto[i, j] != 25 || Tablero.laberinto[i, j] != 26 || Tablero.laberinto[i, j] != 27 || Tablero.laberinto[i, j] != 28 || Tablero.laberinto[i, j] != 29 || Tablero.laberinto[i, j] != 20)
                    niebla[i, j] = true;
        }

        // Quitar Niebla inicial

        for (int i = 1; i < 30; i++)
        {
            for (int j = 1; j < 30; j++)
                if (Tablero.laberinto[i, j] == 21 || Tablero.laberinto[i, j] == 22 || Tablero.laberinto[i, j] == 23 || Tablero.laberinto[i, j] == 24 || Tablero.laberinto[i, j] == 25 || Tablero.laberinto[i, j] == 26 || Tablero.laberinto[i, j] == 27 || Tablero.laberinto[i, j] == 28 || Tablero.laberinto[i, j] == 29 || Tablero.laberinto[i, j] == 20)
                    UpdateNiebla(Tablero.laberinto[i, j], i, j);
        }
    }

    static void AgregarParedes(int x, int y)
    {

        if (x > 1)
            paredes.Add((x - 1, y, x - 2, y));
        if (x < filas - 2)
            paredes.Add((x + 1, y, x + 2, y));
        if (y > 1)
            paredes.Add((x, y - 1, x, y - 2));
        if (y < columnas - 2)
            paredes.Add((x, y + 1, x, y + 2));
    }

    public static void UpdateNiebla(int p, int x, int y)
    {

        int v = Program.Player[p].Vision;
        for (int i = x - v; i <= x + v; i++)
        {
            for (int j = y - v; j <= y + v; j++)
            {

                if (i < 30 && i >= 0 && j < 30 && j >= 0)
                    niebla[i, j] = false;

            }
        }
    }

    //NPC
    //Cofres
    //Coins
    //Vendedor
    //LLaves


}

