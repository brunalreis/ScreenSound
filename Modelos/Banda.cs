namespace ScreenSound.Modelos;
internal class Banda
{
    private List<Album> albums = new List<Album>();
    private List<Avaliacao> notas = new List<Avaliacao>();
    public string NomeBanda { get; }


    public Banda(string nomeBanda)
    {
        NomeBanda = nomeBanda;
    }

    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }
    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {NomeBanda}");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Album {album.NomeAlbum} ({album.DuracaoTotal})");
        }
    }
}