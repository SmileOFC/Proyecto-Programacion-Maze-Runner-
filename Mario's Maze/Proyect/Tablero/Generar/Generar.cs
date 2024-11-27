
public class Tablero
{
    public static Random rand = new Random();
    public static int filas = 31, columnas = 31;
    static int Cont = 0;
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

        //Players

        List<int> Fichas = new List<int>(Picks.Fichas.ToArray());

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

        Cont = 0;

        // Llave

        int ab = rand.Next(1, 3);

        if (ab == 1)
        {

            laberinto[15, 1] = 313;
            laberinto[14, 1] = 1;
            laberinto[16, 1] = 1;
            laberinto[14, 2] = 1;
            laberinto[16, 2] = 1;
            laberinto[15, 2] = 1;

            laberinto[15, 29] = 323;
            laberinto[14, 29] = 1;
            laberinto[16, 29] = 1;
            laberinto[15, 28] = 1;
            laberinto[14, 28] = 1;
            laberinto[16, 28] = 1;

        }
        else
        {

            laberinto[15, 1] = 323;
            laberinto[14, 1] = 1;
            laberinto[16, 1] = 1;
            laberinto[14, 2] = 1;
            laberinto[16, 2] = 1;
            laberinto[15, 2] = 1;

            laberinto[15, 29] = 313;
            laberinto[14, 29] = 1;
            laberinto[16, 29] = 1;
            laberinto[15, 28] = 1;
            laberinto[14, 28] = 1;
            laberinto[16, 28] = 1;

        }

        // Trampas

        for (int i = 1; i < filas; i++)
        {
            for (int j = 1; j < columnas; j++)
            {

                if (laberinto[i, j] == 1)
                {
                    Cont++;
                    if (Cont == 25)
                    {
                        int a = rand.Next(31, 34);
                        laberinto[i, j] = a;
                        Cont = 0;
                    }
                }


            }
        }
        Cont = 0;

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
        Cont = 0;

        //Coins

        for (int i = 1; i < filas; i++)
        {
            for (int j = 1; j < columnas; j++)
            {

                if (laberinto[i, j] == 1)
                {
                    Cont++;
                    if (Cont == 10)
                    {

                        laberinto[i, j] = 2;
                        Cont = 0;
                    }
                }


            }
        }
        Cont = rand.Next(1, 30);

        // cofre comun

        for (int i = 5; i < filas - 5; i++)
        {
            for (int j = 5; j < columnas - 5; j++)
            {

                if (laberinto[i, j] == 1)
                {
                    Cont++;
                    if (Cont == 30)
                    {

                        laberinto[i, j] = 6;
                        Cont = 0;
                    }
                }


            }
        }
        Cont = rand.Next(1, 20);

        // cofre epico

        for (int i = 6; i < filas - 6; i++)
        {
            for (int j = 6; j < columnas - 6; j++)
            {

                if (laberinto[i, j] == 1)
                {
                    Cont++;
                    if (Cont == 20)
                    {

                        laberinto[i, j] = 7;
                        Cont = 0;
                    }
                }


            }
        }
        Cont = rand.Next(1, 20);

        // cofre legendario

        for (int i = 9; i < filas - 9; i++)
        {
            for (int j = 9; j < columnas - 9; j++)
            {

                if (laberinto[i, j] == 1)
                {
                    Cont++;
                    if (Cont == 20)
                    {

                        laberinto[i, j] = 8;
                        Cont = 0;
                    }
                }


            }
        }
        Cont = 0;

        //WIN

        laberinto[11, 13] = 1;
        laberinto[12, 13] = 1;
        laberinto[13, 13] = 1;
        laberinto[14, 13] = 1;
        laberinto[15, 13] = 1;
        laberinto[16, 13] = 1;
        laberinto[17, 13] = 1;
        laberinto[18, 13] = 1;
        laberinto[19, 13] = 1;

        laberinto[11, 14] = 1;
        laberinto[12, 14] = 1;
        laberinto[13, 14] = 0;
        laberinto[14, 14] = 0;
        laberinto[15, 14] = 0;
        laberinto[16, 14] = 0;
        laberinto[17, 14] = 0;
        laberinto[18, 14] = 1;
        laberinto[19, 14] = 1;

        laberinto[11, 15] = 1;
        laberinto[12, 15] = 1;
        laberinto[14, 15] = 1;
        laberinto[15, 15] = 5;
        laberinto[16, 15] = 1;
        laberinto[18, 15] = 1;
        laberinto[19, 15] = 1;

        laberinto[11, 14] = 1;
        laberinto[12, 16] = 1;
        laberinto[13, 16] = 0;
        laberinto[14, 16] = 0;
        laberinto[15, 16] = 0;
        laberinto[16, 16] = 0;
        laberinto[17, 16] = 0;
        laberinto[18, 16] = 1;
        laberinto[19, 14] = 1;

        laberinto[11, 17] = 1;
        laberinto[12, 17] = 1;
        laberinto[13, 17] = 1;
        laberinto[14, 17] = 1;
        laberinto[15, 17] = 1;
        laberinto[16, 17] = 1;
        laberinto[17, 17] = 1;
        laberinto[18, 17] = 1;
        laberinto[19, 17] = 1;

        if (Program.Player[Tablero.laberinto[1, 1]].Equipo) // buenos arriba
        {

            laberinto[13, 15] = 111;
            laberinto[17, 15] = 121;

        }
        else
        {

            laberinto[13, 15] = 121;
            laberinto[17, 15] = 111;

        }

        // Generar Niebla

        for (int i = 1; i < 30; i++)
        {
            for (int j = 1; j < 30; j++)

                if (Tablero.laberinto[i, j] != 21 || Tablero.laberinto[i, j] != 22 || Tablero.laberinto[i, j] != 23 || Tablero.laberinto[i, j] != 24 || Tablero.laberinto[i, j] != 25 || Tablero.laberinto[i, j] != 26 || Tablero.laberinto[i, j] != 27 || Tablero.laberinto[i, j] != 28 || Tablero.laberinto[i, j] != 29 || Tablero.laberinto[i, j] != 20)
                    niebla[i, j] = false; ////////////////////////////////////////////////////////////////////
        }

        // Quitar Niebla inicial

        for (int i = 1; i < 30; i++)
        {
            for (int j = 1; j < 30; j++)

                if (Tablero.laberinto[i, j] == 21 || Tablero.laberinto[i, j] == 22 || Tablero.laberinto[i, j] == 23 || Tablero.laberinto[i, j] == 24 || Tablero.laberinto[i, j] == 25 || Tablero.laberinto[i, j] == 26 || Tablero.laberinto[i, j] == 27 || Tablero.laberinto[i, j] == 28 || Tablero.laberinto[i, j] == 29 || Tablero.laberinto[i, j] == 20)
                    UpdateNiebla(Tablero.laberinto[i, j], i, j);

        }

        /////////////////////////////////////////////////////////////////////////////////////////
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
    //Tienda




}

