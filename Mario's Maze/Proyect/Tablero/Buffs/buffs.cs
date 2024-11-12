
public class Bufss{

    public static void Buff(int x, int y, int bx, int by, int px, int py)
    {

        if(x==41){ // Hongo
            Tablero.laberinto[px,py] = 1;
            Tablero.laberinto[bx,by] = y;

            if(y==21)
                Estadisticas.b21 = Estadisticas.b21 + 2;
            if(y==22)
                Estadisticas.b22 = Estadisticas.b22 + 2;
            if(y==23)
                Estadisticas.b23 = Estadisticas.b23 + 2;
            if(y==24)
                Estadisticas.b24 = Estadisticas.b24 + 2;
            if(y==25)
                Estadisticas.b25 = Estadisticas.b25 + 2;
            if(y==26)
                Estadisticas.b26 = Estadisticas.b26 + 2;
            if(y==27)
                Estadisticas.b27 = Estadisticas.b27 + 2;
            if(y==28)
                Estadisticas.b28 = Estadisticas.b28 + 2;
            if(y==29)
                Estadisticas.b29 = Estadisticas.b29 + 2;
            if(y==20)
                Estadisticas.b20 = Estadisticas.b20 + 2;

        }

        if(x==42) // Estrella
            Tablero.laberinto[px,py] = 1;
            Tablero.laberinto[bx,by] = y;
            Inmunidad.Inmune(y,3);

        if(x==43){ // Gafas



        }
        
    }

}