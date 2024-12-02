
public class Loby
{

    public static int loby()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("//////////////////////");
            Console.WriteLine("Jugar: 1");
            Console.WriteLine("Guia:  2");
            Console.WriteLine("Salir: 3");
            Console.WriteLine("//////////////////////");
            var keyInfo = Console.ReadKey();

            if (keyInfo.KeyChar == '1' || keyInfo.KeyChar == '1')
            {

                if (keyInfo.KeyChar == '1')
                {
                    Picks.SelectEquipo();
                    break;
                }
                //if(keyInfo.KeyChar == 2)

                /* if (keyInfo.KeyChar == 3)
                    Environment.Exit(0); */

            }

            return 0;

        }

    return 1;

    }

}
