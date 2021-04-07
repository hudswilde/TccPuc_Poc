using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TccPuc.Dominio.Servicos;
using TccPuc.Model;
using TccPuc.Model.Request;

namespace TccPuc.Controllers
{
    [Route("/api/[controller]")]
    public class GestaoDeRegrasController : Controller
    {
        private readonly IGestaoDeRegrasServico gestaoDeRegrasServico;
        public GestaoDeRegrasController(IGestaoDeRegrasServico gestaoDeRegrasServico)
        {
            this.gestaoDeRegrasServico = gestaoDeRegrasServico;
        }

        [Authorize(Roles = "Administrador")]
        [Route("/api/[controller]/get")]
        [HttpGet]
        public Standards GetStandards([FromBody] int id)
        {
            Task<Standards> standards = gestaoDeRegrasServico.FindByIdAsync(id);

            return standards.Result;
        }


        [Route("/api/[controller]/delete")]
        [HttpDelete]
        public bool DeleteStandards([FromBody] int id)
        {
            try
            {
                Task<Standards> standards = gestaoDeRegrasServico.FindByIdAsync(id);
                gestaoDeRegrasServico.Remove(standards.Result);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [Route("/api/[controller]/post")]
        [HttpPost]
        public bool PostStandards([FromBody] Standards standards)
        {
            try
            {
                gestaoDeRegrasServico.Add(standards);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [Route("/api/[controller]/update")]
        [HttpPost]
        public bool PostUpdateStandards([FromBody] Standards standards)
        {
            try
            {
                gestaoDeRegrasServico.Update(standards);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
