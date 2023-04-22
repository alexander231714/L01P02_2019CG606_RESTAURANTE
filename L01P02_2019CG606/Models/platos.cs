using System.ComponentModel.DataAnnotations;

namespace L01P02_2019CG606.Models
{
    public class platos
    {
        [Key]
        [Display(Name = "ID Plato")]
        public int platoId { get; set; }
        [Display(Name = "Nombre del plato")]
        public string? nombrePlato { get; set; }
        [Display(Name = "Precio")]
        public decimal? precio { get; set; }
    }
}
