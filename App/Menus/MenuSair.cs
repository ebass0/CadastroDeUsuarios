using App.Modelos;

namespace App.Menus;

internal class MenuSair
{
    public void Executar(Dictionary<string, Usuario> usuarios)
    {
        Console.WriteLine("Saindo o Sistema de Usuários...");
        Thread.Sleep(1000);
        Console.Clear();
    }
}
