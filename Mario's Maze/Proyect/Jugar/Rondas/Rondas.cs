using SixLabors.ImageSharp;
using Spectre.Console;

public class Rondas
{
    public static List<int> FichasList = new List<int>(Picks.Fichas.ToArray());
    public static List<int> EquipoMalosList = new List<int>(Picks.EquipoMalos.ToArray());
    public static List<int> EquipoBuenosList = new List<int>(Picks.EquipoBuenos.ToArray());
    static bool EntradaTiendaBuenos = false;
    static bool EntradaTiendaMalos = false;
    static int EquipoBuenoWin = 0;
    static int EquipoMaloWin = 0;
    static int Jugando;
    static int ejex = 1;
    static int ejey = 1;
    static int Player;
    public static int Ronda()
    {
        Tablero.GenerarTablero();

        //
        if (Program.Player[Tablero.laberinto[1, 1]].Equipo)
            EntradaTiendaBuenos = true;
        else
            EntradaTiendaMalos = true;

        // Rondas
        for (int Turno = 0; ; Turno++)
        {
            Jugando = 1;

            if (Turno == FichasList.Count)
                Turno = 0;

            Player = FichasList[Turno];

            // Revisar q el player no haya llegado a la meta o este inmovil
            if (Player != 0)
            {
                // Turnos
                while (Jugando > 0)
                {
                    // revisar q no este inmovil
                    if (Program.Player[Player].Inmovil)
                        break;

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

                    ///////////////////Actualizar interfaz pendiente arreglar
                    Console.Clear();

                    Tablero.UpdateNiebla(Player, ejex, ejey);
                    Interfaz.Imprimir(Player);
                    Imprime.Print(Player, Player);
                    var keyInfo = Console.ReadKey();

                    // [T] Tienda
                    if (keyInfo.KeyChar == 't')
                    {
                        if (Program.Player[Player].Equipo) // bueno
                        {
                            if (EntradaTiendaBuenos)
                            {
                                Tienda.Comprar(Player);
                                EntradaTiendaBuenos = false;
                                EntradaTiendaMalos = true;
                            }
                        }
                        else
                        {
                            if (EntradaTiendaMalos) // malo
                            {
                                Tienda.Comprar(Player);
                                EntradaTiendaBuenos = true;
                                EntradaTiendaMalos = false;
                            }
                        }
                    }

                    // [Esc] Menu Pendiente //////////////////
                    if (keyInfo.KeyChar == 'q')
                    {
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.Clear();
                        Interfaz.Imprimir(Player);
                        Console.WriteLine("");
                        var Select = AnsiConsole.Prompt(
                            new SelectionPrompt<string>()
                                .Title("───── [Red1]MENU[/] ────────────────────────")
                                .PageSize(3)
                                .MoreChoicesText("────────────────────────────────────────────────")
                                .AddChoices(new[] { " Continuar", " Guia", " Salir" })
                        );

                        if (Select == " Guia") { }
                        if (Select == " Salir")
                        {
                            Console.BackgroundColor = ConsoleColor.Cyan;
                            Console.Clear();
                            Interfaz.Imprimir(Player);
                            Console.WriteLine("");
                            var Salir = AnsiConsole.Prompt(
                                new SelectionPrompt<string>()
                                    .Title(
                                        "───── [Red1]Ya te aburriste de perder Chama? ^v^[/] ────────────────────────"
                                    )
                                    .PageSize(3)
                                    .MoreChoicesText(
                                        "────────────────────────────────────────────────"
                                    )
                                    .AddChoices(new[] { "Si", "No" })
                            );

                            if (Salir == "Si")
                                return 0;
                        }
                    }

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

                    //////////////////////////// REVISAR ///////////////////////////////////////////

                    // Ficha Buenos Meta 
                    if (Jugando == 515)
                    {
                        Console.WriteLine("Holaaaaa");
                        Thread.Sleep(5000);

                        EquipoBuenoWin += 1;
                        break;
                    }

                    // Ficha Malos Meta
                    if (Jugando == 525)
                    {
                        EquipoMaloWin += 1;
                        break;
                    }

                    /////////////////////////////////////////////////////////////////////////////////////

                    // Quitar puertas

                    if (Program.EquipoBuenoLlave)
                    {
                        if (Tablero.laberinto[13, 15] == 111)
                            Tablero.laberinto[13, 15] = 11;
                        else
                            Tablero.laberinto[17, 15] = 1;
                    }

                    if (Program.EquipoMaloLlave)
                    {
                        if (Tablero.laberinto[13, 15] == 121)
                            Tablero.laberinto[13, 15] = 12;
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

        return 1;
    }

    private static object HeaderStyle(Style style)
    {
        throw new NotImplementedException();
    }
}
