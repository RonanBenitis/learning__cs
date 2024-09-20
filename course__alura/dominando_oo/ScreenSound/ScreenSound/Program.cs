using ScreenSound.Modelos;

Banda ira = new("Ira!");
ira.AddNota(10);
ira.AddNota(8);
ira.AddNota(6);

Banda beatles = new("The Beatles!");



Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistradas.Add(ira.Nome, ira);
bandasRegistradas.Add(beatles.Nome, beatles);

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
}

void ExibirOpcoesMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");

    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNum = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNum)
    {
        case 1:
            RegistrarBandas();
            break;
        case 2:
            RegistrarAlbum();
            break;
        case 3:
            MostrarBandas();
            break;
        case 4:
            AvaliarUmaBanda();
            break;
        case 5:
            ExibirDetalhes();
            break;
        case -1:
            Console.WriteLine("Tchau tchau :)");
            break;
        default:
            Console.Write("Opção inválida");
            break;
    }
}

void RegistrarAlbum()
{
    Console.Clear();
    ExibirTituloOpcao("Registro de álbuns");
    Console.Write("Digite a banda cujo álbum deseja registrar: ");
    string nomeBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        Console.Write("Agora digite o título do álbum: ");
        string tituloAlbum = Console.ReadLine()!;

        Banda banda = bandasRegistradas[nomeBanda];
        banda.AddAlbum(new Album(tituloAlbum));
        Console.WriteLine($"O álbum {tituloAlbum} de {nomeBanda} foi registrado com sucesso!");

        Thread.Sleep(4000);
        Console.Clear();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
        ExibirOpcoesMenu();

}

void RegistrarBandas()
{
    Console.Clear();
    ExibirTituloOpcao("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeBanda = Console.ReadLine()!;
    Banda banda = new(nomeBanda);
    bandasRegistradas.Add(nomeBanda, banda);
    Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!");
    Thread.Sleep(2000); // Número representado em ms (milisegundo)
    Console.Clear();
    ExibirOpcoesMenu();
}

void MostrarBandas()
{
    Console.Clear();
    ExibirTituloOpcao("Exibindo todas as bandas registradas");

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}

void ExibirTituloOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Banda banda = bandasRegistradas[nomeDaBanda];
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        banda.AddNota(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}!");
        Thread.Sleep(4000); // 2000 milisegundos
        Console.Clear();
        ExibirOpcoesMenu();
    } 
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal...");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();
    }
}

void ExibirDetalhes()
{
    Console.Clear();
    ExibirTituloOpcao("Exibir detalhes da banda");
    Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
    string nomeBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        Banda banda = bandasRegistradas[nomeBanda];
        Console.WriteLine($"\nA média da banda {nomeBanda} é {banda.Media}.");
        /*
         * Completa função
         */
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();
    }
}

ExibirOpcoesMenu();