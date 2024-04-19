using SoundStore_POO.Menus;
using SoundStore_POO.Models;

namespace SoundStore_POO.Menus;

internal class MenuMostrarGruposRegistrados : Menu
{
    public override void Executar(Dictionary<string, Grupo> gruposRegistrados)
    {
        base.Executar(gruposRegistrados);
        ExibirTituloDaOpcao("Exibindo todos os Grupos registrados na nossa aplicação");

        foreach (string grupo in gruposRegistrados.Keys)
        {
            Console.WriteLine($"Grupo: {grupo}");
        }

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}
