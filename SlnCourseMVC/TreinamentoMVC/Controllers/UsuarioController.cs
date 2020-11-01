﻿using System.Collections.ObjectModel;
using System.Linq;
using System.Web.Mvc;
using TreinamentoMVC.Models;

namespace TreinamentoMVC.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Usuario()
        {
            var usuario = new Usuario();

            return View(usuario);
        }

        [HttpPost]
        public ActionResult Usuario(Usuario usuario)
        {   // Validações não recomendadas
            if (string.IsNullOrEmpty(usuario.Nome))
            {
                ModelState.AddModelError("Nome", "Campo nome é obrigatório");
            }
            if (usuario.Senha != usuario.ConfirmaSenha)
            {
                ModelState.AddModelError("", "As senhas são diferentes");
            }

            if (ModelState.IsValid)
            {
                return View("Resultado", usuario);
            }
            return View(usuario);
        }
        public ActionResult Resultado(Usuario usuario)
        {
            return View(usuario);
        }
        public ActionResult LoginUnico(string login)
        {
            var bdExemplo = new Collection<string>
            {
            "Miguel",
            "Klenio",
            "Sandra",
            "Crislayne",
            };
            return Json(bdExemplo.All(x => x.ToLower() != login.ToLower()), JsonRequestBehavior.AllowGet);
        }
    }
}