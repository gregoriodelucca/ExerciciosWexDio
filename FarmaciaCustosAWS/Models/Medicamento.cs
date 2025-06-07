namespace FarmaciaCustosAWS.Models
{
    public class Medicamento
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
    }
}
