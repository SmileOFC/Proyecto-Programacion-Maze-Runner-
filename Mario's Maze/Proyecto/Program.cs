using System; 
public class Rondas
{
    public static void Main()
    {   
        int z=1;
        int ve;
    
        Tablero.Generar();
        Console.Clear();
        // LOBY SELECT PLAYER      

        for (int x = Tablero.rand.Next(21,29); x<30; x++){

            ve=1;
            if (z == 0) break;
            if (x == 28) x=21;

            while (ve>0){

                Console.Clear();
                Imprime.Imprimir();
                Console.WriteLine("Player: " + x);
                
                var keyInfo = Console.ReadKey();
        
                if ( keyInfo.KeyChar == 'h'){

                    Habilidades.Habilidad();

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
