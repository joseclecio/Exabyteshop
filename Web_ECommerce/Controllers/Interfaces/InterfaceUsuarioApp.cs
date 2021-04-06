using Entities.Entities;
using Entities.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationApp.Interfaces
{
    public interface InterfaceUsuarioApp : InterfaceGenericaApp<Usuario>
    {
        Task<Usuario> ObterUsuarioPeloID(string userID);
        Task AtualizarTipoUsuario(string userID, TipoUsuario tipoUsuario);
        Task<List<Usuario>> ListarUsuarioSomenteParaAdministradores(string userID);
    }
}
