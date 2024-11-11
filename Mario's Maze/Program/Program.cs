using System; 
public class Program
{
    public static Random rand = new Random();
    static int b21 = 10;
    static int b22 = 7;
    static int b23 = 6;
    static int b24 = 5;
    static int b25 = 4;
    static int b26 = 9;
    static int b27 = 3;
    static int b28 = 8;
    static int v(int x){
    
            if(x==21)
                return 10; 
            if(x==22) 
                return 7;
            if(x==23) 
                return 6;
            if(x==24)
                return 5;
            if(x==25)
                return 4;
            if(x==26)
                return 9;
            if(x==27)
                return 3;
            if(x==28)
                return 8;
                return 0;
    }
    static int Velocidad(int x)
        {
            
            if(x==21){

                b21 -= 1 ;
                if(b21==0)
                {
                    b21=v(21);
                    return 0;
                }
                return x;
            }
                
            if(x==22){

                b22 -= 1 ;
                if(b22==0)
                {
                    b22=v(22);
                    return 0;
                }
                return x;                
            }
            if(x==23){

                b23 -= 1 ;
                if(b23==0)
                {
                    b23=v(23);
                    return 0;
                }
                return x;
            }
            if(x==24){

                b24 -= 1 ;
                if(b24==0)
                {
                    b24=v(24);
                    return 0;
                }
                return x;
            }
            if(x==25){

                b25 -= 1 ;
                if(b25==0)
                {
                    b25=v(25);
                    return 0;
                }
                return x;
            }
            if(x==26){

                b26 -= 1 ;
                if(b26==0)
                {
                    b26=v(26);
                    return 0;
                }
                return x;
            }
            if(x==27){

                b27 -= 1 ;
                if(b27==0)
                {
                    b27=v(27);
                    return 0;
                }
                return x;
            }
            if(x==28){

                b28 -= 1 ;
                if(b28==0)
                {
                    b28=v(28);
                    return 0;
                }
                return x;            
            }
            return x;
        } 
    public static void Habilidad(int x)
    {


    
    }
    public class Tablero
    {
        public static int filas = 31, columnas = 31; 
        
        public static int[,] laberinto = new int[filas, columnas]; 
        
        static List<(int, int, int, int)> paredes = new List<(int, int, int, int)>();

        public static void Generar()
    {
        int x = 1, y = 1;
        laberinto[x, y] = 1;
        AgregarParedes(x, y);

        while (paredes.Count > 0)
        {
            int indice = rand.Next(paredes.Count);
            var (px, py, cx, cy) = paredes[indice];
            paredes.RemoveAt(indice);

            if (laberinto[cx, cy] == 0)
            {
                laberinto[px, py] = 1; 
                laberinto[cx, cy] = 1; 
                AgregarParedes(cx, cy); 
            }
        }

        //WIN
        laberinto[16,16]=5; 
        laberinto[15,16]=5;
        laberinto[17,16]=5;
        laberinto[16,15]=5;
        laberinto[16,17]=5;
        laberinto[15,15]=5;
        laberinto[15,17]=5;
        laberinto[17,17]=5;
        laberinto[17,15]=5;
        //Players
        laberinto[1,1]=21; 
        laberinto[16,1]=22;
        laberinto[1,16]=23;
        laberinto[16,29]=24;
        laberinto[29,16]=25;
        laberinto[1,29]=26;
        laberinto[29,1]=27;
        laberinto[29,29]=28;

        int c = 0;

        // Trampas

        /*for (int i = 1; i < filas; i++)
        {
            for (int j = 1; j < columnas; j++)
            {
                
                if(laberinto[i,j]==1){
                    c++;
                    if(c==10){
                        int a = rand.Next(31,33);
                        laberinto[i,j]=a;
                        c=0;
                    }
                }

                
            }
        }

        */
       
        //Buff

       for (int i = 1; i < filas; i++)
        {
            for (int j = 1; j < columnas; j++)
            {
                
                if(laberinto[i,j]==1){
                    c++;
                    if(c==20){
                        int a = rand.Next(41,42);
                        laberinto[i,j]=a;
                        c=0;
                    }
                }

                
            }
        }   
    }

        //NPC
        //Cofres
        
        static void AgregarParedes(int x, int y)
    {
        
        if (x > 1) paredes.Add((x - 1, y, x - 2, y)); 
        if (x < filas - 2) paredes.Add((x + 1, y, x + 2, y));
        if (y > 1) paredes.Add((x, y - 1, x, y - 2)); 
        if (y < columnas - 2) paredes.Add((x, y + 1, x, y + 2)); 
    } 
        
