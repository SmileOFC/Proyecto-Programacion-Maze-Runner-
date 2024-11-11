
public class Jugar
    {       
        public static int Mover(int x, char y)
        {
            int[] xy = new int[2];

            for (int i = 1; i < Tablero.filas; i++)
            {
                for (int j = 1; j < Tablero.columnas; j++)
                {
                    
                    if(Tablero.laberinto[i,j] == x)
                    {
                      
                       xy[0]=i;
                       xy[1]=j;   

                    }
                }
            }
                
            if (y == 'w')
            {
                if(Arriba(xy[0],xy[1]) == 1)
                {
                    Tablero.laberinto[xy[0]-1,xy[1]] = x;
                    Tablero.laberinto[xy[0],xy[1]] = 1;
                    return Velocidades.Velocidad(x);
                }

                if(Arriba(xy[0],xy[1]) == 2)
                 return 1;
                if(Arriba(xy[0],xy[1]) == 3){
                Trampas.Trampa(Tablero.laberinto[xy[0]-1,xy[1]],x,xy[0]-1,xy[1],xy[0],xy[1],y);
                return Velocidades.Velocidad(x); }

                if(Arriba(xy[0],xy[1]) == 4){ 
                Bufss.Buff(Tablero.laberinto[xy[0]-1,xy[1]]);                  
                return Velocidades.Velocidad(x);}
                
                if(Arriba(xy[0],xy[1]) == 5)
                  return 2;

                if(Arriba(xy[0],xy[1]) == 0)
                {
                    bool b =  false;
                    if(Abajo(xy[0],xy[1])==1 || Abajo(xy[0],xy[1])== 3 || Abajo(xy[0],xy[1])==4 || Abajo(xy[0],xy[1])==5 )
                        b = true;
                    if(Izquierda(xy[0],xy[1])==1 || Izquierda(xy[0],xy[1])==3 || Izquierda(xy[0],xy[1])==4 || Izquierda(xy[0],xy[1])==5)
                        b = true;
                    if(Derecha(xy[0],xy[1])==1 || Derecha(xy[0],xy[1])==3 || Derecha(xy[0],xy[1])==4 || Derecha(xy[0],xy[1])==5)
                        b = true;
                    if(b) return 1; else return 0;
                }
            }
            if (y == 's')
            {
                if(Abajo(xy[0],xy[1]) == 1)
                {
                    Tablero.laberinto[xy[0]+1,xy[1]] = x;
                    Tablero.laberinto[xy[0],xy[1]] = 1;
                    return Velocidades.Velocidad(x);
                }

                if(Abajo(xy[0],xy[1]) == 2)
                    return 1;
                if(Abajo(xy[0],xy[1]) == 3){
                    Trampas.Trampa(Tablero.laberinto[xy[0]+1,xy[1]],x,xy[0]+1,xy[1],xy[0],xy[1],y);
                    return Velocidades.Velocidad(x); }

                if(Abajo(xy[0],xy[1]) == 4){ 
                    Bufss.Buff(Tablero.laberinto[xy[0]+1,xy[1]]); 
                    return Velocidades.Velocidad(x);}                 

                if(Abajo(xy[0],xy[1]) == 5)
                    return 2;

                if(Abajo(xy[0],xy[1]) == 0)
                {
                    bool b =  false;
                    if(Arriba(xy[0],xy[1])==1 || Arriba(xy[0],xy[1])== 3 || Arriba(xy[0],xy[1])==4 || Arriba(xy[0],xy[1])==5 )
                        b = true;
                    if(Izquierda(xy[0],xy[1])==1 || Izquierda(xy[0],xy[1])==3 || Izquierda(xy[0],xy[1])==4 || Izquierda(xy[0],xy[1])==5)
                        b = true;
                    if(Derecha(xy[0],xy[1])==1 || Derecha(xy[0],xy[1])==3 || Derecha(xy[0],xy[1])==4 || Derecha(xy[0],xy[1])==5)
                        b = true;
                    if(b) return 1; else return 0;
                }
            }
            if (y == 'a')
            {
                if(Izquierda(xy[0],xy[1]) == 1)
                {
                    Tablero.laberinto[xy[0],xy[1]-1] = x;
                    Tablero.laberinto[xy[0],xy[1]] = 1;
                   return Velocidades.Velocidad(x);
                }

                if(Izquierda(xy[0],xy[1]) == 2)
                   return 1;
                if(Izquierda(xy[0],xy[1]) == 3){
                   Trampas.Trampa(Tablero.laberinto[xy[0],xy[1]-1],x,xy[0],xy[1]-1,xy[0],xy[1],y);
                   return Velocidades.Velocidad(x); }

                if(Izquierda(xy[0],xy[1]) == 4){ 
                   Bufss.Buff(Tablero.laberinto[xy[0],xy[1]-1]);
                   return Velocidades.Velocidad(x); }                  

                if(Izquierda(xy[0],xy[1]) == 5)
                   return 2;

                if(Izquierda(xy[0],xy[1]) == 0)
                {
                    bool b =  false;
                    if(Abajo(xy[0],xy[1])==1 || Abajo(xy[0],xy[1])== 3 || Abajo(xy[0],xy[1])==4 || Abajo(xy[0],xy[1])==5 )
                        b = true;
                    if(Arriba(xy[0],xy[1])==1 || Arriba(xy[0],xy[1])==3 || Arriba(xy[0],xy[1])==4 || Arriba(xy[0],xy[1])==5)
                        b = true;
                    if(Derecha(xy[0],xy[1])==1 || Derecha(xy[0],xy[1])==3 || Derecha(xy[0],xy[1])==4 || Derecha(xy[0],xy[1])==5)
                        b = true;
                    if(b) return 1; else return 0;
                }
            }
            if (y == 'd')
            {
                if(Derecha(xy[0],xy[1]) == 1)
                {
                    Tablero.laberinto[xy[0],xy[1]+1] = x;
                    Tablero.laberinto[xy[0],xy[1]] = 1;
                    return Velocidades.Velocidad(x);
                }

                if(Derecha(xy[0],xy[1]) == 2)
                   return 1;
                if(Derecha(xy[0],xy[1]) == 3){
                   Trampas.Trampa(Tablero.laberinto[xy[0],xy[1]+1],x,xy[0],xy[1]+1,xy[0],xy[1],y);
                   return Velocidades.Velocidad(x);}

                if(Derecha(xy[0],xy[1]) == 4){ 
                   Bufss.Buff(Tablero.laberinto[xy[0]+1,xy[1]]);  
                   return Velocidades.Velocidad(x);}                

                if(Derecha(xy[0],xy[1]) == 5)
                   return 2;

                if(Derecha(xy[0],xy[1]) == 0)
                {
                    bool b =  false;
                    if(Abajo(xy[0],xy[1])==1 || Abajo(xy[0],xy[1])== 3 || Abajo(xy[0],xy[1])==4 || Abajo(xy[0],xy[1])==5 )
                        b = true;
                    if(Arriba(xy[0],xy[1])==1 || Arriba(xy[0],xy[1])==3 || Arriba(xy[0],xy[1])==4 || Arriba(xy[0],xy[1])==5)
                        b = true;
                    if(Izquierda(xy[0],xy[1])==1 || Izquierda(xy[0],xy[1])==3 || Izquierda(xy[0],xy[1])==4 || Izquierda(xy[0],xy[1])==5)
                        b = true;
                    if(b) return 1; else return 0;
                }
            }   
        return 1;
        }
            static int Abajo(int F, int C)
            {
                        // win
                    if(Tablero.laberinto[F+1,C] == 5)
                    {
                        return 5;
                    }    
                   
                        // camino
                    if(Tablero.laberinto[F+1,C] == 1)
                    {
                        return 1;
                    }
                    
                        // trampa
                    if(Tablero.laberinto[F+1,C] == 31 || Tablero.laberinto[F+1,C] == 32 || Tablero.laberinto[F+1,C] == 33 || Tablero.laberinto[F+1,C] == 34 )
                    {
                        return 3;
                    }
                    
                        // buff
                    if(Tablero.laberinto[F+1,C] == 41 || Tablero.laberinto[F+1,C] == 42 || Tablero.laberinto[F+1,C] == 43 )
                    {
                        return 4;
                    }     
                    
                    // colision
                    
                    if(Tablero.laberinto[F+1,C] == 0)
                    {
                        return 2; // direccion equivocada     
                    } 
                    
                    return 0;  // ficha
            }
            static int Arriba(int F, int C)
            {
                        // win
                    if(Tablero.laberinto[F-1,C] == 5)
                    {
                        return 5;
                    }    
                   
                        // camino
                    if(Tablero.laberinto[F-1,C] == 1)
                    {
                        return 1;
                    }
                    
                        // trampa
                    if(Tablero.laberinto[F-1,C] == 31 || Tablero.laberinto[F-1,C] == 32 || Tablero.laberinto[F-1,C] == 33 || Tablero.laberinto[F+1,C] == 34)
                    {
                        return 3;
                    }
                    
                        // buff
                    if(Tablero.laberinto[F-1,C] == 41 || Tablero.laberinto[F-1,C] == 42 || Tablero.laberinto[F-1,C] == 43 )
                    {
                        return 4;
                    }     
                    
                    // colision
                    
                    if(Tablero.laberinto[F-1,C] == 0)
                    {
                        return 2; // direccion equivocada     
                    } 
                    
                    return 0;  // ficha
            }
            static int Izquierda(int F, int C)
            {
                        // win
                    if(Tablero.laberinto[F,C-1] == 5)
                    {
                        return 5;
                    }    
                   
                        // camino
                    if(Tablero.laberinto[F,C-1] == 1)
                    {
                        return 1;
                    }
                    
                        // trampa
                    if(Tablero.laberinto[F,C-1] == 31 || Tablero.laberinto[F,C-1] == 32 || Tablero.laberinto[F,C=1] == 33 || Tablero.laberinto[F+1,C] == 34)
                    {
                        return 3;
                    }
                    
                        // buff
                    if(Tablero.laberinto[F,C-1] == 41 || Tablero.laberinto[F,C-1] == 42 || Tablero.laberinto[F,C-1] == 43 )
                    {
                        return 4;
                    }     
                    
                    // colision
                    
                    if(Tablero.laberinto[F,C-1] == 0)
                    {
                        return 2; // direccion equivocada     
                    } 
                    
                    return 0;  // ficha
            }
            static int Derecha(int F, int C)
            {
                        // win
                    if(Tablero.laberinto[F,C+1] == 5)
                    {
                        return 5;
                    }    
                   
                        // camino
                    if(Tablero.laberinto[F,C+1] == 1)
                    {
                        return 1;
                    }
                    
                        // trampa
                    if(Tablero.laberinto[F,C+1] == 31 || Tablero.laberinto[F,C+1] == 32 || Tablero.laberinto[F,C+1] == 33 || Tablero.laberinto[F+1,C] == 34)
                    {
                        return 3;
                    }
                    
                        // buff
                    if(Tablero.laberinto[F,C+1] == 41 || Tablero.laberinto[F,C+1] == 42 || Tablero.laberinto[F,C+1] == 43 )
                    {
                        return 4;
                    }     
                    
                    // colision
                    
                    if(Tablero.laberinto[F,C+1] == 0)
                    {
                        return 2; // direccion equivocada     
                    } 
                    
                    return 0;  // ficha
            }                 
    }
