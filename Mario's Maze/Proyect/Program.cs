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
        // Cambiar fuente para poder usar emogings
        Console.OutputEncoding = System.Text.Encoding.UTF8;

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

        CrearPlayer Mario = new CrearPlayer("Mario", 12, 12, 0, 2, true, 1, 1, false, false, 0, 0);
        CrearPlayer Luigi = new CrearPlayer("Luigi", 10, 10, 0, 2, true, 1, 1, false, false, 0, 0);
        CrearPlayer Hongo = new CrearPlayer("Hongo", 5, 5, 0, 2, true, 2, 2, false, false, 0, 0);
        CrearPlayer Yoshi = new CrearPlayer("Yoshi", 6, 6, 0, 2, true, 1, 1, false, false, 0, 0);
        CrearPlayer Peach = new CrearPlayer("Peach", 7, 7, 0, 2, true, 2, 2, false, false, 0, 0);

        CrearPlayer Bowser = new CrearPlayer("Bowser", 8, 8, 0, 2, false, 1, 1, false, false, 0, 0);
        CrearPlayer DonkeyKong = new CrearPlayer("DonKeyKong", 4, 4, 0, 2, false, 2, 2, false, false, 0, 0);
        CrearPlayer Koopa = new CrearPlayer("Koopa", 3, 3, 0,2, false, 3, 3, false, false, 0, 0);
        CrearPlayer Waluigi = new CrearPlayer("Waluigi", 9, 9, 0, 2, false, 1, 1, false, false, 0, 0);
        CrearPlayer Wario = new CrearPlayer("Wario", 11, 11, 0, 2, false, 1, 1, false, false, 0, 0);

        //////////////////////////// DICCIONARIO PLAYERS /////////////////////////////

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

        //////////////////////////// DICCIONARIO NOMBRES /////////////////////////////

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

        //////////////////////////// DICCIONARIO MOVER //////////////////////

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

        ///////////////////////////////////// DICCIONARIO PANELES //////////////////////////////////

        //// TABLERO ///////

        // Players

        // Inicio
        Panel.Add(20, $"[italic bold]Mario:\n\nIt's me Mario...[/]");
        Panel.Add(21, $"[italic bold]Luigi:\n\nIt's me Luigi...[/]");
        Panel.Add(22, $"[italic bold]Hongo:\n\nIt's me Hongo...[/]");
        Panel.Add(23, $"[italic bold]Yoshi:\n\nIt's me Yoshi...[/]");
        Panel.Add(24, $"[italic bold]Peach:\n\nIt's me Peach...[/]");

        Panel.Add(25, $"[italic bold]Bowser:\n\nIt's me Bowser...[/]");
        Panel.Add(26, $"[italic bold]DonKeyKong:\n\nIt's me DonKeyKong...[/]");
        Panel.Add(27, $"[italic bold]Koopa:\n\nIt's me Koopa...[/]");
        Panel.Add(28, $"[italic bold]Waluigi:\n\nIt's me Waluigi...[/]");
        Panel.Add(29, $"[italic bold]Wario:\n\nIt's me Wario...[/]");

        // Habilidades
        Panel.Add(200, $"[italic bold]MARIO:\n\nSelecciona una direccion para\nindicarle a Mario que muro saltar.\n              (W)\n           (A)(S)(D)[/]");
        Panel.Add(211, $"[italic bold]Luigi:\n\nIt's me Luigi...Habilidad[/]");
        Panel.Add(222, $"[italic bold]Hongo:\n\nIt's me Hongo...Habilidad[/]");
        Panel.Add(233, $"[italic bold]Yoshi:\n\nIt's me Yoshi...Habilidad[/]");
        Panel.Add(244, $"[italic bold]Peach:\n\nIt's me Peach...Habilidad[/]");

        Panel.Add(255, $"[italic bold]Bowser:\n\nIt's me Bowser...Habilidad[/]");
        Panel.Add(266, $"[italic bold]DonKeyKong:\n\nIt's me DonKeyKong...Habilidad[/]");
        Panel.Add(277, $"[italic bold]Koopa:\n\nIt's me Koopa...Habilidad[/]");
        Panel.Add(288, $"[italic bold]Waluigi:\n\nIt's me Waluigi...Habilidad[/]");
        Panel.Add(299, $"[italic bold]Wario:\n\nIt's me Wario...Habilidad[/]");


        /////////////////////////////////////////////////////////////////////////

        // Trampas

        Panel.Add(31, $"[italic bold]Hueco:\n\nHaz caido en un hueco tu ficha saldra donde comenzo.[/]");
        Panel.Add(32, $"[italic bold]Bomba:\n\nHaz pisado una bomba tu ficha fue empujada 2 pasos.[/]");
        Panel.Add(33, $"[italic bold]Jaula:\n\nHaz activado una placa de presion y ha caido una jaula encima de tu ficha dejandola inmovil.[/]");

        // Buffs

        Panel.Add(41, $"[italic bold]Hongo:\n\nQue bien te haz encontrado un Hongo ahora podras avanzar +10 Pasos en este turno.[/]");
        Panel.Add(42, $"[italic bold]Estrella:\n\nQue bien te haz encontrado una Estrella ahora seras inmune a las trampas en este turno.[/]");
        Panel.Add(43, $"[italic bold]Flor:\n\nQue bien te haz encontrado una Flor ahora tendras +2 vision en este turno.[/]");

        // Meta

        Panel.Add(5, $"[italic bold]Meta:\n\nGenial haz llegado a la meta.[/]");

        ///// TIENDA SELECT //////

        // Items / Poderes / Pociones / Salir

        Panel.Add(555, $"[italic bold]TIENDA:\n\n          (SELECCIONE UNA OPCION)\n\n     (1)ITEMS        (2)PODERES      (3)POCIONES     (4)SALIR[/]");

        // Items Select / Escudo / Escalera / Salir

        Panel.Add(551, $"[italic bold]Items:\n\n        (Seleccione una opcion)\n\n    (1)Escudo (2)Escalera (3)Salir[/]");

        // Poderes Select / Bala / Mascara / Salir

        Panel.Add(552, $"[italic bold]Poderes:\n\n         (Seleccione una opcion)\n\n     (1)Bala (2)Mascara (3)Salir[/]");

        // Pociones Select / Veneno / Vision / Velocidad / Niebla / Hielo / Salir

        Panel.Add(553, $"[italic bold]Pociones:\n\n           (Seleccione una opcion)\n    (1)Veneno (2)Vision (3)Velocidad \n      (4)Niebla (5)Hielo (6)Salir[/]");

        ////////// ITEMS /////////////////

        Panel.Add(5511, $"[italic bold]Escudo:\n\nVuelve una de tus fichas inmune a trampas en su proximo turno.[/]");
        Panel.Add(5512, $"[italic bold]Escalera:\n\nAlcanzale una escalera a una de tus fichas para q pueda subir la muralla.[/]");

        //////////// PODERES ////////////

        Panel.Add(5521, $"[italic bold]Bala:\n\nDisparale una bala gigante a una de las fichas enemigas.[/]");
        Panel.Add(5522, $"[italic bold]Mascara:\n\nCon esta mascara tus enemigos no podran ver casi nada por un turno.[/]");

        ////////////// POCIONES //////////////

        Panel.Add(5531,$"[italic bold][/]");
        Panel.Add(5532,$"[italic bold][/]");
        Panel.Add(5533,$"[italic bold][/]");
        Panel.Add(5534,$"[italic bold][/]");
        Panel.Add(5535,$"[italic bold][/]");

        ///////// COFRES SELECTS //////////

        // Cofres abrir / Yes / No

        Panel.Add(6, $"[italic bold]Cofre Comun: (1$)\n\n   (Deseas abrir este cofre?)\n\n        (1)Si (2)No[/]");
        Panel.Add(7, $"[italic bold]Cofre Epico: (3$)\n\n   (Deseas abrir este cofre?)\n\n        (1)Si (2)No[/]");
        Panel.Add(8, $"[italic bold]Cofre Legendario: (5$)\n\n   (Deseas abrir este cofre?)\n\n        (1)Si (2)No[/]");

        // Cofre Comun select / Bota / Antorcha

        Panel.Add(70, $"[italic bold]Cofre Comun: (1$)\n\n    (Seleccione una opcion)\n\n     (1)Botas (2)Antorcha[/]");

        // Cofre Epico select / Bota / Antorcha

        Panel.Add(80, $"[italic bold]Cofre Epico: (3$)\n\n    (Seleccione una opcion)\n\n     (1)Botas (2)Antorcha[/]");

        // Cofre Legendario select / Bota / Antorcha

        Panel.Add(90, $"[italic bold]Cofre Legendario: (5$)\n\n    (Seleccione una opcion)\n\n     (1)Botas (2)Antorcha[/]");

        // Botas / Comunes / Epicas / Legendarias

        Panel.Add(71, $"[italic bold]Botas Comunes:\n\nAhora la ficha seleccionada tendra +3 Pasos[/]");

        Panel.Add(72, $"[italic bold]Botas Epicas:\n\nAhora la ficha seleccionada tendra +4 Pasos[/]");

        Panel.Add(73, $"[italic bold]Botas Legendarias:\n\nAhora la ficha seleccionada tendra +5 Pasos[/]");

        // Antorcha / Comun / Epica / Legendaria

        Panel.Add(81, $"[italic bold]Antorcha Comun:\n\nAhora la ficha seleccionada tendra +1 Vision[/]");

        Panel.Add(82, $"[italic bold]Antorcha Epica:\n\nAhora la ficha seleccionada tendra +2 Vision[/]");

        Panel.Add(83, $"[italic bold]Antorcha Legendaria:\n\nAhora la ficha seleccionada tendra +3 Vision[/]");

        ///// OTHERS SELECTS ///////

        // Cofre avanzar no tienes monedas suficientes / Yes / No  

        Panel.Add(61, $"[italic bold]NOTA: No tienes monedas suficientes para abrir este cofre si deseas avanzar el cofre sera eliminado.\n\n       (Deseas avanzar?)\n         (1)Si (2)No[/]");

        // Select Players Buenos

        Panel.Add(62, $"[italic bold]Seleccione una Ficha:\n\n  (1)Mario (2)Luigi (3)Hongo (4)Yoshi (5)Peach[/]");

        // Select Players Malos 

        Panel.Add(63, $"[italic bold]Seleccione una Ficha:\n\n  (1)Bowser (2)DonKeyKong (3)Koopa (4)Waluigi (5)Wario[/]");

        // Direccion

        Panel.Add(64, $"[italic bold]Seleccione una Direccion:\n\n       (W)\n    (A)(S)(D)[/]");

        // Menu / Continuar / guia / salir

        Panel.Add(65, $"[italic bold]Menu:\n\n   (1)Continuar   (2)Guia   (3)Salir[/]");

        // Salir / yes / no

        Panel.Add(66, $"[italic bold]NOTA: Si sales se perdera la partida.\n\n      (Seguro que deseas Salir?)\n      (1)Si (2)No[/]");

        ///// ALERTAS ///////

        // Tienda sin dinero

        Panel.Add(151515, $"[italic bold]\n\n  NOTA: No tienes monedas suficientes.[/]");

        // Llave Malos / Buenos

        Panel.Add(333, $"[italic bold]\n\n  NOTA: Esta no es tu llave.[/]");

        // Puerta 

        Panel.Add(444, $"[italic bold]\n\n  NOTA:Esta no es tu puerta.[/]");

        // Kooopa

        Panel.Add(2777, $"[italic bold]\n\n  NOTA:Ya no te queda vision.[/]");

        // Wario

        Panel.Add(2999, $"[italic bold]\n\n  NOTA:Ya no te quedan pasos.[/]");

        Panel.Add(1010, $"[italic bold]\n\n\n  GOOOO!!!![/]");

    //////////////////////////////////////////////////////////////////////////////

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
