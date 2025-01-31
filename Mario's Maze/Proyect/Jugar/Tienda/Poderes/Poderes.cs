using Spectre.Console;

public class Poderes
{
    static int PlayerSelect;
    static char SelectDireccion;

    static int PunteroX;
    static int PunteroY;

    static int PlayerX;
    static int PlayerY;

    public static void Bala(int Player)
    {
        int c = 0;

        if (!Program.Player[Player].Equipo) // Malos
        {
            while (c == 0) // Seleccione player para equipar
            {
                PlayerSelect = Selects.SelectPlayerBuenos(Player);

                for (int i = 0; i < Rondas.EquipoBuenosList.Count; i++)
                    if (Rondas.EquipoBuenosList[i] == PlayerSelect)
                        c++;
            }
        }
        else // Buenos
        {
            while (c == 0) // Seleccione player para equipar
            {
                PlayerSelect = Selects.SelectPlayerMalos(Player);

                for (int i = 0; i < Rondas.EquipoMalosList.Count; i++)
                    if (Rondas.EquipoMalosList[i] == PlayerSelect)
                        c++;
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        for (int x = 1; x < Tablero.filas; x++)
        {
            for (int y = 1; y < Tablero.columnas; y++)
            {
                if (Tablero.laberinto[x, y] == PlayerSelect)
                {
                    Tablero.Puntero[x, y] = true;
                    PunteroX = x;
                    PunteroY = y;
                    PlayerX = x;
                    PlayerY = y;
                    x = Tablero.filas;
                    goto jump;
                }
            }
        }

        jump:

        c = 0;

        while (c < 5)
        {
            SelectDireccion = Selects.Direccion(Player);

            if (
                SelectDireccion == 'w'
                && PunteroX - 1 > 0
                && PunteroX - 1 > PlayerX - 2
                && PunteroY == PlayerY
                && Tablero.laberinto[PunteroX - 1, PunteroY] != 0
            )
            {
                Tablero.Puntero[PunteroX - 1, PunteroY] = true;
                Tablero.Puntero[PunteroX, PunteroY] = false;
                PunteroX = PunteroX - 1;
            }
            if (
                SelectDireccion == 's'
                && PunteroX + 1 < 30
                && PunteroX + 1 < PlayerX + 2
                && PunteroY == PlayerY
                && Tablero.laberinto[PunteroX + 1, PunteroY] != 0
            )
            {
                Tablero.Puntero[PunteroX + 1, PunteroY] = true;
                Tablero.Puntero[PunteroX, PunteroY] = false;
                PunteroX = PunteroX + 1;
            }
            if (
                SelectDireccion == 'a'
                && PunteroY - 1 > 0
                && PunteroY - 1 > PlayerY - 2
                && PunteroX == PlayerX
                && Tablero.laberinto[PunteroX, PunteroY - 1] != 0
            )
            {
                Tablero.Puntero[PunteroX, PunteroY - 1] = true;
                Tablero.Puntero[PunteroX, PunteroY] = false;
                PunteroY = PunteroY - 1;
            }
            if (
                SelectDireccion == 'd'
                && PunteroY + 1 < 30
                && PunteroY + 1 < PlayerY + 2
                && PunteroX == PlayerX
                && Tablero.laberinto[PunteroX, PunteroY + 1] != 0
            )
            {
                Tablero.Puntero[PunteroX, PunteroY + 1] = true;
                Tablero.Puntero[PunteroX, PunteroY] = false;
                PunteroY = PunteroY + 1;
            }
            if (SelectDireccion == 'e')
            {
                Tablero.Puntero[PunteroX, PunteroY] = false;
                Tablero.laberinto[PlayerX, PlayerY] = 1;

                Tablero.laberinto[PunteroX, PunteroY] = PlayerSelect;
                PlayerX = PunteroX;
                PlayerY = PunteroY;
                c++;
            }
        }
    }

    public static void Mascara(int Player)
    {
        int c = 0;

        if (!Program.Player[Player].Equipo) // Malos
        {
            while (c == 0) // Seleccione player para equipar
            {
                PlayerSelect = Selects.SelectPlayerBuenos(Player);

                for (int i = 0; i < Rondas.EquipoBuenosList.Count; i++)
                    if (Rondas.EquipoBuenosList[i] == PlayerSelect)
                        c++;
            }
        }
        else // Buenos
        {
            while (c == 0) // Seleccione player para equipar
            {
                PlayerSelect = Selects.SelectPlayerMalos(Player);

                for (int i = 0; i < Rondas.EquipoMalosList.Count; i++)
                    if (Rondas.EquipoMalosList[i] == PlayerSelect)
                        c++;
            }
        }

        Program.Player[PlayerSelect].BufVision = 1;
        Program.Player[PlayerSelect].Vision = 0;
    }
}
