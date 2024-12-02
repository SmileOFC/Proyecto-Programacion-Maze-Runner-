using Spectre.Console;

public class Tienda
{
    static int ChekCoins;

    public static void Comprar(int Player)
    {
        
        while (true)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
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

Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.Clear();
                    Interfaz.Imprimir(Player);
                    Console.WriteLine("");
                    var SelectItem = AnsiConsole.Prompt(
                        new SelectionPrompt<string>()
                            .Title("───── [Red1]ITEMS[/] ────────────────────────")
                            .PageSize(3)
                            .MoreChoicesText("────────────────────────────────────────────────")
                            .AddChoices(new[] { " Escudo", " Escalera", " Atras" })
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

                        /* if (SelectItem == " Tubo")
                        {
                            Items.Tubo(Player);

                            if (Program.Player[Player].Equipo)
                                Program.EquipoBuenoCoins -= 1;
                            else
                                Program.EquipoMaloCoins -= 1;

                            break;
                        } */
                    }
                    else // Monedas Insuficientes Panel
                    { }
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

Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.Clear();
                    Interfaz.Imprimir(Player);
                    Console.WriteLine("");
                    var SelectPoder = AnsiConsole.Prompt(
                        new SelectionPrompt<string>()
                            .Title("───── [Red1]PODERES[/] ────────────────────────")
                            .PageSize(3)
                            .MoreChoicesText("────────────────────────────────────────────────")
                            .AddChoices(new[] { " Bala", " Mascara", " Atras" })
                    );

                    if (SelectPoder == " Atras")
                        break;

                    if (ChekCoins >= 1)
                    {
                        if (SelectPoder == " Bala")
                        {
                            Poderes.Bala(Player);
                            if (Program.Player[Player].Equipo)
                                Program.EquipoBuenoCoins -= 1;
                            else
                                Program.EquipoMaloCoins -= 1;

                            break;
                        }

                        if (SelectPoder == " Mascara") { }
                    }
                    else // Monedas Insuficientes Panel
                    { }
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

Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.Clear();
                    Interfaz.Imprimir(Player);
                    Console.WriteLine("");
                    var SelectPocion = AnsiConsole.Prompt(
                        new SelectionPrompt<string>()
                            .Title("───── [Red1]POCIONES[/] ────────────────────────")
                            .PageSize(5)
                            .MoreChoicesText("────────────────────────────────────────────────")
                            .AddChoices(new[]{" Veneno"," Vision"," Velocidad"," Niebla"," Hielo"," Telaraña"," Atras"})
                    );

                    if (SelectPocion == " Atras")
                        break;

                    if (ChekCoins >= 1)
                    {
                        if (SelectPocion == " Veneno") { }

                        if (SelectPocion == " Vision") { }

                        if (SelectPocion == " Velocidad") { }

                        if (SelectPocion == " Niebla") { }

                        if (SelectPocion == " Hielo") { }

                        if (SelectPocion == " Telaraña") { }
                    }
                    else // Monedas Insuficientes Panel
                    { }
                }
            }
        }
    }
}
