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
    [Route("/api/Standards")]
    public class GestaoDeRegrasController : Controller
    {
        private readonly IGestaoDeRegrasServico gestaoDeRegrasServico;
        public GestaoDeRegrasController(IGestaoDeRegrasServico gestaoDeRegrasServico)
        {
            this.gestaoDeRegrasServico = gestaoDeRegrasServico;
        }

        //[Authorize(Roles = "Administrador")]
        //[Route("/api/[controller]/get")]
        [HttpGet("{id}")]
        public Standards GetStandards(int id)
        {
            Task<Standards> standards = gestaoDeRegrasServico.FindByIdAsync(id);

            return standards.Result;
        }

        [HttpGet]
        public IEnumerable<Standards> GetListStandards()
        {
            Task<IEnumerable<Standards>> standardsList = gestaoDeRegrasServico.ListAsync();

            return standardsList.Result;
        }


        //[Route("/api/[controller]/delete")]
        [HttpDelete("{id}")]
        public bool DeleteStandards( int id)
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

        //[Route("/api/[controller]/post")]
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

        //[Route("/api/[controller]/update")]
        [HttpPut]
        public bool PutUpdateStandards([FromBody] Standards standards)
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
