
public class Tablero{

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

}