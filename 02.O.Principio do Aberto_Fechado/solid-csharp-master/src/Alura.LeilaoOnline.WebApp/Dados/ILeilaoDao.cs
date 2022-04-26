using Alura.LeilaoOnline.WebApp.Models;
using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Dados
{
    public interface ILeilaoDao
    {
        IEnumerable<Categoria> BuscarTodasCategorias();       
        IEnumerable<Leilao> BuscarTodosLeiloes();
        
        Leilao BuscarPorId(int id);
        void Incluir(Leilao model);
        void Alterar(Leilao model);
        void Excluir(Leilao leilao);
    }
}
