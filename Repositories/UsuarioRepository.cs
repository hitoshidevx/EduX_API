using EduX_API.Contexts;
using EduX_API.Domains;
using EduX_API.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduX_API.Repositories
{
    public class UsuarioRepository : IUsuario
    {
        private readonly EduXContext _ctx;

        public UsuarioRepository()
        {
            _ctx = new EduXContext();
        }
        public void Adicionar(Usuario u)
        {
            _ctx.Usuario.Add(u);
            _ctx.SaveChanges();
        }

        public void Alterar(Guid id, Usuario u)
        {
            try
            {
                Usuario usuario = BuscarPorId(id);

                usuario.Nome = u.Nome;
                usuario.Email = u.Email;
                usuario.Senha = u.Senha;
                usuario.DataCadastro = u.DataCadastro;
                usuario.DataUltimoAcesso = u.DataUltimoAcesso;

                _ctx.Usuario.Update(usuario);
                _ctx.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Usuario BuscarPorId(Guid id)
        {
            try
            {
                return _ctx.Usuario.Find(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Usuario> ListarTodos()
        {
            try
            {
                return _ctx.Usuario.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Remover(Guid id)
        {
            try
            {
                Usuario usuario = BuscarPorId(id);

                if (usuario == null)
                {
                    throw new Exception("Usuario inexistente!");
                }

                _ctx.Usuario.Remove(usuario);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
