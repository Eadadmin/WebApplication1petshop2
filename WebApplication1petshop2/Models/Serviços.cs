using System;
using System.Collections.Generic;
using WebApplication1petshop2.Models.ViewModels;
using System.Linq;

namespace WebApplication1petshop2.Models
{
    public class Serviços
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento {get; set; }
        public double BaseServiço { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<VendaRegistro> Vendas { get; set; } = new List<VendaRegistro>();
        public string Name { get; internal set; }

        public Serviços()
        {
        }

        public Serviços(int id, string nome, string email, DateTime dataNascimento, double baseServiço, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            BaseServiço = baseServiço;
            Departamento = departamento;

        }

        public void AddVenda(VendaRegistro vr)
        {
            Vendas.Add(vr);
        }

        public void RemoveVendas(VendaRegistro vr)
        {
            Vendas.Remove(vr);
        }

        public double TotalVendas(DateTime inicial, DateTime final)  
        {
            return Vendas.Where(vr => vr.Data >= inicial && vr.Data <= final).Sum(vr => vr.Quantidade);
        }
        
        
    }
}
