using System.ComponentModel.DataAnnotations;

namespace L01P02_2019CG606.Models
{
    public class pedidos
    {
        [Key]
        [Display(Name = "ID Pedido")]
        public int pedidoId { get; set; }
        [Display(Name = "ID Motorista")]
        public int? motoristaId { get; set; }
        [Display(Name = "ID Cliente")]
        public int? clienteId { get; set; }
        [Display(Name = "ID Plato")]
        public int? platoId { get; set; }
        [Display(Name = "Cantidad a llevar")]
        public int? cantidad { get; set; }
        [Display(Name = "Precio")]
        public decimal? precio { get; set; }
    }
}
