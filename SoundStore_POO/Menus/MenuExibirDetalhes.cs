using SoundStore_POO.Menus;
using SoundStore_POO.Models;

namespace SoundStore_POO.Menus;

internal class MenuExibirDetalhes : Menu
{
    public override void Executar(Dictionary<string, Grupo> gruposRegistrados)
    {
        base.Executar(gruposRegistrados);
        ExibirTituloDaOpcao("Exibir detalhes do Grupo");
        Console.Write("Digite o nome do Grupo que deseja conhecer melhor: ");
        string nomeDoGrupo = Console.ReadLine()!;
        if (gruposRegistrados.ContainsKey(nomeDoGrupo))
        {
            Grupo grupo = gruposRegistrados[nomeDoGrupo];
            Console.WriteLine(grupo.Resumo);
            Console.WriteLine($"\nA média do Grupo {nomeDoGrupo} é {grupo.Media}.");
            Console.WriteLine("\nDiscografia:");
            foreach (Album album in grupo.Albuns)
            {
                Console.WriteLine($"{album.Nome} -> {album.Media}");
            }

            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nO Grupo {nomeDoGrupo} não foi encontrado!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
