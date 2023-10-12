public class Temporada{
    public int IdTemporada {get; set;}
    public int IdSerie {get; set;}
    public int NumeroTemporada {get; set;}
    public string TituloTemporada {get; set;}

    public Temporada(){}

    public Temporada(int idserie, int numerotemporada, string titulotemporada){
        IdSerie = idserie;
        NumeroTemporada = numerotemporada;
        TituloTemporada = titulotemporada;
    }
}