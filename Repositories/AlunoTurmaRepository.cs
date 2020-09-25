using EduX_API.Contexts;
using EduX_API.Domains;
using EduX_API.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduX_API.Repositories
{
    public class AlunoTurmaRepository : IAlunoTurma
    {
        private readonly EduXContext _ctx;

        public AlunoTurmaRepository()
        {
            _ctx = new EduXContext();
        }

        /// <summary>
        /// Adicionar Aluno
        /// </summary>
        /// <param name="a"> Aluno a ser adicionado </param>
        public void Adicionar(AlunoTurma a)
        {
            _ctx.AlunoTurma.Add(a);
            _ctx.SaveChanges();
        }

        public List<AlunoTurma> ListarTodos()
        {
            try
            {
                return _ctx.AlunoTurma.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public AlunoTurma BuscarPorId(Guid id)
        {
            try
            {
                return _ctx.AlunoTurma.Find(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Alterar(Guid id, AlunoTurma a)
        {
            try
            {
                AlunoTurma aluno = BuscarPorId(id);

                aluno.Matricula = a.Matricula;

                _ctx.AlunoTurma.Update(aluno);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Remover(Guid id)
        {
            try { 
                AlunoTurma aluno = BuscarPorId(id);

                if (aluno == null)
                    throw new Exception("Aluno inexistente!");

                _ctx.AlunoTurma.Remove(aluno);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        
        }
    }
}
