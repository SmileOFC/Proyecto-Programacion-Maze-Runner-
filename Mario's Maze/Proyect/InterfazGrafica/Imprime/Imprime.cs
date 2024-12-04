using Spectre.Console;
using System;
using System.Collections.Generic;
class Imprime
{

    public static Dictionary<int, bool> TrampaVisibleF = new Dictionary<int, bool>();
    public static Dictionary<int, bool> TrampaVisibleC = new Dictionary<int, bool>();

    public static void Print(int player, int img, int panel) // int player
    {

        // Definir el color blanco en RGB 
        var whiteColor = new Color(255, 255, 255);
        // Crear un estilo con texto negro y fondo blanco 
        var style = new Style(foreground: Color.Black, background: whiteColor);

        int Ancho = Console.WindowWidth;
        int Alto = Console.WindowHeight;

        /////////////////////////////////////////////////////////////////////////////////////////////////////

        for (int i = 0; i < Tablero.filas; i++)
        {

            for (int j = 0; j < Tablero.columnas; j++)
            {

                if (Tablero.laberinto[i, j] != Tablero.LaberintoCopy[i, j] || Tablero.niebla[i, j] != Tablero.NieblaCopy[i, j] || Tablero.Puntero[i, j] != Tablero.PunteroCopy[i, j])
                {
                    int fila = i + 1;
                    int columna = j * 2 + 18;
                    Console.SetCursorPosition(columna, fila);

                    // LABERINTO

                    if (Tablero.laberinto[i, j] == 1 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                    {
                        AnsiConsole.Markup("[lightsalmon3]██[/]");
                    }

                    if (Tablero.laberinto[i, j] == 1112 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                    {
                        AnsiConsole.Markup("[lightsalmon3]██[/]");
                    }




                    if (Tablero.laberinto[i, j] == 0 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                    {
                        AnsiConsole.Markup("[green on darkgreen]░░[/]");
                    }

                    if (Tablero.laberinto[i, j] == 1111 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                    {
                        AnsiConsole.Markup("[green on darkgreen]░░[/]");
                    }

                    // META

                    if (Tablero.laberinto[i, j] == 111 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                    {
                        AnsiConsole.Markup("[orange4_1 on blue3]◘◘[/]");
                    }

                    if (Tablero.laberinto[i, j] == 121 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                    {
                        AnsiConsole.Markup("[orange4_1 on red1]◘◘[/]");
                    }

                    if (Tablero.laberinto[i, j] == 5 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                    {
                        AnsiConsole.Markup("[red1 on lightsalmon3]🚩[/]");
                    }


                    // PLAYERS

                    if (Tablero.laberinto[i, j] == 20 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                        AnsiConsole.Markup("[red1]█[/]" + "[blue3]█[/]");

                    if (Tablero.laberinto[i, j] == 21 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                        AnsiConsole.Markup($"[on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})] [/]" + "[green3]█[/]");

                    if (Tablero.laberinto[i, j] == 22 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                        AnsiConsole.Markup("[red1]█[/]" + $"[on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})] [/]");

                    if (Tablero.laberinto[i, j] == 23 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                        AnsiConsole.Markup($"[on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})] [/]" + "[green1]█[/]");

                    if (Tablero.laberinto[i, j] == 24 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                        AnsiConsole.Markup("[hotpink]█[/]" + "[yellow1]█[/]");

                    if (Tablero.laberinto[i, j] == 25 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                        AnsiConsole.Markup("[red1]█[/]" + "[green3]█[/]");

                    if (Tablero.laberinto[i, j] == 26 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                        AnsiConsole.Markup("[orange4_1]█[/]" + $"[on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})] [/]");

                    if (Tablero.laberinto[i, j] == 27 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                        AnsiConsole.Markup("[green1]█[/]" + $"[on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})] [/]");

                    if (Tablero.laberinto[i, j] == 28 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                        AnsiConsole.Markup($"[on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})] [/]" + "[purple4]█[/]");

                    if (Tablero.laberinto[i, j] == 29 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                        AnsiConsole.Markup("[yellow1]█[/]" + "[purple4]█[/]");

                    // TRAMPAS

                    if (Tablero.laberinto[i, j] == 31 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                    {
                        if (TrampaVisibleF.Count == 0)
                        {
                            AnsiConsole.Markup("[on lightsalmon3]  [/]");
                        }
                        else
                        {
                            if (TrampaVisibleF.ContainsKey(i) && TrampaVisibleC.ContainsKey(j))
                            {
                                AnsiConsole.Markup("[red1]██[/]");
                            }
                            else
                                AnsiConsole.Markup("[on lightsalmon3]  [/]");
                        }
                    }

                    if (Tablero.laberinto[i, j] == 32 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                    {
                        if (TrampaVisibleF.Count == 0)
                        {
                            AnsiConsole.Markup("[on lightsalmon3]  [/]");
                        }
                        else
                        {
                            if (TrampaVisibleF.ContainsKey(i) && TrampaVisibleC.ContainsKey(j))
                            {
                                AnsiConsole.Markup("[red1]██[/]");
                            }
                            else
                                AnsiConsole.Markup("[on lightsalmon3]  [/]");
                        }
                    }

                    if (Tablero.laberinto[i, j] == 33 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                    {
                        if (TrampaVisibleF.Count == 0)
                        {
                            AnsiConsole.Markup("[on lightsalmon3]  [/]");
                        }
                        else
                        {
                            if (TrampaVisibleF.ContainsKey(i) && TrampaVisibleC.ContainsKey(j))
                            {
                                AnsiConsole.Markup("[red1]██[/]");
                            }
                            else
                                AnsiConsole.Markup("[on lightsalmon3]  [/]");
                        }
                    }

                    // Reja

                    if (Tablero.laberinto[i, j] == 35 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                        AnsiConsole.Markup("[black on lightsalmon3]■■[/]");

                    // BUFF

                    if (Tablero.laberinto[i, j] == 41 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                    {
                        AnsiConsole.Markup("[black on lightsalmon3]🍄[/]");
                    }
                    if (Tablero.laberinto[i, j] == 42 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                    {
                        AnsiConsole.Markup("[yellow on lightsalmon3]★ [/]");
                    }
                    if (Tablero.laberinto[i, j] == 43 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                    {
                        AnsiConsole.Markup("[red1 on lightsalmon3]✿ [/]");
                    }

                    // Coins

                    if (Tablero.laberinto[i, j] == 2 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                    {
                        AnsiConsole.Markup("[yellow1 on lightsalmon3]💲[/]");
                    }
                    //Llaves

                    if (Tablero.laberinto[i, j] == 323 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                    {
                        AnsiConsole.Markup("[red1 on lightsalmon3]🔑[/]");
                    }

                    if (Tablero.laberinto[i, j] == 313 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                    {
                        AnsiConsole.Markup("[blue3 on lightsalmon3]🔑[/]");
                    }

                    //Cofres

                    if (Tablero.laberinto[i, j] == 6 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false) // comun
                    {
                        AnsiConsole.Markup("[blue3 on orange4_1]▀▀[/]");
                    }

                    if (Tablero.laberinto[i, j] == 7 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false) // epico
                    {
                        AnsiConsole.Markup("[purple4 on orange4_1]▀▀[/]");
                    }

                    if (Tablero.laberinto[i, j] == 8 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false) // legendario
                    {
                        AnsiConsole.Markup("[red1 on orange4_1]▀▀[/]");
                    }

                    // Escalera arriba

                    if (Tablero.laberinto[i, j] == 151 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                    {
                        AnsiConsole.Markup("[orange4_1 on rosybrown]▀▀[/]");
                    }

                    // escalera abajo

                    if (Tablero.laberinto[i, j] == 252 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                    {
                        AnsiConsole.Markup("[orange4_1 on rosybrown]▄▄[/]");
                    }

                    // escalera izquierda

                    if (Tablero.laberinto[i, j] == 353 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                    {
                        AnsiConsole.Markup("[orange4_1 on rosybrown]▌ [/]");
                    }

                    // escalera derecha

                    if (Tablero.laberinto[i, j] == 454 && Tablero.niebla[i, j] == false && Tablero.Puntero[i, j] == false)
                    {
                        AnsiConsole.Markup("[orange4_1 on rosybrown] ▐[/]");
                    }

                    // NIEBLA

                    if (Tablero.niebla[i, j] && Tablero.Puntero[i, j] == false)
                        AnsiConsole.Markup("[grey35 on grey70]░░[/]");

                    // PUNTERO

                    if (Tablero.Puntero[i, j])
                    {
                        AnsiConsole.Markup($"[red1 on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})]✖️[/]");
                    }
                }
            }
        }

        // Igualar laberinto copia al original

        Array.Copy(Tablero.laberinto, Tablero.LaberintoCopy, Tablero.laberinto.Length);
        Array.Copy(Tablero.niebla, Tablero.NieblaCopy, Tablero.niebla.Length);
        Array.Copy(Tablero.Puntero, Tablero.PunteroCopy, Tablero.Puntero.Length);


        // Reset Cursor Grid
        Console.SetCursorPosition(0, Alto - 9);


        ///////////////////// DICCIONARIO IMG ////////////////////

        //// PLAYERS /////

        if (img == 20)
        {
            var Img = new CanvasImage(@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Players\Mario.png");
            Img.MaxWidth(7);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            // Crear un panel con la imagen CanvasImage (sin borde)
            var canvasImagePanel = new Panel(Img)
                .Padding(0, 0, 0, 0) // sin padding alrededor de la imagen
                .NoBorder();

            // Crear otro panel con texto (sin borde)
            var textPanel = new Panel(Program.Panel[panel])
                .Padding(0, 1, 0, 1) // sin padding a la izquierda y derecha
                .NoBorder();

            /////////////////////////////////////////////////////////////////////////////////////////

            // Crear el grid
            var grid = new Grid();

            // Configurar el grid con 2 columnas
            grid.AddColumn(new GridColumn());
            grid.AddColumn(new GridColumn());

            // Añadir los 2 paneles al grid
            grid.AddRow(canvasImagePanel, textPanel);

            // Crear el padder y envolver el grid
            var paddedGrid = new Padder(grid)
                .Padding(15, 0, Ancho - 80, 0);  // padding: izquierda, arriba, derecha, abajo

            /////////////////////////////////////////////////////////////////////////////////////////

            // Renderizar el padder con el grid
            AnsiConsole.Write(paddedGrid);

            /////////////////////////////////////////////////////////////////////////////////////////
        }

        if (img == 21)
        {
            var Img = new CanvasImage(@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Players\Luigi.png");
            Img.MaxWidth(7);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            // Crear un panel con la imagen CanvasImage (sin borde)
            var canvasImagePanel = new Panel(Img)
                .Padding(0, 0, 0, 0) // sin padding alrededor de la imagen
                .NoBorder();

            // Crear otro panel con texto (sin borde)
            var textPanel = new Panel(Program.Panel[panel])
                .Padding(0, 1, 0, 1) // sin padding a la izquierda y derecha
                .NoBorder();

            /////////////////////////////////////////////////////////////////////////////////////////

            // Crear el grid
            var grid = new Grid();

            // Configurar el grid con 2 columnas
            grid.AddColumn(new GridColumn());
            grid.AddColumn(new GridColumn());

            // Añadir los 2 paneles al grid
            grid.AddRow(canvasImagePanel, textPanel);

            // Crear el padder y envolver el grid
            var paddedGrid = new Padder(grid)
                .Padding(15, 0, Ancho - 80, 0);  // padding: izquierda, arriba, derecha, abajo

            /////////////////////////////////////////////////////////////////////////////////////////

            // Renderizar el padder con el grid
            AnsiConsole.Write(paddedGrid);

            /////////////////////////////////////////////////////////////////////////////////////////
        }

        if (img == 22)
        {
            var Img = new CanvasImage(@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Players\Hongo.png");
            Img.MaxWidth(7);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            // Crear un panel con la imagen CanvasImage (sin borde)
            var canvasImagePanel = new Panel(Img)
                .Padding(0, 0, 0, 0) // sin padding alrededor de la imagen
                .NoBorder();

            // Crear otro panel con texto (sin borde)
            var textPanel = new Panel(Program.Panel[panel])
                .Padding(0, 1, 0, 1) // sin padding a la izquierda y derecha
                .NoBorder();

            /////////////////////////////////////////////////////////////////////////////////////////

            // Crear el grid
            var grid = new Grid();

            // Configurar el grid con 2 columnas
            grid.AddColumn(new GridColumn());
            grid.AddColumn(new GridColumn());

            // Añadir los 2 paneles al grid
            grid.AddRow(canvasImagePanel, textPanel);

            // Crear el padder y envolver el grid
            var paddedGrid = new Padder(grid)
                .Padding(15, 0, Ancho - 80, 0);  // padding: izquierda, arriba, derecha, abajo

            /////////////////////////////////////////////////////////////////////////////////////////

            // Renderizar el padder con el grid
            AnsiConsole.Write(paddedGrid);

            /////////////////////////////////////////////////////////////////////////////////////////
        }

        if (img == 23)
        {
            var Img = new CanvasImage(@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Players\Yoshi.png");
            Img.MaxWidth(7);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            // Crear un panel con la imagen CanvasImage (sin borde)
            var canvasImagePanel = new Panel(Img)
                .Padding(0, 0, 0, 0) // sin padding alrededor de la imagen
                .NoBorder();

            // Crear otro panel con texto (sin borde)
            var textPanel = new Panel(Program.Panel[panel])
                .Padding(0, 1, 0, 1) // sin padding a la izquierda y derecha
                .NoBorder();

            /////////////////////////////////////////////////////////////////////////////////////////

            // Crear el grid
            var grid = new Grid();

            // Configurar el grid con 2 columnas
            grid.AddColumn(new GridColumn());
            grid.AddColumn(new GridColumn());

            // Añadir los 2 paneles al grid
            grid.AddRow(canvasImagePanel, textPanel);

            // Crear el padder y envolver el grid
            var paddedGrid = new Padder(grid)
                .Padding(15, 0, Ancho - 80, 0);  // padding: izquierda, arriba, derecha, abajo

            /////////////////////////////////////////////////////////////////////////////////////////

            // Renderizar el padder con el grid
            AnsiConsole.Write(paddedGrid);

            /////////////////////////////////////////////////////////////////////////////////////////
        }

        if (img == 24)
        {
            var Img = new CanvasImage(@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Players\Peach.png");
            Img.MaxWidth(7);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            // Crear un panel con la imagen CanvasImage (sin borde)
            var canvasImagePanel = new Panel(Img)
                .Padding(0, 0, 0, 0) // sin padding alrededor de la imagen
                .NoBorder();

            // Crear otro panel con texto (sin borde)
            var textPanel = new Panel(Program.Panel[panel])
                .Padding(0, 1, 0, 1) // sin padding a la izquierda y derecha
                .NoBorder();

            /////////////////////////////////////////////////////////////////////////////////////////

            // Crear el grid
            var grid = new Grid();

            // Configurar el grid con 2 columnas
            grid.AddColumn(new GridColumn());
            grid.AddColumn(new GridColumn());

            // Añadir los 2 paneles al grid
            grid.AddRow(canvasImagePanel, textPanel);

            // Crear el padder y envolver el grid
            var paddedGrid = new Padder(grid)
                .Padding(15, 0, Ancho - 80, 0);  // padding: izquierda, arriba, derecha, abajo

            /////////////////////////////////////////////////////////////////////////////////////////

            // Renderizar el padder con el grid
            AnsiConsole.Write(paddedGrid);

            /////////////////////////////////////////////////////////////////////////////////////////
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////

        if (img == 25)
        {
            var Img = new CanvasImage(@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Players\Bowser.png");
            Img.MaxWidth(7);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            // Crear un panel con la imagen CanvasImage (sin borde)
            var canvasImagePanel = new Panel(Img)
                .Padding(0, 0, 0, 0) // sin padding alrededor de la imagen
                .NoBorder();

            // Crear otro panel con texto (sin borde)
            var textPanel = new Panel(Program.Panel[panel])
                .Padding(0, 1, 0, 1) // sin padding a la izquierda y derecha
                .NoBorder();

            /////////////////////////////////////////////////////////////////////////////////////////

            // Crear el grid
            var grid = new Grid();

            // Configurar el grid con 2 columnas
            grid.AddColumn(new GridColumn());
            grid.AddColumn(new GridColumn());

            // Añadir los 2 paneles al grid
            grid.AddRow(canvasImagePanel, textPanel);

            // Crear el padder y envolver el grid
            var paddedGrid = new Padder(grid)
                .Padding(15, 0, Ancho - 80, 0);  // padding: izquierda, arriba, derecha, abajo

            /////////////////////////////////////////////////////////////////////////////////////////

            // Renderizar el padder con el grid
            AnsiConsole.Write(paddedGrid);

            /////////////////////////////////////////////////////////////////////////////////////////
        }

        if (img == 26)
        {
            var Img = new CanvasImage(@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Players\Donkey Kong.png");
            Img.MaxWidth(7);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            // Crear un panel con la imagen CanvasImage (sin borde)
            var canvasImagePanel = new Panel(Img)
                .Padding(0, 0, 0, 0) // sin padding alrededor de la imagen
                .NoBorder();

            // Crear otro panel con texto (sin borde)
            var textPanel = new Panel(Program.Panel[panel])
                .Padding(0, 1, 0, 1) // sin padding a la izquierda y derecha
                .NoBorder();

            /////////////////////////////////////////////////////////////////////////////////////////

            // Crear el grid
            var grid = new Grid();

            // Configurar el grid con 2 columnas
            grid.AddColumn(new GridColumn());
            grid.AddColumn(new GridColumn());

            // Añadir los 2 paneles al grid
            grid.AddRow(canvasImagePanel, textPanel);

            // Crear el padder y envolver el grid
            var paddedGrid = new Padder(grid)
                .Padding(15, 0, Ancho - 80, 0);  // padding: izquierda, arriba, derecha, abajo

            /////////////////////////////////////////////////////////////////////////////////////////

            // Renderizar el padder con el grid
            AnsiConsole.Write(paddedGrid);

            /////////////////////////////////////////////////////////////////////////////////////////
        }

        if (img == 27)
        {
            var Img = new CanvasImage(@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Players\Koopa.png");
            Img.MaxWidth(7);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            // Crear un panel con la imagen CanvasImage (sin borde)
            var canvasImagePanel = new Panel(Img)
                .Padding(0, 0, 0, 0) // sin padding alrededor de la imagen
                .NoBorder();

            // Crear otro panel con texto (sin borde)
            var textPanel = new Panel(Program.Panel[panel])
                .Padding(0, 1, 0, 1) // sin padding a la izquierda y derecha
                .NoBorder();

            /////////////////////////////////////////////////////////////////////////////////////////

            // Crear el grid
            var grid = new Grid();

            // Configurar el grid con 2 columnas
            grid.AddColumn(new GridColumn());
            grid.AddColumn(new GridColumn());

            // Añadir los 2 paneles al grid
            grid.AddRow(canvasImagePanel, textPanel);

            // Crear el padder y envolver el grid
            var paddedGrid = new Padder(grid)
                .Padding(15, 0, Ancho - 80, 0);  // padding: izquierda, arriba, derecha, abajo

            /////////////////////////////////////////////////////////////////////////////////////////

            // Renderizar el padder con el grid
            AnsiConsole.Write(paddedGrid);

            /////////////////////////////////////////////////////////////////////////////////////////
        }

        if (img == 28)
        {
            var Img = new CanvasImage(@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Players\Waluigi.png");
            Img.MaxWidth(7);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            // Crear un panel con la imagen CanvasImage (sin borde)
            var canvasImagePanel = new Panel(Img)
                .Padding(0, 0, 0, 0) // sin padding alrededor de la imagen
                .NoBorder();

            // Crear otro panel con texto (sin borde)
            var textPanel = new Panel(Program.Panel[panel])
                .Padding(0, 1, 0, 1) // sin padding a la izquierda y derecha
                .NoBorder();

            /////////////////////////////////////////////////////////////////////////////////////////

            // Crear el grid
            var grid = new Grid();

            // Configurar el grid con 2 columnas
            grid.AddColumn(new GridColumn());
            grid.AddColumn(new GridColumn());

            // Añadir los 2 paneles al grid
            grid.AddRow(canvasImagePanel, textPanel);

            // Crear el padder y envolver el grid
            var paddedGrid = new Padder(grid)
                .Padding(15, 0, Ancho - 80, 0);  // padding: izquierda, arriba, derecha, abajo

            /////////////////////////////////////////////////////////////////////////////////////////

            // Renderizar el padder con el grid
            AnsiConsole.Write(paddedGrid);

            /////////////////////////////////////////////////////////////////////////////////////////
        }

        if (img == 29)
        {
            var Img = new CanvasImage(@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Players\Wario.png");
            Img.MaxWidth(7);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            // Crear un panel con la imagen CanvasImage (sin borde)
            var canvasImagePanel = new Panel(Img)
                .Padding(0, 0, 0, 0) // sin padding alrededor de la imagen
                .NoBorder();

            // Crear otro panel con texto (sin borde)
            var textPanel = new Panel(Program.Panel[panel])
                .Padding(0, 1, 0, 1) // sin padding a la izquierda y derecha
                .NoBorder();

            /////////////////////////////////////////////////////////////////////////////////////////

            // Crear el grid
            var grid = new Grid();

            // Configurar el grid con 2 columnas
            grid.AddColumn(new GridColumn());
            grid.AddColumn(new GridColumn());

            // Añadir los 2 paneles al grid
            grid.AddRow(canvasImagePanel, textPanel);

            // Crear el padder y envolver el grid
            var paddedGrid = new Padder(grid)
                .Padding(15, 0, Ancho - 80, 0);  // padding: izquierda, arriba, derecha, abajo

            /////////////////////////////////////////////////////////////////////////////////////////

            // Renderizar el padder con el grid
            AnsiConsole.Write(paddedGrid);

            /////////////////////////////////////////////////////////////////////////////////////////
        }

        //// TRAMPAS /////

        if (img == 31)
        {
            var Img = new CanvasImage(@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Trampas\Hueco.png");
            Img.MaxWidth(7);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            // Crear un panel con la imagen CanvasImage (sin borde)
            var canvasImagePanel = new Panel(Img)
                .Padding(0, 0, 0, 0) // sin padding alrededor de la imagen
                .NoBorder();

            // Crear otro panel con texto (sin borde)
            var textPanel = new Panel(Program.Panel[panel])
                .Padding(0, 1, 0, 1) // sin padding a la izquierda y derecha
                .NoBorder();

            /////////////////////////////////////////////////////////////////////////////////////////

            // Crear el grid
            var grid = new Grid();

            // Configurar el grid con 2 columnas
            grid.AddColumn(new GridColumn());
            grid.AddColumn(new GridColumn());

            // Añadir los 2 paneles al grid
            grid.AddRow(canvasImagePanel, textPanel);

            // Crear el padder y envolver el grid
            var paddedGrid = new Padder(grid)
                .Padding(15, 0, Ancho - 80, 0);  // padding: izquierda, arriba, derecha, abajo

            /////////////////////////////////////////////////////////////////////////////////////////

            // Renderizar el padder con el grid
            AnsiConsole.Write(paddedGrid);

            /////////////////////////////////////////////////////////////////////////////////////////
        }

        if (img == 32)
        {
            var Img = new CanvasImage(@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Trampas\Bomba.png");
            Img.MaxWidth(7);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            // Crear un panel con la imagen CanvasImage (sin borde)
            var canvasImagePanel = new Panel(Img)
                .Padding(0, 0, 0, 0) // sin padding alrededor de la imagen
                .NoBorder();

            // Crear otro panel con texto (sin borde)
            var textPanel = new Panel(Program.Panel[panel])
                .Padding(0, 1, 0, 1) // sin padding a la izquierda y derecha
                .NoBorder();

            /////////////////////////////////////////////////////////////////////////////////////////

            // Crear el grid
            var grid = new Grid();

            // Configurar el grid con 2 columnas
            grid.AddColumn(new GridColumn());
            grid.AddColumn(new GridColumn());

            // Añadir los 2 paneles al grid
            grid.AddRow(canvasImagePanel, textPanel);

            // Crear el padder y envolver el grid
            var paddedGrid = new Padder(grid)
                .Padding(15, 0, Ancho - 80, 0);  // padding: izquierda, arriba, derecha, abajo

            /////////////////////////////////////////////////////////////////////////////////////////

            // Renderizar el padder con el grid
            AnsiConsole.Write(paddedGrid);

            /////////////////////////////////////////////////////////////////////////////////////////
        }

        if (img == 33)
        {
            var Img = new CanvasImage(@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Trampas\Jaula.png");
            Img.MaxWidth(7);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            // Crear un panel con la imagen CanvasImage (sin borde)
            var canvasImagePanel = new Panel(Img)
                .Padding(0, 0, 0, 0) // sin padding alrededor de la imagen
                .NoBorder();

            // Crear otro panel con texto (sin borde)
            var textPanel = new Panel(Program.Panel[panel])
                .Padding(0, 1, 0, 1) // sin padding a la izquierda y derecha
                .NoBorder();

            /////////////////////////////////////////////////////////////////////////////////////////

            // Crear el grid
            var grid = new Grid();

            // Configurar el grid con 2 columnas
            grid.AddColumn(new GridColumn());
            grid.AddColumn(new GridColumn());

            // Añadir los 2 paneles al grid
            grid.AddRow(canvasImagePanel, textPanel);

            // Crear el padder y envolver el grid
            var paddedGrid = new Padder(grid)
                .Padding(15, 0, Ancho - 80, 0);  // padding: izquierda, arriba, derecha, abajo

            /////////////////////////////////////////////////////////////////////////////////////////

            // Renderizar el padder con el grid
            AnsiConsole.Write(paddedGrid);

            /////////////////////////////////////////////////////////////////////////////////////////
        }

        //// BUFS ////

        if (img == 41)
        {
            var Img = new CanvasImage(@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Buffs\BuffHongo.png");
            Img.MaxWidth(7);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            // Crear un panel con la imagen CanvasImage (sin borde)
            var canvasImagePanel = new Panel(Img)
                .Padding(0, 0, 0, 0) // sin padding alrededor de la imagen
                .NoBorder();

            // Crear otro panel con texto (sin borde)
            var textPanel = new Panel(Program.Panel[panel])
                .Padding(0, 1, 0, 1) // sin padding a la izquierda y derecha
                .NoBorder();

            /////////////////////////////////////////////////////////////////////////////////////////

            // Crear el grid
            var grid = new Grid();

            // Configurar el grid con 2 columnas
            grid.AddColumn(new GridColumn());
            grid.AddColumn(new GridColumn());

            // Añadir los 2 paneles al grid
            grid.AddRow(canvasImagePanel, textPanel);

            // Crear el padder y envolver el grid
            var paddedGrid = new Padder(grid)
                .Padding(15, 0, Ancho - 80, 0);  // padding: izquierda, arriba, derecha, abajo

            /////////////////////////////////////////////////////////////////////////////////////////

            // Renderizar el padder con el grid
            AnsiConsole.Write(paddedGrid);

            /////////////////////////////////////////////////////////////////////////////////////////
        }

        if (img == 42)
        {
            var Img = new CanvasImage(@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Buffs\Estrella.png");
            Img.MaxWidth(7);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            // Crear un panel con la imagen CanvasImage (sin borde)
            var canvasImagePanel = new Panel(Img)
                .Padding(0, 0, 0, 0) // sin padding alrededor de la imagen
                .NoBorder();

            // Crear otro panel con texto (sin borde)
            var textPanel = new Panel(Program.Panel[panel])
                .Padding(0, 1, 0, 1) // sin padding a la izquierda y derecha
                .NoBorder();

            /////////////////////////////////////////////////////////////////////////////////////////

            // Crear el grid
            var grid = new Grid();

            // Configurar el grid con 2 columnas
            grid.AddColumn(new GridColumn());
            grid.AddColumn(new GridColumn());

            // Añadir los 2 paneles al grid
            grid.AddRow(canvasImagePanel, textPanel);

            // Crear el padder y envolver el grid
            var paddedGrid = new Padder(grid)
                .Padding(15, 0, Ancho - 80, 0);  // padding: izquierda, arriba, derecha, abajo

            /////////////////////////////////////////////////////////////////////////////////////////

            // Renderizar el padder con el grid
            AnsiConsole.Write(paddedGrid);

            /////////////////////////////////////////////////////////////////////////////////////////
        }

        if (img == 43)
        {
            var Img = new CanvasImage(@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Buffs\Flor.png");
            Img.MaxWidth(7);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            // Crear un panel con la imagen CanvasImage (sin borde)
            var canvasImagePanel = new Panel(Img)
                .Padding(0, 0, 0, 0) // sin padding alrededor de la imagen
                .NoBorder();

            // Crear otro panel con texto (sin borde)
            var textPanel = new Panel(Program.Panel[panel])
                .Padding(0, 1, 0, 1) // sin padding a la izquierda y derecha
                .NoBorder();

            /////////////////////////////////////////////////////////////////////////////////////////

            // Crear el grid
            var grid = new Grid();

            // Configurar el grid con 2 columnas
            grid.AddColumn(new GridColumn());
            grid.AddColumn(new GridColumn());

            // Añadir los 2 paneles al grid
            grid.AddRow(canvasImagePanel, textPanel);

            // Crear el padder y envolver el grid
            var paddedGrid = new Padder(grid)
                .Padding(15, 0, Ancho - 80, 0);  // padding: izquierda, arriba, derecha, abajo

            /////////////////////////////////////////////////////////////////////////////////////////

            // Renderizar el padder con el grid
            AnsiConsole.Write(paddedGrid);

            /////////////////////////////////////////////////////////////////////////////////////////
        }

        //// META ////

        if (img == 5)
        {
            var Img = new CanvasImage(@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Tablero\Meta.png");
            Img.MaxWidth(7);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            // Crear un panel con la imagen CanvasImage (sin borde)
            var canvasImagePanel = new Panel(Img)
                .Padding(0, 0, 0, 0) // sin padding alrededor de la imagen
                .NoBorder();

            // Crear otro panel con texto (sin borde)
            var textPanel = new Panel(Program.Panel[panel])
                .Padding(0, 1, 0, 1) // sin padding a la izquierda y derecha
                .NoBorder();

            /////////////////////////////////////////////////////////////////////////////////////////

            // Crear el grid
            var grid = new Grid();

            // Configurar el grid con 2 columnas
            grid.AddColumn(new GridColumn());
            grid.AddColumn(new GridColumn());

            // Añadir los 2 paneles al grid
            grid.AddRow(canvasImagePanel, textPanel);

            // Crear el padder y envolver el grid
            var paddedGrid = new Padder(grid)
                .Padding(15, 0, Ancho - 80, 0);  // padding: izquierda, arriba, derecha, abajo

            /////////////////////////////////////////////////////////////////////////////////////////

            // Renderizar el padder con el grid
            AnsiConsole.Write(paddedGrid);

            /////////////////////////////////////////////////////////////////////////////////////////
        }


        //// TIENDA ////

        if (img == 555)
        {
            var Img = new CanvasImage(@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Tablero\Tienda.png");
            Img.MaxWidth(7);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            // Crear un panel con la imagen CanvasImage (sin borde)
            var canvasImagePanel = new Panel(Img)
                .Padding(0, 0, 0, 0) // sin padding alrededor de la imagen
                .NoBorder();

            // Crear otro panel con texto (sin borde)
            var textPanel = new Panel(Program.Panel[panel])
                .Padding(0, 1, 0, 1) // sin padding a la izquierda y derecha
                .NoBorder();

            /////////////////////////////////////////////////////////////////////////////////////////

            // Crear el grid
            var grid = new Grid();

            // Configurar el grid con 2 columnas
            grid.AddColumn(new GridColumn());
            grid.AddColumn(new GridColumn());

            // Añadir los 2 paneles al grid
            grid.AddRow(canvasImagePanel, textPanel);

            // Crear el padder y envolver el grid
            var paddedGrid = new Padder(grid)
                .Padding(15, 0, Ancho - 80, 0);  // padding: izquierda, arriba, derecha, abajo

            /////////////////////////////////////////////////////////////////////////////////////////

            // Renderizar el padder con el grid
            AnsiConsole.Write(paddedGrid);

            /////////////////////////////////////////////////////////////////////////////////////////
        }

        //// LLAVES ////

        if (img == 1)
        {
            var Img = new CanvasImage(@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Tablero\LlaveMalos.png");
            Img.MaxWidth(7);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            // Crear un panel con la imagen CanvasImage (sin borde)
            var canvasImagePanel = new Panel(Img)
                .Padding(0, 0, 0, 0) // sin padding alrededor de la imagen
                .NoBorder();

            // Crear otro panel con texto (sin borde)
            var textPanel = new Panel(Program.Panel[panel])
                .Padding(0, 1, 0, 1) // sin padding a la izquierda y derecha
                .NoBorder();

            /////////////////////////////////////////////////////////////////////////////////////////

            // Crear el grid
            var grid = new Grid();

            // Configurar el grid con 2 columnas
            grid.AddColumn(new GridColumn());
            grid.AddColumn(new GridColumn());

            // Añadir los 2 paneles al grid
            grid.AddRow(canvasImagePanel, textPanel);

            // Crear el padder y envolver el grid
            var paddedGrid = new Padder(grid)
                .Padding(15, 0, Ancho - 80, 0);  // padding: izquierda, arriba, derecha, abajo

            /////////////////////////////////////////////////////////////////////////////////////////

            // Renderizar el padder con el grid
            AnsiConsole.Write(paddedGrid);

            /////////////////////////////////////////////////////////////////////////////////////////
        }

        if (img == 1)
        {
            var Img = new CanvasImage(@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Tablero\LlaveBuenos.png");
            Img.MaxWidth(7);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            // Crear un panel con la imagen CanvasImage (sin borde)
            var canvasImagePanel = new Panel(Img)
                .Padding(0, 0, 0, 0) // sin padding alrededor de la imagen
                .NoBorder();

            // Crear otro panel con texto (sin borde)
            var textPanel = new Panel(Program.Panel[panel])
                .Padding(0, 1, 0, 1) // sin padding a la izquierda y derecha
                .NoBorder();

            /////////////////////////////////////////////////////////////////////////////////////////

            // Crear el grid
            var grid = new Grid();

            // Configurar el grid con 2 columnas
            grid.AddColumn(new GridColumn());
            grid.AddColumn(new GridColumn());

            // Añadir los 2 paneles al grid
            grid.AddRow(canvasImagePanel, textPanel);

            // Crear el padder y envolver el grid
            var paddedGrid = new Padder(grid)
                .Padding(15, 0, Ancho - 80, 0);  // padding: izquierda, arriba, derecha, abajo

            /////////////////////////////////////////////////////////////////////////////////////////

            // Renderizar el padder con el grid
            AnsiConsole.Write(paddedGrid);

            /////////////////////////////////////////////////////////////////////////////////////////
        }

        //// COFRES / BOTAS / ANTORCHAS /////

        // comun
        if (img == 6)
        {
            var Img = new CanvasImage(@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Cofres\Comun\CofreComun.png");
            Img.MaxWidth(7);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            // Crear un panel con la imagen CanvasImage (sin borde)
            var canvasImagePanel = new Panel(Img)
                .Padding(0, 0, 0, 0) // sin padding alrededor de la imagen
                .NoBorder();

            // Crear otro panel con texto (sin borde)
            var textPanel = new Panel(Program.Panel[panel])
                .Padding(0, 1, 0, 1) // sin padding a la izquierda y derecha
                .NoBorder();

            /////////////////////////////////////////////////////////////////////////////////////////

            // Crear el grid
            var grid = new Grid();

            // Configurar el grid con 2 columnas
            grid.AddColumn(new GridColumn());
            grid.AddColumn(new GridColumn());

            // Añadir los 2 paneles al grid
            grid.AddRow(canvasImagePanel, textPanel);

            // Crear el padder y envolver el grid
            var paddedGrid = new Padder(grid)
                .Padding(15, 0, Ancho - 80, 0);  // padding: izquierda, arriba, derecha, abajo

            /////////////////////////////////////////////////////////////////////////////////////////

            // Renderizar el padder con el grid
            AnsiConsole.Write(paddedGrid);

            /////////////////////////////////////////////////////////////////////////////////////////
        }

        if (img == 61)
        {
            var Img = new CanvasImage(@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Cofres\Comun\AntorchaComun.png");
            Img.MaxWidth(7);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            // Crear un panel con la imagen CanvasImage (sin borde)
            var canvasImagePanel = new Panel(Img)
                .Padding(0, 0, 0, 0) // sin padding alrededor de la imagen
                .NoBorder();

            // Crear otro panel con texto (sin borde)
            var textPanel = new Panel(Program.Panel[panel])
                .Padding(0, 1, 0, 1) // sin padding a la izquierda y derecha
                .NoBorder();

            /////////////////////////////////////////////////////////////////////////////////////////

            // Crear el grid
            var grid = new Grid();

            // Configurar el grid con 2 columnas
            grid.AddColumn(new GridColumn());
            grid.AddColumn(new GridColumn());

            // Añadir los 2 paneles al grid
            grid.AddRow(canvasImagePanel, textPanel);

            // Crear el padder y envolver el grid
            var paddedGrid = new Padder(grid)
                .Padding(15, 0, Ancho - 80, 0);  // padding: izquierda, arriba, derecha, abajo

            /////////////////////////////////////////////////////////////////////////////////////////

            // Renderizar el padder con el grid
            AnsiConsole.Write(paddedGrid);

            /////////////////////////////////////////////////////////////////////////////////////////
        }

        if (img == 62)
        {
            var Img = new CanvasImage(@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Cofres\Comun\BotaComun.png");
            Img.MaxWidth(7);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            // Crear un panel con la imagen CanvasImage (sin borde)
            var canvasImagePanel = new Panel(Img)
                .Padding(0, 0, 0, 0) // sin padding alrededor de la imagen
                .NoBorder();

            // Crear otro panel con texto (sin borde)
            var textPanel = new Panel(Program.Panel[panel])
                .Padding(0, 1, 0, 1) // sin padding a la izquierda y derecha
                .NoBorder();

            /////////////////////////////////////////////////////////////////////////////////////////

            // Crear el grid
            var grid = new Grid();

            // Configurar el grid con 2 columnas
            grid.AddColumn(new GridColumn());
            grid.AddColumn(new GridColumn());

            // Añadir los 2 paneles al grid
            grid.AddRow(canvasImagePanel, textPanel);

            // Crear el padder y envolver el grid
            var paddedGrid = new Padder(grid)
                .Padding(15, 0, Ancho - 80, 0);  // padding: izquierda, arriba, derecha, abajo

            /////////////////////////////////////////////////////////////////////////////////////////

            // Renderizar el padder con el grid
            AnsiConsole.Write(paddedGrid);

            /////////////////////////////////////////////////////////////////////////////////////////
        }

        // epico
        if (img == 7)
        {
            var Img = new CanvasImage(@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Cofres\Epico\CofreEpico.png");
            Img.MaxWidth(7);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            // Crear un panel con la imagen CanvasImage (sin borde)
            var canvasImagePanel = new Panel(Img)
                .Padding(0, 0, 0, 0) // sin padding alrededor de la imagen
                .NoBorder();

            // Crear otro panel con texto (sin borde)
            var textPanel = new Panel(Program.Panel[panel])
                .Padding(0, 1, 0, 1) // sin padding a la izquierda y derecha
                .NoBorder();

            /////////////////////////////////////////////////////////////////////////////////////////

            // Crear el grid
            var grid = new Grid();

            // Configurar el grid con 2 columnas
            grid.AddColumn(new GridColumn());
            grid.AddColumn(new GridColumn());

            // Añadir los 2 paneles al grid
            grid.AddRow(canvasImagePanel, textPanel);

            // Crear el padder y envolver el grid
            var paddedGrid = new Padder(grid)
                .Padding(15, 0, Ancho - 80, 0);  // padding: izquierda, arriba, derecha, abajo

            /////////////////////////////////////////////////////////////////////////////////////////

            // Renderizar el padder con el grid
            AnsiConsole.Write(paddedGrid);

            /////////////////////////////////////////////////////////////////////////////////////////
        }

        if (img == 71)
        {
            var Img = new CanvasImage(@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Cofres\Epico\AntorchaEpica.png");
            Img.MaxWidth(7);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            // Crear un panel con la imagen CanvasImage (sin borde)
            var canvasImagePanel = new Panel(Img)
                .Padding(0, 0, 0, 0) // sin padding alrededor de la imagen
                .NoBorder();

            // Crear otro panel con texto (sin borde)
            var textPanel = new Panel(Program.Panel[panel])
                .Padding(0, 1, 0, 1) // sin padding a la izquierda y derecha
                .NoBorder();

            /////////////////////////////////////////////////////////////////////////////////////////

            // Crear el grid
            var grid = new Grid();

            // Configurar el grid con 2 columnas
            grid.AddColumn(new GridColumn());
            grid.AddColumn(new GridColumn());

            // Añadir los 2 paneles al grid
            grid.AddRow(canvasImagePanel, textPanel);

            // Crear el padder y envolver el grid
            var paddedGrid = new Padder(grid)
                .Padding(15, 0, Ancho - 80, 0);  // padding: izquierda, arriba, derecha, abajo

            /////////////////////////////////////////////////////////////////////////////////////////

            // Renderizar el padder con el grid
            AnsiConsole.Write(paddedGrid);

            /////////////////////////////////////////////////////////////////////////////////////////
        }

        if (img == 72)
        {
            var Img = new CanvasImage(@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Cofres\Epico\BotaEpica.png");
            Img.MaxWidth(7);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            // Crear un panel con la imagen CanvasImage (sin borde)
            var canvasImagePanel = new Panel(Img)
                .Padding(0, 0, 0, 0) // sin padding alrededor de la imagen
                .NoBorder();

            // Crear otro panel con texto (sin borde)
            var textPanel = new Panel(Program.Panel[panel])
                .Padding(0, 1, 0, 1) // sin padding a la izquierda y derecha
                .NoBorder();

            /////////////////////////////////////////////////////////////////////////////////////////

            // Crear el grid
            var grid = new Grid();

            // Configurar el grid con 2 columnas
            grid.AddColumn(new GridColumn());
            grid.AddColumn(new GridColumn());

            // Añadir los 2 paneles al grid
            grid.AddRow(canvasImagePanel, textPanel);

            // Crear el padder y envolver el grid
            var paddedGrid = new Padder(grid)
                .Padding(15, 0, Ancho - 80, 0);  // padding: izquierda, arriba, derecha, abajo

            /////////////////////////////////////////////////////////////////////////////////////////

            // Renderizar el padder con el grid
            AnsiConsole.Write(paddedGrid);

            /////////////////////////////////////////////////////////////////////////////////////////
        }

        // legendario
        if (img == 8)
        {
            var Img = new CanvasImage(@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Cofres\Legendario\CofreLegendario .png");
            Img.MaxWidth(7);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            // Crear un panel con la imagen CanvasImage (sin borde)
            var canvasImagePanel = new Panel(Img)
                .Padding(0, 0, 0, 0) // sin padding alrededor de la imagen
                .NoBorder();

            // Crear otro panel con texto (sin borde)
            var textPanel = new Panel(Program.Panel[panel])
                .Padding(0, 1, 0, 1) // sin padding a la izquierda y derecha
                .NoBorder();

            /////////////////////////////////////////////////////////////////////////////////////////

            // Crear el grid
            var grid = new Grid();

            // Configurar el grid con 2 columnas
            grid.AddColumn(new GridColumn());
            grid.AddColumn(new GridColumn());

            // Añadir los 2 paneles al grid
            grid.AddRow(canvasImagePanel, textPanel);

            // Crear el padder y envolver el grid
            var paddedGrid = new Padder(grid)
                .Padding(15, 0, Ancho - 80, 0);  // padding: izquierda, arriba, derecha, abajo

            /////////////////////////////////////////////////////////////////////////////////////////

            // Renderizar el padder con el grid
            AnsiConsole.Write(paddedGrid);

            /////////////////////////////////////////////////////////////////////////////////////////
        }

        if (img == 81)
        {
            var Img = new CanvasImage(@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Cofres\Legendario\AntorchaLegendaria.png");
            Img.MaxWidth(7);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            // Crear un panel con la imagen CanvasImage (sin borde)
            var canvasImagePanel = new Panel(Img)
                .Padding(0, 0, 0, 0) // sin padding alrededor de la imagen
                .NoBorder();

            // Crear otro panel con texto (sin borde)
            var textPanel = new Panel(Program.Panel[panel])
                .Padding(0, 1, 0, 1) // sin padding a la izquierda y derecha
                .NoBorder();

            /////////////////////////////////////////////////////////////////////////////////////////

            // Crear el grid
            var grid = new Grid();

            // Configurar el grid con 2 columnas
            grid.AddColumn(new GridColumn());
            grid.AddColumn(new GridColumn());

            // Añadir los 2 paneles al grid
            grid.AddRow(canvasImagePanel, textPanel);

            // Crear el padder y envolver el grid
            var paddedGrid = new Padder(grid)
                .Padding(15, 0, Ancho - 80, 0);  // padding: izquierda, arriba, derecha, abajo

            /////////////////////////////////////////////////////////////////////////////////////////

            // Renderizar el padder con el grid
            AnsiConsole.Write(paddedGrid);

            /////////////////////////////////////////////////////////////////////////////////////////
        }

        if (img == 82)
        {
            var Img = new CanvasImage(@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Cofres\Legendario\BotaLegendaria.png");
            Img.MaxWidth(7);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            // Crear un panel con la imagen CanvasImage (sin borde)
            var canvasImagePanel = new Panel(Img)
                .Padding(0, 0, 0, 0) // sin padding alrededor de la imagen
                .NoBorder();

            // Crear otro panel con texto (sin borde)
            var textPanel = new Panel(Program.Panel[panel])
                .Padding(0, 1, 0, 1) // sin padding a la izquierda y derecha
                .NoBorder();

            /////////////////////////////////////////////////////////////////////////////////////////

            // Crear el grid
            var grid = new Grid();

            // Configurar el grid con 2 columnas
            grid.AddColumn(new GridColumn());
            grid.AddColumn(new GridColumn());

            // Añadir los 2 paneles al grid
            grid.AddRow(canvasImagePanel, textPanel);

            // Crear el padder y envolver el grid
            var paddedGrid = new Padder(grid)
                .Padding(15, 0, Ancho - 80, 0);  // padding: izquierda, arriba, derecha, abajo

            /////////////////////////////////////////////////////////////////////////////////////////

            // Renderizar el padder con el grid
            AnsiConsole.Write(paddedGrid);

            /////////////////////////////////////////////////////////////////////////////////////////
        }


        ///// TIENDA ////

        // items

        if (img == 5511)
        {
            var Img = new CanvasImage(@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Tienda\Items\Escudo.png");
            Img.MaxWidth(7);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            // Crear un panel con la imagen CanvasImage (sin borde)
            var canvasImagePanel = new Panel(Img)
                .Padding(0, 0, 0, 0) // sin padding alrededor de la imagen
                .NoBorder();

            // Crear otro panel con texto (sin borde)
            var textPanel = new Panel(Program.Panel[panel])
                .Padding(0, 1, 0, 1) // sin padding a la izquierda y derecha
                .NoBorder();

            /////////////////////////////////////////////////////////////////////////////////////////

            // Crear el grid
            var grid = new Grid();

            // Configurar el grid con 2 columnas
            grid.AddColumn(new GridColumn());
            grid.AddColumn(new GridColumn());

            // Añadir los 2 paneles al grid
            grid.AddRow(canvasImagePanel, textPanel);

            // Crear el padder y envolver el grid
            var paddedGrid = new Padder(grid)
                .Padding(15, 0, Ancho - 80, 0);  // padding: izquierda, arriba, derecha, abajo

            /////////////////////////////////////////////////////////////////////////////////////////

            // Renderizar el padder con el grid
            AnsiConsole.Write(paddedGrid);

            /////////////////////////////////////////////////////////////////////////////////////////
        }

        if (img == 5512)
        {
            var Img = new CanvasImage(@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Tienda\Items\Escalera.png");
            Img.MaxWidth(7);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            // Crear un panel con la imagen CanvasImage (sin borde)
            var canvasImagePanel = new Panel(Img)
                .Padding(0, 0, 0, 0) // sin padding alrededor de la imagen
                .NoBorder();

            // Crear otro panel con texto (sin borde)
            var textPanel = new Panel(Program.Panel[panel])
                .Padding(0, 1, 0, 1) // sin padding a la izquierda y derecha
                .NoBorder();

            /////////////////////////////////////////////////////////////////////////////////////////

            // Crear el grid
            var grid = new Grid();

            // Configurar el grid con 2 columnas
            grid.AddColumn(new GridColumn());
            grid.AddColumn(new GridColumn());

            // Añadir los 2 paneles al grid
            grid.AddRow(canvasImagePanel, textPanel);

            // Crear el padder y envolver el grid
            var paddedGrid = new Padder(grid)
                .Padding(15, 0, Ancho - 127, 0);  // padding: izquierda, arriba, derecha, abajo

            /////////////////////////////////////////////////////////////////////////////////////////

            // Renderizar el padder con el grid
            AnsiConsole.Write(paddedGrid);

            /////////////////////////////////////////////////////////////////////////////////////////
        }

        // poderes

        if (img == 5521)
        {
            var Img = new CanvasImage(@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Tienda\Poderes\Bala.png");
            Img.MaxWidth(7);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            // Crear un panel con la imagen CanvasImage (sin borde)
            var canvasImagePanel = new Panel(Img)
                .Padding(0, 0, 0, 0) // sin padding alrededor de la imagen
                .NoBorder();

            // Crear otro panel con texto (sin borde)
            var textPanel = new Panel(Program.Panel[panel])
                .Padding(0, 1, 0, 1) // sin padding a la izquierda y derecha
                .NoBorder();

            /////////////////////////////////////////////////////////////////////////////////////////

            // Crear el grid
            var grid = new Grid();

            // Configurar el grid con 2 columnas
            grid.AddColumn(new GridColumn());
            grid.AddColumn(new GridColumn());

            // Añadir los 2 paneles al grid
            grid.AddRow(canvasImagePanel, textPanel);

            // Crear el padder y envolver el grid
            var paddedGrid = new Padder(grid)
                .Padding(15, 0, Ancho - 80, 0);  // padding: izquierda, arriba, derecha, abajo

            /////////////////////////////////////////////////////////////////////////////////////////

            // Renderizar el padder con el grid
            AnsiConsole.Write(paddedGrid);

            /////////////////////////////////////////////////////////////////////////////////////////
        }

        if (img == 5522)
        {
            var Img = new CanvasImage(@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Tienda\Poderes\Mascara.png");
            Img.MaxWidth(7);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            // Crear un panel con la imagen CanvasImage (sin borde)
            var canvasImagePanel = new Panel(Img)
                .Padding(0, 0, 0, 0) // sin padding alrededor de la imagen
                .NoBorder();

            // Crear otro panel con texto (sin borde)
            var textPanel = new Panel(Program.Panel[panel])
                .Padding(0, 1, 0, 1) // sin padding a la izquierda y derecha
                .NoBorder();

            /////////////////////////////////////////////////////////////////////////////////////////

            // Crear el grid
            var grid = new Grid();

            // Configurar el grid con 2 columnas
            grid.AddColumn(new GridColumn());
            grid.AddColumn(new GridColumn());

            // Añadir los 2 paneles al grid
            grid.AddRow(canvasImagePanel, textPanel);

            // Crear el padder y envolver el grid
            var paddedGrid = new Padder(grid)
                .Padding(15, 0, Ancho - 80, 0);  // padding: izquierda, arriba, derecha, abajo

            /////////////////////////////////////////////////////////////////////////////////////////

            // Renderizar el padder con el grid
            AnsiConsole.Write(paddedGrid);

            /////////////////////////////////////////////////////////////////////////////////////////
        }

        // pociones

        if (img == 5531)
        {
            var Img = new CanvasImage(@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Tienda\Pociones\PocionHielo.png");
            Img.MaxWidth(7);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            // Crear un panel con la imagen CanvasImage (sin borde)
            var canvasImagePanel = new Panel(Img)
                .Padding(0, 0, 0, 0) // sin padding alrededor de la imagen
                .NoBorder();

            // Crear otro panel con texto (sin borde)
            var textPanel = new Panel(Program.Panel[panel])
                .Padding(0, 1, 0, 1) // sin padding a la izquierda y derecha
                .NoBorder();

            /////////////////////////////////////////////////////////////////////////////////////////

            // Crear el grid
            var grid = new Grid();

            // Configurar el grid con 2 columnas
            grid.AddColumn(new GridColumn());
            grid.AddColumn(new GridColumn());

            // Añadir los 2 paneles al grid
            grid.AddRow(canvasImagePanel, textPanel);

            // Crear el padder y envolver el grid
            var paddedGrid = new Padder(grid)
                .Padding(15, 0, Ancho - 80, 0);  // padding: izquierda, arriba, derecha, abajo

            /////////////////////////////////////////////////////////////////////////////////////////

            // Renderizar el padder con el grid
            AnsiConsole.Write(paddedGrid);

            /////////////////////////////////////////////////////////////////////////////////////////
        }

        if (img == 5532)
        {
            var Img = new CanvasImage(@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Tienda\Pociones\PocionNiebla.png");
            Img.MaxWidth(7);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            // Crear un panel con la imagen CanvasImage (sin borde)
            var canvasImagePanel = new Panel(Img)
                .Padding(0, 0, 0, 0) // sin padding alrededor de la imagen
                .NoBorder();

            // Crear otro panel con texto (sin borde)
            var textPanel = new Panel(Program.Panel[panel])
                .Padding(0, 1, 0, 1) // sin padding a la izquierda y derecha
                .NoBorder();

            /////////////////////////////////////////////////////////////////////////////////////////

            // Crear el grid
            var grid = new Grid();

            // Configurar el grid con 2 columnas
            grid.AddColumn(new GridColumn());
            grid.AddColumn(new GridColumn());

            // Añadir los 2 paneles al grid
            grid.AddRow(canvasImagePanel, textPanel);

            // Crear el padder y envolver el grid
            var paddedGrid = new Padder(grid)
                .Padding(15, 0, Ancho - 80, 0);  // padding: izquierda, arriba, derecha, abajo

            /////////////////////////////////////////////////////////////////////////////////////////

            // Renderizar el padder con el grid
            AnsiConsole.Write(paddedGrid);

            /////////////////////////////////////////////////////////////////////////////////////////
        }

        if (img == 5533)
        {
            var Img = new CanvasImage(@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Tienda\Pociones\PocionVelocidad.png");
            Img.MaxWidth(7);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            // Crear un panel con la imagen CanvasImage (sin borde)
            var canvasImagePanel = new Panel(Img)
                .Padding(0, 0, 0, 0) // sin padding alrededor de la imagen
                .NoBorder();

            // Crear otro panel con texto (sin borde)
            var textPanel = new Panel(Program.Panel[panel])
                .Padding(0, 1, 0, 1) // sin padding a la izquierda y derecha
                .NoBorder();

            /////////////////////////////////////////////////////////////////////////////////////////

            // Crear el grid
            var grid = new Grid();

            // Configurar el grid con 2 columnas
            grid.AddColumn(new GridColumn());
            grid.AddColumn(new GridColumn());

            // Añadir los 2 paneles al grid
            grid.AddRow(canvasImagePanel, textPanel);

            // Crear el padder y envolver el grid
            var paddedGrid = new Padder(grid)
                .Padding(15, 0, Ancho - 80, 0);  // padding: izquierda, arriba, derecha, abajo

            /////////////////////////////////////////////////////////////////////////////////////////

            // Renderizar el padder con el grid
            AnsiConsole.Write(paddedGrid);

            /////////////////////////////////////////////////////////////////////////////////////////
        }

        if (img == 5534)
        {
            var Img = new CanvasImage(@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Tienda\Pociones\PocionVeneno.png");
            Img.MaxWidth(7);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            // Crear un panel con la imagen CanvasImage (sin borde)
            var canvasImagePanel = new Panel(Img)
                .Padding(0, 0, 0, 0) // sin padding alrededor de la imagen
                .NoBorder();

            // Crear otro panel con texto (sin borde)
            var textPanel = new Panel(Program.Panel[panel])
                .Padding(0, 1, 0, 1) // sin padding a la izquierda y derecha
                .NoBorder();

            /////////////////////////////////////////////////////////////////////////////////////////

            // Crear el grid
            var grid = new Grid();

            // Configurar el grid con 2 columnas
            grid.AddColumn(new GridColumn());
            grid.AddColumn(new GridColumn());

            // Añadir los 2 paneles al grid
            grid.AddRow(canvasImagePanel, textPanel);

            // Crear el padder y envolver el grid
            var paddedGrid = new Padder(grid)
                .Padding(15, 0, Ancho - 80, 0);  // padding: izquierda, arriba, derecha, abajo

            /////////////////////////////////////////////////////////////////////////////////////////

            // Renderizar el padder con el grid
            AnsiConsole.Write(paddedGrid);

            /////////////////////////////////////////////////////////////////////////////////////////
        }

        if (img == 5535)
        {
            var Img = new CanvasImage(@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Tienda\Pociones\PocionVision.png");
            Img.MaxWidth(7);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            // Crear un panel con la imagen CanvasImage (sin borde)
            var canvasImagePanel = new Panel(Img)
                .Padding(0, 0, 0, 0) // sin padding alrededor de la imagen
                .NoBorder();

            // Crear otro panel con texto (sin borde)
            var textPanel = new Panel(Program.Panel[panel])
                .Padding(0, 1, 0, 1) // sin padding a la izquierda y derecha
                .NoBorder();

            /////////////////////////////////////////////////////////////////////////////////////////

            // Crear el grid
            var grid = new Grid();

            // Configurar el grid con 2 columnas
            grid.AddColumn(new GridColumn());
            grid.AddColumn(new GridColumn());

            // Añadir los 2 paneles al grid
            grid.AddRow(canvasImagePanel, textPanel);

            // Crear el padder y envolver el grid
            var paddedGrid = new Padder(grid)
                .Padding(15, 0, Ancho - 80, 0);  // padding: izquierda, arriba, derecha, abajo

            /////////////////////////////////////////////////////////////////////////////////////////

            // Renderizar el padder con el grid
            AnsiConsole.Write(paddedGrid);

            /////////////////////////////////////////////////////////////////////////////////////////
        }

        ///// ALERTA /////

        if (img == 55555)
        {
            var Img = new CanvasImage(@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Tablero\Alerta.png");
            Img.MaxWidth(7);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            // Crear un panel con la imagen CanvasImage (sin borde)
            var canvasImagePanel = new Panel(Img)
                .Padding(0, 0, 0, 0) // sin padding alrededor de la imagen
                .NoBorder();

            // Crear otro panel con texto (sin borde)
            var textPanel = new Panel(Program.Panel[panel])
                .Padding(0, 1, 0, 1) // sin padding a la izquierda y derecha
                .NoBorder();

            /////////////////////////////////////////////////////////////////////////////////////////

            // Crear el grid
            var grid = new Grid();

            // Configurar el grid con 2 columnas
            grid.AddColumn(new GridColumn());
            grid.AddColumn(new GridColumn());

            // Añadir los 2 paneles al grid
            grid.AddRow(canvasImagePanel, textPanel);

            // Crear el padder y envolver el grid
            var paddedGrid = new Padder(grid)
                .Padding(15, 0, Ancho - 80, 0);  // padding: izquierda, arriba, derecha, abajo

            /////////////////////////////////////////////////////////////////////////////////////////

            // Renderizar el padder con el grid
            AnsiConsole.Write(paddedGrid);

            /////////////////////////////////////////////////////////////////////////////////////////
        }


        /////////////////////////////////// MARCO //////////////////////////////////////////////////

        // Derecha
        for (int y = Alto - 10; y < Alto; y++)
        {
            for (int x = Ancho - 79; x < Ancho; x++)
            {
                Console.SetCursorPosition(x, y);
                AnsiConsole.Markup("[on orange4_1] [/]");

                Console.SetCursorPosition(Ancho - 80, y);
                AnsiConsole.Markup($"[grey69 on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})]▌ [/]");
            }
        }
        // Izquierda

        for (int y = Alto - 10; y < Alto; y++)
        {
            for (int x = 0; x < 10; x++)
            {
                Console.SetCursorPosition(x, y);
                AnsiConsole.Markup("[on orange4_1] [/]");

                Console.SetCursorPosition(10, y);
                AnsiConsole.Markup($"[grey69 on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})] ▐[/]");
            }
        }

        // Marco

        for (int x = 11; x < Ancho - 80; x++)
        {
            Console.SetCursorPosition(x, Alto - 10);
            AnsiConsole.Markup($"[grey69 on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})]▄▄[/]");
        }

        for (int x = 11; x < Ancho - 80; x++)
        {
            Console.SetCursorPosition(x, Alto - 1);
            AnsiConsole.Markup($"[grey69 on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})]▀▀[/]");
        }

        /////////////////////////////////////// LABEL //////////////////////////////////////////////

        Console.SetCursorPosition(124, 8);

        AnsiConsole.Markup($"[italic black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})]■ Ficha: {Program.Player[player].Name}[/]");


        // Posisitionreset cursor
        Console.SetCursorPosition(0, 0);

    }
}
