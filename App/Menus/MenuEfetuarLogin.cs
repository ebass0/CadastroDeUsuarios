using App.Menus.MenusLogin;
using App.Modelos;

namespace App.Menus;

internal class MenuEfetuarLogin
{
    public void Executar(Dictionary<string, Usuario> usuarios)
    {
        Console.Clear();
        Console.WriteLine("Login:");
        Console.Write("\nE-mail: ");
        string email = Console.ReadLine()!;
        Console.Write("Senha: ");
        string senha = Console.ReadLine()!;

        if(usuarios.ContainsKey(email))
        {
            Usuario usuario = usuarios[email];

            if(usuario.Senha == senha)
            {
                MenuExibirUsuario exibirUsuario = new();
                exibirUsuario.Executar(usuarios, email);

                MenuOpcoesLogin opcoesLogin = new();
                opcoesLogin.Executar(usuarios);   
            }
            else
            {
                Console.WriteLine("\nSenha incorreta!");
                Thread.Sleep(1000);

                Console.Write("Deseja tentar novamente (S/N) ? ");
                string resposta = Console.ReadLine()!;

                if (resposta.Equals("S", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Clear();
                    Executar(usuarios);
                }
                else if (resposta.Equals("N", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("\nDigite uma tecla para voltar ao menu principal: ");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("\nOpção inválida!");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Executar(usuarios);
                }
            }
        } 
        else
        {
            Console.WriteLine("E-mail não registrado!");
            Console.Write("\nDigite uma tecla para voltar ao menu principal: ");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
