public class Inmunidad{
    public static void Inmune(int x, int c){

        if(x==21)
            Estadisticas.i21+=c;
        if(x==22)
            Estadisticas.i22+=c;
        if(x==23)
            Estadisticas.i23+=c;
        if(x==24)
            Estadisticas.i24+=c;
        if(x==25)
            Estadisticas.i25+=c;
        if(x==26)
            Estadisticas.i26+=c;
        if(x==27)
            Estadisticas.i27+=c;
        if(x==28)
            Estadisticas.i28+=c;
    }

    public static int Consultar(int x){

        if(x==21){
            if(Estadisticas.i21 == 0) return 0;
            else return Estadisticas.i21;
        }
        
        
        if(x==22){
            if (Estadisticas.i22 == 0) return 0;
            else return Estadisticas.i22;
        }

        if(x==23){
            if(Estadisticas.i23==0) return 0;
            else return Estadisticas.i23;
        }

        if(x==24){
            if(Estadisticas.i24==0) return 0;
            else return Estadisticas.i24;
        }

        if(x==25){
            if(Estadisticas.i25==0) return 0;
            else return Estadisticas.i25;
        }

        if(x==26){
            if(Estadisticas.i26==0) return 0;
            else return Estadisticas.i26;
        }

        if(x==27){
            if(Estadisticas.i27==0) return 0;
            else return Estadisticas.i27;
        }

        if(x==28){
            if(Estadisticas.i28==0) return 0;
            else return Estadisticas.i28;
        }else return 0;

    }

    public static void Rest(int x){

        if(x==21) 
            Estadisticas.i21-=1;
        if(x==22) 
            Estadisticas.i22-=1;
        if(x==23) 
            Estadisticas.i23-=1;
        if(x==24) 
            Estadisticas.i24-=1;
        if(x==25) 
            Estadisticas.i25-=1;
        if(x==26) 
            Estadisticas.i26-=1;
        if(x==27) 
            Estadisticas.i27-=1;
        if(x==28) 
            Estadisticas.i28-=1;
    }

}


