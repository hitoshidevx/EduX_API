using EduX_API.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduX_API.Interface
{
    interface IAlunoTurma
    {
        List<AlunoTurma> Listar();
        void Adicionar();
        void Remover();
        void Ler();
        void Alterar();
    }
}
