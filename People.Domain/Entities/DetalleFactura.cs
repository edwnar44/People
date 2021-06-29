namespace People.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Text;


    public class DetalleFactura : IEntity
    {
        public int Id { get; set; }

        public Factura Factura { get; set; }
        public string Producto { get; set; }
        public decimal ValorUnitario { get; set; }
    }
}
