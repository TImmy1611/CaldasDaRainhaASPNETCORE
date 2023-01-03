using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class AlunoDetalhesController : Controller
    {
        List<AlunoDetalhesViewModel> alunos = new List<AlunoDetalhesViewModel>();
        //List<string> contas= new List<string>();

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MostraAlunosDetalhes()
        {
            AlunoDetalhesViewModel aluno = new AlunoDetalhesViewModel();
            AlunoDetalhesViewModel aluno2 = new AlunoDetalhesViewModel();
            AlunoDetalhesViewModel aluno3 = new AlunoDetalhesViewModel();

            aluno.Estudante = new AlunoModel();
            aluno.Estudante.Nome = "Ruca";
            aluno.Estudante.Idade = 23;
            aluno.Conta = new ContaBancariaModel();
            aluno.Conta.Titular = "Ruca Marques";
            aluno.Conta.NrConta = "123456789";

            aluno2.Estudante = new AlunoModel();
            aluno2.Estudante.Nome = "Joao";
            aluno2.Estudante.Idade = 35;
            aluno2.Conta = new ContaBancariaModel();
            aluno2.Conta.Titular = "Joao Fonseca";
            aluno2.Conta.NrConta = "987456321";

            aluno3.Estudante = new AlunoModel();
            aluno3.Estudante.Nome = "Marta";
            aluno3.Estudante.Idade = 20;
            aluno3.Conta = new ContaBancariaModel();
            aluno3.Conta.Titular = "Marta Maria";
            aluno3.Conta.NrConta = "111222555";
            alunos.Add(aluno);

            alunos.Add(aluno2);

            alunos.Add(aluno3);

            return View(alunos);
        }
    }
}
