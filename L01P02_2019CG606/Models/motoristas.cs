using System.ComponentModel.DataAnnotations;

namespace L01P02_2019CG606.Models
{
    public class motoristas
    {
        [Key]
        [Display(Name = "ID Motorista")]
        public int motoristaId { get; set; }
        [Display(Name = "Nombre Motorista")]
        public string? nombreMotorista { get; set; }
    }
}
