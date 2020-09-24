using EduX_API.Contexts;
using EduX_API.Domains;
using EduX_API.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduX_API.Repositories
{
    public class CurtidaRepository : ICurtida
    {

        private readonly EduXContext _ctx;

        public CurtidaRepository()
        {
            _ctx = new EduXContext();
        }

        /// <summary>
        /// Altera uma curtida.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="curtida"></param>
        public void Alterar(Guid id, Curtida curtida)
        {
            try
            {
                Curtida curtidaTemp = BuscarPorID(id);

                _ctx.Curtida.Update(curtidaTemp);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Busca uma curtida pelo id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Curtida BuscarPorID(Guid id)
        {
            try
            {
                return _ctx.Curtida.Find(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Cadastra uma curtida do banco.
        /// </summary>
        /// <param name="curtida"></param>
        public void Cadastrar(Curtida curtida)
        {
            try
            {
                _ctx.Curtida.Add(curtida);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Exclui uma curtida do banco.
        /// </summary>
        /// <param name="id"></param>
        public void Excluir(Guid id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Listar todas as curtidas cadastradas.
        /// </summary>
        /// <returns></returns>
        public List<Curtida> ListarTodos()
        {
            try
            {
                return _ctx.Curtida.ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
