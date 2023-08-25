using App.Exceptions;
using App.Modelos;

namespace App.Menus;

internal class MenuPrincipal
{
    private void Logo()
    {
        Console.WriteLine("\u001b[1mSeja bem vindo(a) ao IEJPN!\n\u001b[0m");
        Console.WriteLine("\x1B[1;4;45m--- SISTEMA DE USUÁRIOS ---\n\x1B[0m");
    }

    public void Executar(Dictionary<string, Usuario> usuarios)
    {
        try
        {
            char opcao = '0';
            while (opcao != '5')
            {
                Logo();
                Console.WriteLine("Digite 1 para registrar um novo cadastro");
                Console.WriteLine("Digite 2 para fazer login");
                Console.WriteLine("Digite 3 para listar os usuários cadastrados");
                Console.WriteLine("Digite 4 para exibir detalhes");
                Console.WriteLine("Digite 5 para sair");
                Console.Write("\nDigite a sua opção: ");

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
                        MenuNovoCadastro novoCadastro = new();
                        novoCadastro.Executar(usuarios);
                        break;
                    case '2':
                        MenuEfetuarLogin efetuarLogin = new();
                        efetuarLogin.Executar(usuarios);
                        break;
                    case '3':
                        MenuListarUsuarios listarUsuarios = new();
                        listarUsuarios.Executar(usuarios);
                        break;
                    case '4':
                        MenuExibirDetalhes exibirDetalhes = new();
                        exibirDetalhes.Executar(usuarios);
                        break;
                    case '5':
                        MenuSair sair = new();
                        sair.Executar(usuarios);
                        break;
                    default:
                        Console.WriteLine("\nOpção inexistente!");
                        return;
                }
            }

        }
        catch (AppExceptions excecao)
        {
            Console.Clear();
            Console.WriteLine($"{excecao.Message}");
        }
    }
}
