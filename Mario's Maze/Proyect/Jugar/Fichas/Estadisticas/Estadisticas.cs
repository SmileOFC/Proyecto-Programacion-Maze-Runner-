
public class Estadisticas{

    // velocidad
    public static int b21 = 10; // Yoshi B
    public static int b22 = 7; // Koopa M
    public static int b23 = 6; // Luigi B
    public static int b24 = 5; // Mario B
    public static int b25 = 4; // Hongo B
    public static int b26 = 9; // Bowser M
    public static int b27 = 3; // Tortuga M
    public static int b28 = 8; // Wario M
    public static int b29 = 11; // Peach B
    public static int b20 = 12; // Waluigi M

////////////////////////////////////////////////
    
    // inmunidad
    public static int i21 = 0;
    public static int i22 = 0;
    public static int i23 = 0;
    public static int i24 = 0;
    public static int i25 = 0;
    public static int i26 = 0;
    public static int i27 = 0;
    public static int i28 = 0;
    public static int i29 = 0;
    public static int i20 = 0;

////////////////////////////////////////////////

    // contador de buff de velocidad
    public static int contv21 = 0;
    public static int contv22 = 0;
    public static int contv23 = 0;
    public static int contv24 = 0;
    public static int contv25 = 0;
    public static int contv26 = 0;
    public static int contv27 = 0;
    public static int contv28 = 0;
    public static int contv29 = 0;
    public static int contv20 = 0;

////////////////////////////////////////////////

    // contador de buff de vision


////////////////////////////////////////////////

    // coldown habilidad
    public static int c21 = 0;
    public static int c22 = 0;
    public static int c23 = 0;
    public static int c24 = 0;
    public static int c25 = 0;
    public static int c26 = 0;
    public static int c27 = 0;
    public static int c28 = 0;
    public static int c29 = 0;
    public static int c20 = 0;

////////////////////////////////////////////////

    // inventario
    public static int[] inv21 = new int[5]{0,0,0,0,0,};
    public static int[] inv22 = new int[5]{0,0,0,0,0,};
    public static int[] inv23 = new int[5]{0,0,0,0,0,};
    public static int[] inv24 = new int[5]{0,0,0,0,0,};
    public static int[] inv25 = new int[5]{0,0,0,0,0,};
    public static int[] inv26 = new int[5]{0,0,0,0,0,};
    public static int[] inv27 = new int[5]{0,0,0,0,0,};
    public static int[] inv28 = new int[5]{0,0,0,0,0,};
    public static int[] inv29 = new int[5]{0,0,0,0,0,};
    public static int[] inv20 = new int[5]{0,0,0,0,0,};


}

public class Ficha{

    public static string Name (int x){

        if(x==21) return "Yoshi"; 
        if(x==22) return "Koopa"; 
        if(x==23) return "Luigi"; 
        if(x==24) return "Mario"; 
        if(x==25) return "Hongo"; 
        if(x==26) return "Browser"; 
        if(x==27) return "Tortuga"; 
        if(x==28) return "Wario";
        if(x==29) return "Peach";
        if(x==20) return "Waluigi";

        
    return "";
    }

}