using App.Modelos;

namespace App.Menus;

internal class MenuExibirDetalhes
{
    public void Executar(Dictionary<string, Usuario> usuarios)
    {
        Console.Clear();
        Console.WriteLine("Exibir detalhes do usuário: \n");
        Console.Write("Informe o e-mail do usuário que deseja consultar: ");
        string emailDoUsuario = Console.ReadLine()!;
        if(usuarios.ContainsKey(emailDoUsuario))
        {
            Console.Clear();

            Usuario usuario = usuarios[emailDoUsuario];
            Console.WriteLine("Exibindo detalhes do usuário: ");
            Console.WriteLine($"\nNome: {usuario.Nome}");
            Console.WriteLine($"E-mail: {usuario.Email}");

            int qtdLetrasSenha = usuario.Senha.Length;
            string asteriscos = string.Empty.PadLeft(qtdLetrasSenha, '*');
            Console.WriteLine($"Senha: {asteriscos}");

            Console.Write("\nDigite uma tecla para voltar ao menu principal: ");
            Console.ReadKey();
            Console.Clear();
        } else
        {
            Console.WriteLine($"\nO usuário {emailDoUsuario} não foi encontrado!");
            Console.Write("\nDigite uma tecla para voltar ao menu principal: ");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
