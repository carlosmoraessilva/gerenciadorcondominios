﻿using Gerenciador_Condominios.BLL.Models;
using Gerenciador_Condominios.DAL.Interfaces;
using Gerenciador_Condominios.DAL.Repositorios;
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
        private readonly IFuncaoRepositorio _funcaoRepositorio;
        private readonly IWebHostEnvironment _webHostEnviroment;

        public UsuariosController(IUsuarioRepositorio usuarioRepositorio,IFuncaoRepositorio funcaoRepositorio, IWebHostEnvironment webHostEnvironment)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _funcaoRepositorio = funcaoRepositorio;
            _webHostEnviroment = webHostEnvironment;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _usuarioRepositorio.PegarTodos());
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

        [HttpGet]
        public async Task<IActionResult> Login()
        {
            await _usuarioRepositorio.DeslogarUsuario();
            return View();
        }

        [IgnoreAntiforgeryToken]
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if(ModelState.IsValid)
            {
                Usuario usuario = await _usuarioRepositorio.PegarUsuarioPeloEmail(model.Email);

                if(usuario != null)
                {
                    if(usuario.Status == StatusConta.Analisando)
                    {
                        return View("Analise", usuario.UserName);
                    }
                    else if(usuario.Status == StatusConta.Reprovado)
                    {
                        return View("Reprovado", usuario.UserName);
                    }
                    else if(usuario.PrimeiroAcesso == true)
                    {
                        return View("RedefinirUsuario", usuario);
                    }
                    else
                    {
                        PasswordHasher<Usuario> passwordHasher = new PasswordHasher<Usuario>();

                        if(passwordHasher.VerifyHashedPassword(usuario, usuario.PasswordHash, model.Senha) != PasswordVerificationResult.Failed)
                        {
                            await _usuarioRepositorio.LogarUsuario(usuario, false);
                            return RedirectToAction("Index");
                        }
                        else
                        {
                            ModelState.AddModelError("", "Email e/ou senhas inválidos");
                            return View(model);
                        }
                    }
                }

                else
                {
                    ModelState.AddModelError("", "Email e/ou senhas inválidos");
                    return View(model);
                }
            }

            return View(model);
        }

        [HttpPost]

        public async Task<IActionResult> Logout()
        {
            await _usuarioRepositorio.DeslogarUsuario();
            return RedirectToAction("Login");
        }
        public IActionResult Analise(string nome)
        {
            return View(nome);
        }

        public IActionResult Reprovado(string nome)
        {
            return View(nome);
        }

        public async Task<JsonResult> AprovarUsuario(string usuarioId)
        {
            Usuario usuario = await _usuarioRepositorio.PegarPeloId(usuarioId);
            usuario.Status = StatusConta.Aprovado;
            await _usuarioRepositorio.IncluirUsuarioEmFuncao(usuario, "Morador");
            await _usuarioRepositorio.AtualizarUsuario(usuario);

            return Json(true);

        }

        public async Task<JsonResult> ReprovarUsuario(string usuarioId)
        {
            Usuario usuario = await _usuarioRepositorio.PegarPeloId(usuarioId);
            usuario.Status = StatusConta.Reprovado;
            await _usuarioRepositorio.AtualizarUsuario(usuario);

            return Json(true);

        }

        [HttpGet]
        public async Task<IActionResult> GerenciarUsuario(string usuarioId, string nome)
        {
            if (usuarioId == null)
                return NotFound();

            TempData["usuarioId"] = usuarioId;
            ViewBag.Nome = nome;

            Usuario usuario = await _usuarioRepositorio.PegarPeloId(usuarioId);

            if (usuarioId == null)
                return NotFound();

            List<FuncaoUsuariosViewModel> viewModel = new List<FuncaoUsuariosViewModel>();

            foreach (Funcao funcao in await _funcaoRepositorio.PegarTodos())
            {
                FuncaoUsuariosViewModel model = new FuncaoUsuariosViewModel
                {
                    FuncaoId = funcao.Id,
                    Nome = funcao.Name,
                    Descricao = funcao.Descricao
                };

                if (await _usuarioRepositorio.VerificarSeUsuarioEstaEmFuncao(usuario, funcao.Name))
                {
                    model.isSelecionado = true;
                }

                else
                    model.isSelecionado = false;

                viewModel.Add(model);
            }

            return View(viewModel);

        }

        [HttpPost]
        public async Task<IActionResult> GerenciarUsuario(List<FuncaoUsuariosViewModel> model)
        {
            string usuarioId = TempData["usuarioId"].ToString();

            Usuario usuario = await _usuarioRepositorio.PegarPeloId(usuarioId);

            if (usuario == null)
                return NotFound();

            IEnumerable<string> funcoes = await _usuarioRepositorio.PegarFuncoesUsuario(usuario);
            IdentityResult resultado = await _usuarioRepositorio.RemoverFuncoesUsuario(usuario, funcoes);

            if (!resultado.Succeeded)
            {
                ModelState.AddModelError("", "Não foi possível atualizar as funções dos usuarios");
                return View("GerenciarUsuario", usuarioId);
            }

            resultado = await _usuarioRepositorio.IncluirFuncoesUsuario(usuario,
                model.Where(x => x.isSelecionado == true).Select(x => x.Nome));

            if (!resultado.Succeeded)
            {
                ModelState.AddModelError("", "Não foi possível atualizar as funções dos usuarios");
                return View("GerenciarUsuario", usuarioId);
            }

            return RedirectToAction(nameof(Index));
        }


            
        }
    }

