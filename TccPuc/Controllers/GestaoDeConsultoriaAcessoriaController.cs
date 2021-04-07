using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TccPuc.Dominio.Servicos;
using TccPuc.Model;

namespace TccPuc.Controllers
{
    [Route("/api/[controller]")]
    public class GestaoDeConsultoriaAcessoriaController : Controller
    {
        private readonly IGestaoDeConsultoriaAcessoria gestaoDeConsultoriaAcessoria;
        public GestaoDeConsultoriaAcessoriaController(IGestaoDeConsultoriaAcessoria gestaoDeConsultoriaAcessoria)
        {
            this.gestaoDeConsultoriaAcessoria = gestaoDeConsultoriaAcessoria;
        }

        [Route("/api/[controller]/get")]
        [HttpGet]
        public Consultancies GetConsultancies([FromBody] int id)
        {
            Task<Consultancies> consultancies = gestaoDeConsultoriaAcessoria.FindByIdAsync(id);

            return consultancies.Result;
        }




        [Route("/api/[controller]/delete")]
        [HttpDelete]
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

        [Route("/api/[controller]/post")]
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

        [Route("/api/[controller]/update")]
        [HttpPost]
        public bool PostUpdateStandards([FromBody] Consultancies consultancies)
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
