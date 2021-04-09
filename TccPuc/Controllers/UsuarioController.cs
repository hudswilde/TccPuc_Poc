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
    public class UsuarioController : Controller
    {
        private readonly IUsuarioServico usuarioServico;
        public UsuarioController(IUsuarioServico usuarioServico)
        {
            this.usuarioServico = usuarioServico;
        }

        /// <summary>
        /// teste hudson teste hudson teste hudson
        /// </summary>
        [HttpGet]
        //[Route("/api/[controller]/Login")]
        [AllowAnonymous]
        public Usuario GetUsuario([FromBody]RequestGetUsuario request)
        {
            Usuario usuario =  usuarioServico.Get(request.Email);

            if (usuario.Senha == GerarHashMd5.Gerar(request.Senha))
            {
                usuario.Token = "Bearer " + TokenService.GenerateToken(usuario, usuario.Perfil);
                usuario.Senha = "";
                return usuario;
            }
            else
            {
                return null;
            }
        }

        [HttpPost]
        //[Route("/api/[controller]/InserirUsuario")]
        [AllowAnonymous]
        public Usuario PostUsuario([FromBody] Usuario usuario)
        {
            return usuarioServico.Post(usuario);
        }
    }
}
