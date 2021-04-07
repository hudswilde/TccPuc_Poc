using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TccPuc.Model;

namespace TccPuc.Dominio.Servicos
{
    public interface IGestaoDeRegrasServico
    {

        Task<IEnumerable<Standards>> ListAsync();

        Task AddAsync(Standards standards);

        void Add(Standards standards);

        Task<Standards> FindByIdAsync(int id);

        void Remove(Standards standards);

        void Update(Standards standards);
    }
}
