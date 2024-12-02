using Spectre.Console;

public class Poderes
{
    static string PlayerSelect = "";

    static int PunteroX;
    static int PunteroY;

    static int PlayerX;
    static int PlayerY;

    public static void Bala(int Player)
    {
        
        var panel1 = new Panel("Seleccione en que direccion disparar.");
        panel1.Header("[Red1] NOTA [/]", Justify.Left);
        panel1.Border(BoxBorder.Rounded);
        panel1.Padding(1, 1, 1, 1);

        int c = 0;

        if (Program.Player[Player].Equipo) // Buenos
        {
            while (c == 0) // Seleccione Player para equipar
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.Clear();
                Interfaz.Imprimir(Player);

                PlayerSelect = Selects.SelectPlayerMalos();

                for (int i = 0; i < Rondas.EquipoMalosList.Count; i++)
                    if (
                        Program.Player[Rondas.EquipoMalosList[0]].Name == PlayerSelect
                        || Program.Player[Rondas.EquipoMalosList[1]].Name == PlayerSelect
                        || Program.Player[Rondas.EquipoMalosList[2]].Name == PlayerSelect
                    )
                        c++;
            }
        }
        else // Malos
        {
            while (c == 0) // Seleccione Player para equipar
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.Clear();
                Interfaz.Imprimir(Player);

                PlayerSelect = Selects.SelectPlayerBuenos();

                for (int i = 0; i < Rondas.EquipoBuenosList.Count; i++)
                    if (
                        Program.Player[Rondas.EquipoBuenosList[0]].Name == PlayerSelect
                        || Program.Player[Rondas.EquipoBuenosList[1]].Name == PlayerSelect
                        || Program.Player[Rondas.EquipoBuenosList[2]].Name == PlayerSelect
                    )
                        c++;
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.Clear();
        Interfaz.Imprimir(Player);
        AnsiConsole.Write(panel1);
        var keyInf = Console.ReadKey();

        for (int x = 1; x < Tablero.filas; x++)
        {
            for (int y = 1; y < Tablero.columnas; y++)
            {
                if (Tablero.laberinto[x, y] == Program.Nombre[PlayerSelect])
                {
                    Tablero.Puntero[x, y] = true;
                    PunteroX = x;
                    PunteroY = y;
                    PlayerX = x;
                    PlayerY = y;
                    x = Tablero.filas;
                    break;
                }
            }
        }

        while (true)
        {   
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Interfaz.Imprimir(Player);
            var keyInfo = Console.ReadKey();

            if (
                keyInfo.KeyChar == 'w'
                && PunteroX - 1 > 0
                && PunteroX - 1 > PlayerX - 2
                && PunteroY == PlayerY
                && Tablero.laberinto[PunteroX - 1, PunteroY] == 1
            )
            {
                Tablero.Puntero[PunteroX - 1, PunteroY] = true;
                Tablero.Puntero[PunteroX, PunteroY] = false;
                PunteroX = PunteroX - 1;
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.Clear();
                Interfaz.Imprimir(Player);
            }
            if (
                keyInfo.KeyChar == 's'
                && PunteroX + 1 < 30
                && PunteroX + 1 < PlayerX + 2
                && PunteroY == PlayerY
                && Tablero.laberinto[PunteroX + 1, PunteroY] == 1
            )
            {
                Tablero.Puntero[PunteroX + 1, PunteroY] = true;
                Tablero.Puntero[PunteroX, PunteroY] = false;
                PunteroX = PunteroX + 1;
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.Clear();
                Interfaz.Imprimir(Player);
            }
            if (
                keyInfo.KeyChar == 'a'
                && PunteroY - 1 > 0
                && PunteroY - 1 > PlayerY - 2
                && PunteroX == PlayerX
                && Tablero.laberinto[PunteroX, PunteroY - 1] == 1
            )
            {
                Tablero.Puntero[PunteroX, PunteroY - 1] = true;
                Tablero.Puntero[PunteroX, PunteroY] = false;
                PunteroY = PunteroY - 1;
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.Clear();
                Interfaz.Imprimir(Player);
            }
            if (
                keyInfo.KeyChar == 'd'
                && PunteroY + 1 < 30
                && PunteroY + 1 < PlayerY + 2
                && PunteroX == PlayerX
                && Tablero.laberinto[PunteroX, PunteroY + 1] == 1
            )
            {
                Tablero.Puntero[PunteroX, PunteroY + 1] = true;
                Tablero.Puntero[PunteroX, PunteroY] = false;
                PunteroY = PunteroY + 1;
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.Clear();
                Interfaz.Imprimir(Player);
            }
            if (keyInfo.KeyChar == 'e')
            {
                Tablero.Puntero[PunteroX, PunteroY] = false;
                Tablero.laberinto[PunteroX, PunteroY] = Program.Nombre[PlayerSelect];
                Tablero.laberinto[PlayerX, PlayerY] = 1;
                break;
            }
        }
    }

    public static void Telaraña() { }

    public static void Mascara() { }
}
