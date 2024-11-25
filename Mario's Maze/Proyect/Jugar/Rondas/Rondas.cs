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

            int player = Fichas[a];

            int ejex = 1;
            int ejey = 1;

            if (player != 0)
            {
                // Turnos
                while (Jugando > 0)
                {

                    // inmovil 
                    if (Program.Player[player].Inmovil) break;

                    // Pocision del player

                    for (int fila = 1; fila < Tablero.filas; fila++)
                    {
                        for (int columna = 1; columna < Tablero.columnas; columna++)
                        {

                            if (Tablero.laberinto[fila, columna] == player)
                            {

                                ejex = fila;
                                ejey = columna;
                                break;

                            }
                        }

                    }

                    // Actualizar interfaz
                    Console.Clear();

                    Tablero.UpdateNiebla(player, ejex, ejey);
                    Interfaz.Imprimir(player);

                    Console.WriteLine("");
                    Console.WriteLine("     Player: " + Program.Player[player].Name);
                    Console.WriteLine("     Pasos:  " + Program.Player[player].Pasos);
                    Console.WriteLine("     Inmune: " + Program.Player[player].Inmune);
                    Console.WriteLine("");



                    var keyInfo = Console.ReadKey();

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
                    {
                        Program.Player[player].Pasos = Program.Player[player].PasosStatic;
                        Jugando = 0;
                    }


                    // [F] Habilidad 
                    if (keyInfo.KeyChar == 'f')
                    {
                        if (Program.Player[player].PasosCont >= Program.Player[player].Habilidad)
                            Habilidades.Habilidad(player, ejex, ejey);
                        else // todavia no haz cargado la habilidad
                            Console.WriteLine("todavia");
                    }



                    // [A][W][S][D] Moverse  
                    if (keyInfo.KeyChar == 'w' || keyInfo.KeyChar == 's' || keyInfo.KeyChar == 'd' || keyInfo.KeyChar == 'a')
                    {

                        Jugando = Jugar.Mover(player, keyInfo.KeyChar);

                    }
                    //WIN pendiente ///////
                    if (Jugando == 50) break;
                }


                // Pocision del player para niebla

                for (int fila = 1; fila < Tablero.filas; fila++)
                {
                    for (int columna = 1; columna < Tablero.columnas; columna++)
                    {

                        if (Tablero.laberinto[fila, columna] == player)
                        {

                            ejex = fila;
                            ejey = columna;
                            break;

                        }
                    }

                }

                Tablero.UpdateNiebla(player, ejex, ejey);



                // COLDOWNS

                //buff inmunidad

                if (Program.Player[player].Inmune)
                    Program.Player[player].Inmune = false;

                //Buff pasos
                if (Program.Player[player].BufPasos)
                {
                    Program.Player[player].Pasos = Program.Player[player].PasosStatic;
                    Program.Player[player].BufPasos = false;

                }

                //Buff vision
                if (Program.Player[player].BufVision)
                {

                    Program.Player[player].Vision = Program.Player[player].VisionStatic;
                    Program.Player[player].BufVision = false;

                }


                //Inmobilidad
                if (Program.Player[player].Inmovil)
                {

                    Trampas.PlacaQuitar(player);
                    Program.Player[player].Inmovil = false;
                    Program.Player[player].Pasos = Program.Player[player].PasosStatic;

                }

                // WIN 
                if (Jugando == 50)
                {

                    FichaWin(player);
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

    static void FichaWin(int player)
    {

        for (int i = 0; i < Fichas.Count; i++)
        {

            if (Fichas[i] == player)
            {

                Fichas[i] = 0;
            }


        }


    }


}