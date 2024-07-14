
namespace ScreenSound.Modelos;

internal class Album
{
    private List<Musica> musicas = new List<Musica>();

    public Album(string nomeAlbum)
    {
        NomeAlbum = nomeAlbum;
    }

    public string NomeAlbum { get; }
    public int DuracaoTotal
    {
        get
        {
            return musicas.Sum(musica => musica.Duracao);
        }
    }
    public void AdicionarMusica(Musica NomeMusica)
    {
        musicas.Add(NomeMusica);
    }

    public void ExibirMusicasAlbum()
    {
        foreach (var musica in musicas)
        {
            Console.WriteLine(musica.NomeMusica);
        }
        Console.WriteLine($"Tempo de deuração do album: {DuracaoTotal}");
    }
}