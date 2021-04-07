using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TccPuc.Model;

namespace TccPuc.Dominio.Servicos
{
    public interface IGestaoDeConsultoriaAcessoria
    {
        Task<IEnumerable<Consultancies>> ListAsync();

        Task AddAsync(Consultancies standards);

        void Add(Consultancies standards);

        Task<Consultancies> FindByIdAsync(int id);

        void Remove(Consultancies standards);

        void Update(Consultancies standards);
    }
}
