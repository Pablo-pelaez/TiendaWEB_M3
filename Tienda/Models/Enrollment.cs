namespace Tienda.Models
{
    public class Enrollment
    {
        public int enrollmentID { get; set; }
        public int productoID { get; set; }
        public int clienteID { get; set; }
        public int compraID { get; set; }

        public virtual Cliente cliente { get; set; }
        public virtual Producto producto { get; set; }
        public Compra compras { get; set; }
    }
}