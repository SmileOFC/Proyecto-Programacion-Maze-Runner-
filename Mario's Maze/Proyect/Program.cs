using System;
using Spectre.Console;
using SixLabors.ImageSharp;
public class Program
{
    public static Dictionary<int, int> chek = new Dictionary<int, int>();
    /// <summary>
    /// ////////////////////////////////////////////////////////////////////
    /// </summary>
    public static Dictionary<char, int> ChekBuenos = new Dictionary<char, int>();
    public static Dictionary<char, int> ChekMalos = new Dictionary<char, int>();
    ////////////////////////////////////////////////////////////////////////
    public static Dictionary<string, int> Nombre = new Dictionary<string, int>();
    public static Dictionary<int, CrearPlayer> Player = new Dictionary<int, CrearPlayer>();

    public static int EquipoBuenoCoins = 0;
    public static int EquipoMaloCoins = 0;

    public static bool EquipoBuenoLlave = false;
    public static bool EquipoMaloLlave = false;

    public static int Main()
    {

        CrearPlayer Mario = new CrearPlayer("Mario", 12,12,0,48, true, 1,1, false, false, false, false);
        CrearPlayer Luigi = new CrearPlayer("Luigi", 10,10,0,20, true, 1,1, false, false, false, false);
        CrearPlayer Hongo = new CrearPlayer("Hongo", 5,5,0,20, true, 2,2, false, false, false, false);
        CrearPlayer Yoshi = new CrearPlayer("Yoshi", 6,6,0,24, true,  1,1, false, false, false, false);
        CrearPlayer Peach = new CrearPlayer("Peach", 7,7,0,28, true, 2,2, false, false, false, false);

        CrearPlayer Bowser = new CrearPlayer("Bowser", 8,8,0,16, false, 1,1, false, false, false, false);
        CrearPlayer DonkeyKong = new CrearPlayer("DonKeyKong", 4,4,0,16, false, 2,2, false, false, false, false);
        CrearPlayer Koopa = new CrearPlayer("Koopa", 3,3,0,3, false, 3,3, false, false, false, false);
        CrearPlayer Waluigi = new CrearPlayer("Waluigi", 9,9,0,18, false,  1,1, false, false, false, false);
        CrearPlayer Wario = new CrearPlayer("Wario", 11,11,0,11, false, 1,1, false, false, false, false);
        

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

        Nombre.Add("Mario",20);
        Nombre.Add("Luigi",21);
        Nombre.Add("Hongo",22);
        Nombre.Add("Yoshi",23);
        Nombre.Add("Peach",24);

        Nombre.Add("Bowser",25);
        Nombre.Add("DonKeyKong",26);
        Nombre.Add("Koopa",27);
        Nombre.Add("Waluigi",28);
        Nombre.Add("Wario",29);
        
        // Buenos

        ChekBuenos.Add('1',20);
        ChekBuenos.Add('2',21);
        ChekBuenos.Add('3',22);
        ChekBuenos.Add('4',23);
        ChekBuenos.Add('5',24);

        //Malos

        ChekMalos.Add('1',25);
        ChekMalos.Add('2',26);
        ChekMalos.Add('3',27);
        ChekMalos.Add('4',28);
        ChekMalos.Add('5',29);

        
        
        // Diccionario Mover

        chek.Add(0,0);
        chek.Add(1,1);

        //trampas
        chek.Add(31,3);
        chek.Add(32,3);
        chek.Add(33,3);

        //bufs
        chek.Add(41,4);
        chek.Add(42,4);
        chek.Add(43,4);

        //Llave/Cofres/Coins/Meta/Puerta/Escalera
        chek.Add(323,32); // llave malos
        chek.Add(313,31); // llave buenos

        chek.Add(6,6);    // comun
        chek.Add(7,7);    // epico
        chek.Add(8,8);    // legendario

        chek.Add(2,2);    // coins

        chek.Add(5,5);    // meta

        chek.Add(111,11); // buenos puerta
        chek.Add(121,11); // malos puerta

        chek.Add(51,51);  // Escalera
        


        
        //players
        chek.Add(20,20);
        chek.Add(21,20);
        chek.Add(22,20);
        chek.Add(23,20);
        chek.Add(24,20);
        chek.Add(25,20);
        chek.Add(26,20);
        chek.Add(27,20);
        chek.Add(28,20);
        chek.Add(29,20);

        Console.Clear();

        Loby.LOBY();
        Rondas.Ronda();
        Win();
        return Main();
    }

    static void Win()
    {
        


    }

}

