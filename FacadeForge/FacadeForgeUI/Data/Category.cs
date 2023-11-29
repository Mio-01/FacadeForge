using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FacadeForgeUI.Data
{
    [Table("Категории")]
    public class Category
    {
        [Key]
        public int CategoryID { get; set; } //Уникальный идентификатор для каждой категории.


        [Column(TypeName = "nvarchar(125)")]
        [Required(ErrorMessage = "Требуется название.")]
        public string Name { get; set; } //Название или описание категории.

        /*[Column(TypeName = "nvarchar(125)")]
        public string Type { get; set; } = "Expense";*/

        // Навигационные свойства для связи с инструментами и материалами
        public ICollection<Tool>? Tools { get; set; }
        public ICollection<Material>? Materials { get; set; }
    }
}