        public static void Imprimir()
    {  

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {

                // PLAYERS

                if(laberinto[i,j]==21){
                    Console.Write("P1");
                }
                if(laberinto[i,j]==22){
                    Console.Write("P2");
                }
                if(laberinto[i,j]==23){
                    Console.Write("P3");
                }
                if(laberinto[i,j]==24){
                    Console.Write("P4");
                }
                if(laberinto[i,j]==25){
                    Console.Write("P5");
                }
                if(laberinto[i,j]==26){
                    Console.Write("P6");
                }
                if(laberinto[i,j]==27){
                    Console.Write("P7");
                }
                if(laberinto[i,j]==28){
                    Console.Write("P8");
                }

                // TRAMPAS

                if(laberinto[i,j]==31)
                    Console.Write("T1");
                
                if(laberinto[i,j]==32)
                    Console.Write("T2");
            
                if(laberinto[i,j]==33)
                    Console.Write("T3");
        
                if(laberinto[i,j]==34)
                    Console.Write("T4");
                
            
                // BUFF

                if(laberinto[i,j]==41){
                    Console.Write("B1");
                }
                if(laberinto[i,j]==42){
                    Console.Write("B2");
                }
                if(laberinto[i,j]==43){
                    Console.Write("B3");
                }

                // LABERINTO

                if(laberinto[i,j]==1){
                    Console.Write("  ");
                }
                if(laberinto[i,j]==0){
                    Console.Write("██");
                }
                
                // META

                if(laberinto[i,j]==5){
                    Console.Write("  ");
                }

            }
            Console.WriteLine();
        }
    }
       
        public static void Trampa(int t, int x,int tx, int ty, int px, int py, char p)
        {

        if(t==31){ //hueco

            Tablero.laberinto[px,py] = 1;
            Tablero.laberinto[tx,ty] = 1;  
            
            if(x==21) laberinto[1,1]=21;
            if(x==22) laberinto[16,1]=22;
            if(x==23) laberinto[1,16]=23;
            if(x==24) laberinto[16,29]=24;
            if(x==25) laberinto[29,16]=25;
            if(x==26) laberinto[1,29]=26;
            if(x==27) laberinto[29,1]=27;
            if(x==28) laberinto[29,29]=28;
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


            Tablero.Imprimir();
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

        public static void Buff(int x)
    {

        if(x==41){ // Hongo

            

        }

        if(x==42){ // Estrella



        }

        if(x==43){ // Coins



        }
        
    }

    }
    public static class Jugar
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
                    return Velocidad(x);
                }

                if(Arriba(xy[0],xy[1]) == 2)
                 return 1;
                if(Arriba(xy[0],xy[1]) == 3){
                Tablero.Trampa(Tablero.laberinto[xy[0]-1,xy[1]],x,xy[0]-1,xy[1],xy[0],xy[1],y);
                return Velocidad(x); }

                if(Arriba(xy[0],xy[1]) == 4){ 
                Tablero.Buff(Tablero.laberinto[xy[0]-1,xy[1]]);                  
                return Velocidad(x);}
                
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
                    return Velocidad(x);
                }

                if(Abajo(xy[0],xy[1]) == 2)
                    return 1;
                if(Abajo(xy[0],xy[1]) == 3){
                    Tablero.Trampa(Tablero.laberinto[xy[0]+1,xy[1]],x,xy[0]+1,xy[1],xy[0],xy[1],y);
                    return Velocidad(x); }

                if(Abajo(xy[0],xy[1]) == 4){ 
                    Tablero.Buff(Tablero.laberinto[xy[0]+1,xy[1]]); 
                    return Velocidad(x);}                 

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
                   return Velocidad(x);
                }

                if(Izquierda(xy[0],xy[1]) == 2)
                   return 1;
                if(Izquierda(xy[0],xy[1]) == 3){
                   Tablero.Trampa(Tablero.laberinto[xy[0],xy[1]-1],x,xy[0],xy[1]-1,xy[0],xy[1],y);
                   return Velocidad(x); }

                if(Izquierda(xy[0],xy[1]) == 4){ 
                   Tablero.Buff(Tablero.laberinto[xy[0],xy[1]-1]);
                   return Velocidad(x); }                  

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
                    return Velocidad(x);
                }

                if(Derecha(xy[0],xy[1]) == 2)
                   return 1;
                if(Derecha(xy[0],xy[1]) == 3){
                   Tablero.Trampa(Tablero.laberinto[xy[0],xy[1]+1],x,xy[0],xy[1]+1,xy[0],xy[1],y);
                   return Velocidad(x);}

                if(Derecha(xy[0],xy[1]) == 4){ 
                   Tablero.Buff(Tablero.laberinto[xy[0]+1,xy[1]]);  
                   return Velocidad(x);}                

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
    public class Loby
    {


        
    }  
    public class Picks
    {



    }
    public static void Main()
    {   
        int z=1;
        int ve;
    
        Tablero.Generar();
        Console.Clear();
        // LOBY SELECT PLAYER      

        for (int x = rand.Next(21,29); x<30; x++){

            ve=1;
            if (z == 0) break;
            if (x == 28) x=21;

            while (ve>0){

                Console.Clear();
                Tablero.Imprimir();
                Console.WriteLine("Player: " + x);
                
                var keyInfo = Console.ReadKey();
        
                if ( keyInfo.KeyChar == 'h'){



                }
                    
                if(keyInfo.KeyChar == 'w' || keyInfo.KeyChar == 's' || keyInfo.KeyChar == 'd' || keyInfo.KeyChar == 'a'){
                       
                ve = Jugar.Mover(x,keyInfo.KeyChar);

                    if(z==2) {

                    // win  

                    } 
        
                } 
            }
        }       
    }       
}
