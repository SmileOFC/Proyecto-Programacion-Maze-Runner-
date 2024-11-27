using Spectre.Console;
using SixLabors.ImageSharp;

public class Rondas
{

    public static List<int> FichasList = new List<int>(Picks.Fichas.ToArray());
    public static List<int> EquipoMalosList = new List<int>(Picks.EquipoMalos.ToArray());
    public static List<int> EquipoBuenosList = new List<int>(Picks.EquipoBuenos.ToArray());

    public static void Ronda()
    {
        int EquipoBuenoWin = 0;
        int EquipoMaloWin = 0;


        Tablero.GenerarTablero();
        int Jugando;

        // Rondas
        for (int a = 0; ; a++)
        {

            Jugando = 1;

            if (a == 6) a = 0;

            int Player = FichasList[a];

            int ejex = 1;
            int ejey = 1;

            if (Player != 0)
            {
                // Turnos
                while (Jugando > 0)
                {

                    // inmovil 
                    if (Program.Player[Player].Inmovil) break;

                    // Pocision del Player

                    for (int fila = 1; fila < Tablero.filas; fila++)
                    {
                        for (int columna = 1; columna < Tablero.columnas; columna++)
                        {

                            if (Tablero.laberinto[fila, columna] == Player)
                            {

                                ejex = fila;
                                ejey = columna;
                                break;

                            }
                        }

                    }

                    // Actualizar interfaz
                    Console.Clear();

                    Tablero.UpdateNiebla(Player, ejex, ejey);
                    Interfaz.Imprimir(Player);

                    Console.WriteLine("");
                    Console.WriteLine("     Player: " + Program.Player[Player].Name);
                    Console.WriteLine("     Pasos :  " + Program.Player[Player].Pasos);
                    Console.WriteLine("     Koopa : " + Program.Player[27].Habilidad);
                    Console.WriteLine("");



                    var keyInfo = Console.ReadKey();

                    // [T] Tienda 
                    if (keyInfo.KeyChar == 't')
                        Tienda.Comprar(Player);

                    // [Q] Inventario Pendiente ///////////////
                    if (keyInfo.KeyChar == 'q')
                        Jugando = 30;

                    // [Esc] Menu Pendiente //////////////////
                    if (keyInfo.Key == ConsoleKey.Escape)
                        Jugando = 40;

                    // [R] Cancelar turno
                    if (keyInfo.KeyChar == 'r')
                    {
                        Program.Player[Player].Pasos = Program.Player[Player].PasosStatic;
                        Jugando = 0;
                    }


                    // [F] Habilidad 
                    if (keyInfo.KeyChar == 'f')
                    {
                        if (Program.Player[Player].PasosCont >= Program.Player[Player].Habilidad)
                            Habilidades.Habilidad(Player, ejex, ejey);
                        else // todavia no haz cargado la habilidad
                            Console.WriteLine("todavia");
                    }

                    // [A][W][S][D] Moverse  
                    if (keyInfo.KeyChar == 'w' || keyInfo.KeyChar == 's' || keyInfo.KeyChar == 'd' || keyInfo.KeyChar == 'a')
                    {

                        Jugando = Jugar.Mover(Player, keyInfo.KeyChar);

                    }
                    // Ficha Buenos Meta 
                    if (Jugando == 515)
                    {

                        EquipoBuenoWin += 1;
                        break;
                    }

                    // Ficha Malos Meta 
                    if (Jugando == 525)
                    {

                        EquipoMaloWin += 1;
                        break;
                    }

                    // QUitar puertas

                    if (Program.EquipoBuenoLlave)
                    {
                        if (Tablero.laberinto[13, 15] == 313)
                            Tablero.laberinto[13, 15] = 1;
                        else
                            Tablero.laberinto[17, 15] = 1;

                    }

                    if (Program.EquipoMaloLlave)
                    {

                        if (Tablero.laberinto[13, 15] == 323)
                            Tablero.laberinto[13, 15] = 1;
                        else
                            Tablero.laberinto[17, 15] = 1;

                    }

                    // Update Coldown Habilidad de Koopa/Wario

                    Program.Player[27].Habilidad = Program.Player[27].PasosStatic * 3;

                    Program.Player[29].Habilidad = Program.Player[29].VisionStatic * 3;

                }

                // Pocision del Player para niebla

                for (int fila = 1; fila < Tablero.filas; fila++)
                {
                    for (int columna = 1; columna < Tablero.columnas; columna++)
                    {

                        if (Tablero.laberinto[fila, columna] == Player)
                        {

                            ejex = fila;
                            ejey = columna;
                            break;

                        }
                    }

                }

                Tablero.UpdateNiebla(Player, ejex, ejey);

                // COLDOWNS

                //buff inmunidad

                if (Program.Player[Player].Inmune)
                    Program.Player[Player].Inmune = false;

                //Buff pasos
                if (Program.Player[Player].BufPasos)
                {
                    Program.Player[Player].Pasos = Program.Player[Player].PasosStatic;
                    Program.Player[Player].BufPasos = false;

                }

                //Buff vision
                if (Program.Player[Player].BufVision)
                {

                    Program.Player[Player].Vision = Program.Player[Player].VisionStatic;
                    Program.Player[Player].BufVision = false;

                }


                //Inmobilidad
                if (Program.Player[Player].Inmovil)
                {

                    Trampas.PlacaQuitar(Player);
                    Program.Player[Player].Inmovil = false;
                    Program.Player[Player].Pasos = Program.Player[Player].PasosStatic;

                }

            }

            // WIN background sonido.stop();
            if (EquipoBuenoWin == 3 || EquipoMaloWin == 3)
                break;

        }
    }
}