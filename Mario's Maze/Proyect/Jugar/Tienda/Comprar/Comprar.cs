using Spectre.Console;

public class Tienda
{
    static int ChekCoins;

    public static void Comprar(int Player)
    {

        while (true)
        {

            int Select = Selects.Tienda(Player);


            if (Select == 4)
                break;

            if (Select == 1) // Items
            {
                while (true)
                {
                    if (Program.Player[Player].Equipo)
                        ChekCoins = Program.EquipoBuenoCoins;
                    else
                        ChekCoins = Program.EquipoMaloCoins;


                    int SelectItem = Selects.Items(Player);

                    if (SelectItem == 3)
                        break;

                    if (ChekCoins >= 1)
                    {
                        if (SelectItem == 1) // Escudo
                        {
                            Imprime.Print(Player, 5511, 5511); // Player / Img / Panel
                            Console.ReadKey();
                            Items.Escudo(Player);

                            if (Program.Player[Player].Equipo)
                                Program.EquipoBuenoCoins -= 1;
                            else
                                Program.EquipoMaloCoins -= 1;

                            break;
                        }

                        if (SelectItem == 2) // Escalera
                        {
                            Imprime.Print(Player, 5512, 5512); // Player / Img / Panel
                            Console.ReadKey();
                            Items.Escalera(Player);

                            if (Program.Player[Player].Equipo)
                                Program.EquipoBuenoCoins -= 1;
                            else
                                Program.EquipoMaloCoins -= 1;

                            break;
                        }

                    }
                    else // Monedas Insuficientes Panel
                    {

                        Imprime.Print(Player, 55555, 151515); // Player / Img / Panel
                        Console.ReadKey();
                    }
                }
            }

            if (Select == 2) //  Poderes
            {
                while (true)
                {
                    if (Program.Player[Player].Equipo)
                        ChekCoins = Program.EquipoBuenoCoins;
                    else
                        ChekCoins = Program.EquipoMaloCoins;


                    int SelectPoder = Selects.Poderes(Player);

                    if (SelectPoder == 3)
                        break;

                    if (ChekCoins >= 1)
                    {
                        if (SelectPoder == 1) // Bala
                        {

                            Imprime.Print(Player, 5521, 5521); // Player / Img / Panel
                            Console.ReadKey();
                            Poderes.Bala(Player);

                            if (Program.Player[Player].Equipo)
                                Program.EquipoBuenoCoins -= 1;
                            else
                                Program.EquipoMaloCoins -= 1;

                            break;
                        }

                        if (SelectPoder == 2) // Mascara
                        {

                            Imprime.Print(Player, 5521, 5521); // Player / Img / Panel
                            var keyInfo = Console.ReadKey();
                            //Poderes.Mascara(Player);

                            if (Program.Player[Player].Equipo)
                                Program.EquipoBuenoCoins -= 1;
                            else
                                Program.EquipoMaloCoins -= 1;

                            break;

                        }
                    }
                    else // Monedas Insuficientes Panel
                    { }
                }
            }

            if (Select == 3) //  Pociones
            {
                while (true)
                {
                    if (Program.Player[Player].Equipo)
                        ChekCoins = Program.EquipoBuenoCoins;
                    else
                        ChekCoins = Program.EquipoMaloCoins;


                    int SelectPocion = Selects.Pociones(Player);

                    if (SelectPocion == 6)
                        break;

                    if (ChekCoins >= 1)
                    {
                        if (SelectPocion == 1) { }

                        if (SelectPocion == 2) { }

                        if (SelectPocion == 3) { }

                        if (SelectPocion == 4) { }

                        if (SelectPocion == 5) { }


                    }
                    else // Monedas Insuficientes Panel
                    { }
                }
            }
        }
    }
}
