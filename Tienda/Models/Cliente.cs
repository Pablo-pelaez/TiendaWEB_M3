using System.Collections.Generic;

namespace Tienda.Models
{
    public class Cliente
    {
        

        public int clienteID { get; set; }
        public string nombre { get; set; }
        public int numeroTelefono { get; set; }
        public int numeroCompras { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}