using Alura.LeilaoOnline.WebApp.Dados;
using Alura.LeilaoOnline.WebApp.Models;
using System;
using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Services.Handlers
{
    public class DefaultAdminService : IAdminService
    {

        ILeilaoDao _dao;

        public DefaultAdminService(ILeilaoDao dao)
        {
            _dao = dao;
        }

        public void CadastraLeilao(Leilao leilao)
        {

            _dao.Incluir(leilao);

        }

        public IEnumerable<Categoria> ConsultaCategorias()
        {
            return _dao.BuscarTodasCategorias();
        }

        public Leilao ConsultaLeilaoPorId(int id)
        {
            return _dao.BuscarPorId(id);
        }

        public IEnumerable<Leilao> ConsultaLeiloes()
        {
            return _dao.BuscarTodosLeiloes();
        }

        public void FinalizaPregaoDoLeilaoComId(int id)
        {
            var leilao = _dao.BuscarPorId(id);

            if (leilao != null && leilao.Situacao == SituacaoLeilao.Pregao)
            {
                leilao.Situacao = SituacaoLeilao.Finalizado;
                leilao.Termino = DateTime.Now;
                _dao.Alterar(leilao);
            }


        }

        public void IniciaPregaoDoLeilaoComId(int id)
        {
            var leilao = _dao.BuscarPorId(id);

            if (leilao != null && leilao.Situacao == SituacaoLeilao.Rascunho)
            {
                leilao.Situacao = SituacaoLeilao.Pregao;
                leilao.Termino = DateTime.Now;
                _dao.Alterar(leilao);
            }
        }

        public void ModificaLeilao(Leilao leilao)
        {
            _dao.Alterar(leilao);
        }

        public void RemoveLeilao(Leilao leilao)
        {
            _dao.Excluir(leilao);
        }
    }
}
