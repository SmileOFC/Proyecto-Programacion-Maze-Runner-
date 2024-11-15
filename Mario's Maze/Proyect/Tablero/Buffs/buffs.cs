
public class Bufss
{

    public static void ActivarHongo (){

        
    }

    public static void Buff(int x, int y, int bx, int by, int px, int py)
    {

        if (x == 41) // Hongo
        {            
            Tablero.laberinto[px, py] = 1;
            Tablero.laberinto[bx, by] = y;

            Program.Player[y].BufPasos = Program.Player[y].BufPasos + 2;
            Program.Player[y].Pasos = Program.Player[y].Pasos + 2;


        }

        if (x == 42) // Estrella
            Tablero.laberinto[px, py] = 1;
            Tablero.laberinto[bx, by] = y;
            Program.Player[y].BufInmune = true;

        if (x == 43) // Gafas
        { 



        }

    }

}