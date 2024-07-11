class Banda
{
    private List<Album> albums = new List<Album>();
    public string NomeBanda { get; }


    public Banda(string nomeBanda)
    {
        NomeBanda = nomeBanda;
    }
    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
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