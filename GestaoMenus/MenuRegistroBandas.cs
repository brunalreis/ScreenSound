using ScreenSound.Modelos;

namespace ScreenSound.GestaoMenus;

internal class MenuRegistrarBandas : Menu
{
    public void Executar(Dictionary<string, Banda> bandasListadas)
    {
        Console.Clear();
        AlinharTitulo("Registro de Banda");
        Console.WriteLine("Digite o nome da banda que deseja registrar");
        string nomeBanda = Console.ReadLine();
        Banda banda = new Banda(nomeBanda);
        bandasListadas.Add(nomeBanda, banda);
        Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso");
        Console.WriteLine("Retornando ao menu");
        Thread.Sleep(2500);
        Console.Clear();
    }
}
