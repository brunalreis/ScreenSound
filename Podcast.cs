public class Podcast
{
    private List<Episodios> episodios = new List<Episodios>();
    public string Host { get; }
    public string NomePod { get; }
    public int TotalEpisodios
    {
        get
        {
            return episodios.Count();
        }
    }

    public Podcast(string host, string nomePod)
    {
        Host = host;
        NomePod = nomePod;
    }

    public void AdicionarEpisodio(Episodios Titulo)
    {
        episodios.Add(Titulo);
    }

    public string ExibirDetalhes()
    {
        char s;
        if (TotalEpisodios > 1)
        {
            s = 's';

        }
        else
        {
            s = ' ';
        }
        return $"Podcast: {NomePod}, apresentado por {Host}. Contém {TotalEpisodios} episódio{s}. ";

    }



}