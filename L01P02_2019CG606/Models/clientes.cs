using System.ComponentModel.DataAnnotations;

namespace L01P02_2019CG606.Models
{
    public class clientes
    {
        [Key]
        [Display(Name = "ID Cliente")]
        public int clienteId { get; set; }
        [Display(Name = "Nombre del Cliente")]
        public string? nombreCliente { get; set; }
        [Display(Name = "Direccion")]
        public string? direccion { get; set; }
    }
}
