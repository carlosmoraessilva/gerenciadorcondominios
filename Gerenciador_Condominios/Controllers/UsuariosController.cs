﻿using Gerenciador_Condominios.BLL.Models;
using Gerenciador_Condominios.DAL.Interfaces;
using Gerenciador_Condominios.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Gerenciador_Condominios.Controllers
{
    
    public class UsuariosController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly IWebHostEnvironment _webHostEnviroment;

        public UsuariosController(IUsuarioRepositorio usuarioRepositorio, IWebHostEnvironment webHostEnvironment)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _webHostEnviroment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Registro()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Registro(RegistroViewModel model, IFormFile foto)
        {
            if(ModelState.IsValid)
            {
                if(foto != null)
                {
                    string diretorioPasta = Path.Combine(_webHostEnviroment.WebRootPath, "Imagens");
                    string nomeFoto = Guid.NewGuid().ToString() + foto.FileName;

                    using (FileStream fileStream = new FileStream(Path.Combine(diretorioPasta, nomeFoto), FileMode.Create))
                    {
                        await foto.CopyToAsync(fileStream);
                        model.Foto = "~/Imagens/" + nomeFoto;
                    }
                }

                Usuario usuario = new Usuario();
                IdentityResult usuarioCriado;

                if(_usuarioRepositorio.VerificarSeExisteRegistro() == 0)
                {
                    usuario.UserName = model.Nome;
                    usuario.CPF = model.CPF;
                    usuario.Email = model.Email;
                    usuario.Foto = model.Foto;
                    usuario.PhoneNumber = model.Telefone;
                    usuario.PrimeiroAcesso = false;
                    usuario.Status = StatusConta.Aprovado;

                    usuarioCriado = await _usuarioRepositorio.CriarUsuario(usuario, model.Senha);

                    if (usuarioCriado.Succeeded)
                    {
                        await _usuarioRepositorio.IncluirUsuarioEmFuncao(usuario, "Administrador");
                        await _usuarioRepositorio.LogarUsuario(usuario, false);
                        return RedirectToAction("Index", "Usuarios");
                    }
                }

                usuario.UserName = model.Nome;
                usuario.CPF = model.CPF;
                usuario.Email = model.Email;
                usuario.Foto = model.Foto;
                usuario.PhoneNumber = model.Telefone;
                usuario.PrimeiroAcesso = false;
                usuario.Status = StatusConta.Analisando;

                usuarioCriado = await _usuarioRepositorio.CriarUsuario(usuario, model.Senha);

                if (usuarioCriado.Succeeded)
                {
                    return View("Analise", usuario.UserName);
                }
                else
                {
                    foreach (IdentityError erro in usuarioCriado.Errors)
                    {
                        ModelState.AddModelError("", erro.Description);

                    }

                    return View(model);
                }

            }
            return View(model);
        }

        public IActionResult Analise(string nome)
        {
            return View(nome);
        }
    }
}
