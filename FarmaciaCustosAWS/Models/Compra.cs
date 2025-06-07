using System;

namespace FarmaciaCustosAWS.Models
{
    public class Compra
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int MedicamentoId { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoTotal { get; set; }
    }
}
