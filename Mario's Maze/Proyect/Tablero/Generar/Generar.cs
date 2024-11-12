
public class Tablero{

        static int c = 0;
        public static Random rand = new Random();

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
        laberinto[15,15]=55; 
        laberinto[14,14]=5;
        laberinto[14,15]=5;
        laberinto[14,16]=5;
        laberinto[15,14]=5;
        laberinto[15,16]=5;
        laberinto[16,14]=5;
        laberinto[16,15]=5;
        laberinto[16,16]=5;
        
        //Players

        List<int> Fichas = new List<int>(Picks.Fichas.ToArray());
        int c=0;

        while(Picks.Fichas.Count > 0){

        if(c!=6){
            if(c==0)            
                laberinto[1,1] = Fichas[c]; 
        
            if(c==1)
                laberinto[1,15]=Fichas[c];
        
            if(c==2)
                laberinto[1,29]=Fichas[c];
        
            if(c==3)
                laberinto[29,1]=Fichas[c];
        
            if(c==4)
                laberinto[29,15]=Fichas[c];
        
            if(c==5)
                laberinto[29,29]=Fichas[c];
            c++;
        }else break;
        
        }
        
        // Trampas

        for (int i = 1; i < filas; i++)
        {
            for (int j = 1; j < columnas; j++)
            {
                
                if(laberinto[i,j]==1){
                    c++;
                    if(c==20){
                        int a = rand.Next(31,34);
                        laberinto[i,j]=a;
                        c=0;
                    }
                }

                
            }
        }
       
        //Buff

       for (int i = 1; i < filas; i++)
        {
            for (int j = 1; j < columnas; j++)
            {
                
                if(laberinto[i,j]==1){
                    c++;
                    if(c==30){
                        int a = rand.Next(41,43);
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

        static int Posiciones(){


            return 0;
        }

}