using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tienda.Models
{
    public class Compra
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int compraID { get; set; }
        public int valorProductos { get; set; }
        public DateTime fechadecompra { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
            


    }
}