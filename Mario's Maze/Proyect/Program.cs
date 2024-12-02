using System;
using System.Runtime.InteropServices;
using SixLabors.ImageSharp;
using Spectre.Console;

public class Program
{


    // eliminar marco
    private const int SW_MAXIMIZE = 3;
    private const int GWL_STYLE = -16;
    private const int WS_CAPTION = 0x00C00000;
    private const int WS_MINIMIZEBOX = 0x00020000;
    private const int WS_SYSMENU = 0x00080000;
    private const int SWP_NOSIZE = 0x0001;
    private const int SWP_NOMOVE = 0x0002;
    private const int SWP_NOZORDER = 0x0004;
    private const int SWP_FRAMECHANGED = 0x0020;


    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern IntPtr GetConsoleWindow();

    [DllImport("user32.dll", SetLastError = true)]
    private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

    [DllImport("user32.dll", SetLastError = true)]
    private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

    [DllImport("user32.dll", SetLastError = true)]
    private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

    [DllImport("user32.dll", SetLastError = true)]
    private static extern bool SetWindowPos(
        IntPtr hWnd,
        IntPtr hWndInsertAfter,
        int X,
        int Y,
        int cx,
        int cy,
        uint uFlags
    );

    // Eliminar scrool

    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern bool GetConsoleScreenBufferInfo(IntPtr hConsoleOutput, out CONSOLE_SCREEN_BUFFER_INFO lpConsoleScreenBufferInfo);
    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern IntPtr GetStdHandle(int nStdHandle);
    private const int STD_OUTPUT_HANDLE = -11;
    [StructLayout(LayoutKind.Sequential)]
    private struct COORD
    {
        public short X;
        public short Y;
    }

    [StructLayout(LayoutKind.Sequential)]
    private struct SMALL_RECT
    {
        public short Left;
        public short Top;
        public short Right;
        public short Bottom;
    }
    [StructLayout(LayoutKind.Sequential)]
    private struct CONSOLE_SCREEN_BUFFER_INFO
    {
        public COORD dwSize;
        public COORD dwCursorPosition;
        public short wAttributes;
        public SMALL_RECT srWindow;
        public COORD dwMaximumWindowSize;
    }

    public static Dictionary<int, int> chek = new Dictionary<int, int>();
    public static Dictionary<char, int> ChekBuenos = new Dictionary<char, int>();
    public static Dictionary<char, int> ChekMalos = new Dictionary<char, int>();

    ////////////////////////////////////////////////////////////////////////
    public static Dictionary<string, int> Nombre = new Dictionary<string, int>();
    public static Dictionary<int, string> ImgRuta = new Dictionary<int, string>();
    public static Dictionary<int, string> Panel = new Dictionary<int, string>();
    public static Dictionary<int, CrearPlayer> Player = new Dictionary<int, CrearPlayer>();

    public static int EquipoBuenoCoins = 0;
    public static int EquipoMaloCoins = 0;

    public static bool EquipoBuenoLlave = false;
    public static bool EquipoMaloLlave = false;

    public static int Main()
    {


        IntPtr hWnd = GetConsoleWindow(); // Obtener el estilo actual de la ventana
        int style = GetWindowLong(hWnd, GWL_STYLE); // Eliminar los estilos de la barra de título, minimizar y menú de sistema
        style &= ~WS_CAPTION;
        style &= ~WS_MINIMIZEBOX;
        style &= ~WS_SYSMENU; // Aplicar el nuevo estilo a la ventana
        SetWindowLong(hWnd, GWL_STYLE, style); // Actualizar la ventana para aplicar los cambios
        ShowWindow(hWnd, SW_MAXIMIZE);
        SetWindowPos(hWnd, IntPtr.Zero, 0, 0, 0, 0, SWP_NOSIZE | SWP_NOMOVE | SWP_NOZORDER | SWP_FRAMECHANGED);
        // Obtener el handle del búfer de salida de la consola 
        IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE); // Obtener información del búfer de pantalla de la consola 
        GetConsoleScreenBufferInfo(hConsole, out CONSOLE_SCREEN_BUFFER_INFO csbi); // Ajustar el tamaño del búfer para que coincida con el tamaño de la ventana 

        if (hWnd != IntPtr.Zero)
        {

#if WINDOWS
            Console.SetBufferSize(csbi.dwMaximumWindowSize.X, csbi.dwMaximumWindowSize.Y);
#endif

        }

        CrearPlayer Mario = new CrearPlayer("Mario", 100, 12, 0, 48, true, 1, 1, false, false, false, false);
        CrearPlayer Luigi = new CrearPlayer("Luigi", 10, 10, 0, 20, true, 1, 1, false, false, false, false);
        CrearPlayer Hongo = new CrearPlayer("Hongo", 5, 5, 0, 20, true, 2, 2, false, false, false, false);
        CrearPlayer Yoshi = new CrearPlayer("Yoshi", 6, 6, 0, 24, true, 1, 1, false, false, false, false);
        CrearPlayer Peach = new CrearPlayer("Peach", 7, 7, 0, 28, true, 2, 2, false, false, false, false);

