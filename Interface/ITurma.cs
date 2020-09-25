using EduX_API.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduX_API.Interface
{
    interface ITurma
    {
        List<Turma> ListarTodos();
        Turma BuscarPorId(Guid id);
        void Adicionar(Turma t);
        void Alterar(Guid id, Turma t);
        void Remover(Guid id);
    }
}