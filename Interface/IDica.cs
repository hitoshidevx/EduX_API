using EduX_API.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduX_API.Interface
{
    interface IDica
    {

        List<Dica> ListarTodos();
        Dica BuscarPorID(Guid id);
        void Cadastrar(Dica dica);
        void Alterar(Guid id, Dica dica);
        void Excluir(Guid id);
    }
}
