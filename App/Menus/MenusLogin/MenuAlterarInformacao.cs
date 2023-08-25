using App.Exceptions;
using App.Menus.MenusLogin.EditarInformacoes;
using App.Modelos;

namespace App.Menus.MenusLogin;

internal class MenuAlterarInformacao
{
    public void Executar(Dictionary<string, Usuario> usuarios, string usuarioLogado)
    {
        try
        {
            Usuario usuario = usuarios[usuarioLogado];
            char opcao = '0';
            while (opcao != '4')
            {
                Console.Clear();
                Console.WriteLine($"Olá {usuario.Nome}, qual dado deseja alterar?\n_________________");
                Console.WriteLine("\nDigite 1 para alterar seu nome");
                Console.WriteLine("Digite 2 para alterar seu e-mail");
                Console.WriteLine("Digite 3 para alterar sua senha");
                Console.WriteLine("Digite 4 para voltar ao menu anterior");
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
                        AlterarNome editarNome = new();
                        editarNome.ExecutarAlterarNome(usuarios);
                        break;
                    case '2':
                        Console.WriteLine("222");
                        break;
                    case '3':
                        Console.WriteLine("333");
                        break;
                    case '4':
                        Console.WriteLine("\n\nRetornando ao menu anterior...");
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Opção inexistente");
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
