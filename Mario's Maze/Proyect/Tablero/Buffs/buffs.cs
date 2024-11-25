
public class Bufss
{
    public static void Buff(int x, int p, int bx, int by, int px, int py)
    {

        if (x == 41) // Hongo
        {
            Tablero.laberinto[px, py] = 1;
            Tablero.laberinto[bx, by] = p;

            Program.Player[p].BufPasos = true;
            Program.Player[p].Pasos = Program.Player[p].Pasos + 11;


        }

        if (x == 42) // Estrella
        {

            Tablero.laberinto[px, py] = 1;
            Tablero.laberinto[bx, by] = p;
            Program.Player[p].Inmune = true;

        }


        if (x == 43) // Gafas
        {

            Tablero.laberinto[px, py] = 1;
            Tablero.laberinto[bx, by] = p;
            Program.Player[p].BufVision = true;
            Program.Player[p].Vision = Program.Player[p].Vision + 2;

        }

        if (x == 44)
        { // coins



        }

        if (x == 45)
        { // llave


        }

    }

}