using Alura.LeilaoOnline.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;



namespace Alura.LeilaoOnline.WebApp.Dados.EfCore
{
    public class LeilaoDaoComEfCore : ILeilaoDao
    {

        private AppDbContext _context;

        public LeilaoDaoComEfCore()
        {
            _context = new AppDbContext();
        }

        public Leilao BuscarPorId(int id) => _context.Leiloes.First(l => l.Id == id);

        public IEnumerable<Categoria> BuscarTodasCategorias() => _context.Categorias.Include(c => c.Leiloes).ToList();
        
        public IEnumerable<Leilao> BuscarTodosLeiloes() => _context.Leiloes.Include(l => l.Categoria).ToList();        
        

        public void Incluir(Leilao model)
        {
            _context.Leiloes.Add(model);
            _context.SaveChanges();
        }

        public void Alterar(Leilao model)
        {
            _context.Leiloes.Update(model);
            _context.SaveChanges();
        }

        public void Excluir(Leilao leilao)
        {
            _context.Leiloes.Remove(leilao);
            _context.SaveChanges();
        }
    }
}
