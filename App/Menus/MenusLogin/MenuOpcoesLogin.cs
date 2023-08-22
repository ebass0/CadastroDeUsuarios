using App.Modelos;
using System.Security.Principal;

namespace App.Menus.MenusLogin;

internal class MenuOpcoesLogin
{
    public void Executar(Dictionary<string, Usuario> usuarios)
    {
        Console.WriteLine("________________________________________");
        Console.WriteLine("\nDigite 1 para alterar uma informação");
        Console.WriteLine("Digite 2 para excluir sua conta");
        Console.WriteLine("Digite 3 para fazer logout");

        Console.Write("Digite sua opção: ");
        int opcao = int.Parse(Console.ReadLine()!);
        switch (opcao)
        {
            case 1:
                Console.WriteLine("111");
                break;
            case 2:
                Console.WriteLine("222");
                break;
            case 3:
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
