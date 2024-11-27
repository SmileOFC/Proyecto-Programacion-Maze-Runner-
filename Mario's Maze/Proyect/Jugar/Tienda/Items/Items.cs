using Spectre.Console;

public class Items
{
    
    static string PlayerSelect = "";

    public static void Escudo(int Player)
    {
         int c = 0;

        if (Program.Player[Player].Equipo) // Buenos
        {

            while (c == 0) // Seleccione player para equipar
            {
                Console.Clear();
                Interfaz.Imprimir(Player);

                PlayerSelect = Selects.SelectPlayerBuenos();

                for (int i = 0; i < Rondas.EquipoBuenosList.Count; i++)
                    if (Program.Player[Rondas.EquipoBuenosList[0]].Name == PlayerSelect || Program.Player[Rondas.EquipoBuenosList[1]].Name == PlayerSelect || Program.Player[Rondas.EquipoBuenosList[2]].Name == PlayerSelect)
                        c++;
            }

        }
        else // Malos
        {

            while (c == 0) // Seleccione player para equipar
            {
                Console.Clear();
                Interfaz.Imprimir(Player);

                PlayerSelect = Selects.SelectPlayerMalos();

                for (int i = 0; i < Rondas.EquipoMalosList.Count; i++)
                    if (Program.Player[Rondas.EquipoMalosList[0]].Name == PlayerSelect || Program.Player[Rondas.EquipoMalosList[1]].Name == PlayerSelect || Program.Player[Rondas.EquipoMalosList[2]].Name == PlayerSelect)
                        c++;
            }
        }

        Program.Player[Program.Nombre[PlayerSelect]].Inmune = true;

    }

    public static void Escalera(int Player)
    {
        int c = 0;
        
        if (Program.Player[Player].Equipo) // Buenos
        {

            while (c == 0) // Seleccione player para equipar
            {
                Console.Clear();
                Interfaz.Imprimir(Player);

                PlayerSelect = Selects.SelectPlayerBuenos();

                for (int i = 0; i < Rondas.EquipoBuenosList.Count; i++)
                    if (Program.Player[Rondas.EquipoBuenosList[0]].Name == PlayerSelect || Program.Player[Rondas.EquipoBuenosList[1]].Name == PlayerSelect || Program.Player[Rondas.EquipoBuenosList[2]].Name == PlayerSelect)
                        c++;
            }
        }
        else // Malos
        {

            while (c == 0) // Seleccione player para equipar
            {
                Console.Clear();
                Interfaz.Imprimir(Player);

                PlayerSelect = Selects.SelectPlayerMalos();

                for (int i = 0; i < Rondas.EquipoMalosList.Count; i++)
                    if (Program.Player[Rondas.EquipoMalosList[0]].Name == PlayerSelect || Program.Player[Rondas.EquipoMalosList[1]].Name == PlayerSelect || Program.Player[Rondas.EquipoMalosList[2]].Name == PlayerSelect)
                        c++;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////

        for (int fila = 1; fila < Tablero.filas; fila++)
        {
            for (int columna = 1; columna < Tablero.columnas; columna++)
            {

                if (Tablero.laberinto[fila, columna] == Program.Nombre[PlayerSelect])
                {

                    if (fila < 15) // arriba
                    {
                        Tablero.laberinto[fila + 1, columna] = 51; //puente
                        Tablero.laberinto[fila + 2, columna] = 1;

                    }
                    else // abajo
                    {
                        Tablero.laberinto[fila - 1, columna] = 51; //puente
                        Tablero.laberinto[fila - 2, columna] = 1;

                    }
                }
            }
        }
    }

    public static void Tubo(int Player)
    {
        int c = 0;
        int Count = 0;

        if (Program.Player[Player].Equipo) // Buenos
        {

            while (c == 0) // Seleccione player para equipar
            {
                Console.Clear();
                Interfaz.Imprimir(Player);

                PlayerSelect = Selects.SelectPlayerBuenos();

                for (int i = 0; i < Rondas.EquipoBuenosList.Count; i++)
                    if (Program.Player[Rondas.EquipoBuenosList[0]].Name == PlayerSelect || Program.Player[Rondas.EquipoBuenosList[1]].Name == PlayerSelect || Program.Player[Rondas.EquipoBuenosList[2]].Name == PlayerSelect)
                        c++;
            }
        }
        else // Malos
        {

            while (c == 0) // Seleccione player para equipar
            {
                Console.Clear();
                Interfaz.Imprimir(Player);

                PlayerSelect = Selects.SelectPlayerMalos();

                for (int i = 0; i < Rondas.EquipoMalosList.Count; i++)
                    if (Program.Player[Rondas.EquipoMalosList[0]].Name == PlayerSelect || Program.Player[Rondas.EquipoMalosList[1]].Name == PlayerSelect || Program.Player[Rondas.EquipoMalosList[2]].Name == PlayerSelect)
                        c++;
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////

        for (int fila = 1; fila < Tablero.filas; fila++)
        {
            for (int columna = 1; columna < Tablero.columnas; columna++)
            {

                if (Tablero.laberinto[fila, columna] == Program.Nombre[PlayerSelect])
                {

                    if (fila < 15) // arriba
                    {

                        for (int i = fila; i <= fila + 5; i++)
                        {
                            for (int j = columna - 2; j <= columna + 2; j++)
                            {
                                if (i > 1 && i < 29 && j > 1 && j < 29)
                                {
                                    if (Tablero.laberinto[i, j] == 1)
                                        Count++;
                                }
                                if (Count == 5)
                                {

                                    Tablero.laberinto[fila, columna] = 1;
                                    Tablero.laberinto[i, j] = Program.Nombre[PlayerSelect];
                                    break;

                                }
                            }

                            if (Count == 5)
                                break;
                        }
                    }
                    else // abajo
                    {

                        for (int i = fila - 5; i <= fila; i++)
                        {
                            for (int j = columna - 2; j <= columna + 2; j++)
                            {
                                if (i > 1 && i < 29 && j > 1 && j < 29)
                                {
                                    if (Tablero.laberinto[i, j] == 1)
                                        Count++;
                                }
                                if (Count == 5)
                                {

                                    Tablero.laberinto[fila, columna] = 1;
                                    Tablero.laberinto[i, j] = Program.Nombre[PlayerSelect];
                                    break;

                                }
                            }

                            if (Count == 5)
                                break;
                        }
                    }
                }
            }
        }
    }
}