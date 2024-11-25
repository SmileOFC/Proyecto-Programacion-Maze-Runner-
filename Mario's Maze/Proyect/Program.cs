using System;
public class Program
{
    public static Dictionary<int, int> chek = new Dictionary<int, int>();
    public static Dictionary<int, CrearPlayer> Player = new Dictionary<int, CrearPlayer>();

    public static int Main()
    {

        CrearPlayer Mario = new CrearPlayer("Mario", 12,12,0,48, true, 1,1, false, false, false, false);
        CrearPlayer Luigi = new CrearPlayer("Luigi", 10,10,0,20, true, 1,1, false, false, false, false);
        CrearPlayer Hongo = new CrearPlayer("Hongo", 5,5,0,20, true, 2,2, false, false, false, false);
        CrearPlayer Yoshi = new CrearPlayer("Yoshi", 6,6,0,24, true,  1,1, false, false, false, false);
        CrearPlayer Peach = new CrearPlayer("Peach", 7,7,0,28, true, 2,2, false, false, false, false);

        CrearPlayer Bowser = new CrearPlayer("Bowser", 8,8,0,16, false, 1,1, false, false, false, false);
        CrearPlayer DonkeyKong = new CrearPlayer("Donkey Kong", 4,4,0,16, false, 2,2, false, false, false, false);
        CrearPlayer Koopa = new CrearPlayer("Koopa", 3,3,0,3, false, 3,3, false, false, false, false);
        CrearPlayer Waluigi = new CrearPlayer("Waluigi", 9,9,0,18, false,  1,1, false, false, false, false);
        CrearPlayer Wario = new CrearPlayer("Wario", 11,11,0,11, false, 1,1, false, false, false, false);
        

        // Diccionario Players

        Player.Add(20, Mario);
        Player.Add(21, Luigi);
        Player.Add(22, Hongo);
        Player.Add(23, Yoshi);
        Player.Add(24, Peach);

        Player.Add(25, Bowser);
        Player.Add(26, DonkeyKong);
        Player.Add(27, Koopa);
        Player.Add(28, Waluigi);
        Player.Add(29, Wario);



        // Diccionario Mover

        chek.Add(0,0);
        chek.Add(1,1);
        chek.Add(5,5);

        //trampas
        chek.Add(31,3);
        chek.Add(32,3);
        chek.Add(33,3);

        //bufs
        chek.Add(41,4);
        chek.Add(42,4);
        chek.Add(43,4);
        
        //players
        chek.Add(20,2);
        chek.Add(21,2);
        chek.Add(22,2);
        chek.Add(23,2);
        chek.Add(24,2);
        chek.Add(25,2);
        chek.Add(26,2);
        chek.Add(27,2);
        chek.Add(28,2);
        chek.Add(29,2);

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

