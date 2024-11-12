public class Inmunidad{

    public static int i21=0;
    public static int i22=0;
    public static int i23=0;
    public static int i24=0;
    public static int i25=0;
    public static int i26=0;
    public static int i27=0;
    public static int i28=0;

    public static void Inmune(int x, int c){

        if(x==21)
            i21+=c;
        if(x==22)
            i22+=c;
        if(x==23)
            i23+=c;
        if(x==24)
            i24+=c;
        if(x==25)
            i25+=c;
        if(x==26)
            i26+=c;
        if(x==27)
            i27+=c;
        if(x==28)
            i28+=c;
    }

    public static int Consultar(int x){

        if(x==21){
            if(i21 == 0) return 0;
            else return i21;
        }
        
        
        if(x==22){
            if (i22 == 0) return 0;
            else return i22;
        }

        if(x==23){
            if(i23==0) return 0;
            else return i23;
        }

        if(x==24){
            if(i24==0) return 0;
            else return i24;
        }

        if(x==25){
            if(i25==0) return 0;
            else return i25;
        }

        if(x==26){
            if(i26==0) return 0;
            else return i26;
        }

        if(x==27){
            if(i27==0) return 0;
            else return i27;
        }

        if(x==28){
            if(i28==0) return 0;
            else return i28;
        }else return 0;

    }

    public static void Rest(int x){

        if(x==21) 
            i21-=1;
        if(x==22) 
            i22-=1;
        if(x==23) 
            i23-=1;
        if(x==24) 
            i24-=1;
        if(x==25) 
            i25-=1;
        if(x==26) 
            i26-=1;
        if(x==27) 
            i27-=1;
        if(x==28) 
            i28-=1;
    }

}


