using EduX_API.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduX_API.Interface
{
    interface IAlunoTurma
    {
        List<AlunoTurma> ListarTodos();
        AlunoTurma BuscarPorId(Guid id);
        void Adicionar(AlunoTurma a);
        void Alterar(Guid id, AlunoTurma a);
        void Remover(Guid id);
    }
}
