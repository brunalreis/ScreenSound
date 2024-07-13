namespace ScreenSound.Modelos;
class Banda
{
    private List<Album> albums = new List<Album>();
    private List<int> notas = new List<int>();
    public string NomeBanda { get; }


    public Banda(string nomeBanda)
    {
        NomeBanda = nomeBanda;
    }

    public double Media => notas.Average();
    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void AdicionarNota(int nota)
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