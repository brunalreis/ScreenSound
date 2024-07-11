public class Episodios
{
    private List<string> convidados = new List<string>();
    public int EpDuracao { get; }
    public int Ordem { get; }
    public string Resumo => $"{Ordem}. {Titulo} ({EpDuracao} min) - {string.Join(", ", convidados)}";
    public string Titulo { get; }
    public Episodios(int ordem, string titulo, int epDuracao)
    {
        EpDuracao = epDuracao;
        Ordem = ordem;
        Titulo = titulo;
    }
    public void AddConvidados(string convidado)
    {
        convidados.Add(convidado);
    }
}

