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
        while (true)
        {
            Logo();
            Console.WriteLine("Digite 1 para registrar um novo cadastro");
            Console.WriteLine("Digite 2 para fazer login");
            Console.WriteLine("Digite 3 para listar os usuários cadastrados");
            Console.WriteLine("Digite 4 para exibir detalhes");
            Console.WriteLine("Digite 0 para sair");

            Console.Write("\nDigite a sua opção: ");
            int opcao = int.Parse(Console.ReadLine()!);

            switch (opcao)
            {
                case 1:
                    MenuNovoCadastro novoCadastro = new();
                    novoCadastro.Executar(usuarios);
                    break;
                case 2:
                    MenuEfetuarLogin efetuarLogin = new();
                    efetuarLogin.Executar(usuarios);
                    break;
                case 3:
                    MenuListarUsuarios listarUsuarios = new();
                    listarUsuarios.Executar(usuarios);
                    break;
                case 4:
                    MenuExibirDetalhes exibirDetalhes = new();
                    exibirDetalhes.Executar(usuarios);
                    break;
                case 0:
                    MenuSair sair = new();
                    sair.Executar(usuarios);
                    return;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }
}
