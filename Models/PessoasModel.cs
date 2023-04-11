namespace DesafioDev2.Models
{
    public class PessoasModel
    {
        
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public long CPF { get; set; }
        public string? UF { get; set; }

        public DateTime DataNas { get; set; }

    }
}
