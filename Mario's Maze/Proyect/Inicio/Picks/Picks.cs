
public class Modo
{

    public static bool Juego;

    public static void Select()
    {
        while (true)
        {

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("//////////////////////");
            Console.WriteLine("Seleccione el Modo:");
            Console.WriteLine("1vs1:  1");
            Console.WriteLine("2vs2:  2");
            Console.WriteLine("//////////////////////");
            var keyInfo = Console.ReadKey();

            if (keyInfo.KeyChar == '1' || keyInfo.KeyChar == '2')
            {

                if (keyInfo.KeyChar == '1')
                {
                    Juego = true;
                    break;
                }
                if (keyInfo.KeyChar == '2')
                {
                    Juego = false;
                    break;
                }

            }

        }

    }

}

public class Picks
{

    public static Stack<int> Fichas = new Stack<int>();
    public static Stack<int> EquipoBuenos = new Stack<int>();
    public static Stack<int> EquipoMalo = new Stack<int>();
    public static void SelectEquipo()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("//////////////////////");
            Console.WriteLine("Seleccione su equipo:");
            Console.WriteLine();
            Console.WriteLine("Reino Champiñon: 1");
            Console.WriteLine("Reino Koopa:     2");
            Console.WriteLine("//////////////////////");
            var keyInfo = Console.ReadKey();

