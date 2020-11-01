using System.Web.Mvc;
using TreinamentoMVC.Models;

namespace TreinamentoMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            
            var pessoa = new Pessoa
            {
                PessoaId = 1,
                Nome = "Miguel Batista Ribeiro",
                Tipo = "Administrador"
            };

            // Retorno por ViewData // 
            //ViewData["PessoaId"] = pessoa.PessoaId;
            //ViewData["Nome"] = pessoa.Nome;
            //ViewData["Tipo"] = pessoa.Tipo;

            // Retorno por ViewBag // 
            //ViewBag.Id = pessoa.PessoaId;
            //ViewBag.nome = pessoa.Nome;
            //ViewBag.tipo = pessoa.Tipo;

            return View(pessoa);
        }
        public ActionResult Contato()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Lista(Pessoa pessoa)
        {
            //ViewData["PessoaId"] = pessoa.PessoaId;
            //ViewData["Nome"] = pessoa.Nome;
            //ViewData["Tipo"] = pessoa.Tipo;

            return View(pessoa);
        }
    }
}