using Spectre.Console;

public class Escenas
{
    // Pantalla de Carga
    public static void Carga()
    {
        var whiteColor = new Color(255, 255, 255);
        int Ancho = Console.WindowWidth;
        int Alto = Console.WindowHeight;

        for (int x = 0; x < Ancho; x++)
        {
            for (int y = 0; y < Alto; y++)
            {
                Console.SetCursorPosition(x, y);
                AnsiConsole.Markup($"[on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})] [/]");
            }
        }

        Console.SetCursorPosition(0, 0);
        var Img = new CanvasImage(
            @"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Carga\Carga.png"
        );
        Img.MaxWidth(85);
        AnsiConsole.Write(Img);
        Console.SetCursorPosition(0, 0);

        // Barra de Carga

        Console.SetCursorPosition(50, 42);
        Console.Write(
            "                                                                                 "
        );

        for (int x = 50; x <= 130; x++)
        {
            Console.SetCursorPosition(x, 42);
            if (x < 70)
            {
                //darkgreen
                AnsiConsole.Markup($"[on darkgreen] [/]");
            }
            if (x >= 70 && x < 90)
            {
                //green4
                AnsiConsole.Markup($"[on green4] [/]");
            }
            if (x >= 90 && x < 110)
            {
                //green3
                AnsiConsole.Markup($"[on green3] [/]");
            }
            if (x >= 110)
            {
                //green1
                AnsiConsole.Markup($"[on green1] [/]");
            }

            Thread.Sleep(Tablero.rand.Next(0, 150));
        }

        Thread.Sleep(2000);
    }

    public static void LobyInicio()
    {
        Console.Clear();
        Console.SetCursorPosition(0, 0);

        var Img = new CanvasImage(
            @"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Carga\Loby.png"
        );
        Img.MaxWidth(85);
        AnsiConsole.Write(Img);
        Console.SetCursorPosition(0, 0);
    }

    public static void Win(int equipo)
    {
        Console.Clear();
        Console.SetCursorPosition(0, 0);

        if (equipo == 1)
        {
            var Img = new CanvasImage(
                @"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Carga\WinBuenos.png"
            );
            Img.MaxWidth(85);
            AnsiConsole.Write(Img);
            Console.SetCursorPosition(0, 0);
        }

        if (equipo == 2)
        {
            var Img = new CanvasImage(
                @"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Carga\WinMalos.png"
            );
            Img.MaxWidth(85);
            AnsiConsole.Write(Img);
            Console.SetCursorPosition(0, 0);
        }
    }

    public static void PicksB()
    {
        Console.Clear();
        Console.SetCursorPosition(0, 0);

        var Img = new CanvasImage(
            @"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Carga\PicksB.png"
        );
        Img.MaxWidth(85);
        AnsiConsole.Write(Img);
        Console.SetCursorPosition(0, 0);
    }

    public static void PicksM()
    {
        Console.Clear();
        Console.SetCursorPosition(0, 0);

        var Img = new CanvasImage(
            @"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Carga\PicksM.png"
        );
        Img.MaxWidth(85);
        AnsiConsole.Write(Img);
        Console.SetCursorPosition(0, 0);
    }
}
