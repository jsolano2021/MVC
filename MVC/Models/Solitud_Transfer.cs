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
    
    public partial class Solitud_Transfer
    {
        public int Solicitud { get; set; }
        public string Estado { get; set; }
        public Nullable<System.DateTime> Fecha_Doc { get; set; }
        public Nullable<int> Empleado_Depto_Ventas { get; set; }
        public string De_Almacen { get; set; }
        public string Almacen_Destino { get; set; }
        public string Comentario { get; set; }
        public string ItemCode { get; set; }
        public string Dscription { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public Nullable<int> Num_TR { get; set; }
        public string TR_ItemCode { get; set; }
        public string TR_Dscription { get; set; }
        public string TR_De_Almacen { get; set; }
        public string TR_Almacen_Destino { get; set; }
        public Nullable<decimal> TR_Cantidad { get; set; }
        public string U_NAME { get; set; }
    }
}
