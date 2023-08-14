using App.Menus;
using App.Modelos;
Dictionary<string, Usuario> usuarios = new();

void Logo()
{
    Console.WriteLine("Seja bem vindo(a) ao IEJPN!");
    Console.WriteLine("--- SISTEMA DE USUÁRIOS ---\n");
}
void MenuInicial()
{
    while (true)
    {
        Logo();
        Console.WriteLine("Digite 1 para registrar um novo cadastro");
        Console.WriteLine("Digite 2 para listar os usuários cadastrados");
        Console.WriteLine("Digite 3 para exibir detalhes");
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
                MenuListarUsuarios listarUsuarios = new();
                listarUsuarios.Executar(usuarios);
                break;
            case 3:
                MenuExibirDetalhes exibirDetalhes = new();
                exibirDetalhes.Executar(usuarios);
                break;
            case 0:
                Console.Clear();
                Console.WriteLine("Saindo o Sistema de Usuários...");
                Thread.Sleep(1000);
                return;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }
    }
}
MenuInicial();