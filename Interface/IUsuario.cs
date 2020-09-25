using EduX_API.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduX_API.Interface
{
    interface IUsuario
    {
        List<Usuario> ListarTodos();
        Usuario BuscarPorId(Guid id);
        void Adicionar(Usuario u);
        void Alterar(Guid id, Usuario u);
        void Remover(Guid id);
    }
}
