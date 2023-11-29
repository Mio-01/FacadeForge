using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FacadeForgeUI.Data
{
    [Table("Материалы")]
    public class Material
    {
        [Key]
        public int MaterialId { get; set; } //Уникальный идентификатор для каждого материала.

        [Required]
        public string? Name { get; set; } //Название или описание материала.

        public string? Type { get; set; } //Категория, к которой относится материал (например, краска, гипс, цемент и т. д.).

        [Required]
        public string? UnitOfMeasure { get; set; } //Единица измерения для материала (например, килограмм, литр, метр и т. д.).

        [Range(1, int.MaxValue, ErrorMessage = "Цена должна быть больше 0")]
        public float PricePerUnit { get; set; } //Стоимость материала за единицу измерения.

        [Range(1, int.MaxValue, ErrorMessage = "Количество должно быть больше 0")]
        public int QuantityInStock { get; set; } //Текущее количество материала на складе.

        [Range(1, int.MaxValue, ErrorMessage = "Пожалуйста, выберите категорию")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

    }
}