//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CLVS_ResumenDocsVentas
    {
        public string Vendedor { get; set; }
        public string Creador { get; set; }
        public Nullable<System.DateTime> Contabilizacion { get; set; }
        public Nullable<System.DateTime> Vencimiento { get; set; }
        public string Documento { get; set; }
        public string Tipo { get; set; }
        public string Estado { get; set; }
        public string Cliente { get; set; }
        public string Nombre_cliente { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> Impuestos { get; set; }
        public Nullable<decimal> Descuento { get; set; }
        public Nullable<decimal> Total_neto { get; set; }
        public Nullable<decimal> Costo { get; set; }
        public Nullable<decimal> Utilidad { get; set; }
    }
}
