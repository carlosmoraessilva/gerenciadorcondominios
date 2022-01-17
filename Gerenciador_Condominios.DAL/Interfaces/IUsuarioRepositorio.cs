﻿using Gerenciador_Condominios.BLL.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_Condominios.DAL.Interfaces
{
    public interface IUsuarioRepositorio : IRepositorioGenerico<Usuario>
    {

        int VerificarSeExisteRegistro();
        Task LogarUsuario(Usuario usuario, bool lembrar);

        Task DeslogarUsuario();
        Task<IdentityResult> CriarUsuario(Usuario usuario, string senha);
        Task IncluirUsuarioEmFuncao(Usuario usuario, string funcao);

        Task<Usuario> PegarUsuarioPeloEmail(string email);

        Task AtualizarUsuario(Usuario usuario);
        Task<bool> VerificarSeUsuarioEstaEmFuncao(Usuario usuario, string funcao);
        Task<IEnumerable<string>> PegarFuncoesUsuario(Usuario usuario);
        Task<IdentityResult> RemoverFuncoesUsuario(Usuario usuario, IEnumerable<string> funcoes);
        Task<IdentityResult> IncluirFuncoesUsuario(Usuario usuario, IEnumerable<string> funcoes);
        Task<Usuario> PegarUsuarioPeloNome(ClaimsPrincipal usuario);
    }
}
