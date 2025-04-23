public class Disco{
    public int ID {get; private set;}
    public string nombreAlbum {get; private set;}
    public string foto {get; private set;}
    public Artista artista {get; private set;}
    public Productor productor {get; private set;}
    public string genero  {get; private set;}
    public List <Tema> temas {get; private set;}
    public Disco (string nombre, string foto, Artista artista, Productor productor, string generoMusical){
        this.nombreAlbum = nombre;
        this.foto = foto;
        this.artista = artista;
        this.productor = productor;
        this.genero = generoMusical;
        temas = new List<Tema>();
    }

}
