using ScreenSound.Modelos;

namespace ScreenSound.GestaoMenus;

internal class MenuMediaBanda : Menu
{

    internal void Executar(Dictionary<string, Banda> bandasListadas)
    {
        Console.Clear();
        AlinharTitulo("AVALIAR BANDA");
        Console.Write("Que banda você deseja avaliar? ");
        string nomeBanda = Console.ReadLine()!;
        if (bandasListadas.ContainsKey(nomeBanda))
        {
            Banda banda = bandasListadas[nomeBanda];
            Console.WriteLine($"A nota média de {nomeBanda} é {banda.Media}");
            Console.WriteLine("Digite qualquer tecla para voltar ao menu principal");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine($"A banda {nomeBanda} não foi registrada");
            Console.WriteLine("Digite qualquer tecla para voltar ao menu principal");
            Console.ReadKey();

        }
    }
}