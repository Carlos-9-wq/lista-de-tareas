using System.ComponentModel.DataAnnotations;

namespace lista_de_tareas.Models
{
    public class TareaEntity
    {
        [Key] public int Id { get; set; }

        [StringLength(30), Required] public string Tarea { get; set; }

        [StringLength(200), Required] public string Descripcion { get; set; }

        [Required] public bool Estatus { get; set; }
        [Required] public DateTime Fecha { get; set; }
    }
}
