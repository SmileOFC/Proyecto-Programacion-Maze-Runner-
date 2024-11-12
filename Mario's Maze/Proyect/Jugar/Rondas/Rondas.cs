public class Rondas{

    public static void Ronda(){

        Tablero.Generar();
        int Pasos;
        
        List<int> Fichas = new List<int>(Picks.Fichas.ToArray());

        for (int a = 0; ; a++){

            Pasos=1;
            
            if (a == 6) a=0;

            int x = Fichas[a];

            while (Pasos>0){

                Console.Clear();
                Imprime.Imprimir();
                Console.WriteLine("");
                Console.WriteLine("     Player: " + (x-20));
                Console.WriteLine("     Pasos:  " + Velocidades.Actual(x));
                Console.WriteLine("     Inmune: " + Inmunidad.Consultar(x));
                
                var keyInfo = Console.ReadKey();

                if(keyInfo.KeyChar == 'r')
                    Pasos=0;
        
                if (keyInfo.KeyChar == 'h')
                    Habilidades.Habilidad();

                
                    
                if(keyInfo.KeyChar == 'w' || keyInfo.KeyChar == 's' || keyInfo.KeyChar == 'd' || keyInfo.KeyChar == 'a'){
                       
                Pasos = Jugar.Mover(x,keyInfo.KeyChar);

                }
                if(Pasos==2) break; 
            }
            // COLDOWNS
            Trampas.PlacaQuitar();
            if(Inmunidad.Consultar(x) != 0)
                Inmunidad.Rest(x);
            
            // WIN 
            if(Pasos==2) break; 
        }

    }
    
}