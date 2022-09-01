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
        public ICollection<ServiçoRegistro> Serviço { get; set; } = new List<ServiçoRegistro>();

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

        public void AddServiços(ServiçosRegistro sr)
        {
            Serviço.Add(sr);
        }

        public void RemoveServiços(ServiçosRegistro sr)
        {
            Serviço.Remove(sr);
        }

        public double TotalServiços(DateTime inicial, DateTime final)
        {
            return Serviço.Where(sr => sr.Data >= inicial && sr.Data <= final).Sum(sr => sr.Quantidade);
        }
        
        
    }
}
