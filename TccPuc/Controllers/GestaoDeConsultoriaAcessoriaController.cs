using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TccPuc.Dominio.Servicos;
using TccPuc.Model;

namespace TccPuc.Controllers
{
    [Route("/api/Consultancies")]
    public class GestaoDeConsultoriaAcessoriaController : Controller
    {
        private readonly IGestaoDeConsultoriaAcessoria gestaoDeConsultoriaAcessoria;
        public GestaoDeConsultoriaAcessoriaController(IGestaoDeConsultoriaAcessoria gestaoDeConsultoriaAcessoria)
        {
            this.gestaoDeConsultoriaAcessoria = gestaoDeConsultoriaAcessoria;
        }

        [HttpGet("{id}")]
        public Consultancies GetConsultancies([FromBody] int id)
        {
            Task<Consultancies> consultancies = gestaoDeConsultoriaAcessoria.FindByIdAsync(id);

            return consultancies.Result;
        }


        [HttpGet]
        public IEnumerable<Consultancies> GetListStandards()
        {
            Task<IEnumerable<Consultancies>> consultanciesList = gestaoDeConsultoriaAcessoria.ListAsync();

            return consultanciesList.Result;
        }

        [HttpDelete("{id}")]
        public bool DeleteConsultancies([FromBody] int id)
        {
            try
            {
                Task<Consultancies> consultancies = gestaoDeConsultoriaAcessoria.FindByIdAsync(id);
                gestaoDeConsultoriaAcessoria.Remove(consultancies.Result);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpPost]
        public bool PostConsultancies([FromBody] Consultancies consultancies)
        {
            try
            {
                gestaoDeConsultoriaAcessoria.Add(consultancies);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpPut]
        public bool PutUpdateStandards([FromBody] Consultancies consultancies)
        {
            try
            {
                gestaoDeConsultoriaAcessoria.Update(consultancies);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
