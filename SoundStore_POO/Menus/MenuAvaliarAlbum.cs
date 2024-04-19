using SoundStore_POO.Menus;
using SoundStore_POO.Models;

namespace SoundStore_POO.Menus;

internal class MenuAvaliarAlbum : Menu
{
    public override void Executar(Dictionary<string, Grupo> gruposRegistrados)
    {
        base.Executar(gruposRegistrados);

        ExibirTituloDaOpcao("Avaliar álbum");
        Console.Write("Digite o nome do Grupo que deseja avaliar: ");
        string nomeDoGrupo = Console.ReadLine()!;
        if (gruposRegistrados.ContainsKey(nomeDoGrupo))
        {
            Grupo grupo = gruposRegistrados[nomeDoGrupo];
            Console.Write("Agora digite o título do álbum: ");
            string tituloAlbum = Console.ReadLine()!;
            if (grupo.Albuns.Any(a => a.Nome.Equals(tituloAlbum)))
            {
                Album album = grupo.Albuns.First(a => a.Nome.Equals(tituloAlbum));
                Console.Write($"Qual a nota que o álbum {tituloAlbum} merece: ");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                album.AdicionarNota(nota);
                Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para o álbum {tituloAlbum}");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else
            {
                {
                    Console.WriteLine($"\nO álbum {tituloAlbum} não foi encontrado!");
                    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
