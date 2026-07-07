using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstudoRecurso.Models; // <-- ADICIONA ESTA LINHA!


namespace EstudoRecurso.Controllers
{
    public class SuplementoController
    {
        private AppDbContext _context; // Agora o Visual Studio já aceita!

        public SuplementoController()
        {
            _context = new AppDbContext();
        }
        //Método para ser chamado pela view
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

        //Método para preencher a DataGridView
        public List<Suplementos> ObterTodosSuplementos()
        {
            return _context.Suplementos.ToList();
        }
    }
}
