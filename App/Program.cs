using App.Menus;
using App.Modelos;
Dictionary<string, Usuario> usuarios = new();

MenuPrincipal menuPrincipal = new();

menuPrincipal.Executar(usuarios);