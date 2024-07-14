using ScreenSound.Modelos;

namespace ScreenSound.GestaoMenus;

internal class AvaliarBandas : Menu
{

    public void Executar(Dictionary<string, Banda> bandasListadas)
    {
        Console.Clear();
        AlinharTitulo("AVALIAR BANDA");
        Console.Write("Que banda você deseja avaliar? ");
        string nomeBanda = Console.ReadLine()!;
        if (bandasListadas.ContainsKey(nomeBanda))
        {
            Banda banda = bandasListadas[nomeBanda];
            Console.Write($"Que nota você dá para a banda {nomeBanda}? ");
            Avaliacao nota = Avaliacao.Parse(Console.ReadLine());
            banda.AdicionarNota(nota);
            Console.WriteLine($"\nA banda {nomeBanda} foi avaliada com sucesso, com a nota {nota.Nota}");
            Console.Clear();
            Thread.Sleep(2000);
        }
        else
        {
            Console.WriteLine($"A banda {nomeBanda} não foi registrada");
            Console.WriteLine("Digite uma tecla pra voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();

        }
    }
}