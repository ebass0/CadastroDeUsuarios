using App.Modelos;

namespace App.Menus;

internal class MenuListarUsuarios
{
    public void Executar(Dictionary<string, Usuario> usuarios)
    {
        Console.Clear();
        Console.WriteLine("Exibindo todos os usuários cadastrados:\n");

        foreach (string usuario in usuarios.Keys)
        {
            Console.WriteLine($"Usuário: {usuario}");
        }

        Console.Write("\nDigite uma tecla para voltar ao menu principal: ");
        Console.ReadKey();
        Console.Clear();
    }
}
