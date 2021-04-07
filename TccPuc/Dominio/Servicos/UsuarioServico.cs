using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TccPuc.Model;

namespace TccPuc.Dominio.Servicos
{
    public class UsuarioServico : IUsuarioServico
    {
        private readonly ApplicationDbContext _context;
        public UsuarioServico(ApplicationDbContext context)
        {
            _context = context;
        }

        public Usuario Get(String email)
        {
            Usuario usuario =  _context.Usuario.Where(x => x.Email == email).FirstOrDefault();
            usuario.Perfil = _context.Perfil.Find(usuario.idPerfil);
            return usuario;
            
        }

        public Usuario Post(Usuario usuario)
        {
            usuario.Senha = usuario.Senha = GerarHashMd5.Gerar(usuario.Senha);
            usuario.DataCriacao = DateTime.Now;
            _context.Usuario.Add(usuario);
            _context.SaveChanges();
            return usuario;

        }
    }
}
