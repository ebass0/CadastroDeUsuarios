namespace App.Modelos;

internal class Usuario
{
    private List<Usuario> nomes = new();
    private List<Usuario> emails = new();
    private List<Usuario> senhas = new();

    public Usuario(string nome, string email, string senha)
    {
        Nome = nome;
        Email = email;
        Senha = senha;
    }

    public string Nome { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }

    public void RegistrarUsuario(Usuario nome, Usuario email, Usuario senha)
    {
        nomes.Add(nome);
        emails.Add(email);
        senhas.Add(senha);
    }
}
