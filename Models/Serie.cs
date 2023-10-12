public class Serie{
    public int IdSerie {get; set;}
    public string Nombre {get; set;}
    public int AñoInicio {get; set;}
    public string Sinopsis {get; set;}
    public string ImagenSerie {get; set;}

    public Serie(){}

    public Serie(string nombre, int añoinicio, string sinopsis, string imagenserie){
        Nombre = nombre;
        AñoInicio = añoinicio;
        Sinopsis = sinopsis;
        ImagenSerie = imagenserie;
    }
}