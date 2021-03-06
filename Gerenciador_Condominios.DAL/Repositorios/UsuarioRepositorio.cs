using Gerenciador_Condominios.BLL.Models;
using Gerenciador_Condominios.DAL.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;


namespace Gerenciador_Condominios.DAL.Repositorios
{
    public class UsuarioRepositorio : RepositorioGenerico<Usuario>, IUsuarioRepositorio
    {

        private readonly Contexto _contexto;
        private readonly UserManager<Usuario> _gerenciadorUsuarios;
        private readonly SignInManager<Usuario> _gerenciadorLogin;
        public UsuarioRepositorio(Contexto contexto, UserManager<Usuario> gerenciadorUsuarios, SignInManager<Usuario> gerenciadorLogin) : base(contexto)
        {
            _contexto = contexto;
            _gerenciadorUsuarios = gerenciadorUsuarios;
            _gerenciadorLogin = gerenciadorLogin;
        }

        public async Task<IdentityResult> CriarUsuario(Usuario usuario, string senha)
        {
            try
            {
                return await _gerenciadorUsuarios.CreateAsync(usuario, senha);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task IncluirUsuarioEmFuncao(Usuario usuario, string funcao)
        {
            try
            {
                await _gerenciadorUsuarios.AddToRoleAsync(usuario, funcao);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task LogarUsuario(Usuario usuario, bool lembrar)
        {
            try
            {
                 await _gerenciadorLogin.SignInAsync(usuario, lembrar);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task DeslogarUsuario()
        {
            try
            {
                await _gerenciadorLogin.SignOutAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int VerificarSeExisteRegistro()
        {
            try
            {
                return _contexto.Usuarios.Count();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<Usuario> PegarUsuarioPeloEmail(string email)
        {
            try
            {
                return await _gerenciadorUsuarios.FindByEmailAsync(email);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task AtualizarUsuario(Usuario usuario)
        {
            try
            {
                await _gerenciadorUsuarios.UpdateAsync(usuario);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<bool> VerificarSeUsuarioEstaEmFuncao(Usuario usuario, string funcao)
        {
            try
            {
               return await _gerenciadorUsuarios.IsInRoleAsync(usuario, funcao);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<IEnumerable<string>> PegarFuncoesUsuario(Usuario usuario)
        {
            return await _gerenciadorUsuarios.GetRolesAsync(usuario);
        }

        public async Task<IdentityResult> RemoverFuncoesUsuario(Usuario usuario, IEnumerable<string> funcoes)
        {
            try
            {
                return await _gerenciadorUsuarios.RemoveFromRolesAsync(usuario, funcoes);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<IdentityResult> IncluirFuncoesUsuario(Usuario usuario, IEnumerable<string> funcoes)
        {
            try
            {
                return await _gerenciadorUsuarios.AddToRolesAsync(usuario, funcoes);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public async Task<Usuario> PegarUsuarioPeloNome(ClaimsPrincipal usuario)
        {
            try
            {
                return await _gerenciadorUsuarios.FindByNameAsync(usuario.Identity.Name);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<Usuario> PegarUsuarioPeloId(string usuarioId)
        {
            try
            {
                return await _gerenciadorUsuarios.FindByNameAsync(usuarioId);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
