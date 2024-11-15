public class Rondas
{

    public static List<int> Fichas = new List<int>(Picks.Fichas.ToArray());

    public static void Ronda()
    {
        int cont = 0;

        Tablero.GenerarTablero();
        int Jugando;

        // Rondas
        for (int a = 0; ; a++)
        {

            Jugando = 1;

            if (a == 6) a = 0;

            int x = Fichas[a];

            if (x != 0)
            {
                // Turnos
                while (Jugando > 0)
                {

                    // Actualizar inmunidad
                    if (Program.Player[x].Inmovil > 0) break;

                    // Activar buff
                    if (Program.Player[x].BufInmune)
                    {
                        Program.Player[x].Inmune = 1;
                        Program.Player[x].BufInmune = false;
                    }
                    
                    // Pocision del player
                    int[] xy = new int[2];

                    for (int i = 1; i < Tablero.filas; i++)
                    {
                        for (int j = 1; j < Tablero.columnas; j++)
                        {

                            if (Tablero.laberinto[i, j] == x)
                            {

                                xy[0] = i;
                                xy[1] = j;

                            }
                        }
                    }

                    // Actualizar interfaz
                    Console.Clear();

                    Tablero.UpdateNiebla(x,xy[0],xy[1]);
                    Interfaz.Imprimir(x);

                    Console.WriteLine("");
                    Console.WriteLine("     Player: " + Program.Player[x].Name);
                    Console.WriteLine("     Pasos:  " + Program.Player[x].Pasos);
                    Console.WriteLine("     Inmune: " + Program.Player[x].Inmune);
                    Console.WriteLine("     Coordenadas: "+xy[0]+","+xy[1]);
                    Console.WriteLine("");

                    
                    
                    var keyInfo = Console.ReadKey(true);

                    // [E] Interactuar Pendiente ///////////////
                    if (keyInfo.KeyChar == 'e')
                        Jugando = 30;

                    // [Q] Inventario Pendiente ///////////////
                    if (keyInfo.KeyChar == 'q')
                        Jugando = 30;

                    // [Esc] Menu Pendiente //////////////////
                    if (keyInfo.Key == ConsoleKey.Escape)
                        Jugando = 40;

                    // [R] Cancelar turno
                    if (keyInfo.KeyChar == 'r')
                        Jugando = 0;

                    // [F] Habilidad Pendiente //////////////////
                    if (keyInfo.KeyChar == 'f')
                        Habilidades.Habilidad();


                    // [A][W][S][D] Moverse  
                    if (keyInfo.KeyChar == 'w' || keyInfo.KeyChar == 's' || keyInfo.KeyChar == 'd' || keyInfo.KeyChar == 'a')
                    {

                        Jugando = Jugar.Mover(x, keyInfo.KeyChar);

                    }
                    //WIN
                    if (Jugando == 50) break;
                }

                // COLDOWNS

                // Inmunidad
                if (Program.Player[x].Inmune > 0)
                    Program.Player[x].Inmune = Program.Player[x].Inmune - 1;

                //Inmobilidad
                if (Program.Player[x].Inmovil > 0)
                {

                    Trampas.PlacaQuitar();
                    Program.Player[x].Inmovil = Program.Player[x].Inmovil - 1;

                }

                // WIN 
                if (Jugando == 50)
                {

                    FichaWin(x);
                    break;
                }
            }

            for (int j = 0; j < Fichas.Count; j++)
                if (Fichas[j] == 0)
                    cont++;
            if (cont == 3)
                break;

        }
    }

    static void FichaWin(int x)
    {

        for (int i = 0; i < Fichas.Count; i++)
        {

            if (Fichas[i] == x)
            {

                Fichas[i] = 0;
            }


        }


    }


}