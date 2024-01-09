using System.ComponentModel.DataAnnotations.Schema;

namespace AgenciaHorizonteAberto.ComponentModel
{
    [Table("AgenciaHorizonte")]
    public class Viagem
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("destino")]
        public string Destino { get; set; }

        [Column("preco")]
        public decimal? Preco { get; set; }
    }
}
