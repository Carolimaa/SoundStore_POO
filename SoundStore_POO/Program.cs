using SoundStore_POO.Menus;
using SoundStore_POO.Models;
using System.Text.RegularExpressions;

Grupo soweto = new Grupo("Soweto");
soweto.AdicionarNota(new Avaliacao(10));
soweto.AdicionarNota(new Avaliacao(8));
soweto.AdicionarNota(new Avaliacao(6));
Grupo sensacao = new Grupo("Sensação");

Dictionary<string, Grupo> gruposRegistrados = new();
gruposRegistrados.Add(soweto.Nome, soweto);
gruposRegistrados.Add(sensacao.Nome, sensacao);

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarGrupo());
opcoes.Add(2, new MenuRegistrarAlbum());
opcoes.Add(3, new MenuMostrarGruposRegistrados());
opcoes.Add(4, new MenuAvaliarGrupo());
opcoes.Add(5, new MenuAvaliarAlbum());
opcoes.Add(6, new MenuExibirDetalhes());
opcoes.Add(-1, new MenuSair());

void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░███╗░░░███╗██████╗░░█████╗░░░░░░░░██████╗██╗░░██╗░█████╗░░██╗░░░░░░░██╗████████╗██╗███╗░░░███╗███████╗
██╔════╝██╔══██╗████╗░████║██╔══██╗██╔══██╗░░░░░░██╔════╝██║░░██║██╔══██╗░██║░░██╗░░██║╚══██╔══╝██║████╗░████║██╔════╝
╚█████╗░███████║██╔████╔██║██████╦╝███████║█████╗╚█████╗░███████║██║░░██║░╚██╗████╗██╔╝░░░██║░░░██║██╔████╔██║█████╗░░
░╚═══██╗██╔══██║██║╚██╔╝██║██╔══██╗██╔══██║╚════╝░╚═══██╗██╔══██║██║░░██║░░████╔═████║░░░░██║░░░██║██║╚██╔╝██║██╔══╝░░
██████╔╝██║░░██║██║░╚═╝░██║██████╦╝██║░░██║░░░░░░██████╔╝██║░░██║╚█████╔╝░░╚██╔╝░╚██╔╝░░░░██║░░░██║██║░╚═╝░██║███████╗
╚═════╝░╚═╝░░╚═╝╚═╝░░░░░╚═╝╚═════╝░╚═╝░░╚═╝░░░░░░╚═════╝░╚═╝░░╚═╝░╚════╝░░░░╚═╝░░░╚═╝░░░░░╚═╝░░░╚═╝╚═╝░░░░░╚═╝╚══════╝");
    Console.WriteLine("Seja Bem-Vinde ao Samba-ShowTime!");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar um grupo");
    Console.WriteLine("Digite 2 para registrar o álbum de um grupo");
    Console.WriteLine("Digite 3 para mostrar todos os grupos");
    Console.WriteLine("Digite 4 para avaliar um grupo");
    Console.WriteLine("Digite 5 para avaliar um álbum");
    Console.WriteLine("Digite 6 para exibir os detalhes de um grupo");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
        menuASerExibido.Executar(gruposRegistrados);
        if (opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine("Opção inválida");
    }
}

ExibirOpcoesDoMenu();