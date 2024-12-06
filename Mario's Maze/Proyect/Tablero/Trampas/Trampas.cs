public class Trampas
{


    public static List<int[]> Muro = new List<int[]>();

    public static void PlacaQuitar(int p)
    {


        if (Muro.Count > 0)
        {
            for (int player = 0; player < Muro.Count; player++)
            {
                Tablero.laberinto[Muro[player][0], Muro[player][1]] = 1;
            }
            Muro.Clear();
        }
    }

    public static void PlacaGenerar(int p, int player, int y)
    {

        Muro.Add(new int[] { player, y });
        Tablero.laberinto[player, y] = 35;
    }

    public static void Trampa(int t, int player, int tx, int ty, int px, int py, char p)
    {

        if (!Program.Player[player].Inmune)
        {

            if (t == 31)
            { //hueco

                List<int> Respwn = new List<int>(Picks.Fichas.ToArray());
                int c = 0;

                while (Respwn.Count > 0)
                {

                    if (c > Respwn.Count) break;
                    if (Respwn[c] == player)
                    {
                        if (c == 0)
                        {

                            if (Tablero.laberinto[1, 1] == 1)
                            {
                                Imprime.Print(player, 31, 31);
                                Console.ReadKey();

                                Tablero.laberinto[1, 1] = Respwn[c];
                                Tablero.laberinto[px, py] = 1;
                                Tablero.laberinto[tx, ty] = 1;
                                Program.Player[player].Inmovil = true;
                                break;

                            }
                            else
                            {

                                Tablero.laberinto[px, py] = 1;
                                Tablero.laberinto[tx, ty] = Respwn[c];
                                break;

                            }

                        }


                        if (c == 1)
                        {

                            if (Tablero.laberinto[1, 15] == 1)
                            {
                                Imprime.Print(player, 31, 31);
                                Console.ReadKey();

                                Tablero.laberinto[1, 15] = Respwn[c];
                                Tablero.laberinto[px, py] = 1;
                                Tablero.laberinto[tx, ty] = 1;
                                Program.Player[player].Inmovil = true;
                                break;

                            }
                            else
                            {

                                Tablero.laberinto[px, py] = 1;
                                Tablero.laberinto[tx, ty] = Respwn[c];
                                break;

                            }

                        }


                        if (c == 2)
                        {

                            if (Tablero.laberinto[1, 29] == 1)
                            {
                                Imprime.Print(player, 31, 31);
                                Console.ReadKey();

                                Tablero.laberinto[1, 29] = Respwn[c];
                                Tablero.laberinto[px, py] = 1;
                                Tablero.laberinto[tx, ty] = 1;
                                Program.Player[player].Inmovil = true;
                                break;

                            }
                            else
                            {

                                Tablero.laberinto[px, py] = 1;
                                Tablero.laberinto[tx, ty] = Respwn[c];
                                break;

                            }

                        }


                        if (c == 3)
                        {

                            if (Tablero.laberinto[29, 1] == 1)
                            {
                                Imprime.Print(player, 31, 31);
                                Console.ReadKey();

                                Tablero.laberinto[29, 1] = Respwn[c];
                                Tablero.laberinto[px, py] = 1;
                                Tablero.laberinto[tx, ty] = 1;
                                Program.Player[player].Inmovil = true;
                                break;

                            }
                            else
                            {

                                Tablero.laberinto[px, py] = 1;
                                Tablero.laberinto[tx, ty] = Respwn[c];
                                break;

                            }

                        }


                        if (c == 4)
                        {

                            if (Tablero.laberinto[29, 15] == 1)
                            {
                                Imprime.Print(player, 31, 31);
                                Console.ReadKey();

                                Tablero.laberinto[29, 15] = Respwn[c];
                                Tablero.laberinto[px, py] = 1;
                                Tablero.laberinto[tx, ty] = 1;
                                Program.Player[player].Inmovil = true;
                                break;

                            }
                            else
                            {

                                Tablero.laberinto[px, py] = 1;
                                Tablero.laberinto[tx, ty] = Respwn[c];
                                break;

                            }

                        }


                        if (c == 5)
                        {

                            if (Tablero.laberinto[29, 29] == 1)
                            {
                                Imprime.Print(player, 31, 31);
                                Console.ReadKey();

                                Tablero.laberinto[29, 29] = Respwn[c];
                                Tablero.laberinto[px, py] = 1;
                                Tablero.laberinto[tx, ty] = 1;
                                Program.Player[player].Inmovil = true;
                                break;

                            }
                            else
                            {

                                Tablero.laberinto[px, py] = 1;
                                Tablero.laberinto[tx, ty] = Respwn[c];
                                break;

                            }

                        }

                    }
                    c++;
                }
            }

            if (t == 32)
            { //bomba

                if (p == 'a')
                {

                    if (py + 2 < 30 && Tablero.laberinto[px, py + 2] == 1)
                    {
                        Imprime.Print(player, 32, 32);
                        Console.ReadKey();

                        Tablero.laberinto[px, py] = 1;
                        Tablero.laberinto[tx, ty] = 1;
                        Tablero.laberinto[px, py + 2] = player;
                    }
                    else
                    {
                        if (Tablero.laberinto[px, py + 1] == 1)
                        {
                            Imprime.Print(player, 32, 32);
                            Console.ReadKey();

                            Tablero.laberinto[px, py] = 1;
                            Tablero.laberinto[tx, ty] = 1;
                            Tablero.laberinto[px, py + 1] = player;
                        }
                        else
                        {
                            Tablero.laberinto[px, py] = 1;
                            Tablero.laberinto[tx, ty] = player;
                        }
                    }
                }



                if (p == 'd')
                {

                    if (py - 2 > 0 && Tablero.laberinto[px, py - 2] == 1)
                    {
                        Imprime.Print(player, 32, 32);
                        Console.ReadKey();

                        Tablero.laberinto[px, py] = 1;
                        Tablero.laberinto[tx, ty] = 1;
                        Tablero.laberinto[px, py - 2] = player;
                    }
                    else
                    {
                        if (Tablero.laberinto[px, py - 1] == 1)
                        {
                            Imprime.Print(player, 32, 32);
                            Console.ReadKey();

                            Tablero.laberinto[px, py] = 1;
                            Tablero.laberinto[tx, ty] = 1;
                            Tablero.laberinto[px, py - 1] = player;

                        }
                        else
                        {
                            Tablero.laberinto[px, py] = 1;
                            Tablero.laberinto[tx, ty] = player;
                        }
                    }
                }


                if (p == 'w')
                {

                    if (px + 2 < 30 && Tablero.laberinto[px + 2, py] == 1)
                    {
                        Imprime.Print(player, 32, 32);
                        Console.ReadKey();

                        Tablero.laberinto[px, py] = 1;
                        Tablero.laberinto[tx, ty] = 1;
                        Tablero.laberinto[px + 2, py] = player;
                    }
                    else
                    {
                        if (Tablero.laberinto[px + 1, py] == 1)
                        {
                            Imprime.Print(player, 32, 32);
                            Console.ReadKey();

                            Tablero.laberinto[px, py] = 1;
                            Tablero.laberinto[tx, ty] = 1;
                            Tablero.laberinto[px + 1, py] = player;
                        }
                        else
                        {
                            Tablero.laberinto[px, py] = 1;
                            Tablero.laberinto[tx, ty] = player;
                        }
                    }
                }


                if (p == 's')
                {

                    if (px - 2 > 0 && Tablero.laberinto[px - 2, py] == 1)
                    {

                        Imprime.Print(player, 32, 32);
                        Console.ReadKey();

                        Tablero.laberinto[px, py] = 1;
                        Tablero.laberinto[tx, ty] = 1;
                        Tablero.laberinto[px - 2, py] = player;
                    }
                    else
                    {
                        if (Tablero.laberinto[px - 1, py] == 1)
                        {
                            Imprime.Print(player, 32, 32);
                            Console.ReadKey();

                            Tablero.laberinto[px, py] = 1;
                            Tablero.laberinto[tx, ty] = 1;
                            Tablero.laberinto[px - 1, py] = player;
                        }
                        else
                        {
                            Tablero.laberinto[px, py] = 1;
                            Tablero.laberinto[tx, ty] = player;
                        }

                    }
                }
            }

            if (t == 33)
            { //Placa

                Tablero.laberinto[px, py] = 1;
                Tablero.laberinto[tx, ty] = player;
                Program.Player[player].Inmovil = true;
                Tablero.UpdateNiebla(player, tx, ty);



                if (Tablero.laberinto[tx + 1, ty] == 1)
                    PlacaGenerar(p, tx + 1, ty);

                if (Tablero.laberinto[tx, ty + 1] == 1)
                    PlacaGenerar(p, tx, ty + 1);

                if (Tablero.laberinto[tx - 1, ty] == 1)
                    PlacaGenerar(p, tx - 1, ty);

                if (Tablero.laberinto[tx, ty - 1] == 1)
                    PlacaGenerar(p, tx, ty + -1);

                if (Tablero.laberinto[tx - 1, ty - 1] == 1)
                    PlacaGenerar(p, tx - 1, ty - 1);

                if (Tablero.laberinto[tx + 1, ty - 1] == 1)
                    PlacaGenerar(p, tx + 1, ty - 1);

                if (Tablero.laberinto[tx + 1, ty + 1] == 1)
                    PlacaGenerar(p, tx + 1, ty + 1);

                if (Tablero.laberinto[tx - 1, ty + 1] == 1)
                    PlacaGenerar(p, tx - 1, ty + 1);

                Imprime.Print(player, 33, 33);
                Console.ReadKey();

            }

            /* if(t==34){ //bala
                Console.WriteLine("Hola");
                if(tx-2 > 0 && tx+2 < columnas && ty-2 > 0 && ty+2 < filas){
                    Tablero.laberinto[px,py] = 1;
                    Tablero.laberinto[tx,ty] = 1;

                    if(rand.Next(1,3)==1){ // columna

                        if(rand.Next(1,3)==1){ // arriba

                            if(Tablero.laberinto[tx-2,ty] == 1)
                                Tablero.laberinto[tx-2,ty] = player;
                                else Tablero.laberinto[tx,ty] = player;
                        }
                            else{ // abajo

                                if(Tablero.laberinto[tx+2,ty] == 1)
                                Tablero.laberinto[tx+2,ty] = player;
                                else Tablero.laberinto[tx,ty] = player;
                            }

                    }
                    else{ // Fila

                        if(rand.Next(1,3)==1){ // izquierda

                            if(Tablero.laberinto[tx,ty-2] == 1)
                                Tablero.laberinto[tx,ty-2] = player;
                                else Tablero.laberinto[tx,ty] = player;
                        }
                            else{ // derecha

                                if(Tablero.laberinto[tx,ty+2] == 1)
                                Tablero.laberinto[tx,py+2] = player;
                                else Tablero.laberinto[tx,ty] = player;
                            }

                    }
                }
            }
    */
        }
        else
        {
            Tablero.laberinto[px, py] = 1;
            Tablero.laberinto[tx, ty] = player;

        }
    }
}
