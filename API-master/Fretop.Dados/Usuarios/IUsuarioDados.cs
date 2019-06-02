using Fretop.Infraestrutura.Classes;
using System;
using System.Collections.Generic;

namespace Fretop.Dados.Usuarios
{
    /// <summary>
    /// Classe de Dados para Usuários
    /// </summary>
    public interface IUsuarioDados
    {
        IList<Usuario> BuscaTodosUsuario();
        Usuario SalvaUsuario(Usuario usuario);
        Usuario AlteraUsuario(Usuario usuario);
        Usuario SelecionaUsuarioPorLogin(String usuario);
        bool SelecionaUsuarioLoginSenha(string login, string senha);
    }
}
