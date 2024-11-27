using System.Security.Cryptography.X509Certificates;
using Spectre.Console;
public class Cofres
{

    static string SelectItem()
    {

        Console.WriteLine("");
        var Select = AnsiConsole.Prompt(

                        new SelectionPrompt<string>()
                        .Title("───── [Red1]Seleccione un Item[/] ────────────────────────")
                        .PageSize(3)
                        .AddChoices(new[] { "Botas", "Antorcha" })
                    );

        return Select;
    }

    public static void Cofre(int Player, int x)
    {


        ///////////////////////////////////////////////////////////////////////////////////////////////////////
        if (x == 6) // COMUN
        {

            if (Program.Player[Player].Equipo) // BUENOS
            {

                if (Program.EquipoBuenoCoins > 0) // Revisar q tenga monedas
                {
                    Console.Clear();
                    Interfaz.Imprimir(Player); // Seleccione item

                    var ItemComun = SelectItem();
                    var PlayerSelect = "";
                    int c = 0;

                    while (c == 0) // Seleccione player para equipar
                    {
                        Console.Clear();
                        Interfaz.Imprimir(Player);

                        PlayerSelect = Selects.SelectPlayerBuenos();

                        for (int i = 0; i < Rondas.EquipoBuenosList.Count; i++)
                        {
                            if (Program.Player[Rondas.EquipoBuenosList[0]].Name == PlayerSelect || Program.Player[Rondas.EquipoBuenosList[1]].Name == PlayerSelect || Program.Player[Rondas.EquipoBuenosList[2]].Name == PlayerSelect)
                                c++;

                        }
                    }

                    if (ItemComun == "Botas") // BOTAS
                    {
                        Program.Player[Program.Nombre[PlayerSelect]].PasosStatic = Program.Player[Program.Nombre[PlayerSelect]].PasosStatic + 1;
                        Program.Player[Program.Nombre[PlayerSelect]].Pasos = Program.Player[Program.Nombre[PlayerSelect]].Pasos + 1;

                    }
                    if (ItemComun == "Antorcha") // ANTORCHA
                    {
                        Program.Player[Program.Nombre[PlayerSelect]].VisionStatic = Program.Player[Program.Nombre[PlayerSelect]].VisionStatic + 1;
                        Program.Player[Program.Nombre[PlayerSelect]].Vision = Program.Player[Program.Nombre[PlayerSelect]].Vision + 1;

                    }


                }
            }


            /////////////////////////////////////////////////////////////////////////////////////////////////////////////


            else // MALOS
            {

                if (Program.EquipoMaloCoins > 0) // Revisar q tenga monedas
                {
                    Console.Clear();
                    Interfaz.Imprimir(Player); // Seleccione item

                    var ItemComun = SelectItem();
                    var PlayerSelect = "";
                    int c = 0;

                    while (c == 0) // Seleccione player para equipar
                    {
                        Console.Clear();
                        Interfaz.Imprimir(Player);

                        PlayerSelect = Selects.SelectPlayerMalos();

                        for (int i = 0; i < Rondas.EquipoMalosList.Count; i++)
                        {
                            if (Program.Player[Rondas.EquipoMalosList[0]].Name == PlayerSelect || Program.Player[Rondas.EquipoMalosList[1]].Name == PlayerSelect || Program.Player[Rondas.EquipoMalosList[2]].Name == PlayerSelect)
                                c++;

                        }
                    }

                    if (ItemComun == "Botas") // BOTAS
                    {
                        Program.Player[Program.Nombre[PlayerSelect]].PasosStatic = Program.Player[Program.Nombre[PlayerSelect]].PasosStatic + 1;
                        Program.Player[Program.Nombre[PlayerSelect]].Pasos = Program.Player[Program.Nombre[PlayerSelect]].Pasos + 1;

                    }
                    if (ItemComun == "Antorcha") // ANTORCHA
                    {
                        Program.Player[Program.Nombre[PlayerSelect]].VisionStatic = Program.Player[Program.Nombre[PlayerSelect]].VisionStatic + 1;
                        Program.Player[Program.Nombre[PlayerSelect]].Vision = Program.Player[Program.Nombre[PlayerSelect]].Vision + 1;

                    }


                }

            }
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////
        if (x == 7) // EPICO
        {

            if (Program.Player[Player].Equipo) // BUENOS
            {

                if (Program.EquipoBuenoCoins > 2) // Revisar q tenga monedas
                {
                    Console.Clear();
                    Interfaz.Imprimir(Player); // Seleccione item

                    var ItemEpico = SelectItem();
                    var PlayerSelect = "";
                    int c = 0;

                    while (c == 0) // Seleccione player para equipar
                    {
                        Console.Clear();
                        Interfaz.Imprimir(Player);

                        PlayerSelect = Selects.SelectPlayerBuenos();

                        for (int i = 0; i < Rondas.EquipoBuenosList.Count; i++)
                        {
                            if (Program.Player[Rondas.EquipoBuenosList[0]].Name == PlayerSelect || Program.Player[Rondas.EquipoBuenosList[1]].Name == PlayerSelect || Program.Player[Rondas.EquipoBuenosList[2]].Name == PlayerSelect)
                                c++;

                        }
                    }

                    if (ItemEpico == "Botas") // BOTAS
                    {
                        Program.Player[Program.Nombre[PlayerSelect]].PasosStatic = Program.Player[Program.Nombre[PlayerSelect]].PasosStatic + 2;
                        Program.Player[Program.Nombre[PlayerSelect]].Pasos = Program.Player[Program.Nombre[PlayerSelect]].Pasos + 2;

                    }
                    if (ItemEpico == "Antorcha") // ANTORCHA
                    {
                        Program.Player[Program.Nombre[PlayerSelect]].VisionStatic = Program.Player[Program.Nombre[PlayerSelect]].VisionStatic + 2;
                        Program.Player[Program.Nombre[PlayerSelect]].Vision = Program.Player[Program.Nombre[PlayerSelect]].Vision + 2;

                    }


                }
            }


            /////////////////////////////////////////////////////////////////////////////////////////////////////////////


            else // MALOS
            {

                if (Program.EquipoMaloCoins > 2) // Revisar q tenga monedas
                {
                    Console.Clear();
                    Interfaz.Imprimir(Player); // Seleccione item

                    var ItemEpico = SelectItem();
                    var PlayerSelect = "";
                    int c = 0;

                    while (c == 0) // Seleccione player para equipar
                    {
                        Console.Clear();
                        Interfaz.Imprimir(Player);

                        PlayerSelect = Selects.SelectPlayerMalos();

                        for (int i = 0; i < Rondas.EquipoMalosList.Count; i++)
                        {
                            if (Program.Player[Rondas.EquipoMalosList[0]].Name == PlayerSelect || Program.Player[Rondas.EquipoMalosList[1]].Name == PlayerSelect || Program.Player[Rondas.EquipoMalosList[2]].Name == PlayerSelect)
                                c++;

                        }
                    }

                    if (ItemEpico == "Botas") // BOTAS
                    {
                        Program.Player[Program.Nombre[PlayerSelect]].PasosStatic = Program.Player[Program.Nombre[PlayerSelect]].PasosStatic + 2;
                        Program.Player[Program.Nombre[PlayerSelect]].Pasos = Program.Player[Program.Nombre[PlayerSelect]].Pasos + 2;

                    }
                    if (ItemEpico == "Antorcha") // ANTORCHA
                    {
                        Program.Player[Program.Nombre[PlayerSelect]].VisionStatic = Program.Player[Program.Nombre[PlayerSelect]].VisionStatic + 2;
                        Program.Player[Program.Nombre[PlayerSelect]].Vision = Program.Player[Program.Nombre[PlayerSelect]].Vision + 2;

                    }


                }

            }
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////
        if (x == 8) // LEGENDARIO
        {

            if (Program.Player[Player].Equipo) // BUENOS
            {

                if (Program.EquipoBuenoCoins > 4) // Revisar q tenga monedas
                {
                    Console.Clear();
                    Interfaz.Imprimir(Player); // Seleccione item

                    var ItemLegendario = SelectItem();
                    var PlayerSelect = "";
                    int c = 0;

                    while (c == 0) // Seleccione player para equipar
                    {
                        Console.Clear();
                        Interfaz.Imprimir(Player);

                        PlayerSelect = Selects.SelectPlayerBuenos();

                        for (int i = 0; i < Rondas.EquipoBuenosList.Count; i++)
                        {
                            if (Program.Player[Rondas.EquipoBuenosList[0]].Name == PlayerSelect || Program.Player[Rondas.EquipoBuenosList[1]].Name == PlayerSelect || Program.Player[Rondas.EquipoBuenosList[2]].Name == PlayerSelect)
                                c++;

                        }
                    }

                    if (ItemLegendario == "Botas") // BOTAS
                    {
                        Program.Player[Program.Nombre[PlayerSelect]].PasosStatic = Program.Player[Program.Nombre[PlayerSelect]].PasosStatic + 3;
                        Program.Player[Program.Nombre[PlayerSelect]].Pasos = Program.Player[Program.Nombre[PlayerSelect]].Pasos + 3;

                    }
                    if (ItemLegendario == "Antorcha") // ANTORCHA
                    {
                        Program.Player[Program.Nombre[PlayerSelect]].VisionStatic = Program.Player[Program.Nombre[PlayerSelect]].VisionStatic + 3;
                        Program.Player[Program.Nombre[PlayerSelect]].Vision = Program.Player[Program.Nombre[PlayerSelect]].Vision + 3;

                    }


                }
            }


            /////////////////////////////////////////////////////////////////////////////////////////////////////////////


            else // MALOS
            {

                if (Program.EquipoMaloCoins > 4) // Revisar q tenga monedas
                {
                    Console.Clear();
                    Interfaz.Imprimir(Player); // Seleccione item

                    var ItemLegendario = SelectItem();
                    var PlayerSelect = "";
                    int c = 0;

                    while (c == 0) // Seleccione player para equipar
                    {
                        Console.Clear();
                        Interfaz.Imprimir(Player);

                        PlayerSelect = Selects.SelectPlayerMalos();

                       for (int i = 0; i < Rondas.EquipoMalosList.Count; i++)
                        {
                            if (Program.Player[Rondas.EquipoMalosList[0]].Name == PlayerSelect || Program.Player[Rondas.EquipoMalosList[1]].Name == PlayerSelect || Program.Player[Rondas.EquipoMalosList[2]].Name == PlayerSelect)
                                c++;

                        }
                    }

                    if (ItemLegendario == "Botas") // BOTAS
                    {
                        Program.Player[Program.Nombre[PlayerSelect]].PasosStatic = Program.Player[Program.Nombre[PlayerSelect]].PasosStatic + 3;
                        Program.Player[Program.Nombre[PlayerSelect]].Pasos = Program.Player[Program.Nombre[PlayerSelect]].PasosStatic;

                    }
                    if (ItemLegendario == "Antorcha") // ANTORCHA
                    {
                        Program.Player[Program.Nombre[PlayerSelect]].VisionStatic = Program.Player[Program.Nombre[PlayerSelect]].VisionStatic + 3;
                        Program.Player[Program.Nombre[PlayerSelect]].Vision = Program.Player[Program.Nombre[PlayerSelect]].VisionStatic;

                    }


                }

            }
        }
    }
}
