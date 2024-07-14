using ScreenSound.Modelos;

namespace ScreenSound.GestaoMenus;

internal class Menu
{
    public void AlinharTitulo(string titulo)
    {
        int nLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(nLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos);
    }
}