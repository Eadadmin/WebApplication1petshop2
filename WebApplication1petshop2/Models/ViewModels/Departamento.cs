using System.Collections.Generic;
using System;
using System.Linq;

namespace WebApplication1petshop2.Models.ViewModels

{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Serviços> Serviços { get; set; } = new List<Serviços>();

        public Departamento()
        {
        }

        public Departamento(int id, string nome )
        {
            Id = id;
            Nome = nome;
        }

        public void AddServiço(Serviços serviço)
        {
            Serviços.Add(serviço);
        }

        public double TotalVendas(DateTime inicial, DateTime final)
        {
            return Serviços.Sum(serviços => serviços.TotalVendas(inicial, final)); 
        }
    }
}
