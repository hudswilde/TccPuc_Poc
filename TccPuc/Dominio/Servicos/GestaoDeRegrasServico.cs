using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TccPuc.Model;

namespace TccPuc.Dominio.Servicos
{
    public class GestaoDeRegrasServico : IGestaoDeRegrasServico
    {
        private readonly ApplicationDbContext _context;

        public GestaoDeRegrasServico(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Standards>> ListAsync()
        {
            return await _context.Standards.ToListAsync();
        }

        public async Task AddAsync(Standards standards)
        {
            await _context.Standards.AddAsync(standards);
            await _context.SaveChangesAsync();
        }

        public void Add(Standards standards)
        {
            _context.Standards.Add(standards);
            _context.SaveChanges();
        }


        public async Task<Standards> FindByIdAsync(int id)
        {
            return await _context.Standards.FindAsync(id);
        }

        public void Remove(Standards standards)
        {
            _context.Standards.Remove(standards);
            _context.SaveChanges();
        }

        public void Update(Standards standards)
        {
            _context.Standards.Update(standards);
            _context.SaveChanges();
        }
    }
}
