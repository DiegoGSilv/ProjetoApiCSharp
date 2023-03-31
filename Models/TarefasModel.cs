using DesafioDev2.Enums;

namespace DesafioDev2.Models
{
    public class TarefasModel
    {

        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public int? CPF { get; set; }
        public string? UF { get; set; }

        public string? DataNas { get; set; }

        public string? Descricao { get; set; }

        public StatusTarefa Status { get; set; } 

    }
}
