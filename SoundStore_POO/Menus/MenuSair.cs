using SoundStore_POO.Menus;
using SoundStore_POO.Models;

namespace SoundStore_POO.Menus;

internal class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Grupo> gruposRegistrados)
    {
        Console.WriteLine("Até Logo :)");
    }
}
