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
    
    public partial class CLVS_TBL_OFERTAS_FACT
    {
        public Nullable<int> C__Doc { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Cod_Cliente { get; set; }
        public string Cliente { get; set; }
        public string Moneda { get; set; }
        public string Agente { get; set; }
        public string Clase_Doc { get; set; }
        public string Estado_Documento { get; set; }
        public Nullable<decimal> Total_LOC { get; set; }
        public Nullable<decimal> Pagado_LOC { get; set; }
        public Nullable<decimal> Total_USD { get; set; }
        public Nullable<decimal> Pagado_USD { get; set; }
    }
}