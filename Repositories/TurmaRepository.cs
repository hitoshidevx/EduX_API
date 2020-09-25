using EduX_API.Contexts;
using EduX_API.Domains;
using EduX_API.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduX_API.Repositories
{
    public class TurmaRepository : ITurma
    {
        private readonly EduXContext _ctx;

        public TurmaRepository()
        {
            _ctx = new EduXContext();
        }

        public void Adicionar(Turma t)
        {
            _ctx.Turma.Add(t);
            _ctx.SaveChanges();  
        }

        public void Alterar(Guid id, Turma t)
        {
            try
            {
                Turma turma = BuscarPorId(id);

                turma.Descricao = t.Descricao;

                _ctx.Turma.Update(turma);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Turma BuscarPorId(Guid id)
        {
            try
            {
                return _ctx.Turma.Find(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Turma> ListarTodos()
        {
            try
            {
                return _ctx.Turma.ToList();
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
                Turma turma = BuscarPorId(id);

                if (turma == null){
                    throw new Exception("Turma inexistente!");    
                }

                _ctx.Turma.Remove(turma);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
