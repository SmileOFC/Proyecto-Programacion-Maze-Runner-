using Spectre.Console;

public class Loby
{
    public static int loby()
    {
        int c = 1;
        var whiteColor = new Color(255, 255, 255);
        Escenas.LobyInicio();

        // Reset

        for (int x = 77; x <= 102; x++)
        {
            for (int y = 22; y <= 30; y++)
            {
                if (y == 24 && x == 87)
                {
                    Console.SetCursorPosition(x, y);
                    AnsiConsole.Markup(
                        $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})] JUGAR[/]"
                    );
                }

                if (y == 26 && x == 87)
                {
                    Console.SetCursorPosition(x, y);
                    AnsiConsole.Markup(
                        $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})]AJUSTES[/]"
                    );
                }

                if (y == 28 && x == 87)
                {
                    Console.SetCursorPosition(x, y);
                    AnsiConsole.Markup(
                        $"[black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})] SALIR[/]"
                    );
                }
            }
        }

        while (true)
        {
            if (c == 1)
            {
                Console.SetCursorPosition(84, 24);
                AnsiConsole.Markup("[on red1]  [/]");
            }

            if (c == 2)
            {
                Console.SetCursorPosition(84, 26);
                AnsiConsole.Markup("[on red1]  [/]");
            }

            if (c == 3)
            {
                Console.SetCursorPosition(84, 28);
                AnsiConsole.Markup("[on red1]  [/]");
            }

            Console.SetCursorPosition(0, 0);
            var keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.UpArrow || keyInfo.KeyChar == 'w')
            {
                if (c > 1)
                {
                    c--;
                    Console.SetCursorPosition(84, 24);
                    AnsiConsole.Markup(
                        $"[on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})]  [/]"
                    );
                    Console.SetCursorPosition(84, 26);
                    AnsiConsole.Markup(
                        $"[on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})]  [/]"
                    );
                    Console.SetCursorPosition(84, 28);
                    AnsiConsole.Markup(
                        $"[on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})]  [/]"
                    );
                }
            }
            if (keyInfo.Key == ConsoleKey.DownArrow || keyInfo.KeyChar == 's')
            {
                if (c < 3)
                {
                    c++;
                    Console.SetCursorPosition(84, 24);
                    AnsiConsole.Markup(
                        $"[on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})]  [/]"
                    );
                    Console.SetCursorPosition(84, 26);
                    AnsiConsole.Markup(
                        $"[on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})]  [/]"
                    );
                    Console.SetCursorPosition(84, 28);
                    AnsiConsole.Markup(
                        $"[on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})]  [/]"
                    );
                }
            }

            if (keyInfo.KeyChar == 'e' || keyInfo.Key == ConsoleKey.Enter)
            {
                if (c == 1)
                {
                    Picks.SelectEquipo();
                    break;
                }

                if (c == 2)
                {
                    // Escena opciones
                }

                if (c == 3)
                    return 0;
            }
        }
        return 1;
    }
}
