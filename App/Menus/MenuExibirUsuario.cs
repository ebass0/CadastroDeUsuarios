using App.Modelos;

namespace App.Menus;

internal class MenuExibirUsuario
{
    public void Executar(Dictionary<string, Usuario> usuarios, string usuarioLogado)
    {
        Console.Clear();
        Usuario usuario = usuarios[usuarioLogado];
        Console.WriteLine($"Olá {usuario.Nome}!");
        Console.WriteLine("\nInformações do usuário: ");
        Console.WriteLine($"Nome: {usuario.Nome}");
        Console.WriteLine($"E-mail: {usuario.Email}");
        Console.WriteLine($"Senha: {usuario.Senha}");
    }
}
