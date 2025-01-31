using Spectre.Console;

public class Habilidades
{
    public static void Habilidad(int player, int x, int y)
    {
        if (player == 20) // Mario
        {
            while (true)
            {
                Imprime.Print(player, player, 200); // Player / Img / Panel

                var keyInfo = Console.ReadKey();

                if (keyInfo.KeyChar == 'w')
                {
                    if (x - 1 > 0 && Tablero.laberinto[x - 1, y] == 0)
                    {
                        if (x - 2 > 0)
                        {
                            if (
                                Tablero.laberinto[x - 2, y] == 1
                                || Tablero.laberinto[x - 2, y] == 0
                                || Tablero.laberinto[x - 2, y] == 31
                                || Tablero.laberinto[x - 2, y] == 32
                                || Tablero.laberinto[x - 2, y] == 33
                            )
                            {
                                Tablero.laberinto[x - 2, y] = player;
                                Tablero.laberinto[x, y] = 1;

                                break;
                            }
                            else
                                break;
                        }
                        else
                            break;
                    }
                    else
                        break;
                }

                if (keyInfo.KeyChar == 's')
                {
                    if (x + 1 < 31 && Tablero.laberinto[x + 1, y] == 0)
                    {
                        if (x + 2 < 31)
                        {
                            if (
                                Tablero.laberinto[x + 2, y] == 0
                                || Tablero.laberinto[x + 2, y] == 0
                                || Tablero.laberinto[x + 2, y] == 31
                                || Tablero.laberinto[x + 2, y] == 32
                                || Tablero.laberinto[x + 2, y] == 33
                            )
                            {
                                Tablero.laberinto[x + 2, y] = player;
                                Tablero.laberinto[x, y] = 1;

                                break;
                            }
                            else
                                break;
                        }
                        else
                            break;
                    }
                    else
                        break;
                }

                if (keyInfo.KeyChar == 'a')
                {
                    if (y - 1 > 0 && Tablero.laberinto[x, y - 1] == 0)
                    {
                        if (y - 2 > 0)
                        {
                            if (
                                Tablero.laberinto[x, y - 2] == 0
                                || Tablero.laberinto[x, y - 2] == 0
                                || Tablero.laberinto[x, y - 2] == 31
                                || Tablero.laberinto[x, y - 2] == 32
                                || Tablero.laberinto[x, y - 2] == 33
                            )
                            {
                                Tablero.laberinto[x, y - 2] = player;
                                Tablero.laberinto[x, y] = 1;

                                break;
                            }
                            else
                                break;
                        }
                        else
                            break;
                    }
                    else
                        break;
                }

                if (keyInfo.KeyChar == 'd')
                {
                    if (y + 1 > 0 && Tablero.laberinto[x, y + 1] == 0)
                    {
                        if (y + 2 > 0)
                        {
                            if (
                                Tablero.laberinto[x, y + 2] == 0
                                || Tablero.laberinto[x, y + 2] == 0
                                || Tablero.laberinto[x, y + 2] == 31
                                || Tablero.laberinto[x, y + 2] == 32
                                || Tablero.laberinto[x, y + 2] == 33
                            )
                            {
                                Tablero.laberinto[x, y + 2] = player;
                                Tablero.laberinto[x, y] = 1;

                                break;
                            }
                            else
                                break;
                        }
                        else
                            break;
                    }
                    else
                        break;
                }
            }
        }

        if (player == 21) //Luigi
        {
            Imprime.Print(player, player, 211); // Player / Img / Panel

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
                            Imprime.TrampaVisibleF.Add(i, true);
                            Imprime.TrampaVisibleC.Add(j, true);
                        }
                    }
                }
            }

            Console.ReadKey();
            Imprime.TrampaVisibleF.Clear();
            Imprime.TrampaVisibleC.Clear();
        }

        if (player == 22) //Hongo
        {
            Imprime.Print(player, player, 222); // Player / Img / Panel
            Console.ReadKey();

            for (int i = 0; i < Rondas.EquipoBuenosList.Count; i++)
            {
                Program.Player[Rondas.EquipoBuenosList[i]].Vision =
                    Program.Player[Rondas.EquipoBuenosList[i]].Vision + 1;
                Program.Player[Rondas.EquipoBuenosList[i]].BufVision = 1;
            }
        }

        if (player == 23) //Yoshi
        {
            Imprime.Print(player, player, 233); // Player / Img / Panel

            Tablero.Puntero[x, y] = true;

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

                    Imprime.Print(player, player, 233); // Player / Img / Panel
                }
                if (keyInfo.KeyChar == 's' && xx + 1 < 30)
                {
                    Tablero.Puntero[xx + 1, yy] = true;
                    Tablero.Puntero[xx, yy] = false;
                    xx = xx + 1;

                    Imprime.Print(player, player, 233); // Player / Img / Panel
                }
                if (keyInfo.KeyChar == 'a' && yy - 1 > 0)
                {
                    Tablero.Puntero[xx, yy - 1] = true;
                    Tablero.Puntero[xx, yy] = false;
                    yy = yy - 1;

                    Imprime.Print(player, player, 233); // Player / Img / Panel
                }
                if (keyInfo.KeyChar == 'd' && yy + 1 < 30)
                {
                    Tablero.Puntero[xx, yy + 1] = true;
                    Tablero.Puntero[xx, yy] = false;
                    yy = yy + 1;

                    Imprime.Print(player, player, 233); // Player / Img / Panel
                }
                if (keyInfo.KeyChar == 'e')
                {
                    Tablero.Puntero[xx, yy] = false;

                    for (int i = xx - 2; i <= xx + 2; i++)
                    {
                        for (int j = yy - 2; j <= yy + 2; j++)
                        {
                            if (i < 30 && i >= 0 && j < 30 && j >= 0)
                                Tablero.niebla[i, j] = false;
                        }
                    }

                    break;
                }
            }
        }

        if (player == 24) //Peach
        {
            Imprime.Print(player, player, 244); // Player / Img / Panel
            Console.ReadKey();

            for (int i = 0; i < Rondas.EquipoMalosList.Count; i++)
                Program.Player[Rondas.EquipoMalosList[i]].Inmovil = true;
        }

        if (player == 25) //Bowser
        {
            Imprime.Print(player, player, 255); // Player / Img / Panel
            Console.ReadKey();

            Program.Player[player].Inmune = true;
        }

        if (player == 26) //DonkeyKong
        {
            while (true)
            {
                Imprime.Print(player, player, 266); // Player / Img / Panel

                var keyInfo = Console.ReadKey();

                if (keyInfo.KeyChar == 'w')
                {
                    if (x - 1 > 0 && Tablero.laberinto[x - 1, y] == 0)
                    {
                        Tablero.laberinto[x - 1, y] = 1;
                        break;
                    }
                    else
                        break;
                }

                if (keyInfo.KeyChar == 's')
                {
                    if (x + 1 < 31 && Tablero.laberinto[x + 1, y] == 0)
                    {
                        Tablero.laberinto[x + 1, y] = 1;
                        break;
                    }
                    else
                        break;
                }

                if (keyInfo.KeyChar == 'a')
                {
                    if (y - 1 > 0 && Tablero.laberinto[x, y - 1] == 0)
                    {
                        Tablero.laberinto[x, y - 1] = 1;
                        break;
                    }
                    else
                        break;
                }

                if (keyInfo.KeyChar == 'd')
                {
                    if (y + 1 > 0 && Tablero.laberinto[x, y + 1] == 0)
                    {
                        Tablero.laberinto[x, y + 1] = 1;
                        break;
                    }
                    else
                        break;
                }
            }
        }

        if (player == 27) //Koopa
        {
            Imprime.Print(player, player, 277); // Player / Img / Panel
            Console.ReadKey();

            if (
                Program.Player[player].VisionStatic - 1 > 0
                && Program.Player[player].Vision - 1 > 0
            )
            {
                Program.Player[player].VisionStatic = Program.Player[player].VisionStatic - 1;
                Program.Player[player].Vision = Program.Player[player].Vision - 1;

                Program.Player[player].Pasos = Program.Player[player].Pasos + 5;
                Program.Player[player].PasosStatic = Program.Player[player].PasosStatic + 5;
            }
            else
            {
                Imprime.Print(player, 55555, 2777); // Player / Img / Panel
                Console.ReadKey();
            }
        }

        if (player == 28) //Waluigi
        {
            Imprime.Print(player, player, 288); // Player / Img / Panel

            Tablero.Puntero[x, y] = true;

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

                    Imprime.Print(player, player, 288); // Player / Img / Panel
                }
                if (keyInfo.KeyChar == 's' && xx + 1 < 30)
                {
                    Tablero.Puntero[xx + 1, yy] = true;
                    Tablero.Puntero[xx, yy] = false;
                    xx = xx + 1;

                    Imprime.Print(player, player, 288); // Player / Img / Panel
                }
                if (keyInfo.KeyChar == 'a' && yy - 1 > 0)
                {
                    Tablero.Puntero[xx, yy - 1] = true;
                    Tablero.Puntero[xx, yy] = false;
                    yy = yy - 1;

                    Imprime.Print(player, player, 288); // Player / Img / Panel
                }
                if (keyInfo.KeyChar == 'd' && yy + 1 < 30)
                {
                    Tablero.Puntero[xx, yy + 1] = true;
                    Tablero.Puntero[xx, yy] = false;
                    yy = yy + 1;

                    Imprime.Print(player, player, 288); // Player / Img / Panel
                }
                if (keyInfo.KeyChar == 'e' && Tablero.laberinto[xx, yy] == 1)
                {
                    Tablero.Puntero[xx, yy] = false;
                    Tablero.laberinto[xx, yy] = 31;

                    break;
                }
            }
        }

        if (player == 29) //Wario
        {
            Imprime.Print(player, player, 299); // Player / Img / Panel
            Console.ReadKey();

            if (Program.Player[player].Pasos - 5 > 0 || Program.Player[player].PasosStatic - 5 > 0)
            {
                Program.Player[player].VisionStatic = Program.Player[player].VisionStatic + 1;
                Program.Player[player].Vision = Program.Player[player].Vision + 1;

                Program.Player[player].Pasos = Program.Player[player].Pasos - 5;
                Program.Player[player].PasosStatic = Program.Player[player].PasosStatic - 5;
            }
            else
            {
                Imprime.Print(player, 55555, 2999); // Player / Img / Panel
                Console.ReadKey();
            }
        }
    }
}
