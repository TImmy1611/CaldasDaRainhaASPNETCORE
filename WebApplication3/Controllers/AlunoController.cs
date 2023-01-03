using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebApplication3.Controllers
{
    public class AlunoController : Controller
    {
        List<string> alunos = new List<string>();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MostraAlunos()
        {
            ViewBag.Alunos = alunos;
            return View("Index");
        }
    }
}
