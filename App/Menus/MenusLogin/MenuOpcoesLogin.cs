using App.Modelos;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace App.Menus.MenusLogin;

internal class MenuOpcoesLogin
{
    public void Executar(Dictionary<string, Usuario> usuarios, string email)
    {
        Usuario usuario = usuarios[email];

        while (true)
        {
            Console.Clear();
            Console.WriteLine($"Seja bem-vindo(a) {usuario.Nome}");
            Console.WriteLine("________________________________________");
            Console.WriteLine("\nDigite 1 para exibir suas informações");
            Console.WriteLine("Digite 2 para alterar uma informação");
            Console.WriteLine("Digite 3 para excluir sua conta");
            Console.WriteLine("Digite 4 para fazer logout");

            Console.Write("\nDigite sua opção: ");
            int opcao = int.Parse(Console.ReadLine()!);

            switch (opcao)
            {
                case 1:
                    MenuExibirUsuario exibirUsuario = new();
                    exibirUsuario.Executar(usuarios, email);
                    break;
                case 2:
                    Console.WriteLine("222");
                    break;
                case 3:
                    Console.WriteLine("333");
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Efetuando logout...");
                    Thread.Sleep(1000);
                    Console.Clear();
                    MenuPrincipal menuPrincipal = new();
                    menuPrincipal.Executar(usuarios);
                    return;
            }
        }
    }
}
