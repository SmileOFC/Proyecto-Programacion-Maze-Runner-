using Spectre.Console;
class Imprime
{

    public static void Print(int img, int panel)
    {


        int Ancho = Console.WindowWidth;
        int Alto = Console.WindowHeight;
        string path = Program.ImgRuta[img];

        // Posisition Grid reset cursor
        Console.SetCursorPosition(0, Alto - 9);



        // diccionario imagenes path, paneles uno a uno
        var canvasImage = new CanvasImage(@path);
        canvasImage.MaxWidth(7);

        // Crear un panel con la imagen CanvasImage (sin borde)
        var canvasImagePanel = new Panel(canvasImage)
            .Padding(0, 0, 0, 0) // sin padding alrededor de la imagen
            .NoBorder();

        // Crear otro panel con texto (sin borde)
        var textPanel = new Panel(Program.Panel[panel])
            .Header("Texto", Justify.Left)
            .Padding(0, 4, 0, 4) // sin padding a la izquierda y derecha
            .NoBorder();

        /////////////////////////////////////////////////////////////////////////////////////////

        // Crear el grid
        var grid = new Grid();

        // Configurar el grid con 2 columnas
        grid.AddColumn(new GridColumn().NoWrap());
        grid.AddColumn(new GridColumn().NoWrap());

        // Añadir los 2 paneles al grid
        grid.AddRow(canvasImagePanel, textPanel);

        // Crear el padder y envolver el grid
        var paddedGrid = new Padder(grid)
            .Padding(10, 2, 40, 2);  // padding: izquierda, arriba, derecha, abajo

        /////////////////////////////////////////////////////////////////////////////////////////

        // Renderizar el padder con el grid
        AnsiConsole.Write(paddedGrid);

        /////////////////////////////////////////////////////////////////////////////////////////


        // Rellenar huecos

        // Derecha
        for (int y = Alto - 9; y < Alto; y++)
        {
            for (int x = Ancho - 39; x < Ancho; x++)
            {
                Console.SetCursorPosition(x, y);
                AnsiConsole.Markup("[on orange4_1] [/]");

                Console.SetCursorPosition(Ancho - 40, y);
                AnsiConsole.Markup("[on White]  [/]");
            }
        }
        // Izquierda
        for (int y = Alto - 9; y < Alto; y++)
        {
            for (int x = 0; x < 10; x++)
            {
                Console.SetCursorPosition(x, y);
                AnsiConsole.Markup("[on orange4_1] [/]");

                Console.SetCursorPosition(10, y);
                AnsiConsole.Markup("[on White]  [/]");
            }
        }
    }
}
