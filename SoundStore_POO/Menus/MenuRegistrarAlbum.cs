using SoundStore_POO.Menus;
using SoundStore_POO.Models;

namespace SoundStore_POO.Menus;

internal class MenuRegistrarAlbum : Menu
{
    public override void Executar(Dictionary<string, Grupo> gruposRegistrados)
    {
        base.Executar(gruposRegistrados);
        ExibirTituloDaOpcao("Registro de álbuns");
        Console.Write("Digite o Grupo cujo álbum deseja registrar: ");
        string nomeDoGrupo = Console.ReadLine()!;
        if (gruposRegistrados.ContainsKey(nomeDoGrupo))
        {
            Console.Write("Agora digite o título do álbum: ");
            string tituloAlbum = Console.ReadLine()!;
            Grupo grupo = gruposRegistrados[nomeDoGrupo];
            grupo.AdicionarAlbum(new Album(tituloAlbum));
            Console.WriteLine($"O álbum {tituloAlbum} de {nomeDoGrupo} foi registrado com sucesso!");
            Thread.Sleep(4000);
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
