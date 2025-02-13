﻿using Spectre.Console;

public class Jugar
{
    static int RestPasos(int Player)
    {
        if (Program.Player[Player].Pasos - 1 != 0)
        {
            Program.Player[Player].PasosCont = Program.Player[Player].PasosCont + 1;
            Program.Player[Player].Pasos = Program.Player[Player].Pasos - 1;

            return Program.Player[Player].Pasos;
        }
        else
        {
            Program.Player[Player].Pasos = Program.Player[Player].PasosStatic;

            return 0;
        }
    }

    public static int Mover(int Player, char Direccion)
    {
        int x = 1;
        int y = 1;
        var yn = "";
        int ChekCoins;

        for (int xx = 1; xx < Tablero.filas; xx++)
        {
            for (int yy = 1; yy < Tablero.columnas; yy++)
            {
                if (Tablero.laberinto[xx, yy] == Player)
                {
                    x = xx;
                    y = yy;
                    break;
                }
            }
        }

        if (Direccion == 'w')
        {
            if (Program.chek[Tablero.laberinto[x - 1, y]] == 0)
                return Program.Player[Player].Pasos;

            if (
                Program.chek[Tablero.laberinto[x - 1, y]] == 1
                || Program.chek[Tablero.laberinto[x - 1, y]] == 151
                || Program.chek[Tablero.laberinto[x - 1, y]] == 252
                || Program.chek[Tablero.laberinto[x - 1, y]] == 353
                || Program.chek[Tablero.laberinto[x - 1, y]] == 454
            )
            {
                Tablero.laberinto[x - 1, y] = Player;
                Tablero.laberinto[x, y] = 1;

                return RestPasos(Player);
            }

            if (Program.chek[Tablero.laberinto[x - 1, y]] == 20)
            {
                int Ficha = Tablero.laberinto[x - 1, y];

                Tablero.laberinto[x - 1, y] = Tablero.laberinto[x, y];
                Tablero.laberinto[x, y] = Ficha;

                return RestPasos(Player);
            }

            if (Program.chek[Tablero.laberinto[x - 1, y]] == 3)
            {
                Trampas.Trampa(Tablero.laberinto[x - 1, y], Player, x - 1, y, x, y, Direccion);

                return RestPasos(Player);
            }

            if (Program.chek[Tablero.laberinto[x - 1, y]] == 4)
            {
                Bufss.Buff(Tablero.laberinto[x - 1, y], Player, x - 1, y, x, y);

                return RestPasos(Player);
            }

            if (Program.chek[Tablero.laberinto[x - 1, y]] == 5)
            {
                Tablero.laberinto[x, y] = 1;
                return 555;
            }

            if (Program.chek[Tablero.laberinto[x - 1, y]] == 2)
            {
                if (Program.Player[Player].Equipo)
                    Program.EquipoBuenoCoins = Program.EquipoBuenoCoins + 1;
                else
                    Program.EquipoMaloCoins = Program.EquipoMaloCoins + 1;

                Tablero.laberinto[x - 1, y] = Player;
                Tablero.laberinto[x, y] = 1;

                return RestPasos(Player);
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////
            if (Program.chek[Tablero.laberinto[x - 1, y]] == 6)
            {
                yn = Selects.CofreComunY_N(Player);

                if (yn == "Si")
                {
                    if (Program.Player[Player].Equipo)
                        ChekCoins = Program.EquipoBuenoCoins;
                    else
                        ChekCoins = Program.EquipoMaloCoins;

                    if (ChekCoins < 1)
                    {
                        yn = Selects.AvanzarY_N(Player);
                    }
                    else
                    {
                        Cofres.Cofre(Player, 6);

                        if (Program.Player[Player].Equipo)
                            Program.EquipoBuenoCoins -= 1;
                        else
                            Program.EquipoMaloCoins -= 1;
                    }
                }

                if (yn == "Si")
                {
                    Tablero.laberinto[x - 1, y] = Player;
                    Tablero.laberinto[x, y] = 1;

                    return RestPasos(Player);
                }
                else
                    return Program.Player[Player].Pasos;
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////

            if (Program.chek[Tablero.laberinto[x - 1, y]] == 7)
            {
                yn = Selects.CofreEpicoY_N(Player);

                if (yn == "Si")
                {
                    if (Program.Player[Player].Equipo)
                        ChekCoins = Program.EquipoBuenoCoins;
                    else
                        ChekCoins = Program.EquipoMaloCoins;

                    if (ChekCoins < 3)
                    {
                        yn = Selects.AvanzarY_N(Player);
                    }
                    else
                    {
                        Cofres.Cofre(Player, 7);

                        if (Program.Player[Player].Equipo)
                            Program.EquipoBuenoCoins -= 1;
                        else
                            Program.EquipoMaloCoins -= 1;
                    }
                }

                if (yn == "Si")
                {
                    Tablero.laberinto[x - 1, y] = Player;
                    Tablero.laberinto[x, y] = 1;

                    return RestPasos(Player);
                }
                else
                    return Program.Player[Player].Pasos;
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////

            if (Program.chek[Tablero.laberinto[x - 1, y]] == 8)
            {
                yn = Selects.CofreLegendarioY_N(Player);

                if (yn == "Si")
                {
                    if (Program.Player[Player].Equipo)
                        ChekCoins = Program.EquipoBuenoCoins;
                    else
                        ChekCoins = Program.EquipoMaloCoins;

                    if (ChekCoins < 5)
                    {
                        yn = Selects.AvanzarY_N(Player);
                    }
                    else
                    {
                        Cofres.Cofre(Player, 8);

                        if (Program.Player[Player].Equipo)
                            Program.EquipoBuenoCoins -= 1;
                        else
                            Program.EquipoMaloCoins -= 1;
                    }
                }

                if (yn == "Si")
                {
                    Tablero.laberinto[x - 1, y] = Player;
                    Tablero.laberinto[x, y] = 1;

                    return RestPasos(Player);
                }
                else
                    return Program.Player[Player].Pasos;
            }

            if (Program.chek[Tablero.laberinto[x - 1, y]] == 31) // recoge LLave de los buenos
            {
                if (Program.Player[Player].Equipo) // buenos
                {
                    Program.EquipoBuenoLlave = true;

                    Tablero.laberinto[x - 1, y] = Player;
                    Tablero.laberinto[x, y] = 1;

                    return RestPasos(Player);
                }
                else // malos
                {
                    Imprime.Print(Player, 55555, 333); // Player / Img / Panel
                    Console.ReadKey();
                }
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////

            if (Program.chek[Tablero.laberinto[x - 1, y]] == 32) // recoge LLave de los malos
            {
                if (!Program.Player[Player].Equipo) // malos
                {
                    Program.EquipoMaloLlave = true;

                    Tablero.laberinto[x - 1, y] = Player;
                    Tablero.laberinto[x, y] = 1;

                    return RestPasos(Player);
                }
                else // Buenos
                {
                    Imprime.Print(Player, 55555, 333); // Player / Img / Panel
                    Console.ReadKey();
                }
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            if (Program.chek[Tablero.laberinto[x - 1, y]] == 11) // puerta abierta
            {
                if (Program.Player[Player].Equipo)
                {
                    Tablero.laberinto[x - 1, y] = Player;
                    Tablero.laberinto[x, y] = 1;

                    return RestPasos(Player);
                }
                else
                {
                    Imprime.Print(Player, 55555, 4441); // Player / Img / Panel
                    Console.ReadKey();
                }
            }

            if (Program.chek[Tablero.laberinto[x - 1, y]] == 12) // puerta abierta
            {
                if (!Program.Player[Player].Equipo)
                {
                    Tablero.laberinto[x - 1, y] = Player;
                    Tablero.laberinto[x, y] = 1;

                    return RestPasos(Player);
                }
                else
                {
                    Imprime.Print(Player, 55555, 4441); // Player / Img / Panel
                    Console.ReadKey();
                }
            }

            if (Program.chek[Tablero.laberinto[x - 1, y]] == 111) // puerta cerrada
            {
                Console.Write(Tablero.laberinto[x - 1, y]);
                Imprime.Print(Player, 55555, 444); // Player / Img / Panel
                Console.ReadKey();
            }
        }
        if (Direccion == 's')
        {
            if (Program.chek[Tablero.laberinto[x + 1, y]] == 0)
                return Program.Player[Player].Pasos;

            if (
                Program.chek[Tablero.laberinto[x + 1, y]] == 1
                || Program.chek[Tablero.laberinto[x + 1, y]] == 151
                || Program.chek[Tablero.laberinto[x + 1, y]] == 252
                || Program.chek[Tablero.laberinto[x + 1, y]] == 353
                || Program.chek[Tablero.laberinto[x + 1, y]] == 454
            )
            {
                Tablero.laberinto[x + 1, y] = Player;
                Tablero.laberinto[x, y] = 1;

                return RestPasos(Player);
            }

            if (Program.chek[Tablero.laberinto[x + 1, y]] == 20)
            {
                int Ficha = Tablero.laberinto[x + 1, y];

                Tablero.laberinto[x + 1, y] = Tablero.laberinto[x, y];
                Tablero.laberinto[x, y] = Ficha;

                return RestPasos(Player);
            }

            if (Program.chek[Tablero.laberinto[x + 1, y]] == 3)
            {
                Trampas.Trampa(Tablero.laberinto[x + 1, y], Player, x + 1, y, x, y, Direccion);

                return RestPasos(Player);
            }

            if (Program.chek[Tablero.laberinto[x + 1, y]] == 4)
            {
                Bufss.Buff(Tablero.laberinto[x + 1, y], Player, x + 1, y, x, y);

                return RestPasos(Player);
            }

            if (Program.chek[Tablero.laberinto[x + 1, y]] == 5)
            {
                Tablero.laberinto[x, y] = 1;
                return 555;
            }

            if (Program.chek[Tablero.laberinto[x + 1, y]] == 2)
            {
                if (Program.Player[Player].Equipo)
                    Program.EquipoBuenoCoins = Program.EquipoBuenoCoins + 1;
                else
                    Program.EquipoMaloCoins = Program.EquipoMaloCoins + 1;

                Tablero.laberinto[x + 1, y] = Player;
                Tablero.laberinto[x, y] = 1;

                return RestPasos(Player);
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////
            if (Program.chek[Tablero.laberinto[x + 1, y]] == 6)
            {
                yn = Selects.CofreComunY_N(Player);

                if (yn == "Si")
                {
                    if (Program.Player[Player].Equipo)
                        ChekCoins = Program.EquipoBuenoCoins;
                    else
                        ChekCoins = Program.EquipoMaloCoins;

                    if (ChekCoins < 1)
                    {
                        yn = Selects.AvanzarY_N(Player);
                    }
                    else
                    {
                        Cofres.Cofre(Player, 6);

                        if (Program.Player[Player].Equipo)
                            Program.EquipoBuenoCoins -= 1;
                        else
                            Program.EquipoMaloCoins -= 1;
                    }
                }

                if (yn == "Si")
                {
                    Tablero.laberinto[x + 1, y] = Player;
                    Tablero.laberinto[x, y] = 1;

                    return RestPasos(Player);
                }
                else
                    return Program.Player[Player].Pasos;
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////

            if (Program.chek[Tablero.laberinto[x + 1, y]] == 7)
            {
                yn = Selects.CofreEpicoY_N(Player);

                if (yn == "Si")
                {
                    if (Program.Player[Player].Equipo)
                        ChekCoins = Program.EquipoBuenoCoins;
                    else
                        ChekCoins = Program.EquipoMaloCoins;

                    if (ChekCoins < 3)
                    {
                        yn = Selects.AvanzarY_N(Player);
                    }
                    else
                    {
                        Cofres.Cofre(Player, 7);

                        if (Program.Player[Player].Equipo)
                            Program.EquipoBuenoCoins -= 1;
                        else
                            Program.EquipoMaloCoins -= 1;
                    }
                }

                if (yn == "Si")
                {
                    Tablero.laberinto[x + 1, y] = Player;
                    Tablero.laberinto[x, y] = 1;

                    return RestPasos(Player);
                }
                else
                    return Program.Player[Player].Pasos;
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////

            if (Program.chek[Tablero.laberinto[x + 1, y]] == 8)
            {
                yn = Selects.CofreLegendarioY_N(Player);

                if (yn == "Si")
                {
                    if (Program.Player[Player].Equipo)
                        ChekCoins = Program.EquipoBuenoCoins;
                    else
                        ChekCoins = Program.EquipoMaloCoins;

                    if (ChekCoins < 5)
                    {
                        yn = Selects.AvanzarY_N(Player);
                    }
                    else
                    {
                        Cofres.Cofre(Player, 8);

                        if (Program.Player[Player].Equipo)
                            Program.EquipoBuenoCoins -= 1;
                        else
                            Program.EquipoMaloCoins -= 1;
                    }
                }

                if (yn == "Si")
                {
                    Tablero.laberinto[x + 1, y] = Player;
                    Tablero.laberinto[x, y] = 1;

                    return RestPasos(Player);
                }
                else
                    return Program.Player[Player].Pasos;
            }

            if (Program.chek[Tablero.laberinto[x + 1, y]] == 31) // recoge ficha de los buenos
            {
                if (Program.Player[Player].Equipo) // buenos
                {
                    Program.EquipoBuenoLlave = true;

                    Tablero.laberinto[x + 1, y] = Player;
                    Tablero.laberinto[x, y] = 1;

                    return RestPasos(Player);
                }
                else // malos
                {
                    Imprime.Print(Player, 55555, 333); // Player / Img / Panel
                    var keyInfo = Console.ReadKey();
                }
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////

            if (Program.chek[Tablero.laberinto[x + 1, y]] == 32) // recoge ficha de los malos
            {
                if (!Program.Player[Player].Equipo) // malos
                {
                    Program.EquipoMaloLlave = true;

                    Tablero.laberinto[x + 1, y] = Player;
                    Tablero.laberinto[x, y] = 1;

                    return RestPasos(Player);
                }
                else // Buenos
                {
                    Imprime.Print(Player, 55555, 333); // Player / Img / Panel
                    var keyInfo = Console.ReadKey();
                }
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            if (Program.chek[Tablero.laberinto[x + 1, y]] == 11) // puerta abierta
            {
                if (Program.Player[Player].Equipo)
                {
                    Tablero.laberinto[x + 1, y] = Player;
                    Tablero.laberinto[x, y] = 1;

                    return RestPasos(Player);
                }
                else
                {
                    Imprime.Print(Player, 55555, 4441); // Player / Img / Panel
                    Console.ReadKey();
                }
            }

            if (Program.chek[Tablero.laberinto[x + 1, y]] == 12) // puerta abierta
            {
                if (!Program.Player[Player].Equipo)
                {
                    Tablero.laberinto[x + 1, y] = Player;
                    Tablero.laberinto[x, y] = 1;

                    return RestPasos(Player);
                }
                else
                {
                    Imprime.Print(Player, 55555, 4441); // Player / Img / Panel
                    Console.ReadKey();
                }
            }

            if (Program.chek[Tablero.laberinto[x + 1, y]] == 111) // puerta cerrada
            {
                Imprime.Print(Player, 55555, 444); // Player / Img / Panel
                Console.ReadKey();
            }
        }
        if (Direccion == 'a')
        {
            if (Program.chek[Tablero.laberinto[x, y - 1]] == 0)
                return Program.Player[Player].Pasos;

            if (
                Program.chek[Tablero.laberinto[x, y - 1]] == 1
                || Program.chek[Tablero.laberinto[x, y - 1]] == 151
                || Program.chek[Tablero.laberinto[x, y - 1]] == 252
                || Program.chek[Tablero.laberinto[x, y - 1]] == 353
                || Program.chek[Tablero.laberinto[x, y - 1]] == 454
            )
            {
                Tablero.laberinto[x, y - 1] = Player;
                Tablero.laberinto[x, y] = 1;

                return RestPasos(Player);
            }

            if (Program.chek[Tablero.laberinto[x, y - 1]] == 20)
            {
                int Ficha = Tablero.laberinto[x, y - 1];

                Tablero.laberinto[x, y - 1] = Tablero.laberinto[x, y];
                Tablero.laberinto[x, y] = Ficha;

                return RestPasos(Player);
            }

            if (Program.chek[Tablero.laberinto[x, y - 1]] == 3)
            {
                Trampas.Trampa(Tablero.laberinto[x, y - 1], Player, x, y - 1, x, y, Direccion);

                return RestPasos(Player);
            }

            if (Program.chek[Tablero.laberinto[x, y - 1]] == 4)
            {
                Bufss.Buff(Tablero.laberinto[x, y - 1], Player, x, y - 1, x, y);

                return RestPasos(Player);
            }

            if (Program.chek[Tablero.laberinto[x, y - 1]] == 5)
            {
                Tablero.laberinto[x, y] = 1;
                return 555;
            }

            if (Program.chek[Tablero.laberinto[x, y - 1]] == 2)
            {
                if (Program.Player[Player].Equipo)
                    Program.EquipoBuenoCoins = Program.EquipoBuenoCoins + 1;
                else
                    Program.EquipoMaloCoins = Program.EquipoMaloCoins + 1;

                Tablero.laberinto[x, y - 1] = Player;
                Tablero.laberinto[x, y] = 1;

                return RestPasos(Player);
            }

            if (Program.chek[Tablero.laberinto[x, y - 1]] == 6)
            {
                yn = Selects.CofreComunY_N(Player);

                if (yn == "Si")
                {
                    if (Program.Player[Player].Equipo)
                        ChekCoins = Program.EquipoBuenoCoins;
                    else
                        ChekCoins = Program.EquipoMaloCoins;

                    if (ChekCoins < 1)
                    {
                        yn = Selects.AvanzarY_N(Player);
                    }
                    else
                    {
                        Cofres.Cofre(Player, 6);

                        if (Program.Player[Player].Equipo)
                            Program.EquipoBuenoCoins -= 1;
                        else
                            Program.EquipoMaloCoins -= 1;
                    }
                }

                if (yn == "Si")
                {
                    Tablero.laberinto[x, y - 1] = Player;
                    Tablero.laberinto[x, y] = 1;

                    return RestPasos(Player);
                }
                else
                    return Program.Player[Player].Pasos;
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////

            if (Program.chek[Tablero.laberinto[x, y - 1]] == 7)
            {
                yn = Selects.CofreEpicoY_N(Player);

                if (yn == "Si")
                {
                    if (Program.Player[Player].Equipo)
                        ChekCoins = Program.EquipoBuenoCoins;
                    else
                        ChekCoins = Program.EquipoMaloCoins;

                    if (ChekCoins < 3)
                    {
                        yn = Selects.AvanzarY_N(Player);
                    }
                    else
                    {
                        Cofres.Cofre(Player, 7);

                        if (Program.Player[Player].Equipo)
                            Program.EquipoBuenoCoins -= 1;
                        else
                            Program.EquipoMaloCoins -= 1;
                    }
                }

                if (yn == "Si")
                {
                    Tablero.laberinto[x, y - 1] = Player;
                    Tablero.laberinto[x, y] = 1;

                    return RestPasos(Player);
                }
                else
                    return Program.Player[Player].Pasos;
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////

            if (Program.chek[Tablero.laberinto[x, y - 1]] == 8)
            {
                yn = Selects.CofreLegendarioY_N(Player);

                if (yn == "Si")
                {
                    if (Program.Player[Player].Equipo)
                        ChekCoins = Program.EquipoBuenoCoins;
                    else
                        ChekCoins = Program.EquipoMaloCoins;

                    if (ChekCoins < 5)
                    {
                        yn = Selects.AvanzarY_N(Player);
                    }
                    else
                    {
                        Cofres.Cofre(Player, 8);

                        if (Program.Player[Player].Equipo)
                            Program.EquipoBuenoCoins -= 1;
                        else
                            Program.EquipoMaloCoins -= 1;
                    }
                }

                if (yn == "Si")
                {
                    Tablero.laberinto[x, y - 1] = Player;
                    Tablero.laberinto[x, y] = 1;

                    return RestPasos(Player);
                }
                else
                    return Program.Player[Player].Pasos;
            }

            if (Program.chek[Tablero.laberinto[x, y - 1]] == 31) // recoge llave de los buenos
            {
                if (Program.Player[Player].Equipo) // buenos
                {
                    Program.EquipoBuenoLlave = true;

                    Tablero.laberinto[x, y - 1] = Player;
                    Tablero.laberinto[x, y] = 1;

                    return RestPasos(Player);
                }
                else // malos
                {
                    Imprime.Print(Player, 55555, 333); // Player / Img / Panel
                    var keyInfo = Console.ReadKey();
                }
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////

            if (Program.chek[Tablero.laberinto[x, y - 1]] == 32) // recoge llave de los malos
            {
                if (!Program.Player[Player].Equipo) // malos
                {
                    Program.EquipoMaloLlave = true;

                    Tablero.laberinto[x, y - 1] = Player;
                    Tablero.laberinto[x, y] = 1;

                    return RestPasos(Player);
                }
                else // Buenos
                {
                    Imprime.Print(Player, 55555, 333); // Player / Img / Panel
                    var keyInfo = Console.ReadKey();
                }
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            if (Program.chek[Tablero.laberinto[x, y - 1]] == 11) // puerta abierta
            {
                if (Program.Player[Player].Equipo)
                {
                    Tablero.laberinto[x, y - 1] = Player;
                    Tablero.laberinto[x, y] = 1;

                    return RestPasos(Player);
                }
                else
                {
                    Imprime.Print(Player, 55555, 4441); // Player / Img / Panel
                    Console.ReadKey();
                }
            }

            if (Program.chek[Tablero.laberinto[x, y - 1]] == 12) // puerta abierta
            {
                if (!Program.Player[Player].Equipo)
                {
                    Tablero.laberinto[x, y - 1] = Player;
                    Tablero.laberinto[x, y] = 1;

                    return RestPasos(Player);
                }
                else
                {
                    Imprime.Print(Player, 55555, 4441); // Player / Img / Panel
                    Console.ReadKey();
                }
            }

            if (Program.chek[Tablero.laberinto[x, y - 1]] == 111) // puerta cerrada
            {
                Imprime.Print(Player, 55555, 444); // Player / Img / Panel
                Console.ReadKey();
            }
        }
        if (Direccion == 'd')
        {
            if (Program.chek[Tablero.laberinto[x, y + 1]] == 0)
                return Program.Player[Player].Pasos;

            if (
                Program.chek[Tablero.laberinto[x, y + 1]] == 1
                || Program.chek[Tablero.laberinto[x, y + 1]] == 151
                || Program.chek[Tablero.laberinto[x, y + 1]] == 252
                || Program.chek[Tablero.laberinto[x, y + 1]] == 353
                || Program.chek[Tablero.laberinto[x, y + 1]] == 454
            )
            {
                Tablero.laberinto[x, y + 1] = Player;
                Tablero.laberinto[x, y] = 1;

                return RestPasos(Player);
            }

            if (Program.chek[Tablero.laberinto[x, y + 1]] == 20)
            {
                int Ficha = Tablero.laberinto[x, y + 1];

                Tablero.laberinto[x, y + 1] = Tablero.laberinto[x, y];
                Tablero.laberinto[x, y] = Ficha;

                return RestPasos(Player);
            }

            if (Program.chek[Tablero.laberinto[x, y + 1]] == 3)
            {
                Trampas.Trampa(Tablero.laberinto[x, y + 1], Player, x, y + 1, x, y, Direccion);

                return RestPasos(Player);
            }

            if (Program.chek[Tablero.laberinto[x, y + 1]] == 4)
            {
                Bufss.Buff(Tablero.laberinto[x, y + 1], Player, x, y + 1, x, y);

                return RestPasos(Player);
            }

            if (Program.chek[Tablero.laberinto[x, y + 1]] == 5)
            {
                Tablero.laberinto[x, y] = 1;
                return 555;
            }

            if (Program.chek[Tablero.laberinto[x, y + 1]] == 2)
            {
                if (Program.Player[Player].Equipo)
                    Program.EquipoBuenoCoins = Program.EquipoBuenoCoins + 1;
                else
                    Program.EquipoMaloCoins = Program.EquipoMaloCoins + 1;

                Tablero.laberinto[x, y + 1] = Player;
                Tablero.laberinto[x, y] = 1;

                return RestPasos(Player);
            }

            if (Program.chek[Tablero.laberinto[x, y + 1]] == 6)
            {
                yn = Selects.CofreComunY_N(Player);

                if (yn == "Si")
                {
                    if (Program.Player[Player].Equipo)
                        ChekCoins = Program.EquipoBuenoCoins;
                    else
                        ChekCoins = Program.EquipoMaloCoins;

                    if (ChekCoins < 1)
                    {
                        yn = Selects.AvanzarY_N(Player);
                    }
                    else
                    {
                        Cofres.Cofre(Player, 6);

                        if (Program.Player[Player].Equipo)
                            Program.EquipoBuenoCoins -= 1;
                        else
                            Program.EquipoMaloCoins -= 1;
                    }
                }

                if (yn == "Si")
                {
                    Tablero.laberinto[x, y + 1] = Player;
                    Tablero.laberinto[x, y] = 1;

                    return RestPasos(Player);
                }
                else
                    return Program.Player[Player].Pasos;
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////

            if (Program.chek[Tablero.laberinto[x, y + 1]] == 7)
            {
                yn = Selects.CofreEpicoY_N(Player);

                if (yn == "Si")
                {
                    if (Program.Player[Player].Equipo)
                        ChekCoins = Program.EquipoBuenoCoins;
                    else
                        ChekCoins = Program.EquipoMaloCoins;

                    if (ChekCoins < 3)
                    {
                        yn = Selects.AvanzarY_N(Player);
                    }
                    else
                    {
                        Cofres.Cofre(Player, 7);

                        if (Program.Player[Player].Equipo)
                            Program.EquipoBuenoCoins -= 1;
                        else
                            Program.EquipoMaloCoins -= 1;
                    }
                }

                if (yn == "Si")
                {
                    Tablero.laberinto[x, y + 1] = Player;
                    Tablero.laberinto[x, y] = 1;

                    return RestPasos(Player);
                }
                else
                    return Program.Player[Player].Pasos;
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////

            if (Program.chek[Tablero.laberinto[x, y + 1]] == 8)
            {
                if (Program.Player[Player].Equipo)
                    ChekCoins = Program.EquipoBuenoCoins;
                else
                    ChekCoins = Program.EquipoMaloCoins;

                if (ChekCoins < 5)
                {
                    yn = Selects.AvanzarY_N(Player);
                }
                else
                {
                    Cofres.Cofre(Player, 8);

                    if (Program.Player[Player].Equipo)
                        Program.EquipoBuenoCoins -= 1;
                    else
                        Program.EquipoMaloCoins -= 1;
                }
                if (yn == "Si")
                {
                    Tablero.laberinto[x, y + 1] = Player;
                    Tablero.laberinto[x, y] = 1;

                    return RestPasos(Player);
                }
                else
                    return Program.Player[Player].Pasos;
            }

            if (Program.chek[Tablero.laberinto[x, y + 1]] == 31) // recoge ficha de los buenos
            {
                if (Program.Player[Player].Equipo) // buenos
                {
                    Program.EquipoBuenoLlave = true;

                    Tablero.laberinto[x, y + 1] = Player;
                    Tablero.laberinto[x, y] = 1;

                    return RestPasos(Player);
                }
                else // malos
                {
                    Imprime.Print(Player, 55555, 333); // Player / Img / Panel
                    var keyInfo = Console.ReadKey();
                }
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////

            if (Program.chek[Tablero.laberinto[x, y + 1]] == 32) // recoge ficha de los malos
            {
                if (!Program.Player[Player].Equipo) // malos
                {
                    Program.EquipoMaloLlave = true;

                    Tablero.laberinto[x, y + 1] = Player;
                    Tablero.laberinto[x, y] = 1;

                    return RestPasos(Player);
                }
                else // Buenos
                {
                    Imprime.Print(Player, 55555, 333); // Player / Img / Panel
                    var keyInfo = Console.ReadKey();
                }
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            if (Program.chek[Tablero.laberinto[x, y + 1]] == 11) // puerta abierta
            {
                if (Program.Player[Player].Equipo)
                {
                    Tablero.laberinto[x, y + 1] = Player;
                    Tablero.laberinto[x, y] = 1;

                    return RestPasos(Player);
                }
                else
                {
                    Imprime.Print(Player, 55555, 4441); // Player / Img / Panel
                    Console.ReadKey();
                }
            }

            if (Program.chek[Tablero.laberinto[x, y + 1]] == 12) // puerta abierta
            {
                if (!Program.Player[Player].Equipo)
                {
                    Tablero.laberinto[x, y + 1] = Player;
                    Tablero.laberinto[x, y] = 1;

                    return RestPasos(Player);
                }
                else
                {
                    Imprime.Print(Player, 55555, 4441); // Player / Img / Panel
                    Console.ReadKey();
                }
            }

            if (Program.chek[Tablero.laberinto[x, y + 1]] == 111) // puerta cerrada
            {
                Imprime.Print(Player, 55555, 444); // Player / Img / Panel
                Console.ReadKey();
            }
        }

        return Program.Player[Player].Pasos;
    }
}
