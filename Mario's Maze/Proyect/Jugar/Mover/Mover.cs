
public class Jugar
{
    public static int Mover(int Player, char Direccion)
    {
        int x=1;
        int y=1;

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
            if (Program.chek[Tablero.laberinto[x - 1, y]] == 1)
            {
                Tablero.laberinto[x - 1, y] = Player;
                Tablero.laberinto[x, y] = 1;

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

            if (Program.chek[Tablero.laberinto[x - 1, y]] == 2)
                return Program.Player[Player].Pasos;

            if (Program.chek[Tablero.laberinto[x - 1, y]] == 0)
                return Program.Player[Player].Pasos;

            if (Program.chek[Tablero.laberinto[x - 1, y]] == 3)
            {
                Trampas.Trampa(Tablero.laberinto[x - 1, y], Player, x - 1, y, x, y, Direccion);
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

            if (Program.chek[Tablero.laberinto[x - 1, y]] == 4)
            {
                Bufss.Buff(Tablero.laberinto[x - 1, y], Player, x - 1, y, x, y);
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

            if (Program.chek[Tablero.laberinto[x - 1, y]] == 55)
            {
                Tablero.laberinto[x, y] = 1;
                return 50; // win
            }


            if (Program.chek[Tablero.laberinto[x - 1, y]] == 0)
                return Program.Player[Player].Pasos;
        }
        if (Direccion == 's')
        {
            if (Program.chek[Tablero.laberinto[x + 1, y]] == 1)
            {
                Tablero.laberinto[x + 1, y] = Player;
                Tablero.laberinto[x, y] = 1;
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

            if (Program.chek[Tablero.laberinto[x + 1, y]] == 2)
                return Program.Player[Player].Pasos;

            if (Program.chek[Tablero.laberinto[x + 1, y]] == 0)
                return Program.Player[Player].Pasos;

            if (Program.chek[Tablero.laberinto[x + 1, y]] == 3)
            {
                Trampas.Trampa(Tablero.laberinto[x + 1, y], Player, x + 1, y, x, y, Direccion);
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

            if (Program.chek[Tablero.laberinto[x + 1, y]] == 4)
            {
                Bufss.Buff(Tablero.laberinto[x + 1, y], Player, x + 1, y, x, y);
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

            if (Program.chek[Tablero.laberinto[x + 1, y]] == 55)
            {
                Tablero.laberinto[x, y] = 1;
                return 50; // win
            }

            if (Program.chek[Tablero.laberinto[x + 1, y]] == 0)
                return Program.Player[Player].Pasos;
        }
        if (Direccion == 'a')
        {
            if (Program.chek[Tablero.laberinto[x, y - 1]] == 1)
            {
                Tablero.laberinto[x, y - 1] = Player;
                Tablero.laberinto[x, y] = 1;
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

            if (Program.chek[Tablero.laberinto[x, y - 1]] == 2)
                return Program.Player[Player].Pasos;

            if (Program.chek[Tablero.laberinto[x, y - 1]] == 0)
                return Program.Player[Player].Pasos;

            if (Program.chek[Tablero.laberinto[x, y - 1]] == 3)
            {
                Trampas.Trampa(Tablero.laberinto[x, y - 1], Player, x, y - 1, x, y, Direccion);
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

            if (Program.chek[Tablero.laberinto[x, y - 1]] == 4)
            {
                Bufss.Buff(Tablero.laberinto[x, y - 1], Player, x, y - 1, x, y);
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

            if (Program.chek[Tablero.laberinto[x, y - 1]] == 5)
            {
                Tablero.laberinto[x, y] = 1;
                return 50; // win
            }

            if (Program.chek[Tablero.laberinto[x, y - 1]] == 0)
                return Program.Player[Player].Pasos;
        }
        if (Direccion == 'd')
        {
            if (Program.chek[Tablero.laberinto[x, y + 1]] == 1)
            {
                Tablero.laberinto[x, y + 1] = Player;
                Tablero.laberinto[x, y] = 1;
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

            if (Program.chek[Tablero.laberinto[x, y + 1]] == 2)
                return Program.Player[Player].Pasos;

            if (Program.chek[Tablero.laberinto[x, y + 1]] == 0)
                return Program.Player[Player].Pasos;

            if (Program.chek[Tablero.laberinto[x, y + 1]] == 3)
            {
                Trampas.Trampa(Tablero.laberinto[x, y + 1], Player, x, y + 1, x, y, Direccion);
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

            if (Program.chek[Tablero.laberinto[x, y + 1]] == 4)
            {
                Bufss.Buff(Tablero.laberinto[x, y + 1], Player, x, y + 1, x, y);
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

            if (Program.chek[Tablero.laberinto[x, y + 1]] == 5)
            {
                Tablero.laberinto[x, y] = 1;
                return 50; // win
            }

            if (Program.chek[Tablero.laberinto[x, y + 1]] == 0)
                return Program.Player[Player].Pasos;
        }


        return Program.Player[Player].Pasos;
    }
}
