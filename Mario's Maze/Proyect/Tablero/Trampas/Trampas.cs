public class Trampas
{
    

    public static List<int[]> Muro = new List<int[]>();

    public static void PlacaQuitar(int p)
    {
        

        if (Muro.Count > 0)
        {
            for (int x = 0; x < Muro.Count; x++)
            {
                
                Console.Clear();
                Interfaz.Imprimir(p);
                Thread.Sleep(1000);
                Tablero.laberinto[Muro[x][0], Muro[x][1]] = 1;
            }
            Muro.Clear();
        }
    }

    public static void PlacaGenerar(int p, int x, int y)
    {
        

        Console.Clear();
        Interfaz.Imprimir(p);
        Thread.Sleep(1000);
        Muro.Add(new int[] { x, y });
        Tablero.laberinto[x, y] = 35;
    }

    public static void Trampa(int t, int x, int tx, int ty, int px, int py, char p)
    {

        if (!Program.Player[x].Inmune)
        {

            if (t == 31)
            { //hueco

                List<int> Respwn = new List<int>(Picks.Fichas.ToArray());
                int c = 0;

                while (Respwn.Count > 0)
                {

                    if (c > Respwn.Count) break;
                    if (Respwn[c] == x)
                    {
                        if (c == 0)
                        {

                            if (Tablero.laberinto[1, 1] == 1)
                            {

                                Tablero.laberinto[1, 1] = Respwn[c];
                                Tablero.laberinto[px, py] = 1;
                                Tablero.laberinto[tx, ty] = 1;
                                Program.Player[x].Inmovil = true;
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

                                Tablero.laberinto[1, 15] = Respwn[c];
                                Tablero.laberinto[px, py] = 1;
                                Tablero.laberinto[tx, ty] = 1;
                                Program.Player[x].Inmovil = true;
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

                                Tablero.laberinto[1, 29] = Respwn[c];
                                Tablero.laberinto[px, py] = 1;
                                Tablero.laberinto[tx, ty] = 1;
                                Program.Player[x].Inmovil = true;
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

                                Tablero.laberinto[29, 1] = Respwn[c];
                                Tablero.laberinto[px, py] = 1;
                                Tablero.laberinto[tx, ty] = 1;
                                Program.Player[x].Inmovil = true;
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

                                Tablero.laberinto[29, 15] = Respwn[c];
                                Tablero.laberinto[px, py] = 1;
                                Tablero.laberinto[tx, ty] = 1;
                                Program.Player[x].Inmovil = true;
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

                                Tablero.laberinto[29, 29] = Respwn[c];
                                Tablero.laberinto[px, py] = 1;
                                Tablero.laberinto[tx, ty] = 1;
                                Program.Player[x].Inmovil = true;
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

                        Tablero.laberinto[px, py] = 1;
                        Tablero.laberinto[tx, ty] = 1;
                        Tablero.laberinto[px, py + 2] = x;
                    }
                    else
                    {
                        if (Tablero.laberinto[px, py + 1] == 1)
                        {

                            Tablero.laberinto[px, py] = 1;
                            Tablero.laberinto[tx, ty] = 1;
                            Tablero.laberinto[px, py + 1] = x;
                        }
                        else
                        {
                            Tablero.laberinto[px, py] = 1;
                            Tablero.laberinto[tx, ty] = x;
                        }
                    }
                }



                if (p == 'd')
                {

                    if (py - 2 > 0 && Tablero.laberinto[px, py - 2] == 1)
                    {

                        Tablero.laberinto[px, py] = 1;
                        Tablero.laberinto[tx, ty] = 1;
                        Tablero.laberinto[px, py - 2] = x;
                    }
                    else
                    {
                        if (Tablero.laberinto[px, py - 1] == 1)
                        {
                            Tablero.laberinto[px, py] = 1;
                            Tablero.laberinto[tx, ty] = 1;
                            Tablero.laberinto[px, py - 1] = x;

                        }
                        else
                        {
                            Tablero.laberinto[px, py] = 1;
                            Tablero.laberinto[tx, ty] = x;
                        }
                    }
                }


                if (p == 'w')
                {

                    if (px + 2 < 30 && Tablero.laberinto[px + 2, py] == 1)
                    {

                        Tablero.laberinto[px, py] = 1;
                        Tablero.laberinto[tx, ty] = 1;
                        Tablero.laberinto[px + 2, py] = x;
                    }
                    else
                    {
                        if (Tablero.laberinto[px + 1, py] == 1)
                        {
                            Tablero.laberinto[px, py] = 1;
                            Tablero.laberinto[tx, ty] = 1;
                            Tablero.laberinto[px + 1, py] = x;
                        }
                        else
                        {
                            Tablero.laberinto[px, py] = 1;
                            Tablero.laberinto[tx, ty] = x;
                        }
                    }
                }


                if (p == 's')
                {

                    if (px - 2 > 0 && Tablero.laberinto[px - 2, py] == 1)
                    {

                        Tablero.laberinto[px, py] = 1;
                        Tablero.laberinto[tx, ty] = 1;
                        Tablero.laberinto[px - 2, py] = x;
                    }
                    else
                    {
                        if (Tablero.laberinto[px - 1, py] == 1)
                        {
                            Tablero.laberinto[px, py] = 1;
                            Tablero.laberinto[tx, ty] = 1;
                            Tablero.laberinto[px - 1, py] = x;
                        }
                        else
                        {
                            Tablero.laberinto[px, py] = 1;
                            Tablero.laberinto[tx, ty] = x;
                        }

                    }
                }
            }

            if (t == 33)
            { //Placa

                Tablero.laberinto[px, py] = 1;
                Tablero.laberinto[tx, ty] = x;
                Program.Player[x].Inmovil = true;
                Tablero.UpdateNiebla(x, tx, ty);

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



            }

            /* if(t==34){ //bala
                Console.WriteLine("Hola");
                if(tx-2 > 0 && tx+2 < columnas && ty-2 > 0 && ty+2 < filas){
                    Tablero.laberinto[px,py] = 1;
                    Tablero.laberinto[tx,ty] = 1;

                    if(rand.Next(1,3)==1){ // columna

                        if(rand.Next(1,3)==1){ // arriba

                            if(Tablero.laberinto[tx-2,ty] == 1)
                                Tablero.laberinto[tx-2,ty] = x;
                                else Tablero.laberinto[tx,ty] = x;
                        }
                            else{ // abajo

                                if(Tablero.laberinto[tx+2,ty] == 1)
                                Tablero.laberinto[tx+2,ty] = x;
                                else Tablero.laberinto[tx,ty] = x;
                            }

                    }
                    else{ // Fila

                        if(rand.Next(1,3)==1){ // izquierda

                            if(Tablero.laberinto[tx,ty-2] == 1)
                                Tablero.laberinto[tx,ty-2] = x;
                                else Tablero.laberinto[tx,ty] = x;
                        }
                            else{ // derecha

                                if(Tablero.laberinto[tx,ty+2] == 1)
                                Tablero.laberinto[tx,py+2] = x;
                                else Tablero.laberinto[tx,ty] = x;
                            }

                    }
                }
            }
    */
        }
        else
        {
            Tablero.laberinto[px, py] = 1;
            Tablero.laberinto[tx, ty] = x;

        }
    }
}
