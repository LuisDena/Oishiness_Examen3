using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oishiness.Models
{
    public class Platillo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Nombre del Platillo")]
        public string? Nombre { get; set; }
        [Display(Name = "Categoría")]
        public int IdCategoria { get; set; }
        [ForeignKey("IdCategoria")]
        public Categoria? Categoria { get; set; }
        [Display(Name = "Descripción")]
        public string? Descripcion { get; set; }
        [Display(Name = "Precio")]
        public double? Precio { get; set; }
        [Display(Name = "Imagen Platillo")]
        public string? UrlImagen { get; set; }
        
    }
}
