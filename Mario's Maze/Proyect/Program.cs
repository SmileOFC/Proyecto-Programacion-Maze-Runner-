using System; 
public class Program {
    static void Main()
    {   
        
    
        Tablero.Generar();
        Console.Clear();
        // LOBY SELECT PLAYER      

        int ve;

        for (int x = Tablero.rand.Next(21,29); x<30; x++){

            ve=1;
            
            if (x == 28) x=21;

            while (ve>0){

                Console.Clear();
                Imprime.Imprimir();
                Console.WriteLine("Player: " + (x-20));
                Console.WriteLine("Velocidad: " + Velocidades.Actual(x));
                Console.WriteLine("Inmune: " + Inmunidad.Consultar(x));
                
                var keyInfo = Console.ReadKey();
        
                if ( keyInfo.KeyChar == 'h'){

                    Habilidades.Habilidad();

                }
                    
                if(keyInfo.KeyChar == 'w' || keyInfo.KeyChar == 's' || keyInfo.KeyChar == 'd' || keyInfo.KeyChar == 'a'){
                       
                ve = Jugar.Mover(x,keyInfo.KeyChar);

                } 
            }
            // COLDOWNS
            if(Inmunidad.Consultar(x) != 0)
                Inmunidad.Rest(x);
            

        }       
    }       
}

