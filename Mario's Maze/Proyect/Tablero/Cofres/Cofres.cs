using System.Security.Cryptography.X509Certificates;
using Spectre.Console;
public class Cofres
{
    static int PlayerSelect;

    public static void Cofre(int Player, int x)
    {


        ///////////////////////////////////////////////////////////////////////////////////////////////////////
        if (x == 6) // COMUN
        {

            if (Program.Player[Player].Equipo) // BUENOS
            {

                if (Program.EquipoBuenoCoins > 0) // Revisar q tenga monedas
                {


                    int Comun = Selects.SelectCofreComun(Player);

                    int c = 0;


                    while (c == 0) // Seleccione player para equipar
                    {

                        PlayerSelect = Selects.SelectPlayerBuenos(Player);

                        for (int i = 0; i < Rondas.EquipoBuenosList.Count; i++)
                            if (Rondas.EquipoBuenosList[i] == PlayerSelect)
                                c++;
                    }

                    if (Comun == 1) // BOTAS
                    {
                        Program.Player[PlayerSelect].PasosStatic = Program.Player[PlayerSelect].PasosStatic + 1;
                        Program.Player[PlayerSelect].Pasos = Program.Player[PlayerSelect].Pasos + 1;
                        Imprime.Print(Player, 62, 71); // Player / Img / Panel
                        Console.ReadKey();

                    }
                    if (Comun == 2) // ANTORCHA
                    {
                        Program.Player[PlayerSelect].VisionStatic = Program.Player[PlayerSelect].VisionStatic + 1;
                        Program.Player[PlayerSelect].Vision = Program.Player[PlayerSelect].Vision + 1;
                        Imprime.Print(Player, 61, 81); // Player / Img / Panel
                        Console.ReadKey();

                    }

                }
            }
            else
            {

                if (Program.EquipoMaloCoins > 0) // Revisar q tenga monedas
                {


                    int Comun = Selects.SelectCofreComun(Player);

                    int c = 0;


                    while (c == 0) // Seleccione player para equipar
                    {

                        PlayerSelect = Selects.SelectPlayerMalos(Player);

                        for (int i = 0; i < Rondas.EquipoMalosList.Count; i++)
                            if (Rondas.EquipoMalosList[i] == PlayerSelect)
                                c++;
                    }

                    if (Comun == 1) // BOTAS
                    {
                        Program.Player[PlayerSelect].PasosStatic = Program.Player[PlayerSelect].PasosStatic + 1;
                        Program.Player[PlayerSelect].Pasos = Program.Player[PlayerSelect].Pasos + 1;
                        Imprime.Print(Player, 62, 71); // Player / Img / Panel
                        Console.ReadKey();

                    }
                    if (Comun == 2) // ANTORCHA
                    {
                        Program.Player[PlayerSelect].VisionStatic = Program.Player[PlayerSelect].VisionStatic + 1;
                        Program.Player[PlayerSelect].Vision = Program.Player[PlayerSelect].Vision + 1;
                        Imprime.Print(Player, 61, 81); // Player / Img / Panel
                        Console.ReadKey();

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


                    int Epico = Selects.SelectCofreEpico(Player);

                    int c = 0;


                    while (c == 0) // Seleccione player para equipar
                    {

                        PlayerSelect = Selects.SelectPlayerBuenos(Player);

                        for (int i = 0; i < Rondas.EquipoBuenosList.Count; i++)
                            if (Rondas.EquipoBuenosList[i] == PlayerSelect)
                                c++;
                    }

                    if (Epico == 1) // BOTAS
                    {
                        Program.Player[PlayerSelect].PasosStatic = Program.Player[PlayerSelect].PasosStatic + 2;
                        Program.Player[PlayerSelect].Pasos = Program.Player[PlayerSelect].Pasos + 2;
                        Imprime.Print(Player, 72, 72); // Player / Img / Panel
                        Console.ReadKey();

                    }
                    if (Epico == 2) // ANTORCHA
                    {
                        Program.Player[PlayerSelect].VisionStatic = Program.Player[PlayerSelect].VisionStatic + 2;
                        Program.Player[PlayerSelect].Vision = Program.Player[PlayerSelect].Vision + 2;
                        Imprime.Print(Player, 71, 82); // Player / Img / Panel
                        Console.ReadKey();

                    }

                }
            }
            else
            {

                if (Program.EquipoMaloCoins > 2) // Revisar q tenga monedas
                {


                    int Epico = Selects.SelectCofreEpico(Player);

                    int c = 0;


                    while (c == 0) // Seleccione player para equipar
                    {

                        PlayerSelect = Selects.SelectPlayerMalos(Player);

                        for (int i = 0; i < Rondas.EquipoMalosList.Count; i++)
                            if (Rondas.EquipoMalosList[i] == PlayerSelect)
                                c++;
                    }

                    if (Epico == 1) // BOTAS
                    {
                        Program.Player[PlayerSelect].PasosStatic = Program.Player[PlayerSelect].PasosStatic + 2;
                        Program.Player[PlayerSelect].Pasos = Program.Player[PlayerSelect].Pasos + 2;
                        Imprime.Print(Player, 72, 72); // Player / Img / Panel
                        Console.ReadKey();

                    }
                    if (Epico == 2) // ANTORCHA
                    {
                        Program.Player[PlayerSelect].VisionStatic = Program.Player[PlayerSelect].VisionStatic + 2;
                        Program.Player[PlayerSelect].Vision = Program.Player[PlayerSelect].Vision + 2;
                        Imprime.Print(Player, 71, 82); // Player / Img / Panel
                        Console.ReadKey();

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


                    int Legendario = Selects.SelectCofreLegendario(Player);

                    int c = 0;


                    while (c == 0) // Seleccione player para equipar
                    {

                        PlayerSelect = Selects.SelectPlayerBuenos(Player);

                        for (int i = 0; i < Rondas.EquipoBuenosList.Count; i++)
                            if (Rondas.EquipoBuenosList[i] == PlayerSelect)
                                c++;
                    }

                    if (Legendario == 1) // BOTAS
                    {
                        Program.Player[PlayerSelect].PasosStatic = Program.Player[PlayerSelect].PasosStatic + 3;
                        Program.Player[PlayerSelect].Pasos = Program.Player[PlayerSelect].Pasos + 3;
                        Imprime.Print(Player, 82, 73); // Player / Img / Panel
                        Console.ReadKey();

                    }
                    if (Legendario == 2) // ANTORCHA
                    {
                        Program.Player[PlayerSelect].VisionStatic = Program.Player[PlayerSelect].VisionStatic + 3;
                        Program.Player[PlayerSelect].Vision = Program.Player[PlayerSelect].Vision + 3;
                        Imprime.Print(Player, 81, 83); // Player / Img / Panel
                        Console.ReadKey();

                    }

                }
            }
            else
            {

                if (Program.EquipoMaloCoins > 4) // Revisar q tenga monedas
                {


                    int Legendario = Selects.SelectCofreLegendario(Player);

                    int c = 0;


                    while (c == 0) // Seleccione player para equipar
                    {

                        PlayerSelect = Selects.SelectPlayerMalos(Player);

                        for (int i = 0; i < Rondas.EquipoMalosList.Count; i++)
                            if (Rondas.EquipoMalosList[i] == PlayerSelect)
                                c++;
                    }

                    if (Legendario == 1) // BOTAS
                    {
                        Program.Player[PlayerSelect].PasosStatic = Program.Player[PlayerSelect].PasosStatic + 3;
                        Program.Player[PlayerSelect].Pasos = Program.Player[PlayerSelect].Pasos + 3;
                        Imprime.Print(Player, 82, 73); // Player / Img / Panel
                        Console.ReadKey();

                    }
                    if (Legendario == 2) // ANTORCHA
                    {
                        Program.Player[PlayerSelect].VisionStatic = Program.Player[PlayerSelect].VisionStatic + 3;
                        Program.Player[PlayerSelect].Vision = Program.Player[PlayerSelect].Vision + 3;
                        Imprime.Print(Player, 81, 83); // Player / Img / Panel
                        Console.ReadKey();

                    }


                }
            }
        }
    }
}
