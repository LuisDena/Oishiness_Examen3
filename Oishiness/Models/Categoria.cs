using System.ComponentModel.DataAnnotations;

namespace Oishiness.Models
{
    public class Categoria
    {
        [Key]
        public int Id {get; set;}
        [Required]
        [Display(Name ="Nombre Categoría")]
        public string? Nombre {get; set;}
    }
}
