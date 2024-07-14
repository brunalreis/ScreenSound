using ScreenSound.Modelos;

namespace ScreenSound.GestaoMenus;

internal class MenuRegistrarAlbum : Menu
{
    internal void Executar(Dictionary<string, Banda> bandasListadas)
    {
        Console.Clear();
        AlinharTitulo("REGISTRAR ALBUM");
        Console.Write("Digite o nome da banda que detém o álbum: ");
        string nomeBanda = Console.ReadLine()!;
        if (bandasListadas.ContainsKey(nomeBanda))
        {
            Console.Write("Agora digite o título do album: ");
            string tituloAlbum = Console.ReadLine()!;
            Banda banda = bandasListadas[nomeBanda];
            banda.AdicionarAlbum(new Album(tituloAlbum));
            Console.WriteLine($"O album {tituloAlbum} da banda {nomeBanda}, foi registrado com sucesso!");
            Thread.Sleep(4000);
            Console.Clear();
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