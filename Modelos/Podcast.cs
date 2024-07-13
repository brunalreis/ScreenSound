namespace ScreenSound.Modelos;

public class Podcast
{
    private List<Episodios> episodios = new List<Episodios>();
    public string Host { get; }
    public string NomePod { get; }
    public int TotalEpisodios => episodios.Count();

    public Podcast(string nomePod, string host)
    {
        Host = host;
        NomePod = nomePod;
    }

    public void AdicionarEpisodio(Episodios episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast: {NomePod}, apresentado por {Host}. Contém {TotalEpisodios} episódios.\n");
        foreach (Episodios episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }

    }



}