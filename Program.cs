
using ScreenSound.Modelos;
using ScreenSound.GestaoMenus;

internal class Program
{
    static void Main(string[] args)
    {
        Banda ira = new Banda("Ira");
        ira.AdicionarNota(new Avaliacao(10));
        ira.AdicionarNota(new Avaliacao(8));
        ira.AdicionarNota(new Avaliacao(7));

        Banda beatles = new Banda("The Beatles");
        beatles.AdicionarNota(new Avaliacao(10));
        beatles.AdicionarNota(new Avaliacao(10));
        beatles.AdicionarNota(new Avaliacao(6));

        Console.Clear();

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
                case 1:
                    MenuRegistrarBandas registrarBandas = new MenuRegistrarBandas();
                    registrarBandas.Executar(bandasListadas); break;
                case 2:
                    MenuMostrarBanda mostrarBandas = new MenuMostrarBanda();
                    mostrarBandas.Executar(bandasListadas); break;


                case 3:
                    AvaliarBandas avaliarBandas = new AvaliarBandas();
                    avaliarBandas.Executar(bandasListadas); break;


                case 4:
                    MenuMediaBanda media = new MenuMediaBanda();
                    media.Executar(bandasListadas); break;


                case 5:
                    MenuRegistrarAlbum menu = new MenuRegistrarAlbum();
                    menu.Executar(bandasListadas); break;


                case 6: Console.WriteLine("Então vai-te embora"); break;
                default: Console.WriteLine("Opção inválida"); break;
            }
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
    }
}




