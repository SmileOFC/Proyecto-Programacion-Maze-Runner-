
public class Bufss{

    public static void Buff(int x, int y, int bx, int by, int px, int py)
    {

        if(x==41){ // Hongo
            Tablero.laberinto[px,py] = 1;
            Tablero.laberinto[bx,by] = y;

            if(y==21)
                Velocidades.b21 += 2;
            if(y==22)
                Velocidades.b22 += 2;
            if(y==23)
                Velocidades.b23 += 2;
            if(y==24)
                Velocidades.b24 += 2;
            if(y==25)
                Velocidades.b25 += 2;
            if(y==26)
                Velocidades.b26 += 2;
            if(y==27)
                Velocidades.b27 += 2;
            if(y==28)
                Velocidades.b28 += 2;

        }

        if(x==42) // Estrella
            Tablero.laberinto[px,py] = 1;
            Tablero.laberinto[bx,by] = y;
            Inmunidad.Inmune(y,3);

        if(x==43){ // Gafas



        }
        
    }

}