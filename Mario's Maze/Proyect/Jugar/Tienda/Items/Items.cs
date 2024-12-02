using Spectre.Console;

public class Items
{
    static string PlayerSelect = "";
    static string DireccionSelect = "";

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
                    if (
                        Program.Player[Rondas.EquipoBuenosList[0]].Name == PlayerSelect
                        || Program.Player[Rondas.EquipoBuenosList[1]].Name == PlayerSelect
                        || Program.Player[Rondas.EquipoBuenosList[2]].Name == PlayerSelect
                    )
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
                    if (
                        Program.Player[Rondas.EquipoMalosList[0]].Name == PlayerSelect
                        || Program.Player[Rondas.EquipoMalosList[1]].Name == PlayerSelect
                        || Program.Player[Rondas.EquipoMalosList[2]].Name == PlayerSelect
                    )
                        c++;
            }
        }

        Program.Player[Program.Nombre[PlayerSelect]].Inmune = true;
    }

    public static void Escalera(int Player)
    {
        int c = 0;

        // panel

        if (Program.Player[Player].Equipo) // Buenos
        {
            while (c == 0) // Seleccione player para equipar
            {
                
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
        else // Malos
        {
            while (c == 0) // Seleccione player para equipar
            {
                
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

        ////////////////////////////////////////////////////////////////////////////////////////////////

        for (int x = 1; x < Tablero.filas; x++)
        {
            for (int y = 1; y < Tablero.columnas; y++)
            {
                if (Tablero.laberinto[x, y] == Program.Nombre[PlayerSelect])
                {
                    while (true)
                    {
                        
                        Console.Clear();
                        Interfaz.Imprimir(Player);

                        DireccionSelect = Selects.SelectEscalera();

                        if (DireccionSelect == "Arriba")
                        {
                            if (x - 1 > 0 )
                            {
                                Tablero.laberinto[x - 1, y] = 151;

                                if (Tablero.laberinto[x - 2, y] == 0 && x - 2 > 0)
                                    Tablero.laberinto[x - 2, y] = 1;

                                break;
                            }
                        }
                        if (DireccionSelect == "Abajo")
                        {
                            if (x + 1 < 30 )
                            {
                                Tablero.laberinto[x + 1, y] = 252;

                                if (Tablero.laberinto[x - 2, y] == 0 && x + 2 < 30)
                                    Tablero.laberinto[x - 2, y] = 1;
                                break;
                            }
                        }
                        if (DireccionSelect == "Izquierda")
                        {
                            if (y - 1 > 0 )
                            {
                                Tablero.laberinto[x, y - 1] = 353;

                                if (Tablero.laberinto[x, y - 2] == 0 && y - 2 > 0)
                                    Tablero.laberinto[x, y - 2] = 1;
                                break;
                            }
                        }
                        if (DireccionSelect == "Derecha")
                        {
                            if (y + 1 < 30 )
                            {
                                Tablero.laberinto[x, y + 1] = 454;

                                if (Tablero.laberinto[x, y + 2] == 0 && y + 2 < 30)
                                    Tablero.laberinto[x, y + 2] = 1;
                                break;
                            }
                        }

                        // panel aqui no puedes poner una escalera
                    }
                }
            }
        }
    }

    /* public static void Tubo(int Player)
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

        for (int x = 1; x < Tablero.filas; x++)
        {
            for (int y = 1; y < Tablero.columnas; y++)
            {

                if (Tablero.laberinto[x, y] == Program.Nombre[PlayerSelect])
                {

                    if (x < 15) // arriba
                    {

                        for (int i = x; i <= x + 5; i++)
                        {
                            for (int j = y - 2; j <= y + 2; j++)
                            {
                                if (i > 1 && i < 29 && j > 1 && j < 29)
                                {
                                    if (Tablero.laberinto[i, j] == 1)
                                        Count++;
                                }
                                if (Count == 5)
                                {

                                    Tablero.laberinto[x, y] = 1;
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

                        for (int i = x - 5; i <= x; i++)
                        {
                            for (int j = y - 2; j <= y + 2; j++)
                            {
                                if (i > 1 && i < 29 && j > 1 && j < 29)
                                {
                                    if (Tablero.laberinto[i, j] == 1)
                                        Count++;
                                }
                                if (Count == 5)
                                {

                                    Tablero.laberinto[x, y] = 1;
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
    } */
}
