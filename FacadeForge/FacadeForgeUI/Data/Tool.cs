using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FacadeForgeUI.Data
{
    [Table("Инструменты")]
    public class Tool
    {
        [Key]
        public int ToolId { get; set; } //Уникальный идентификатор для каждого инструмента.

        [Column(TypeName = "nvarchar(255)")]
        [Required(ErrorMessage = "Требуется название")]
        public string? Name { get; set; } //Название или описание инструмента.

        [Column(TypeName = "nvarchar(255)")]
        [Required(ErrorMessage = "Требуется сирийный номер")]
        public string? SerialNumber { get; set; } //Уникальный номер для идентификации конкретного экземпляра инструмента.

        public string Type { get; set; } //Категория или тип инструмента (например, электроинструменты, ручные инструменты и т. д.).

        [DataType(DataType.Date)]
        public DateTime PurchaseDate { get; set; } = DateTime.Now; //Дата приобретения инструмента.

        [Range(1, int.MaxValue, ErrorMessage = "Сумма должна быть больше 0")]
        public float PurchasePrice { get; set; } //Стоимость инструмента при покупке.

        public string? Condition { get; set; } //Состояние инструмента (новый, б/у, требует ремонта и т. д.).

        [DataType(DataType.Date)]
        public DateTime LastMaintenanceDate { get; set; } = DateTime.Now; //Дата последнего технического обслуживания инструмента.


        [Range(1, int.MaxValue, ErrorMessage = "Пожалуйста, выберите категорию")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
