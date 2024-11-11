using static Program;

public class Trampas{

    public static void Trampa(int t, int x,int tx, int ty, int px, int py, char p)
        {

        if(t==31){ //hueco

            Tablero.laberinto[px,py] = 1;
            Tablero.laberinto[tx,ty] = 1;  
            
            if(x==21) Tablero.laberinto[1,1]=21;
            if(x==22) Tablero.laberinto[16,1]=22;
            if(x==23) Tablero.laberinto[1,16]=23;
            if(x==24) Tablero.laberinto[16,29]=24;
            if(x==25) Tablero.laberinto[29,16]=25;
            if(x==26) Tablero.laberinto[1,29]=26;
            if(x==27) Tablero.laberinto[29,1]=27;
            if(x==28) Tablero.laberinto[29,29]=28;
        }

        if(t==32){ //bomba

            Tablero.laberinto[px,py] = 1;
            Tablero.laberinto[tx,ty] = 1;
            
            if (p == 'a'){

                Tablero.laberinto[px,py+1] = x;
                
                if(Tablero.laberinto[px,py+2] == 1){
                    
                    Tablero.laberinto[px,py+1] = 1;
                    Tablero.laberinto[px,py+2] = x;
                }

            }

            if (p == 'd'){

                Tablero.laberinto[px,py-1]= x;

                if(Tablero.laberinto[px,py-2] == 1){
                    
                    Tablero.laberinto[px,py-1] = 1;
                    Tablero.laberinto[px,py-2] = x;
                }

            }

            if (p == 'w'){

                Tablero.laberinto[px+1,py]= x;

                if(Tablero.laberinto[px+2,py] == 1){
                    
                    Tablero.laberinto[px+1,py] = 1;
                    Tablero.laberinto[px+2,py] = x;
                }

            }

            if (p == 's'){

                Tablero.laberinto[px-1,py]= x;

                if(Tablero.laberinto[px-2,py] == 1){
                    
                    Tablero.laberinto[px-1,py] = 1;
                    Tablero.laberinto[px-2,py] = x;
                }

            }
        
        }

        if (t==34){ //Placa

            Console.WriteLine("Hola");

            Tablero.laberinto[px,py] = 0;
            Tablero.laberinto[tx,ty] = x;

            if(Tablero.laberinto[tx+1,ty] == 1)
                Tablero.laberinto[tx+1,ty] = 0;

            if(Tablero.laberinto[tx,ty+1] == 1)
                Tablero.laberinto[tx,ty+1] = 0;

            if(Tablero.laberinto[tx-1,ty] == 1)
                Tablero.laberinto[tx-1,ty] = 0;

            if(Tablero.laberinto[tx,ty-1] == 1)
                Tablero.laberinto[tx,ty-1] = 0;
        }
        
        /* if(t==33){ //bala
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

}