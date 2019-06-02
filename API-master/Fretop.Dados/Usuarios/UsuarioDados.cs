using System;
using System.Collections.Generic;
using Fretop.Infraestrutura.Classes;

namespace Fretop.Dados.Usuarios
{
    /// <summary>
    /// Classe de Dados para Usuários
    /// </summary>
    public class UsuarioDados : IUsuarioDados
    {
        #region ATRIBUTOS E CONSTRUTOR

        /// <summary>
        /// Metodo contrutor
        /// </summary>
        /// <param name="db"></param>
        public UsuarioDados()
        {
        }

        #endregion

        #region USUARIO

        /// <summary>
        /// Metodo responsavel por buscar todos usuarios
        /// </summary>
        /// <returns></returns>
        public IList<Usuario> BuscaTodosUsuario()
        {
            return this.PopulaUsuarios();
        }

        /// <summary>
        /// Metodo responsavel por salvar o usuario
        /// </summary>
        /// <param name="Usuario"></param>
        /// <returns></returns>
        public Usuario SalvaUsuario(Usuario usuario)
        {
            return usuario;
        }

        /// <summary>
        /// Metodo responsavel por alterar o usuario 
        /// </summary>
        /// <param name="usuario"></param>
        public Usuario AlteraUsuario(Usuario usuario)
        {
            return usuario;
        }


        /// <summary>
        /// Metodo responsavel por selecionar o Usuário
        /// </summary>
        /// <param name="Usuario"></param>
        /// <returns></returns>
        public Usuario SelecionaUsuarioPorLogin(String usuario)
        {
            return new Usuario();
        }

        public bool SelecionaUsuarioLoginSenha(string login, string senha)
        {
            return true;
        }
        #endregion

        public IList<Usuario> PopulaUsuarios()
        {
            var lista = new List<Usuario>();

            var usuario1 = new Usuario();
            usuario1.nome = "Teste";

            lista.Add(usuario1);

            return lista;
        }

    }
}
