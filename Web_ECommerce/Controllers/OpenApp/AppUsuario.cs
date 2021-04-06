using ApplicationApp.Interfaces;
using Domain.Interfaces.InterfaceServices;
using Domain.Interfaces.InterfaceUsuario;
using Entities.Entities;
using Entities.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationApp.OpenApp
{
    public class AppUsuario : InterfaceUsuarioApp
    {
        private readonly IUsuario _IUsuario;
        private readonly IServiceUsuario _IServiceUsuario;
        public AppUsuario(IUsuario IUsuario, IServiceUsuario IServiceUsuario)
        {
            _IUsuario = IUsuario;
            _IServiceUsuario = IServiceUsuario;
        }

        public async Task AtualizarTipoUsuario(string userID, TipoUsuario tipoUsuario)
        {
            await _IUsuario.AtualizarTipoUsuario(userID, tipoUsuario);
        }

        public async Task<Usuario> ObterUsuarioPeloID(string userID)
        {
            return await _IUsuario.ObterUsuarioPeloID(userID);
        }

        public async Task<List<Usuario>> ListarUsuarioSomenteParaAdministradores(string userID)
        {
            return await _IServiceUsuario.ListarUsuarioSomenteParaAdministradores(userID);
        }

        public async Task<List<Usuario>> List()
        {
            return await _IUsuario.List();
        }

        public async Task Add(Usuario Objeto)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(Usuario Objeto)
        {
            throw new NotImplementedException();
        }

        public async Task<Usuario> GetEntityById(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task Update(Usuario Objeto)
        {
            throw new NotImplementedException();
        }


    }
}
