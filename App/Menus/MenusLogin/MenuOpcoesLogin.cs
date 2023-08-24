using App.Exceptions;
using App.Modelos;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace App.Menus.MenusLogin;

internal class MenuOpcoesLogin
{
    public void Executar(Dictionary<string, Usuario> usuarios, string email)
    {
        try
        {
            Usuario usuario = usuarios[email];

            char opcao = '0';
            while (opcao != '4')
            {
                Console.Clear();
                Console.WriteLine($"Seja bem-vindo(a) {usuario.Nome}");
                Console.WriteLine("________________________________________");
                Console.WriteLine("\nDigite 1 para exibir suas informações");
                Console.WriteLine("Digite 2 para alterar uma informação");
                Console.WriteLine("Digite 3 para excluir sua conta");
                Console.WriteLine("Digite 4 para fazer logout");
                Console.Write("\nDigite sua opção: ");

                try
                {
                    opcao = Console.ReadLine()[0];
                }
                catch (Exception excecao)
                {
                    throw new AppExceptions(excecao.Message);
                }

                switch (opcao)
                {
                    case '1':
                        MenuExibirUsuario exibirUsuario = new();
                        exibirUsuario.Executar(usuarios, email);
                        break;
                    case '2':
                        Console.WriteLine("222");
                        break;
                    case '3':
                        Console.WriteLine("333");
                        break;
                    case '4':
                        Console.Clear();
                        Console.WriteLine("Efetuando logout...");
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Opção inexistente!");
                        break;
                }

            }
        }
        catch (Exception excecao) 
        {
            Console.Clear();
            Console.WriteLine($"{excecao.Message}");
            Console.Write("\nDigite uma tecla para voltar ao menu principal: ");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
