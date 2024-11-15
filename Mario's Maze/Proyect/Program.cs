using System;
public class Program
{

    public static Dictionary<int, CrearPlayer> Player = new Dictionary<int, CrearPlayer>();

    public static int Main()
    {


        CrearPlayer Yoshi = new CrearPlayer("Yoshi", 10, true, 10, 1,1, 0, 0, false, 0, 0);
        CrearPlayer Koopa = new CrearPlayer("Koopa", 7, false, 7, 1,1, 0, 0, false, 0, 0);
        CrearPlayer Luigi = new CrearPlayer("Luigi", 6, true, 6, 1,1, 0, 0, false, 0, 0);
        CrearPlayer Mario = new CrearPlayer("Mario", 5, true, 5, 1,1, 0, 0, false, 0, 0);
        CrearPlayer Hongo = new CrearPlayer("Hango", 4, true, 4, 1,1, 0, 0, false, 0, 0);
        CrearPlayer Bowser = new CrearPlayer("Bowser", 9, false, 9, 1,1, 0, 0, false, 0, 0);
        CrearPlayer Tortuga = new CrearPlayer("Tortuga", 3, false, 3, 3,3, 0, 0, false, 0, 0);
        CrearPlayer Wario = new CrearPlayer("Wario", 8, false, 8, 1,1, 0, 0, false, 0, 0);
        CrearPlayer Peach = new CrearPlayer("Peach", 11, true, 11, 1,1, 0, 0, false, 0, 0);
        CrearPlayer Waluigi = new CrearPlayer("Waluigi", 12, false, 12, 1,1, 0, 0, false, 0, 0);

        // Diccionario Players

        Player.Add(21, Yoshi);
        Player.Add(22, Koopa);
        Player.Add(23, Luigi);
        Player.Add(24, Mario);
        Player.Add(25, Hongo);
        Player.Add(26, Bowser);
        Player.Add(27, Tortuga);
        Player.Add(28, Wario);
        Player.Add(29, Peach);
        Player.Add(20, Waluigi);

        Console.Clear();
        Loby.LOBY();
        Rondas.Ronda();
        Win();
        return Main();
    }

    static void Win()
    {
        int equipo = 0;
        while (equipo < Rondas.Fichas.Count)
        {
            if (Rondas.Fichas[equipo] == 0)
            {
                equipo = Rondas.Fichas[equipo];
                break;
            }

        }

        if (Player[equipo].Equipo)
            Console.WriteLine("Gano el Equipo de Mario: ");
        else
            Console.WriteLine("Ganno el Equipo de Browser: ");

        for (int x = 0; x < Rondas.Fichas.Count; x++)
        {
            if (Rondas.Fichas[x] == 0)
                Console.Write("  " + Rondas.Fichas[x] + "  ");

        }


    }

}

