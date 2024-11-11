
public class Imprime {

    public static void Imprimir()
    {  

        for (int i = 0; i < Tablero.filas; i++)
        {
            for (int j = 0; j < Tablero.columnas; j++)
            {

                // PLAYERS

                if(Tablero.laberinto[i,j]==21){
                    Console.Write("P1");
                }
                if(Tablero.laberinto[i,j]==22){
                    Console.Write("P2");
                }
                if(Tablero.laberinto[i,j]==23){
                    Console.Write("P3");
                }
                if(Tablero.laberinto[i,j]==24){
                    Console.Write("P4");
                }
                if(Tablero.laberinto[i,j]==25){
                    Console.Write("P5");
                }
                if(Tablero.laberinto[i,j]==26){
                    Console.Write("P6");
                }
                if(Tablero.laberinto[i,j]==27){
                    Console.Write("P7");
                }
                if(Tablero.laberinto[i,j]==28){
                    Console.Write("P8");
                }

                // TRAMPAS

                if(Tablero.laberinto[i,j]==31)
                    Console.Write("T1");
                
                if(Tablero.laberinto[i,j]==32)
                    Console.Write("T2");
            
                if(Tablero.laberinto[i,j]==33)
                    Console.Write("T3");
        
                if(Tablero.laberinto[i,j]==34)
                    Console.Write("T4");
                
            
                // BUFF

                if(Tablero.laberinto[i,j]==41){
                    Console.Write("B1");
                }
                if(Tablero.laberinto[i,j]==42){
                    Console.Write("B2");
                }
                if(Tablero.laberinto[i,j]==43){
                    Console.Write("B3");
                }

                // LABERINTO

                if(Tablero.laberinto[i,j]==1){
                    Console.Write("  ");
                }
                if(Tablero.laberinto[i,j]==0){
                    Console.Write("██");
                }
                
                // META

                if(Tablero.laberinto[i,j]==5){
                    Console.Write("  ");
                }

            }
            Console.WriteLine();
        }
    }

} 