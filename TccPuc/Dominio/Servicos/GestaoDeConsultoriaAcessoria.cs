using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TccPuc.Model;

namespace TccPuc.Dominio.Servicos
{
    public class GestaoDeConsultoriaAcessoria : IGestaoDeConsultoriaAcessoria
    {
        private readonly ApplicationDbContext _context;

        public GestaoDeConsultoriaAcessoria(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Consultancies>> ListAsync()
        {
            return await _context.Consultancies.ToListAsync();
        }

        public async Task AddAsync(Consultancies consultancies)
        {
            await _context.Consultancies.AddAsync(consultancies);
            await _context.SaveChangesAsync();
        }

        public void Add(Consultancies consultancies)
        {
            _context.Consultancies.Add(consultancies);
            _context.SaveChanges();
        }

        public async Task<Consultancies> FindByIdAsync(int id)
        {
            return await _context.Consultancies.FindAsync(id);
        }

        public void Remove(Consultancies consultancies)
        {
            _context.Consultancies.Remove(consultancies);
            _context.SaveChanges();
        }

        public void Update(Consultancies consultancies)
        {
            _context.Consultancies.Update(consultancies);
            _context.SaveChanges();
        }
    }
}
