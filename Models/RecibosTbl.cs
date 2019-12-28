using System;
using System.Collections.Generic;

namespace axosnet.Models
{
    public partial class RecibosTbl
    {
        public int ReciboId { get; set; }
        public string Proveedor { get; set; }
        public int Monto { get; set; }
        public string Moneda { get; set; }
        public string Fecha { get; set; }
        public string Comentario { get; set; }
    }
}
