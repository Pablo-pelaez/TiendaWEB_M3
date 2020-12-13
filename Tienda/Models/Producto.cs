using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tienda.Models
{
    public class Producto
    {
       [DatabaseGenerated(DatabaseGeneratedOption.None)]
       public int productoID { get; set; }
       public string nombreProducto { get; set; }
       public int unidadesDisponibles { get; set; }

       public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}