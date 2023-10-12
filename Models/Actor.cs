public class Actor{
    public int IdActor {get; set;}
    public int IdSerie {get; set;}
    public string Nombre {get; set;}

    public Actor(){}

    public Actor(int idserie, string nombre){
        IdSerie = idserie;
        Nombre = nombre;
    }
}