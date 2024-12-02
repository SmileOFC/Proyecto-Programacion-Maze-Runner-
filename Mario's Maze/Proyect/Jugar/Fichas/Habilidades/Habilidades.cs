using Spectre.Console;

public class Habilidades
{
    public static void Habilidad(int player, int x, int y)
    {
        if (player == 20) // Mario
        {
            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.Clear();
                Interfaz.Imprimir(player);

                var keyInfo = Console.ReadKey();

                if (keyInfo.KeyChar == 'w')
                {
                    if (Tablero.laberinto[x - 1, y] == 0 && x - 2 > 0)
                    {
                        Tablero.laberinto[x - 2, y] = player;
                        Tablero.laberinto[x, y] = 1;
                        Program.Player[player].PasosCont = 0;
                        break;
                    }
                }

                if (keyInfo.KeyChar == 's')
                {
                    if (Tablero.laberinto[x + 1, y] == 0 && x + 2 < 31)
                    {
                        Tablero.laberinto[x + 2, y] = player;
                        Tablero.laberinto[x, y] = 1;
                        Program.Player[player].PasosCont = 0;
                        break;
                    }
                }

                if (keyInfo.KeyChar == 'a')
                {
                    if (Tablero.laberinto[x, y - 1] == 0 && y - 2 > 0)
                    {
                        Tablero.laberinto[x, y - 2] = player;
                        Tablero.laberinto[x, y] = 1;
                        Program.Player[player].PasosCont = 0;
                        break;
                    }
                }

                if (keyInfo.KeyChar == 'd')
                {
                    if (Tablero.laberinto[x, y + 1] == 0 && y + 2 > 0)
                    {
                        Tablero.laberinto[x, y + 2] = player;
                        Tablero.laberinto[x, y] = 1;
                        Program.Player[player].PasosCont = 0;
                        break;
                    }
                }
            }
        }

        if (player == 21) //Luigi
        {
            int v = Program.Player[player].Vision;
            for (int i = x - v; i <= x + v; i++)
            {
                for (int j = y - v; j <= y + v; j++)
                {
                    if (i < 30 && i >= 0 && j < 30 && j >= 0)
                    {
                        if (
                            Tablero.laberinto[i, j] == 31
                            || Tablero.laberinto[i, j] == 32
                            || Tablero.laberinto[i, j] == 33
                        )
                        {
                            Interfaz.TrampaVisibleF.Add(i, true);
                            Interfaz.TrampaVisibleC.Add(j, true);
                        }
                    }
                }
            }

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Interfaz.Imprimir(player);
            Thread.Sleep(5000);
            Interfaz.TrampaVisibleF.Clear();
            Interfaz.TrampaVisibleC.Clear();
            Program.Player[player].PasosCont = 0;
        }

        if (player == 22) //Hongo
        {
            for (int i = 0; i < Rondas.EquipoBuenosList.Count; i++)
            {
                Program.Player[Rondas.EquipoBuenosList[i]].Vision =
                    Program.Player[Rondas.EquipoBuenosList[i]].Vision + 1;
                Program.Player[Rondas.EquipoBuenosList[i]].BufVision = true;
            }

            Program.Player[player].PasosCont = 0;
        }

        if (player == 23) //Yoshi
        {
            Tablero.Puntero[x, y] = true;

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Interfaz.Imprimir(player);

            int xx = x;
            int yy = y;

            while (true)
            {
                var keyInfo = Console.ReadKey();

                if (keyInfo.KeyChar == 'w' && xx - 1 > 0)
                {
                    Tablero.Puntero[xx - 1, yy] = true;
                    Tablero.Puntero[xx, yy] = false;
                    xx = xx - 1;

                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.Clear();
                    Interfaz.Imprimir(player);
                }
                if (keyInfo.KeyChar == 's' && xx + 1 < 30)
                {
                    Tablero.Puntero[xx + 1, yy] = true;
                    Tablero.Puntero[xx, yy] = false;
                    xx = xx + 1;

                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.Clear();
                    Interfaz.Imprimir(player);
                }
                if (keyInfo.KeyChar == 'a' && yy - 1 > 0)
                {
                    Tablero.Puntero[xx, yy - 1] = true;
                    Tablero.Puntero[xx, yy] = false;
                    yy = yy - 1;

                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.Clear();
                    Interfaz.Imprimir(player);
                }
                if (keyInfo.KeyChar == 'd' && yy + 1 < 30)
                {
                    Tablero.Puntero[xx, yy + 1] = true;
                    Tablero.Puntero[xx, yy] = false;
                    yy = yy + 1;

                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.Clear();
                    Interfaz.Imprimir(player);
                }
                if (keyInfo.KeyChar == 'e')
                {
                    Tablero.Puntero[xx, yy] = false;

                    for (int i = xx - 3; i <= xx + 3; i++)
                    {
                        for (int j = yy - 3; j <= yy + 3; j++)
                        {
                            if (i < 30 && i >= 0 && j < 30 && j >= 0)
                                Tablero.niebla[i, j] = false;
                        }
                    }

                    Program.Player[player].PasosCont = 0;
                    break;
                }
            }
        }

