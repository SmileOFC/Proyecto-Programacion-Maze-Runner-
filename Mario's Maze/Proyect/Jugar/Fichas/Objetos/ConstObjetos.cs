public class CrearPlayer
{
    public string? Name;
    public int Pasos;
    public int PasosStatic;
    public int PasosCont;
    public int Habilidad;
    public bool Equipo;
    public int Vision;
    public int VisionStatic;
    public bool Inmovil;
    public bool Inmune;
    public int BufPasos;
    public int BufVision;

    public CrearPlayer(
        string Name_,
        int Pasos_,
        int PasosStatic_,
        int PasosCont_,
        int Habilidad_,
        bool Equipo_,
        int Vision_,
        int VisionStatic_,
        bool Inmovil_,
        bool Inmune_,
        int BufPasos_,
        int BufVision_
    )
    {
        Name = Name_;
        Pasos = Pasos_;
        PasosStatic = PasosStatic_;
        PasosCont = PasosCont_;
        Habilidad = Habilidad_;
        Equipo = Equipo_;
        Vision = Vision_;
        VisionStatic = VisionStatic_;
        Inmovil = Inmovil_;
        Inmune = Inmune_;
        BufPasos = BufPasos_;
        BufVision = BufVision_;
    }
}
