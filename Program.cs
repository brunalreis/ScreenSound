
Console.Clear();

//List<string> listaBandas = new List<string> { "Banda Uó", "Aviões do Forró", "The Lumineers", "É o Tchan" };

Dictionary<string, List<int>> bandasListadas = new Dictionary<string, List<int>>();
bandasListadas.Add("Banda Uo", new List<int> { 10, 8, 9, 7 });
bandasListadas.Add("Avioes do Forro", new List<int> { 7, 8, 6, 5 });
/*
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
    Console.WriteLine("5. Sair");

    var escolha = int.Parse(Console.ReadLine());
    switch (escolha)
    {
        case 1: RegistroBanda(); break;
        case 2: MostratBandas(); break;
        case 3: AvaliarBanda(); break;
        case 4: MediaBanda(); break;
        case 5: Console.WriteLine("Então vai-te embora"); break;
        default: Console.WriteLine("Opção inválida"); break;

    }
}

void RegistroBanda()
{
    Console.Clear();
    AlinharTitulo("Registro de Banda");
    Console.WriteLine("Digite o nome da banda que deseja registrar");
    string nomeBanda = Console.ReadLine();
    bandasListadas.Add(nomeBanda, new List<int>());
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
        Console.Write($"Que nota você dá para a banda {nomeBanda}? ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasListadas[nomeBanda].Add(nota);
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
        int media = bandasListadas[nomeBanda].Sum() / bandasListadas[nomeBanda].Count();
        Console.WriteLine($"A nota média de {nomeBanda} é {media}");
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

Menu(); */


Banda queen = new Banda("Queen");

Album albumQueen = new Album("A Night at the Opera");

Musica musica1 = new Musica(queen, "Love of my Life", 213)
{
    Disponivel = true, //inicialização de itens opcionais
};

Musica musica2 = new Musica(queen, "Bohemian Rhapsody", 354)
{
    Disponivel = false,
};

albumQueen.AdicionarMusica(musica1);
albumQueen.AdicionarMusica(musica2);

musica1.FichaTecnica();
Console.WriteLine("\n");

musica2.FichaTecnica();
Console.WriteLine("\n");

queen.AdicionarAlbum(albumQueen);
queen.ExibirDiscografia();

