
public class CrearPlayer
{
    public string? Name;
    public bool Equipo;
    public int Pasos;
    public int Pasos_Static;
    public int Vision;
    public int VisionStatic;
    public int Inmovil;
    public int Inmune;
    public int BufPasos;
    public int BufVision;
    public bool BufInmune;
    public CrearPlayer(string Name_, int Pasos_,bool Equipo_,int PasosStatic_, int Vision_,int VisionStatic_, int Inmovil_, int Inmune_,bool BufInmune_, int BufPasos_, int BufVision_)
    {
        Name = Name_;
        Pasos = Pasos_;
        Equipo = Equipo_;
        Pasos_Static = PasosStatic_;
        Vision = Vision_;
        VisionStatic = VisionStatic_;
        Inmovil = Inmovil_;
        Inmune = Inmune_;
        BufInmune = BufInmune_;
        BufPasos = BufPasos_;
        BufVision = BufVision_;

    }
}


    // inventario obj equipo pendiente
  /*  public static int[] inv21 = new int[5] { 0, 0, 0, 0, 0, };
    public static int[] inv22 = new int[5] { 0, 0, 0, 0, 0, };
    public static int[] inv23 = new int[5] { 0, 0, 0, 0, 0, };
    public static int[] inv24 = new int[5] { 0, 0, 0, 0, 0, };
    public static int[] inv25 = new int[5] { 0, 0, 0, 0, 0, };
    public static int[] inv26 = new int[5] { 0, 0, 0, 0, 0, };
    public static int[] inv27 = new int[5] { 0, 0, 0, 0, 0, };
    public static int[] inv28 = new int[5] { 0, 0, 0, 0, 0, };
    public static int[] inv29 = new int[5] { 0, 0, 0, 0, 0, };
    public static int[] inv20 = new int[5] { 0, 0, 0, 0, 0, }; */

