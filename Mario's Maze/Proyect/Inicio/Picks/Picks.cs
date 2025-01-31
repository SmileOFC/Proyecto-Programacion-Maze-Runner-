using Spectre.Console;

public class Picks
{
    public static Stack<int> Fichas = new Stack<int>();
    public static Stack<int> EquipoBuenos = new Stack<int>();
    public static Stack<int> EquipoMalos = new Stack<int>();

    static bool Esta;
    static int c = 1;
    static int f = 1;
    static int[] color = new int[30];
    static bool[] select = new bool[30];
    static int cont = 0;
    public static int cant = 1;

    public static void SelectEquipo()
    {
        // Reset
        var whiteColor = new Color(255, 255, 255);
        for (int x = 77; x <= 102; x++)
        {
            for (int y = 22; y <= 30; y++)
            {
                if (y == 24 && x == 80)
                {
                    Console.SetCursorPosition(x, y);
                    AnsiConsole.Markup(
                        $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})]SELECCIONE UN EQUIPO[/]"
                    );
                }

                if (y == 26 && x == 83)
                {
                    Console.SetCursorPosition(x, y);
                    AnsiConsole.Markup(
                        $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})]REINO CHAMPIÑON[/]"
                    );
                }

                if (y == 28 && x == 85)
                {
                    Console.SetCursorPosition(x, y);
                    AnsiConsole.Markup(
                        $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})]REINO KOOPA[/]"
                    );
                }
            }
        }
        c = 1;
        while (true)
        {
            if (c == 1)
            {
                Console.SetCursorPosition(78, 26);
                AnsiConsole.Markup("[on red1]  [/]");
            }

            if (c == 2)
            {
                Console.SetCursorPosition(78, 28);
                AnsiConsole.Markup("[on red1]  [/]");
            }

            Console.SetCursorPosition(0, 0);
            var keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.UpArrow || keyInfo.KeyChar == 'w')
            {
                if (c == 2)
                {
                    c--;

                    Console.SetCursorPosition(78, 26);
                    AnsiConsole.Markup(
                        $"[on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})]  [/]"
                    );
                    Console.SetCursorPosition(78, 28);
                    AnsiConsole.Markup(
                        $"[on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})]  [/]"
                    );
                }
            }
            if (keyInfo.Key == ConsoleKey.DownArrow || keyInfo.KeyChar == 's')
            {
                if (c == 1)
                {
                    c++;

                    Console.SetCursorPosition(78, 26);
                    AnsiConsole.Markup(
                        $"[on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})]  [/]"
                    );
                    Console.SetCursorPosition(78, 28);
                    AnsiConsole.Markup(
                        $"[on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})]  [/]"
                    );
                }
            }

            if (keyInfo.Key == ConsoleKey.Enter || keyInfo.KeyChar == 'e')
            {
                if (c == 1)
                {
                    Picks.SelectFichas('B');
                    break;
                }
                if (c == 2)
                {
                    Picks.SelectFichas('M');
                    break;
                }
            }
        }
    }

    static void SelectFichas(char x)
    {
        c = 20;
        f = 1;

        var whiteColor = new Color(255, 255, 255);

        if (x == 'B')
        {
            EquipoBuenos.Clear();
            Escenas.PicksB();
            Info(c);
        }
        else
        {
            EquipoMalos.Clear();
            Escenas.PicksM();
            Info(c + 5);
        }

        Console.SetCursorPosition(140, 6);
        AnsiConsole.Markup(
            $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]INFORMACION[/]"
        );

        // reset stack



        while (cont < 3)
        {
            while (true)
            {
                Esta = false;
                Console.SetCursorPosition(0, 0);
                var keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.RightArrow || keyInfo.KeyChar == 'd')
                {
                    if (f == 1)
                    {
                        if (c < 22)
                        {
                            color[c] = 0;
                            c++;
                            color[c] = 1;

                            Marca();
                            if (x == 'B')
                                Info(c);
                            else
                                Info(c + 5);
                        }
                    }
                    else
                    {
                        if (c < 25)
                        {
                            color[c] = 0;
                            c++;
                            color[c] = 1;

                            Marca();
                            if (x == 'B')
                                Info(c);
                            else
                                Info(c + 5);
                        }
                    }
                }
                if (keyInfo.Key == ConsoleKey.LeftArrow || keyInfo.KeyChar == 'a')
                {
                    if (f == 1)
                    {
                        if (c > 20)
                        {
                            color[c] = 0;
                            c--;
                            color[c] = 1;

                            Marca();
                            if (x == 'B')
                                Info(c);
                            else
                                Info(c + 5);
                        }
                    }
                    else
                    {
                        if (c > 23)
                        {
                            color[c] = 0;
                            c--;
                            color[c] = 1;

                            Marca();
                            if (x == 'B')
                                Info(c);
                            else
                                Info(c + 5);
                        }
                    }
                }

                if (keyInfo.Key == ConsoleKey.UpArrow || keyInfo.KeyChar == 'w')
                {
                    if (f == 2)
                    {
                        color[c] = 0;
                        if (c == 23)
                            c = 20;
                        if (c == 24)
                            c = 21;
                        if (c == 25)
                            c = 22;
                        f = 1;
                        color[c] = 1;
                        Marca();
                        if (x == 'B')
                            Info(c);
                        else
                            Info(c + 5);
                    }
                }

                if (keyInfo.Key == ConsoleKey.DownArrow || keyInfo.KeyChar == 's')
                {
                    if (f == 1)
                    {
                        color[c] = 0;
                        if (c == 20)
                            c = 23;
                        if (c == 21)
                            c = 24;
                        if (c == 22)
                            c = 25;
                        f = 2;
                        color[c] = 1;
                        Marca();
                        if (x == 'B')
                            Info(c);
                        else
                            Info(c + 5);
                    }
                }

                if (keyInfo.Key == ConsoleKey.Enter || keyInfo.KeyChar == 'e')
                {
                    if (c == 25)
                    {
                        //eliminar
                    }

                    List<int> EquipoMalosList = new List<int>(Picks.EquipoMalos.ToArray());
                    List<int> EquipoBuenosList = new List<int>(Picks.EquipoBuenos.ToArray());

                    if (x == 'B')
                    {
                        for (int i = 0; i < EquipoBuenosList.Count; i++)
                        {
                            if (c == EquipoBuenosList[i])
                                Esta = true;
                        }
                    }

                    if (x == 'M')
                    {
                        for (int i = 0; i < EquipoMalosList.Count; i++)
                        {
                            if (c + 5 == EquipoMalosList[i])
                                Esta = true;
                        }
                    }

                    if (!Esta)
                    {
                        if (x == 'B')
                        {
                            Fichas.Push(c);
                            EquipoBuenos.Push(c);
                        }
                        if (x == 'M')
                        {
                            Fichas.Push(c + 5);
                            EquipoMalos.Push(c + 5);
                        }
                        select[c] = true;
                        Select(c);
                        cont++;
                        break;
                    }
                    else
                    {
                        // ya esta alerta
                    }
                }
            }
        }

        Thread.Sleep(1000);

        cont = 0;

        for (int i = 20; i < 25; i++)
        {
            color[i] = 0;
            select[i] = false;
        }

        if (cant != 2)
        {
            cant++;

            if (x == 'B')
                Picks.SelectFichas('M');
            else
                Picks.SelectFichas('B');
        }
    }

    static void Marca()
    {
        var whiteColor = new Color(255, 255, 255);

        Console.SetCursorPosition(16, 12);
        if (color[20] == 1)
            AnsiConsole.Markup("[on red1]  [/]");
        else
        {
            if (color[20] == 0)
                AnsiConsole.Markup($"[on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})]  [/]");
            if (select[20])
                AnsiConsole.Markup("[on green]  [/]");
        }

        Console.SetCursorPosition(60, 12);
        if (color[21] == 1)
            AnsiConsole.Markup("[on red1]  [/]");
        else
        {
            if (color[21] == 0)
                AnsiConsole.Markup($"[on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})]  [/]");
            if (select[21])
                AnsiConsole.Markup("[on green]  [/]");
        }

        Console.SetCursorPosition(102, 12);
        if (color[22] == 1)
            AnsiConsole.Markup("[on red1]  [/]");
        else
        {
            if (color[22] == 0)
                AnsiConsole.Markup($"[on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})]  [/]");
            if (select[22])
                AnsiConsole.Markup("[on green]  [/]");
        }

        Console.SetCursorPosition(16, 29);
        if (color[23] == 1)
            AnsiConsole.Markup("[on red1]  [/]");
        else
        {
            if (color[23] == 0)
                AnsiConsole.Markup($"[on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})]  [/]");
            if (select[23])
                AnsiConsole.Markup("[on green]  [/]");
        }

        Console.SetCursorPosition(60, 29);
        if (color[24] == 1)
            AnsiConsole.Markup("[on red1]  [/]");
        else
        {
            if (color[24] == 0)
                AnsiConsole.Markup($"[on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})]  [/]");
            if (select[24])
                AnsiConsole.Markup("[on green]  [/]");
        }

        Console.SetCursorPosition(102, 29);
        if (color[25] == 1)
            AnsiConsole.Markup("[on red1]  [/]");
        else
        {
            if (color[25] == 0)
                AnsiConsole.Markup($"[on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})]  [/]");
            if (select[25])
                AnsiConsole.Markup("[on green]  [/]");
        }
    }

    static void Select(int x)
    {
        if (x == 20)
        {
            Console.SetCursorPosition(16, 12);
            AnsiConsole.Markup("[on red1]  [/]");
            AnsiConsole.Markup("[on green]  [/]");
        }
        if (x == 21)
        {
            Console.SetCursorPosition(60, 12);
            AnsiConsole.Markup("[on red1]  [/]");
            AnsiConsole.Markup("[on green]  [/]");
        }
        if (x == 22)
        {
            Console.SetCursorPosition(102, 12);
            AnsiConsole.Markup("[on red1]  [/]");
            AnsiConsole.Markup("[on green]  [/]");
        }
        if (x == 23)
        {
            Console.SetCursorPosition(16, 29);
            AnsiConsole.Markup("[on red1]  [/]");
            AnsiConsole.Markup("[on green]  [/]");
        }
        if (x == 24)
        {
            Console.SetCursorPosition(60, 29);
            AnsiConsole.Markup("[on red1]  [/]");
            AnsiConsole.Markup("[on green]  [/]");
        }
    }

    static void Info(int c)
    {
        var whiteColor = new Color(255, 255, 255);

        if (c == 20)
        {
            Console.SetCursorPosition(128, 10);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]NOMBRE: Super Mario        [/]"
            );

            Console.SetCursorPosition(128, 12);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]PASOS: 12[/]"
            );

            Console.SetCursorPosition(128, 14);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]VISION: 1[/]"
            );

            Console.SetCursorPosition(128, 18);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]HABILIDAD: Salto           [/]"
            );

            Console.SetCursorPosition(128, 20);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]-> Salta un muro que tenga en frente      [/]"
            );

            Console.SetCursorPosition(128, 22);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]   con la agilidad que lo caracteriza     [/]"
            );

            Console.SetCursorPosition(128, 24);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]   en sus aventuras clásicas.             [/]"
            );

            Console.SetCursorPosition(128, 28);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]DESCRIPCION:[/]"
            );

            Console.SetCursorPosition(128, 30);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]-> Plomero valiente que siempre rescata   [/]"
            );

            Console.SetCursorPosition(128, 32);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]   a la Princesa Peach y defiende el Reino[/]"
            );

            Console.SetCursorPosition(128, 34);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]   Champiñón de Bowser.                   [/]"
            );
        }

        if (c == 21)
        {
            Console.SetCursorPosition(128, 10);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]NOMBRE: Luigi             [/]"
            );

            Console.SetCursorPosition(128, 12);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]PASOS: 10[/]"
            );

            Console.SetCursorPosition(128, 14);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]VISION: 1[/]"
            );

            Console.SetCursorPosition(128, 18);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]HABILIDAD: Revelación      [/]"
            );

            Console.SetCursorPosition(128, 20);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]-> Revela trampas en su campo de visión   [/]"
            );

            Console.SetCursorPosition(128, 22);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]   utilizando su valentía espectral para  [/]"
            );

            Console.SetCursorPosition(128, 24);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]   detectar peligros ocultos.             [/]"
            );

            Console.SetCursorPosition(128, 28);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]DESCRIPCION:[/]"
            );

            Console.SetCursorPosition(128, 30);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]-> Hermano menor de Mario, conocido       [/]"
            );

            Console.SetCursorPosition(128, 32);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]   por su valentía y habilidades en       [/]"
            );

            Console.SetCursorPosition(128, 34);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]   la caza de fantasmas.           [/]"
            );
        }

        if (c == 22)
        {
            Console.SetCursorPosition(128, 10);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]NOMBRE: Hongo             [/]"
            );

            Console.SetCursorPosition(128, 12);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]PASOS: 5 [/]"
            );

            Console.SetCursorPosition(128, 14);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]VISION: 2[/]"
            );

            Console.SetCursorPosition(128, 18);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]HABILIDAD: Visión Magica      [/]"
            );

            Console.SetCursorPosition(128, 20);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]-> Buffea +1 la visión de todas las fichas[/]"
            );

            Console.SetCursorPosition(128, 22);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]   aliadas, esparciendo su sabiduría      [/]"
            );

            Console.SetCursorPosition(128, 24);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]   micótica a sus compañeros.             [/]"
            );

            Console.SetCursorPosition(128, 28);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]DESCRIPCION:[/]"
            );

            Console.SetCursorPosition(128, 30);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]-> Leal sirviente de la Princesa Peach    [/]"
            );

            Console.SetCursorPosition(128, 32);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]   y habitante del Reino conocido         [/]"
            );

            Console.SetCursorPosition(128, 34);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]   por su distintivo gorro de seta.[/]"
            );
        }

        if (c == 23)
        {
            Console.SetCursorPosition(128, 10);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]NOMBRE: Yoshi             [/]"
            );

            Console.SetCursorPosition(128, 12);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]PASOS: 6 [/]"
            );

            Console.SetCursorPosition(128, 14);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]VISION: 1[/]"
            );

            Console.SetCursorPosition(128, 18);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]HABILIDAD: Olfato      [/]"
            );

            Console.SetCursorPosition(128, 20);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]-> Genera un cuadrado 2x2 de visión       [/]"
            );

            Console.SetCursorPosition(128, 22);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]   en el tablero, gracias a su olfato     [/]"
            );

            Console.SetCursorPosition(128, 24);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]   y agilidad inigualables.               [/]"
            );

            Console.SetCursorPosition(128, 28);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]DESCRIPCION:[/]"
            );

            Console.SetCursorPosition(128, 30);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]-> Un dinosaurio verde y fiel compañero   [/]"
            );

            Console.SetCursorPosition(128, 32);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]   de Mario, conocido por su larga lengua [/]"
            );

            Console.SetCursorPosition(128, 34);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]   y su habilidad para poner huevos.[/]"
            );
        }

        if (c == 24)
        {
            Console.SetCursorPosition(128, 10);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]NOMBRE: Peach             [/]"
            );

            Console.SetCursorPosition(128, 12);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]PASOS: 7 [/]"
            );

            Console.SetCursorPosition(128, 14);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]VISION: 2[/]"
            );

            Console.SetCursorPosition(128, 18);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]HABILIDAD: Gracia Real      [/]"
            );

            Console.SetCursorPosition(128, 20);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]-> Inmoviliza todas las fichas enemigas   [/]"
            );

            Console.SetCursorPosition(128, 22);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]   permitiéndote repetir la ronda con     [/]"
            );

            Console.SetCursorPosition(128, 24);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]   la gracia real que la caracteriza.     [/]"
            );

            Console.SetCursorPosition(128, 28);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]DESCRIPCION:[/]"
            );

            Console.SetCursorPosition(128, 30);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]-> La gobernante del Reino Champiñón      [/]"
            );

            Console.SetCursorPosition(128, 32);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]   a menudo secuestrada por Bowser        [/]"
            );

            Console.SetCursorPosition(128, 34);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]   pero rescatada por Mario.              [/]"
            );
        }

        if (c == 25)
        {
            Console.SetCursorPosition(128, 10);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]NOMBRE: Bowser            [/]"
            );

            Console.SetCursorPosition(128, 12);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]PASOS: 8 [/]"
            );

            Console.SetCursorPosition(128, 14);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]VISION: 1[/]"
            );

            Console.SetCursorPosition(128, 18);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]HABILIDAD: Coraza Dura      [/]"
            );

            Console.SetCursorPosition(128, 20);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]-> Se vuelve inmune por ese turno,        [/]"
            );

            Console.SetCursorPosition(128, 22);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]   desatando su furia imparable para      [/]"
            );

            Console.SetCursorPosition(128, 24);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]   protegerse de cualquier ataque.        [/]"
            );

            Console.SetCursorPosition(128, 28);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]DESCRIPCION:[/]"
            );

            Console.SetCursorPosition(128, 30);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]-> Bowser, el imponente rey de los Koopas [/]"
            );

            Console.SetCursorPosition(128, 32);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]   es el archienemigo de Mario y suele    [/]"
            );

            Console.SetCursorPosition(128, 34);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]   secuestrar a la Princesa Peach.        [/]"
            );
        }

        if (c == 26)
        {
            Console.SetCursorPosition(128, 10);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]NOMBRE: DonKeyKong            [/]"
            );

            Console.SetCursorPosition(128, 12);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]PASOS: 4 [/]"
            );

            Console.SetCursorPosition(128, 14);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]VISION: 2[/]"
            );

            Console.SetCursorPosition(128, 18);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]HABILIDAD: Puñetazo              [/]"
            );

            Console.SetCursorPosition(128, 20);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]-> Rompe una muralla en la dirección      [/]"
            );

            Console.SetCursorPosition(128, 22);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]   seleccionada, demostrando su           [/]"
            );

            Console.SetCursorPosition(128, 24);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]   fuerza bruta.                          [/]"
            );

            Console.SetCursorPosition(128, 28);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]DESCRIPCION:[/]"
            );

            Console.SetCursorPosition(128, 30);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]-> Con su fuerza bruta y amor por         [/]"
            );

            Console.SetCursorPosition(128, 32);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]   los plátanos, Donkey Kong es           [/]"
            );

            Console.SetCursorPosition(128, 34);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]   un personaje icónico.                  [/]"
            );
        }

        if (c == 27)
        {
            Console.SetCursorPosition(128, 10);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]NOMBRE: Koopa            [/]"
            );

            Console.SetCursorPosition(128, 12);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]PASOS: 3 [/]"
            );

            Console.SetCursorPosition(128, 14);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]VISION: 3[/]"
            );

            Console.SetCursorPosition(128, 18);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]HABILIDAD: Vision Caminante      [/]"
            );

            Console.SetCursorPosition(128, 20);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]-> Resta 1 visión y suma +5 pasos[/]"
            );

            Console.SetCursorPosition(128, 22);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]   sacrificando su vista para    [/]"
            );

            Console.SetCursorPosition(128, 24);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]   ganar velocidad en el tablero.[/]"
            );

            Console.SetCursorPosition(128, 28);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]DESCRIPCION:[/]"
            );

            Console.SetCursorPosition(128, 30);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]-> Koopa Troopa es conocido por su        [/]"
            );

            Console.SetCursorPosition(128, 32);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]   persistencia y capacidad para convertir[/]"
            );

            Console.SetCursorPosition(128, 34);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]    su caparazón en un peligro.           [/]"
            );
        }

        if (c == 28)
        {
            Console.SetCursorPosition(128, 10);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]NOMBRE: Waluigi            [/]"
            );

            Console.SetCursorPosition(128, 12);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]PASOS: 9 [/]"
            );

            Console.SetCursorPosition(128, 14);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]VISION: 1[/]"
            );

            Console.SetCursorPosition(128, 18);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]HABILIDAD: Caida Profunda      [/]"
            );

            Console.SetCursorPosition(128, 20);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]-> Genera una trampa 'Hueco' en una       [/]"
            );

            Console.SetCursorPosition(128, 22);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]   casilla del tablero, siempre travieso  [/]"
            );

            Console.SetCursorPosition(128, 24);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]   y astuto en sus movimientos.           [/]"
            );

            Console.SetCursorPosition(128, 28);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]DESCRIPCION:[/]"
            );

            Console.SetCursorPosition(128, 30);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]-> Waluigi, el eterno rival de Luigi, es  [/]"
            );

            Console.SetCursorPosition(128, 32);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]   un personaje astuto y algo excéntrico  [/]"
            );

            Console.SetCursorPosition(128, 34);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]    conocido por su risa inconfundible.   [/]"
            );
        }

        if (c == 29)
        {
            Console.SetCursorPosition(128, 10);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]NOMBRE: Wario            [/]"
            );

            Console.SetCursorPosition(128, 12);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]PASOS: 11 [/]"
            );

            Console.SetCursorPosition(128, 14);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]VISION: 1[/]"
            );

            Console.SetCursorPosition(128, 18);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]HABILIDAD: Botas de Vision      [/]"
            );

            Console.SetCursorPosition(128, 20);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]-> Resta 3 pasos y suma 1 visión,         [/]"
            );

            Console.SetCursorPosition(128, 22);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]   ajustando su torpe equilibrio para ver [/]"
            );

            Console.SetCursorPosition(128, 24);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]    más claramente.                       [/]"
            );

            Console.SetCursorPosition(128, 28);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]DESCRIPCION:[/]"
            );

            Console.SetCursorPosition(128, 30);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]-> Wario, el rival codicioso y rival de   [/]"
            );

            Console.SetCursorPosition(128, 32);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]   Mario, es conocido por su fuerza brutal[/]"
            );

            Console.SetCursorPosition(128, 34);
            AnsiConsole.Markup(
                $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B}) bold]     y su insaciable afán por el oro.     [/]"
            );
        }
    }
}
