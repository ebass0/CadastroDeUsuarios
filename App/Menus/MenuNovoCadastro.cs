using App.Modelos;
using System.Collections.Generic;

namespace App.Menus;

internal class MenuNovoCadastro
{
    public void Executar(Dictionary<string, Usuario> usuarios)
    {
        Console.Clear();
        Console.WriteLine("Novo Cadastro");
        Console.WriteLine("--------------");

        Console.Write("\nNome: ");
        string nome = Console.ReadLine()!;

        Console.Write("E-mail: ");
        string email = Console.ReadLine()!;

        Console.Write("Senha: ");
        string senha = Console.ReadLine()!;

        Console.Write("\nConfirmar o registro do novo usuário (S/N) ? ");
        string resp = Console.ReadLine()!;

        if(resp.Equals("S", StringComparison.OrdinalIgnoreCase))
        {
            Usuario usuario = new Usuario(nome, email, senha);
            usuarios.Add(email, usuario);
            Console.WriteLine("Cadastro registrado com sucesso!");
        }
        else if (resp.Equals("N", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Operação cancelada!");
        } else
        {
            Console.WriteLine("Opção inválida!");
        }
        Console.Write("\nDigite uma tecla para voltar ao menu principal: ");
        Console.ReadKey();
        Console.Clear();
    }
}