            if (keyInfo.KeyChar == '1' || keyInfo.KeyChar == '2')
            {

                if (keyInfo.KeyChar == '1')
                {

                    SelectFichas('B');
                    SelectFichas('M');
                    break;

                }

                if (keyInfo.KeyChar == '2')
                {

                    SelectFichas('M');
                    SelectFichas('B');
                    break;

                }

            }

        }

    }

    static void SelectFichas(char x)
    {


        if (Modo.Juego)
        { // 1v1
            if (x == 'B')
            {

                Console.Clear();

                Console.WriteLine("//////////////////////");
                Console.WriteLine("   Reino Champiñon    ");
                Console.WriteLine("//////////////////////");
                Console.WriteLine();
                Console.WriteLine("=> Mario: 1");
                Console.WriteLine("=> Luigi: 2");
                Console.WriteLine("=> Hongo: 3");
                Console.WriteLine("=> Yoshi: 4");
                Console.WriteLine("=> Peach: 5");
                Console.WriteLine();
                Console.WriteLine("//////////////////////");

                for (int c = 1; c <= 3;)
                {

                    var keyInfo = Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine("//////////////////////");
                    Console.WriteLine("   Reino Champiñon    ");
                    Console.WriteLine("//////////////////////");
                    Console.WriteLine();
                    Console.WriteLine("=> Mario: 1");
                    Console.WriteLine("=> Luigi: 2");
                    Console.WriteLine("=> Hongo: 3");
                    Console.WriteLine("=> Yoshi: 4");
                    Console.WriteLine("=> Peach: 5");
                    Console.WriteLine();
                    Console.WriteLine("//////////////////////");

                    if (keyInfo.KeyChar == '1' || keyInfo.KeyChar == '2' || keyInfo.KeyChar == '3' || keyInfo.KeyChar == '4' || keyInfo.KeyChar == '5')
                    {

                        if (keyInfo.KeyChar == '1')
                        {
                            Fichas.Push(20);
                            EquipoBuenos.Push(20);
                            Console.WriteLine("Ficha " + c + ": " + Program.Player[20].Name);
                            c++;
                        }

                        if (keyInfo.KeyChar == '2')
                        {
                            Fichas.Push(21);
                            EquipoBuenos.Push(21);
                            Console.WriteLine("Ficha " + c + ": " + Program.Player[21].Name);
                            c++;
                        }

                        if (keyInfo.KeyChar == '3')
                        {
                            Fichas.Push(22);
                            EquipoBuenos.Push(22);
                            Console.WriteLine("Ficha " + c + ": " + Program.Player[22].Name);
                            c++;
                        }

                        if (keyInfo.KeyChar == '4')
                        {
                            Fichas.Push(23);
                            EquipoBuenos.Push(23);
                            Console.WriteLine("Ficha " + c + ": " + Program.Player[23].Name);
                            c++;
                        }

                        if (keyInfo.KeyChar == '5')
                        {
                            Fichas.Push(24);
                            EquipoBuenos.Push(24);
                            Console.WriteLine("Ficha " + c + ": " + Program.Player[24].Name);
                            c++;
                        }

                    }

                }

                Thread.Sleep(1000);
                Console.Clear();

            }

            if (x == 'M')
            {

                Console.Clear();

                Console.WriteLine("//////////////////////");
                Console.WriteLine("      Reino Koopa     ");
                Console.WriteLine("//////////////////////");
                Console.WriteLine();
                Console.WriteLine("=> Bowser:     1");
                Console.WriteLine("=> DonkeyKong: 2");
                Console.WriteLine("=> Koopa:      3");
                Console.WriteLine("=> Waluigi:    4");
                Console.WriteLine("=> Wario:      5");
                Console.WriteLine();
                Console.WriteLine("//////////////////////");


                for (int c = 1; c <= 3;)
                {

                    var keyInfo = Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine("//////////////////////");
                    Console.WriteLine("      Reino Koopa     ");
                    Console.WriteLine("//////////////////////");
                    Console.WriteLine();
                    Console.WriteLine("=> Bowser:     1");
                    Console.WriteLine("=> DonkeyKong: 2");
                    Console.WriteLine("=> Koopa:      3");
                    Console.WriteLine("=> Waluigi:    4");
                    Console.WriteLine("=> Wario:      5");
                    Console.WriteLine();
                    Console.WriteLine("//////////////////////");

                    if (keyInfo.KeyChar == '1' || keyInfo.KeyChar == '2' || keyInfo.KeyChar == '3' || keyInfo.KeyChar == '4' || keyInfo.KeyChar == '5')
                    {
                        if (keyInfo.KeyChar == '1')
                        {
                            Fichas.Push(25);
                            EquipoMalo.Push(25);
                            Console.WriteLine("Ficha " + c + ": " + Program.Player[25].Name);
                            c++;
                        }

                        if (keyInfo.KeyChar == '2')
                        {
                            Fichas.Push(26);
                            EquipoMalo.Push(26);
                            Console.WriteLine("Ficha " + c + ": " + Program.Player[26].Name);
                            c++;
                        }

                        if (keyInfo.KeyChar == '3')
                        {
                            Fichas.Push(27);
                            EquipoMalo.Push(27);
                            Console.WriteLine("Ficha " + c + ": " + Program.Player[27].Name);
                            c++;
                        }

                        if (keyInfo.KeyChar == '4')
                        {
                            Fichas.Push(28);
                            EquipoMalo.Push(28);
                            Console.WriteLine("Ficha " + c + ": " + Program.Player[28].Name);
                            c++;
                        }

                        if (keyInfo.KeyChar == '5')
                        {
                            Fichas.Push(29);
                            EquipoMalo.Push(29);
                            Console.WriteLine("Ficha " + c + ": " + Program.Player[29].Name);
                            c++;
                        }
                    }

                }

                Thread.Sleep(2000);
                Console.Clear();



            }

        }
        else
        { // 2v2


            if (x == 'B')
            {

                Console.Clear();

                Console.WriteLine("//////////////////////");
                Console.WriteLine("   Reino Champiñon    ");
                Console.WriteLine("//////////////////////");
                Console.WriteLine();
                Console.WriteLine("=> Mario: 1");
                Console.WriteLine("=> Luigi: 2");
                Console.WriteLine("=> Hongo: 3");
                Console.WriteLine("=> Yoshi: 4");
                Console.WriteLine("=> Peach: 5");
                Console.WriteLine();
                Console.WriteLine("//////////////////////");

                for (int c = 1; c <= 4;)
                {

                    var keyInfo = Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine("//////////////////////");
                    Console.WriteLine("   Reino Champiñon    ");
                    Console.WriteLine("//////////////////////");
                    Console.WriteLine();
                    Console.WriteLine("=> Mario: 1");
                    Console.WriteLine("=> Luigi: 2");
                    Console.WriteLine("=> Hongo: 3");
                    Console.WriteLine("=> Yoshi: 4");
                    Console.WriteLine("=> Peach: 5");
                    Console.WriteLine();
                    Console.WriteLine("//////////////////////");

                    if (keyInfo.KeyChar == '1' || keyInfo.KeyChar == '2' || keyInfo.KeyChar == '3' || keyInfo.KeyChar == '4' || keyInfo.KeyChar == '5')
                    {
                        if (keyInfo.KeyChar == '1')
                        {
                            Fichas.Push(20);
                            EquipoBuenos.Push(20);
                            Console.WriteLine("Ficha " + c + ": " + Program.Player[20].Name);
                            c++;
                        }

                        if (keyInfo.KeyChar == '2')
                        {
                            Fichas.Push(21);
                            EquipoBuenos.Push(21);
                            Console.WriteLine("Ficha " + c + ": " + Program.Player[21].Name);
                            c++;
                        }

                        if (keyInfo.KeyChar == '3')
                        {
                            Fichas.Push(22);
                            EquipoBuenos.Push(22);
                            Console.WriteLine("Ficha " + c + ": " + Program.Player[22].Name);
                            c++;
                        }

                        if (keyInfo.KeyChar == '4')
                        {
                            Fichas.Push(23);
                            EquipoBuenos.Push(23);
                            Console.WriteLine("Ficha " + c + ": " + Program.Player[23].Name);
                            c++;
                        }

                        if (keyInfo.KeyChar == '5')
                        {
                            Fichas.Push(24);
                            EquipoBuenos.Push(24);
                            Console.WriteLine("Ficha " + c + ": " + Program.Player[24].Name);
                            c++;
                        }

                    }
                }

                Thread.Sleep(2000);
                Console.Clear();



            }

            if (x == 'M')
            {

                Console.Clear();

                Console.WriteLine("//////////////////////");
                Console.WriteLine("      Reino Koopa     ");
                Console.WriteLine("//////////////////////");
                Console.WriteLine();
                Console.WriteLine("=> Bowser:     1");
                Console.WriteLine("=> DonkeyKong: 2");
                Console.WriteLine("=> Koopa:      3");
                Console.WriteLine("=> Waluigi:    4");
                Console.WriteLine("=> Wario:      5");
                Console.WriteLine();
                Console.WriteLine("//////////////////////");


                for (int c = 1; c <= 4;)
                {

                    var keyInfo = Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine("//////////////////////");
                    Console.WriteLine("      Reino Koopa     ");
                    Console.WriteLine("//////////////////////");
                    Console.WriteLine();
                    Console.WriteLine("=> Bowser:     1");
                    Console.WriteLine("=> DonkeyKong: 2");
                    Console.WriteLine("=> Koopa:      3");
                    Console.WriteLine("=> Waluigi:    4");
                    Console.WriteLine("=> Wario:      5");
                    Console.WriteLine();
                    Console.WriteLine("//////////////////////");

                    if (keyInfo.KeyChar == '1' || keyInfo.KeyChar == '2' || keyInfo.KeyChar == '3' || keyInfo.KeyChar == '4' || keyInfo.KeyChar == '5')
                    {

                        if (keyInfo.KeyChar == '1')
                        {
                            Fichas.Push(25);
                            EquipoMalo.Push(25);
                            Console.WriteLine("Ficha " + c + ": " + Program.Player[25].Name);
                            c++;
                        }

                        if (keyInfo.KeyChar == '2')
                        {
                            Fichas.Push(26);
                            EquipoMalo.Push(26);
                            Console.WriteLine("Ficha " + c + ": " + Program.Player[26].Name);
                            c++;
                        }

                        if (keyInfo.KeyChar == '3')
                        {
                            Fichas.Push(27);
                            EquipoMalo.Push(27);
                            Console.WriteLine("Ficha " + c + ": " + Program.Player[27].Name);
                            c++;
                        }

                        if (keyInfo.KeyChar == '4')
                        {
                            Fichas.Push(28);
                            EquipoMalo.Push(28);
                            Console.WriteLine("Ficha " + c + ": " + Program.Player[28].Name);
                            c++;
                        }

                        if (keyInfo.KeyChar == '5')
                        {
                            Fichas.Push(29);
                            EquipoMalo.Push(29);
                            Console.WriteLine("Ficha " + c + ": " + Program.Player[29].Name);
                            c++;
                        }
                    }

                }

                Thread.Sleep(2000);
                Console.Clear();



            }

        }



    }

}
