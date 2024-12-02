using Spectre.Console;
using System;
using System.Collections.Generic;
class Imprime
{

    public static void Print(int player, int img, int panel) // int player
    {

        // Definir el color blanco en RGB 
        var whiteColor = new Color(255, 255, 255);
        // Crear un estilo con texto negro y fondo blanco 
        var style = new Style(foreground: Color.Black, background: whiteColor);

        int Ancho = Console.WindowWidth;
        int Alto = Console.WindowHeight;

        // Posisition Grid reset cursor
        Console.SetCursorPosition(0, Alto - 9);

        /////////////////////////////////////////////////////////////////////////////////////////////////////

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

        if (img == 1)
        {
            var Img = new CanvasImage(@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Tablero\Tienda.png");
            //Img.MaxWidth(7);

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
            //Img.MaxWidth(7);

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
            //Img.MaxWidth(7);

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
        if (img == 1)
        {
            var Img = new CanvasImage(@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Cofres\Comun\CofreComun.png");
            //Img.MaxWidth(7);

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
            var Img = new CanvasImage(@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Cofres\Comun\AntorchaComun.png");
            //Img.MaxWidth(7);

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
            var Img = new CanvasImage(@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Cofres\Comun\BotaComun.png");
            //Img.MaxWidth(7);

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
        if (img == 1)
        {
            var Img = new CanvasImage(@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Cofres\Epico\CofreEpico.png");
            //Img.MaxWidth(7);

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
            var Img = new CanvasImage(@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Cofres\Epico\AntorchaEpica.png");
            //Img.MaxWidth(7);

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
        if (img == 1)
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

        if (img == 1)
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

        if (img == 1)
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

        if (img == 1)
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
        
        if (img == 1)
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
                .Padding(15, 0, Ancho - 80, 0);  // padding: izquierda, arriba, derecha, abajo

            /////////////////////////////////////////////////////////////////////////////////////////

            // Renderizar el padder con el grid
            AnsiConsole.Write(paddedGrid);

            /////////////////////////////////////////////////////////////////////////////////////////
        }

        // poderes

        if (img == 1)
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
        
        if (img == 1)
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

        if (img == 1)
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

        if (img == 1)
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

        if (img == 1)
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

        if (img == 1)
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

        if (img == 1)
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

        if (img == 1)
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

        AnsiConsole.Markup($"[italic black on rgb({whiteColor.R},{whiteColor.G},{whiteColor.B})]■ Ficha: {Program.Player[img].Name}[/]");


    }
}
