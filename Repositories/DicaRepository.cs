using EduX_API.Contexts;
using EduX_API.Domains;
using EduX_API.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduX_API.Repositories
{
    public class DicaRepository : IDica
    {
        private readonly EduXContext _ctx;

        public DicaRepository()
        {
            _ctx = new EduXContext();
        }

        public void Alterar(Guid id, Dica dica)
        {
            try
            {
                Dica dicaTemp = BuscarPorID(id);

                dicaTemp.Curtida = dica.Curtida;
                dicaTemp.Imagem  = dica.Imagem;
                dicaTemp.Texto   = dica.Texto;

                _ctx.Dica.Update(dicaTemp);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public Dica BuscarPorID(Guid id)
        {
            try
            {
                return _ctx.Dica.Find(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Cadastrar(Dica dica)
        {
            try
            {
                _ctx.Dica.Add(dica);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Excluir(Guid id)
        {
            try
            {
                Dica dica = BuscarPorID(id);

                if (dica == null) 
                    throw new Exception("Produto não encontrado.");

                _ctx.Dica.Remove(dica);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public List<Dica> ListarTodos()
        {
            try
            {
                return _ctx.Dica.ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
