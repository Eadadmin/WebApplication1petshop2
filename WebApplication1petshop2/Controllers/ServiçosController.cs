using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1petshop2.Models;

namespace WebApplication1petshop2.Controllers
{
    public class ServiçosController : Controller
    {
        public IActionResult Index()
        {
            List<Serviços> list = new List<Serviços>();
            list.Add(new Serviços { Id = 1, Name = "Banho" });
            list.Add(new Serviços { Id = 2, Name = "Corte de unhas " });
            list.Add(new Serviços { Id = 3, Name = "Escovação de dentes" });
            list.Add(new Serviços { Id = 4, Name = "Tosa" });


            return View(list);
        }
    }
}