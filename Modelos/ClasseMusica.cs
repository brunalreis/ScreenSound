using System.Diagnostics.Contracts;
namespace ScreenSound.Modelos;

class Musica
{
    public string NomeMusica { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; } /*esse get e set sao propriedades que significam que estamos tratando de uma valor privado, mas que se comportará como o público. Get: ler || Set: escrever.*/

    public string DescricaoResum => "A musica " + NomeMusica + " pertence à banda " + Artista; //somente modo leitura

    public Musica(Banda artista)
    {
        Artista = artista;
    }

    public Musica(Banda artista, string nomeMusica, int duracao) : this(artista)
    {
        NomeMusica = nomeMusica;
        Duracao = duracao;
    }

    /*     public void EscreveDisponivel(bool value)
         {
             disponivel = value;
         }

         public bool RetornoDisponivel()
         {
             return disponivel;
        } */

    public void FichaTecnica()
    {
        Console.WriteLine($"Nome da faixa: {NomeMusica}");
        Console.WriteLine($"Artista: {Artista.NomeBanda}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel == true)
        {
            Console.WriteLine("Disponível no plano");
        }
        else
        {
            Console.WriteLine("Infelizmente essa faixa está indisponível no momento");

        }
        Console.WriteLine(DescricaoResum);
    }
}