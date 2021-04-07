using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TccPuc.Model;

namespace TccPuc.Dominio.Servicos
{
    public interface IUsuarioServico
    {
        //Task<IEnumerable<Usuario>> ListAsync();
        Usuario Get(String email);

        Usuario Post(Usuario usuario);

    }
}
