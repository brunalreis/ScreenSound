
Console.Clear();

//List<string> listaBandas = new List<string> { "Banda Uó", "Aviões do Forró", "The Lumineers", "É o Tchan" };

Dictionary<string, List<int>> bandasListadas = new Dictionary<string, List<int>>();
bandasListadas.Add("Banda Uo", new List<int> { 10, 8, 9, 7 });
bandasListadas.Add("Avioes do Forro", new List<int> { 7, 8, 6, 5 });



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


