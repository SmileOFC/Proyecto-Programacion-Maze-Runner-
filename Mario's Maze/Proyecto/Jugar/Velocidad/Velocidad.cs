using static Program;

public class Velocidades{

    static int b21 = 10;
    static int b22 = 7;
    static int b23 = 6;
    static int b24 = 5;
    static int b25 = 4;
    static int b26 = 9;
    static int b27 = 3;
    static int b28 = 8;

    static int v(int x){
    
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

                b21 -= 1 ;
                if(b21==0)
                {
                    b21=v(21);
                    return 0;
                }
                return x;
            }
                
            if(x==22){

                b22 -= 1 ;
                if(b22==0)
                {
                    b22=v(22);
                    return 0;
                }
                return x;                
            }
            if(x==23){

                b23 -= 1 ;
                if(b23==0)
                {
                    b23=v(23);
                    return 0;
                }
                return x;
            }
            if(x==24){

                b24 -= 1 ;
                if(b24==0)
                {
                    b24=v(24);
                    return 0;
                }
                return x;
            }
            if(x==25){

                b25 -= 1 ;
                if(b25==0)
                {
                    b25=v(25);
                    return 0;
                }
                return x;
            }
            if(x==26){

                b26 -= 1 ;
                if(b26==0)
                {
                    b26=v(26);
                    return 0;
                }
                return x;
            }
            if(x==27){

                b27 -= 1 ;
                if(b27==0)
                {
                    b27=v(27);
                    return 0;
                }
                return x;
            }
            if(x==28){

                b28 -= 1 ;
                if(b28==0)
                {
                    b28=v(28);
                    return 0;
                }
                return x;            
            }
            return x;
        }

}
