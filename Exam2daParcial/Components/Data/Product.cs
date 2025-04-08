using System.ComponentModel.DataAnnotations;
namespace Exam2daParcial.Components.Data
{
    public class Product
    {
        [Required(ErrorMessage = "\"Inventario\" es obligatorio.")]
        [Range(1, int.MaxValue, ErrorMessage = "\"Inventario\" debe ser un entero positivo mayor a 0.")]
        public int Inv { get; set; } = 0;
        [Required(ErrorMessage = "Este \"Nombre\" no debe quedar vacio.")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Debe seleccionar \"Departamento\".")]
        public string Dep { get; set; } = string.Empty;
    }
}
