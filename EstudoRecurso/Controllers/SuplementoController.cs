using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstudoRecurso.Models;


namespace EstudoRecurso.Controllers
{
    public class SuplementoController
    {
        private AppDbContext _context;

        public SuplementoController()
        {
            _context = new AppDbContext();
        }

        public void AdicionarSuplemento(string nome, string marca, string categoria, decimal precoUnidade)
        {
            var suplemento = new Suplementos
            {
                Nome = nome,
                Marca = marca,
                Categoria = categoria,
                PrecoUnidade = precoUnidade
            };
            _context.Suplementos.Add(suplemento);
            _context.SaveChanges();
        }

        public List<Suplementos> ObterTodosSuplementos()
        {
            return _context.Suplementos.ToList();
        }

        public void EliminarSuplemento(int id)
        {
            var suplemento = _context.Suplementos.FirstOrDefault(s => s.Id == id);
            if (suplemento != null)
            {
                _context.Suplementos.Remove(suplemento);
                _context.SaveChanges();
            }
        }
    }
}
