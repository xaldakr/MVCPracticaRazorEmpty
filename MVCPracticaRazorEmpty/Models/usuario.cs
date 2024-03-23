using System.ComponentModel.DataAnnotations;

namespace MVCPracticaRazorEmpty.Models
{
    public class usuario
    {
        [Key]
        public int idUser { get; set; }
        [Required]
        [StringLength(100)]
        public string nombre { get; set; }
        [Required]
        [StringLength(100)]
        public string pass { get; set; }

        [StringLength(1)]
        public string genero { get; set; }

        [StringLength(400)]
        public string direccion { get; set; }

        [StringLength(50)]
        public string curso { get; set; }
    }
}
