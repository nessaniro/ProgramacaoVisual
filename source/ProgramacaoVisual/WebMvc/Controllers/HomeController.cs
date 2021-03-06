﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebMvc.Models;

namespace WebMvc.Controllers
{
    public class HomeController : Controller
    {
        private static IList<Pessoa> pessoaList = new List<Pessoa>
        {
            new Pessoa { Id = 1, Nome = "Joao"},
            new Pessoa { Id = 2, Nome = "Juao"},
            new Pessoa { Id = 3, Nome = "Jonh"}
        };

        public IList<Pessoa> GetPessoas()
        {
            return pessoaList;
        }

        public Pessoa AddPessoa(string nome)
        {
            try {
                var pessoa = new Pessoa { Nome = nome };
                pessoa.Id = pessoaList.Max(p => p.Id) + 1;
                pessoaList.Add(pessoa);
                return pessoa;
            } catch{}

            return null;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