        CrearPlayer Bowser = new CrearPlayer("Bowser", 8, 8, 0, 16, false, 1, 1, false, false, false, false);
        CrearPlayer DonkeyKong = new CrearPlayer("DonKeyKong", 4, 4, 0, 16, false, 2, 2, false, false, false, false);
        CrearPlayer Koopa = new CrearPlayer("Koopa", 3, 3, 0, 3, false, 3, 3, false, false, false, false);
        CrearPlayer Waluigi = new CrearPlayer("Waluigi", 9, 9, 0, 18, false, 1, 1, false, false, false, false);
        CrearPlayer Wario = new CrearPlayer("Wario", 11, 11, 0, 11, false, 1, 1, false, false, false, false);

        // Diccionario Players

        Player.Add(20, Mario);
        Player.Add(21, Luigi);
        Player.Add(22, Hongo);
        Player.Add(23, Yoshi);
        Player.Add(24, Peach);

        Player.Add(25, Bowser);
        Player.Add(26, DonkeyKong);
        Player.Add(27, Koopa);
        Player.Add(28, Waluigi);
        Player.Add(29, Wario);

        // Diccionario Nombre

        Nombre.Add("Mario", 20);
        Nombre.Add("Luigi", 21);
        Nombre.Add("Hongo", 22);
        Nombre.Add("Yoshi", 23);
        Nombre.Add("Peach", 24);

        Nombre.Add("Bowser", 25);
        Nombre.Add("DonKeyKong", 26);
        Nombre.Add("Koopa", 27);
        Nombre.Add("Waluigi", 28);
        Nombre.Add("Wario", 29);

        // Buenos

        ChekBuenos.Add('1', 20);
        ChekBuenos.Add('2', 21);
        ChekBuenos.Add('3', 22);
        ChekBuenos.Add('4', 23);
        ChekBuenos.Add('5', 24);

        //Malos

        ChekMalos.Add('1', 25);
        ChekMalos.Add('2', 26);
        ChekMalos.Add('3', 27);
        ChekMalos.Add('4', 28);
        ChekMalos.Add('5', 29);

        ///////////////////////////////////// Diccionario Panel //////////////////////////////////

        //// TABLERO ///////

        // Players

        Panel.Add(20,"It's me Mario...");
        Panel.Add(21,"");
        Panel.Add(22,"");
        Panel.Add(23,"");
        Panel.Add(24,"");

        Panel.Add(25,"");
        Panel.Add(26,"");
        Panel.Add(27,"");
        Panel.Add(28,"");
        Panel.Add(29,"");

        // Trampas

        Panel.Add(31,"");
        Panel.Add(32,"");
        Panel.Add(33,"");

        // Buffs

        Panel.Add(41,"");
        Panel.Add(42,"");
        Panel.Add(43,"");

        // Cofres

        Panel.Add(6,"");
        Panel.Add(7,"");
        Panel.Add(8,"");

        // Meta

        /* Panel.Add(1,"");

        // Llave Malos Buenos

        Panel.Add(1,"");
        Panel.Add(1,"");


        ///// TIENDA /////

        // items

            // Escudo 
            // Escalera

        // poderes

            // Bala
            // Mascara

        // pociones

            // Veneno
            // Vision
            // Velocidad
            // Niebla
            // Hielo
            // Telaraña


        ///// ALERTAS ///////
        
        // Puerta Buenos no Malos

        // Puerta Malos no Buenos

        // Llave Buenos no Malos

        // Llave Malos no Buenos


        ///// SELECTS
        
            // cofre botas antorchas

            // Direccion

            // Select Players Buenos

            // Select Players Malos        

            // Direccion

            // Menu / Continuar / guia / salir

            // Salir / yes / no

            // Cofre avanzar / Yes / No

       */ 
        ///////////////////// Diccionario ImgRuta /////////////////////

        //// PLAYERS /////

        ImgRuta.Add(20, @"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Players\Mario.png");
        ImgRuta.Add(21, @"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Players\Luigi.png");
        ImgRuta.Add(22, @"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Players\Hongo.png");
        ImgRuta.Add(23, @"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Players\Yoshi.png");
        ImgRuta.Add(24, @"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Players\Peach.png");

        ImgRuta.Add(25, @".\InterfazGrafica\Assets\Players\Bowser.png");
        ImgRuta.Add(26, @"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Players\DonkeyKong.png");
        ImgRuta.Add(27, @"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Players\Koopa.png");
        ImgRuta.Add(28, @"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Players\Waluigi.png");
        ImgRuta.Add(29, @"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Players\Wario.png");

