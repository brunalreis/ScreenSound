using ScreenSound.Modelos;

namespace ScreenSound.GestaoMenus;

internal class MenuMostrarBanda : Menu
{
    public void Executar(Dictionary<string, Banda> bandasListadas)
    {
        Console.Clear();
        AlinharTitulo("BANDAS REGISTRADAS");
        foreach (string banda in bandasListadas.Keys)
        {
            Console.WriteLine($"Banda: {banda}");
        }
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}