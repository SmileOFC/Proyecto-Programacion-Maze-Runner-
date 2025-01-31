using Spectre.Console;

public class Selects
{
    public static int Menu(int Player) // (1)Continuar   (2)Guia   (3)Salir
    {
        while (true)
        {
            Imprime.Print(Player, Player, 65); // Player / Img / Panel
            var keyInfo = Console.ReadKey();

            if (keyInfo.KeyChar == '1')
                return 1;

            if (keyInfo.KeyChar == '2')
                return 2;

            if (keyInfo.KeyChar == '3')
                return 3;
        }
    }

    public static int Seguro(int Player) // (1)Si (2)No
    {
        while (true)
        {
            Imprime.Print(Player, Player, 66); // Player / Img / Panel
            var keyInfo = Console.ReadKey();

            if (keyInfo.KeyChar == '1')
                return 1;

            if (keyInfo.KeyChar == '2')
                return 2;
        }
    }

    public static int Tienda(int Player) // (1)Items (2)Poderes (3)Salir
    {
        while (true)
        {
            Imprime.Print(Player, 555, 555); // Player / Img / Panel
            var keyInfo = Console.ReadKey();

            if (keyInfo.KeyChar == '1')
                return 1;

            if (keyInfo.KeyChar == '2')
                return 2;

            if (keyInfo.KeyChar == '3')
                return 3;
        }
    }

    public static int Items(int Player) // (1)Escudo (2)Escalera (3)Salir
    {
        while (true)
        {
            Imprime.Print(Player, 555, 551); // Player / Img / Panel
            var keyInfo = Console.ReadKey();

            if (keyInfo.KeyChar == '1')
                return 1;

            if (keyInfo.KeyChar == '2')
                return 2;

            if (keyInfo.KeyChar == '3')
                return 3;
        }
    }

    public static int Poderes(int Player) // (1)Bala (2)Mascara (3)Salir
    {
        while (true)
        {
            Imprime.Print(Player, 555, 552); // Player / Img / Panel
            var keyInfo = Console.ReadKey();

            if (keyInfo.KeyChar == '1')
                return 1;

            if (keyInfo.KeyChar == '2')
                return 2;

            if (keyInfo.KeyChar == '3')
                return 3;
        }
    }

    public static int Pociones(int Player) // (1)Veneno (2)Vision (3)Velocidad (4)Niebla (5)Hielo (6)Salir
    {
        while (true)
        {
            Imprime.Print(Player, 555, 553); // Player / Img / Panel
            var keyInfo = Console.ReadKey();

            if (keyInfo.KeyChar == '1')
                return 1;

            if (keyInfo.KeyChar == '2')
                return 2;

            if (keyInfo.KeyChar == '3')
                return 3;

            if (keyInfo.KeyChar == '4')
                return 4;

            if (keyInfo.KeyChar == '5')
                return 5;

            if (keyInfo.KeyChar == '6')
                return 6;
        }
    }

    public static char Direccion(int Player)
    {
        while (true)
        {
            Imprime.Print(Player, Player, 64); // Player / Img / Panel
            var keyInfo = Console.ReadKey();

            if (keyInfo.KeyChar == 'w')
                return 'w';

            if (keyInfo.KeyChar == 'a')
                return 'a';

            if (keyInfo.KeyChar == 's')
                return 's';

            if (keyInfo.KeyChar == 'd')
                return 'd';

            if (keyInfo.KeyChar == 'e')
                return 'e';
        }
    }

    public static int SelectPlayerBuenos(int Player) // (1)Mario (2)Luigi (3)Hongo (4)Yoshi (5)Peach
    {
        while (true)
        {
            Imprime.Print(Player, Player, 62); // Player / Img / Panel
            var keyInfo = Console.ReadKey();

            if (keyInfo.KeyChar == '1')
                return 20;

            if (keyInfo.KeyChar == '2')
                return 21;

            if (keyInfo.KeyChar == '3')
                return 22;

            if (keyInfo.KeyChar == '4')
                return 23;

            if (keyInfo.KeyChar == '5')
                return 24;
        }
    }

    public static int SelectPlayerMalos(int Player) // (1)Bowser (2)DonKeyKong (3)Koopa (4)Waluigi (5)Wario
    {
        while (true)
        {
            Imprime.Print(Player, Player, 63); // Player / Img / Panel
            var keyInfo = Console.ReadKey();

            if (keyInfo.KeyChar == '1')
                return 25;

            if (keyInfo.KeyChar == '2')
                return 26;

            if (keyInfo.KeyChar == '3')
                return 27;

            if (keyInfo.KeyChar == '4')
                return 28;

            if (keyInfo.KeyChar == '5')
                return 29;
        }
    }

    public static string CofreComunY_N(int Player)
    {
        while (true)
        {
            Imprime.Print(Player, 6, 6); // Player / Img / Panel
            var keyInfo = Console.ReadKey();

            if (keyInfo.KeyChar == '1')
                return "Si";

            if (keyInfo.KeyChar == '2')
                return "No";
        }
    }

    public static int SelectCofreComun(int Player)
    {
        while (true)
        {
            Imprime.Print(Player, 6, 70); // Player / Img / Panel
            var keyInfo = Console.ReadKey();

            if (keyInfo.KeyChar == '1')
                return 1;

            if (keyInfo.KeyChar == '2')
                return 2;
        }
    }

    public static int SelectCofreEpico(int Player)
    {
        while (true)
        {
            Imprime.Print(Player, 7, 80); // Player / Img / Panel
            var keyInfo = Console.ReadKey();

            if (keyInfo.KeyChar == '1')
                return 1;

            if (keyInfo.KeyChar == '2')
                return 2;
        }
    }

    public static int SelectCofreLegendario(int Player)
    {
        while (true)
        {
            Imprime.Print(Player, 8, 90); // Player / Img / Panel
            var keyInfo = Console.ReadKey();

            if (keyInfo.KeyChar == '1')
                return 1;

            if (keyInfo.KeyChar == '2')
                return 2;
        }
    }

    public static string CofreEpicoY_N(int Player)
    {
        while (true)
        {
            Imprime.Print(Player, 7, 7); // Player / Img / Panel
            var keyInfo = Console.ReadKey();

            if (keyInfo.KeyChar == '1')
                return "Si";

            if (keyInfo.KeyChar == '2')
                return "No";
        }
    }

    public static string CofreLegendarioY_N(int Player)
    {
        while (true)
        {
            Imprime.Print(Player, 8, 8); // Player / Img / Panel
            var keyInfo = Console.ReadKey();

            if (keyInfo.KeyChar == '1')
                return "Si";

            if (keyInfo.KeyChar == '2')
                return "No";
        }
    }

    public static string AvanzarY_N(int Player)
    {
        while (true)
        {
            Imprime.Print(Player, 55555, 61); // Player / Img / Panel
            var keyInfo = Console.ReadKey();

            if (keyInfo.KeyChar == '1')
                return "Si";

            if (keyInfo.KeyChar == '2')
                return "No";
        }
    }
}