        // Trampas

        ImgRuta.Add(31,@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Trampas\Hueco.png");
        ImgRuta.Add(32,@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Trampas\Bomba.png");
        ImgRuta.Add(33,@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Trampas\Jaula.png");

        // Buffs

        ImgRuta.Add(41,@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Buffs\BuffHongo.png");
        ImgRuta.Add(42,@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Buffs\Estrella.png");
        ImgRuta.Add(43,@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Buffs\Flor.png");

        // Meta

        ImgRuta.Add(5,@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Tablero\Meta.png");
/*
        // Tienda

        ImgRuta.Add(1,@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Tablero\Tienda.png");

        // Llave Malo Buenos

        ImgRuta.Add(1,@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Tablero\LlaveMalos.png");
        ImgRuta.Add(1,@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Tablero\LlaveBuenos.png");



        //// COFRES /////

        // Comun
        ImgRuta.Add(6,@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Cofres\Comun\Cofre Comun.png");
            //Antorcha / Botas
            ImgRuta.Add(1,@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Cofres\Comun\AntorchaComun.png");
            ImgRuta.Add(1,@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Cofres\Comun\BotaComun.png");
            
        // Epico
        ImgRuta.Add(7,@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Cofres\Epico\Cofre Epico.png");
            //Antorcha / Botas
            ImgRuta.Add(1,@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Cofres\Epico\AntorchaEpica.png");
            ImgRuta.Add(1,@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Cofres\Epico\BotaEpica.png");

        // Legendario
        ImgRuta.Add(8,@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Cofres\Legendario\Cofre Legendario .png");
            //Antorcha / Botas
            ImgRuta.Add(1,@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Cofres\Legendario\AntorchaLegendaria.png");
            ImgRuta.Add(1,@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Cofres\Legendario\BotaLegendaria.png");


        ///// TIENDA ////

        // items

        ImgRuta.Add(1,@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Tienda\Items\Escudo.png");
        ImgRuta.Add(1,@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Tienda\Items\Escalera.png");

        // poderes

        ImgRuta.Add(1,@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Tienda\Poderes\Bala.png");
        ImgRuta.Add(1,@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Tienda\Poderes\Mascara.png");

        // pociones

        ImgRuta.Add(1,@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Tienda\Pociones\PocionVeneno.png");
        ImgRuta.Add(1,@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Tienda\Pociones\PocionVision.png");
        ImgRuta.Add(1,@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Tienda\Pociones\PocionVelocidad.png");
        ImgRuta.Add(1,@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Tienda\Pociones\PocionNiebla.png");
        ImgRuta.Add(1,@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Tienda\Pociones\PocionHielo.png");
        ImgRuta.Add(1,@"C:\Users\Mayito\OneDrive\Documentos\GitHub\Proyecto-Programacion-Maze-Runner-\Mario's Maze\Proyect\InterfazGrafica\Assets\Tienda\Pociones\PocionTelaraña.png");
 */
        ///// ALERTAS
        
        

        
        
        
        
        
        
        // Diccionario MOVER

        chek.Add(0, 0);
        chek.Add(1, 1);

        //trampas
        chek.Add(31, 3);
        chek.Add(32, 3);
        chek.Add(33, 3);

        //bufs
        chek.Add(41, 4);
        chek.Add(42, 4);
        chek.Add(43, 4);

        //Llave/Cofres/Coins/Meta/Puerta/Escalera
        chek.Add(323, 32); // llave malos
        chek.Add(313, 31); // llave buenos

        chek.Add(6, 6); // comun
        chek.Add(7, 7); // epico
        chek.Add(8, 8); // legendario

        chek.Add(2, 2); // coins

        chek.Add(5, 5); // meta

        chek.Add(111, 11); // buenos puerta
        chek.Add(121, 11); // malos puerta

        chek.Add(151, 151); // Escalera arriba
        chek.Add(252, 252); // Escalera abajo
        chek.Add(353, 353); // Escalera arriba
        chek.Add(454, 454); // Escalera abajo

        //players
        chek.Add(20, 20);
        chek.Add(21, 20);
        chek.Add(22, 20);
        chek.Add(23, 20);
        chek.Add(24, 20);
        chek.Add(25, 20);
        chek.Add(26, 20);
        chek.Add(27, 20);
        chek.Add(28, 20);
        chek.Add(29, 20);

    main:
        Console.Clear();

    loby:
        if (Loby.loby() == 0)
        {
            goto salir;
        }


        if (Rondas.Ronda() == 0)
        {
            goto loby;
        }
        Win();
        goto main;
    salir: // salir
        return 0;
    }

    static void Win() { }
}
