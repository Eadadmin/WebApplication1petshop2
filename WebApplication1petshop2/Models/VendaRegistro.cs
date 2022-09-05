using System;
using WebApplication1petshop2.Models.Enums;

namespace WebApplication1petshop2.Models
{
    public class VendaRegistro
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Quantidade { get; set; }
        public VendasStatus Status { get; set; }
        public Serviços Serviços { get; set; }

        public VendaRegistro()
        {
        }

        public VendaRegistro(int id, DateTime data, double quantidade, VendasStatus status, Serviços serviços)
        {
            Id = id;
            Data = data;
            Quantidade = quantidade;
            Status = status;
            Serviços = serviços;
        }
    }
}
