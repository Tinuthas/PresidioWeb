using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PresidioWebAsp.Context;
using PresidioWebAsp.Models;

namespace PresidioWebAsp.Controllers
{
    public class CelaController : Controller
    {

        public PresidioContext _context { get; set; }

        public CelaController(PresidioContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Cela cela)
        {
            _context.Celas.Add(cela);
            _context.SaveChanges();
            TempData["msg"] = "Cela Cadastrada com Sucesso";
            return Redirect("Listar");
        }
    }
}