using System;
using EstudoRecurso.Models;

namespace EstudoRecurso.Controllers
{
    public class PlanoController
    {
        private AppDbContext _context;

        public PlanoController()
        {
            _context = new AppDbContext();
        }

        public void FecharPlano(decimal totalGasto)
        {
            // Implementar lógica para guardar o plano na base de dados
            // Por enquanto, apenas confirmamos que foi guardado
        }
    }
}
