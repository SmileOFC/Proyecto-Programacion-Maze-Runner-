
public static class Velocidades{
    public static int Actual(int x){

            if(x==21)
                return Estadisticas.b21; 
            if(x==22) 
                return Estadisticas.b22;
            if(x==23) 
                return Estadisticas.b23;
            if(x==24)
                return Estadisticas.b24;
            if(x==25)
                return Estadisticas.b25;
            if(x==26)
                return Estadisticas.b26;
            if(x==27)
                return Estadisticas.b27;
            if(x==28)
                return Estadisticas.b28;
                return 0;

    }

    public static int v(int x){
    
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
    public static int Velocidad(int x)
        {
            
            if(x==21){

                Estadisticas.b21 -= 1 ;
                if(Estadisticas.b21==0)
                {
                    Estadisticas.b21=v(21);
                    return 0;
                }
                return Estadisticas.b21;
            }
                
            if(x==22){

                Estadisticas.b22 -= 1 ;
                if(Estadisticas.b22==0)
                {
                    Estadisticas.b22=v(22);
                    return 0;
                }
                return Estadisticas.b22;                
            }
            if(x==23){

                Estadisticas.b23 -= 1 ;
                if(Estadisticas.b23==0)
                {
                    Estadisticas.b23=v(23);
                    return 0;
                }
                return Estadisticas.b23;
            }
            if(x==24){

                Estadisticas.b24 -= 1 ;
                if(Estadisticas.b24==0)
                {
                    Estadisticas.b24=v(24);
                    return 0;
                }
                return Estadisticas.b24;
            }
            if(x==25){

                Estadisticas.b25 -= 1 ;
                if(Estadisticas.b25==0)
                {
                    Estadisticas.b25=v(25);
                    return 0;
                }
                return Estadisticas.b25;
            }
            if(x==26){

                Estadisticas.b26 -= 1 ;
                if(Estadisticas.b26==0)
                {
                    Estadisticas.b26=v(26);
                    return 0;
                }
                return Estadisticas.b26;
            }
            if(x==27){

                Estadisticas.b27 -= 1 ;
                if(Estadisticas.b27==0)
                {
                    Estadisticas.b27=v(27);
                    return 0;
                }
                return Estadisticas.b27;
            }
            if(x==28){

                Estadisticas.b28 -= 1 ;
                if(Estadisticas.b28==0)
                {
                    Estadisticas.b28=v(28);
                    return 0;
                }
                return Estadisticas.b28;            
            }
            return 0;
        }

}
