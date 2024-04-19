using SoundStore_POO.Menus;
using SoundStore_POO.Models;

namespace SoundStore_POO.Menus;

internal class MenuAvaliarGrupo : Menu
{

    public override void Executar(Dictionary<string, Grupo> gruposRegistrados)
    {
        base.Executar(gruposRegistrados);
        ExibirTituloDaOpcao("Avaliar Grupo");
        Console.Write("Digite o nome do Grupo que deseja avaliar: ");
        string nomeDoGrupo = Console.ReadLine()!;
        if (gruposRegistrados.ContainsKey(nomeDoGrupo))
        {
            Grupo grupo = gruposRegistrados[nomeDoGrupo];
            Console.Write($"Qual a nota que o Grupo {nomeDoGrupo} merece: ");
            Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
            grupo.AdicionarNota(nota);
            Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para o Grupo {nomeDoGrupo}");
            Thread.Sleep(2000);
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
