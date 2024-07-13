
using ScreenSound.Modelos;

Banda ira = new Banda("Ira");
ira.AdicionarNota(8);
ira.AdicionarNota(10);
ira.AdicionarNota(7);

Banda beatles = new Banda("The Beatles");
beatles.AdicionarNota(10);
beatles.AdicionarNota(10);
beatles.AdicionarNota(6);

Console.Clear();

//List<string> listaBandas = new List<string> { "Banda Uó", "Aviões do Forró", "The Lumineers", "É o Tchan" };

Dictionary<string, Banda> bandasListadas = new();
bandasListadas.Add(ira.NomeBanda, ira);
bandasListadas.Add(beatles.NomeBanda, beatles);


void ExibirBoasVindas()
{
    string boasVindas = "Boas vindas ao \n";
    string logo = @"𝕤 𝕔 𝕣 𝕖 𝕖 𝕟   𝕤 𝕠 𝕦 𝕟 𝕕 ";
    Console.WriteLine(boasVindas);
    Console.WriteLine(logo);
}
void Menu()
{
    ExibirBoasVindas();
    Console.WriteLine("\n \n Digite o que deseja fazer: \n");
    Console.WriteLine("1. Registrar uma banda");
    Console.WriteLine("2. Mostrar todas as bandas");
    Console.WriteLine("3. Avaliar uma banda");
    Console.WriteLine("4. Exibir média de uma banda");
    Console.WriteLine("5. Registrar o album de uma banda");
    Console.WriteLine("6. Sair");
    var escolha = int.Parse(Console.ReadLine());
    switch (escolha)
    {
        case 1: RegistroBanda(); break;
        case 2: MostratBandas(); break;
        case 3: AvaliarBanda(); break;
        case 4: MediaBanda(); break;
        case 5: RegistrarAlbum(); break;
        case 6: Console.WriteLine("Então vai-te embora"); break;
        default: Console.WriteLine("Opção inválida"); break;
    }
}
void RegistroBanda()
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
    Menu();
}
void MostratBandas()
{
    Console.Clear();
    AlinharTitulo("BANDAS REGISTRADAS");
    // for (int i = 0; i < listaBandas.Count; i++)
    // {
    //   Console.WriteLine($"Banda: {listaBandas[i]}");
    //}
    foreach (string banda in bandasListadas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    Menu();
}
void AvaliarBanda()
{
    //digite a banda que deseja avaliar
    //se a banda existir no dicionario >> atribuir uma nota a ela
    //senao, voltar ao menu principal
    Console.Clear();
    AlinharTitulo("AVALIAR BANDA");
    Console.Write("Que banda você deseja avaliar? ");
    string nomeBanda = Console.ReadLine()!;
    if (bandasListadas.ContainsKey(nomeBanda))
    {
        Banda banda = bandasListadas[nomeBanda];
        Console.Write($"Que nota você dá para a banda {nomeBanda}? ");
        int nota = int.Parse(Console.ReadLine()!);
        banda.AdicionarNota(nota);
        Console.WriteLine($"\nA banda {nomeBanda} foi avaliada com sucesso, com a nota {nota}");
        Console.Clear();
        Thread.Sleep(2000);
        Menu();
    }
    else
    {
        Console.WriteLine($"A banda {nomeBanda} não foi registrada");
        Console.WriteLine("Digite uma tecla pra voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        Menu();
    }
}
void MediaBanda()
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
        Menu();
    }
    else
    {
        Console.WriteLine($"A banda {nomeBanda} não foi registrada");
        Console.WriteLine("Digite qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        Menu();
    }
}
void AlinharTitulo(string titulo)
{
    int nLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(nLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos);
}
void RegistrarAlbum()
{
    Console.Clear();
    AlinharTitulo("REGISTRAR ALBUM");
    Console.Write("Digite o nome do album que deseja registrar: ");
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

    Menu();
}










Menu();

Episodios ep1 = new(1, "Bailarina", 12);
ep1.AddConvidados("Mabê");
ep1.AddConvidados("Carol Moreira");
Console.WriteLine(ep1.Resumo);

Episodios ep2 = new(2, "Firma", 10);
ep2.AddConvidados("Foquinha");
ep2.AddConvidados("André");
Console.WriteLine(ep2.Resumo);

Podcast nInviabilize = new Podcast("Não Inviabilize", "Déia Freitas");
nInviabilize.AdicionarEpisodio(ep1);
nInviabilize.AdicionarEpisodio(ep2);
nInviabilize.ExibirDetalhes();


