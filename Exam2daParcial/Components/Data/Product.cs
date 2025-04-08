using System.ComponentModel.DataAnnotations;
namespace Exam2daParcial.Components.Data
{
    public class Producto
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; } = string.Empty;

        [Range(1, int.MaxValue, ErrorMessage = "El inventario debe ser un número positivo")]
        public int Inventario { get; set; } = 0;

        [Required(ErrorMessage = "Debe seleccionar un departamento")]
        public string Departamento { get; set; } = string.Empty;
    }

}