        if (player == 24) //Peach
        {
            for (int i = 0; i < Rondas.EquipoBuenosList.Count; i++)
                Program.Player[Rondas.EquipoBuenosList[i]].Inmovil = true;

            Program.Player[player].PasosCont = 0;
        }

        if (player == 25) //Bowser
        {
            Program.Player[player].Inmune = true;
            Program.Player[player].PasosCont = 0;
        }

        if (player == 26) //DonkeyKong
        {
            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.Clear();
                Interfaz.Imprimir(player);

                var keyInfo = Console.ReadKey();

                if (keyInfo.KeyChar == 'w')
                {
                    if (Tablero.laberinto[x - 1, y] == 0 && x - 2 > 0)
                    {
                        Tablero.laberinto[x - 1, y] = 1;
                        break;
                    }
                }

                if (keyInfo.KeyChar == 's')
                {
                    if (Tablero.laberinto[x + 1, y] == 0 && x + 2 < 31)
                    {
                        Tablero.laberinto[x + 1, y] = 1;
                        break;
                    }
                }

                if (keyInfo.KeyChar == 'a')
                {
                    if (Tablero.laberinto[x, y - 1] == 0 && y - 2 > 0)
                    {
                        Tablero.laberinto[x, y - 1] = 1;
                        break;
                    }
                }

                if (keyInfo.KeyChar == 'd')
                {
                    if (Tablero.laberinto[x, y + 1] == 0 && y + 2 > 0)
                    {
                        Tablero.laberinto[x, y + 1] = 1;
                        break;
                    }
                }

                Program.Player[player].PasosCont = 0;
            }
        }

        if (player == 27) //Koopa
        {
            if (
                Program.Player[player].VisionStatic - 1 > 0
                && Program.Player[player].Vision - 1 > 0
            )
            {
                Program.Player[player].VisionStatic = Program.Player[player].VisionStatic - 1;
                Program.Player[player].Vision = Program.Player[player].Vision - 1;

                Program.Player[player].Pasos = Program.Player[player].Pasos + 5;
                Program.Player[player].PasosStatic = Program.Player[player].PasosStatic + 5;

                Program.Player[player].PasosCont = 0;
            }
        }

        if (player == 28) //Waluigi
        {
            Tablero.Puntero[x, y] = true;

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Interfaz.Imprimir(player);

            int xx = x;
            int yy = y;

            while (true)
            {
                var keyInfo = Console.ReadKey();

                if (keyInfo.KeyChar == 'w' && xx - 1 > 0)
                {
                    Tablero.Puntero[xx - 1, yy] = true;
                    Tablero.Puntero[xx, yy] = false;
                    xx = xx - 1;

                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.Clear();
                    Interfaz.Imprimir(player);
                }
                if (keyInfo.KeyChar == 's' && xx + 1 < 30)
                {
                    Tablero.Puntero[xx + 1, yy] = true;
                    Tablero.Puntero[xx, yy] = false;
                    xx = xx + 1;

                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.Clear();
                    Interfaz.Imprimir(player);
                }
                if (keyInfo.KeyChar == 'a' && yy - 1 > 0)
                {
                    Tablero.Puntero[xx, yy - 1] = true;
                    Tablero.Puntero[xx, yy] = false;
                    yy = yy - 1;

                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.Clear();
                    Interfaz.Imprimir(player);
                }
                if (keyInfo.KeyChar == 'd' && yy + 1 < 30)
                {
                    Tablero.Puntero[xx, yy + 1] = true;
                    Tablero.Puntero[xx, yy] = false;
                    yy = yy + 1;

                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.Clear();
                    Interfaz.Imprimir(player);
                }
                if (keyInfo.KeyChar == 'e' && Tablero.laberinto[xx, yy] == 1)
                {
                    Tablero.Puntero[xx, yy] = false;
                    Tablero.laberinto[xx, yy] = 31;

                    Program.Player[player].PasosCont = 0;
                    break;
                }
            }
        }

        if (player == 29) //Wario
        {
            if (Program.Player[player].Pasos - 5 > 0 || Program.Player[player].PasosStatic - 5 > 0)
            {
                Program.Player[player].VisionStatic = Program.Player[player].VisionStatic + 1;
                Program.Player[player].Vision = Program.Player[player].Vision + 1;

                Program.Player[player].Pasos = Program.Player[player].Pasos - 5;
                Program.Player[player].PasosStatic = Program.Player[player].PasosStatic - 5;

                Program.Player[player].PasosCont = 0;
            }
            else
            {
                // Necesitas mas pasos para poder utilizar la habilidad
            }
        }
    }
}
