public class Bufss
{
    public static void Buff(int x, int player, int bx, int by, int px, int py)
    {
        if (x == 41) // Hongo
        {
            Imprime.Print(player, 41, 41);
            Console.ReadKey();

            Tablero.laberinto[px, py] = 1;
            Tablero.laberinto[bx, by] = player;

            Program.Player[player].BufPasos = 10;
            Program.Player[player].Pasos = Program.Player[player].Pasos + 11;
        }

        if (x == 42) // Estrella
        {
            Imprime.Print(player, 42, 42);
            Console.ReadKey();

            Tablero.laberinto[px, py] = 1;
            Tablero.laberinto[bx, by] = player;
            Program.Player[player].Inmune = true;
        }

        if (x == 43) // Flor
        {
            Imprime.Print(player, 43, 43);
            Console.ReadKey();

            Tablero.laberinto[px, py] = 1;
            Tablero.laberinto[bx, by] = player;
            Program.Player[player].BufVision = 2;
            Program.Player[player].Vision = Program.Player[player].Vision + 2;
        }
    }
}
