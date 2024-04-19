using SoundStore_POO.Menus;
using SoundStore_POO.Models;

namespace SoundStore_POO.Menus;

internal class MenuRegistrarGrupo : Menu
{
    public override void Executar(Dictionary<string, Grupo> gruposRegistrados)
    {
        base.Executar(gruposRegistrados);
        ExibirTituloDaOpcao("Registro dos Grupos");
        Console.Write("Digite o nome do Grupo que deseja registrar: ");
        string nomeDoGrupo = Console.ReadLine()!;
        Grupo grupo = new Grupo(nomeDoGrupo);
        gruposRegistrados.Add(nomeDoGrupo, grupo);

        Console.WriteLine($"O Grupo {nomeDoGrupo} foi registrado com sucesso!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}
