using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }

        [StringLength(100)] // Limite o comprimento para 100 caracteres
        public required string Name { get; set; }
    }
}
