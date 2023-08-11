using App.Modelos;
using System.Runtime.CompilerServices;

void Logo()
{
    Console.WriteLine("Seja bem vindo(a) ao IEJPN!");
    Console.WriteLine("--- SISTEMA DE USUÁRIOS ---\n");
}
void Menu()
{
    Logo();
    Console.WriteLine("Digite 1 para registrar um novo cadastro");
    Console.WriteLine("Digite 2 para listar os usuários cadastrados");
    Console.WriteLine("Digite 3 para exibir detalhes");
    Console.WriteLine("Digite 0 para sair");

    int opcao = int.Parse(Console.ReadLine()!);

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Acessando a opção 1");
            break;
        case 2:
            Console.WriteLine("Acessando a opção 2");
                break;
        case 3:
            Console.WriteLine("Acessando a opção 3");
            break;
        case 0:
            Console.WriteLine("Saindo o Sistema de Usuários...");
            Thread.Sleep(1000);
            break;
    }
}


Menu();