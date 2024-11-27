using Spectre.Console;
public class Tienda
{
    static int ChekCoins;
    static bool EntradaTienda = Program.Player[Rondas.FichasList[0]].Equipo;

    public static void Comprar(int Player)
    {

        if ( Program.Player[Player].Equipo == EntradaTienda)
        {
                if(EntradaTienda)
                    EntradaTienda = false;
                else 
                    EntradaTienda = true;

            while (true)
            {

                Console.Clear();
                Interfaz.Imprimir(Player);
                Console.WriteLine("");
                var Select = AnsiConsole.Prompt(

                                new SelectionPrompt<string>()
                                .Title("───── [Red1]TIENDA[/] ────────────────────────")
                                .PageSize(3)
                                .MoreChoicesText("────────────────────────────────────────────────")
                                .AddChoices(new[] { " Items", " Poderes", " Pociones", " Salir" })
                            );

                if (Select == " Salir")
                    break;

                if (Select == " Items") // Items
                {
                    while (true)
                    {

                        if (Program.Player[Player].Equipo)
                            ChekCoins = Program.EquipoBuenoCoins;
                        else
                            ChekCoins = Program.EquipoMaloCoins;
                            
                        Console.Clear();
                        Interfaz.Imprimir(Player);
                        Console.WriteLine("");
                        var SelectItem = AnsiConsole.Prompt(

                                        new SelectionPrompt<string>()
                                        .Title("───── [Red1]ITEMS[/] ────────────────────────")
                                        .PageSize(3)
                                        .MoreChoicesText("────────────────────────────────────────────────")
                                        .AddChoices(new[] { " Escudo", " Escalera", " Tubo", " Atras" })
                                    );

                        if (SelectItem == " Atras")
                            break;

                        if (ChekCoins >= 1)
                        {

                            if (SelectItem == " Escudo")
                            {

                                Items.Escudo(Player);

                                if (Program.Player[Player].Equipo)
                                    Program.EquipoBuenoCoins -= 1;
                                else
                                    Program.EquipoMaloCoins -= 1;

                                break;

                            }


                            if (SelectItem == " Escalera")
                            {

                                Items.Escalera(Player);

                                if (Program.Player[Player].Equipo)
                                    Program.EquipoBuenoCoins -= 1;
                                else
                                    Program.EquipoMaloCoins -= 1;

                                break;

                            }


                            if (SelectItem == " Tubo")
                            {

                                Items.Tubo(Player);

                                if (Program.Player[Player].Equipo)
                                    Program.EquipoBuenoCoins -= 1;
                                else
                                    Program.EquipoMaloCoins -= 1;

                                break;

                            }
                        }
                        else // Monedas Insuficientes Panel
                        {

                        }
                    }
                }

                if (Select == " Poderes") //  Poderes
                {

                    while (true)
                    {

                        if (Program.Player[Player].Equipo)
                            ChekCoins = Program.EquipoBuenoCoins;
                        else
                            ChekCoins = Program.EquipoMaloCoins;

                        Console.Clear();
                        Interfaz.Imprimir(Player);
                        Console.WriteLine("");
                        var SelectPoder = AnsiConsole.Prompt(

                                        new SelectionPrompt<string>()
                                        .Title("───── [Red1]PODERES[/] ────────────────────────")
                                        .PageSize(3)
                                        .MoreChoicesText("────────────────────────────────────────────────")
                                        .AddChoices(new[] { " Bala ", " Telaraña", " Mascara", " Atras" })
                                    );

                        if (SelectPoder == " Atras")
                            break;

                        if (ChekCoins >= 1)
                        {

                            if (SelectPoder == " Bala")
                            {



                            }

                            if (SelectPoder == " Telaraña")
                            {



                            }

                            if (SelectPoder == " Mascara")
                            {



                            }

                        }
                        else // Monedas Insuficientes Panel
                        {

                        }

                    }
                }

                if (Select == " Pociones") //  Pociones
                {

                    while (true)
                    {
                        if (Program.Player[Player].Equipo)
                            ChekCoins = Program.EquipoBuenoCoins;
                        else
                            ChekCoins = Program.EquipoMaloCoins;



                        Console.Clear();
                        Interfaz.Imprimir(Player);
                        Console.WriteLine("");
                        var SelectPocion = AnsiConsole.Prompt(

                                        new SelectionPrompt<string>()
                                        .Title("───── [Red1]POCIONES[/] ────────────────────────")
                                        .PageSize(5)
                                        .MoreChoicesText("────────────────────────────────────────────────")
                                        .AddChoices(new[] { " Veneno", " Vision", " Velocidad", " Niebla", " Hielo", " Atras" })
                                    );

                        if (SelectPocion == " Atras")
                            break;

                        if (ChekCoins >= 1)
                        {

                            if (SelectPocion == " Veneno")
                            {



                            }

                            if (SelectPocion == " Vision")
                            {



                            }

                            if (SelectPocion == " Velocidad")
                            {



                            }

                            if (SelectPocion == " Niebla")
                            {



                            }

                            if (SelectPocion == " Hielo")
                            {



                            }

                        }
                        else // Monedas Insuficientes Panel
                        {

                        }
                    }
                }
            }
        }
        else // ya compraste ya
        {

        }
    }
}