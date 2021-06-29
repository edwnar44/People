namespace People.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Text;


    public class Factura : IEntity
    {
        public int Id { get; set; }
        public string NumeroFactura { get; set; }
        public DateTime Fecha { get; set; }
        public string NombreCliente { get; set; }
        public List<DetalleFactura> DetalleFacturas { get; set; }
    }
}
