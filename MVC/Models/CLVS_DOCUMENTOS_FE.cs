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
    
    public partial class CLVS_DOCUMENTOS_FE
    {
        public int Id { get; set; }
        public int Situacion { get; set; }
        public Nullable<int> Anio { get; set; }
        public Nullable<int> Mes { get; set; }
        public Nullable<int> Dia { get; set; }
        public string FechaHora { get; set; }
        public string FechaFact { get; set; }
        public string HoraFact { get; set; }
        public string Estado { get; set; }
        public System.DateTime LastTransact { get; set; }
        public string ErrDetails { get; set; }
        public int CompanyId { get; set; }
        public int Sucursal { get; set; }
        public int Terminal { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroSAP { get; set; }
        public string EmsrNombre { get; set; }
        public string EmsrIdeTipo { get; set; }
        public string EmsrIdeNumero { get; set; }
        public string EmsrNombreComercial { get; set; }
        public string EmsrCorreoElectronico { get; set; }
        public string RcprNombre { get; set; }
        public string RcprIdeTipo { get; set; }
        public string RcprIdeNumero { get; set; }
        public string RcprNombreComercial { get; set; }
        public string RcprCorreoElectronico { get; set; }
        public string CodigoMoneda { get; set; }
        public decimal TipoCambio { get; set; }
        public Nullable<decimal> TotalServGravados { get; set; }
        public Nullable<decimal> TotalServExentos { get; set; }
        public Nullable<decimal> TotalMercanciasGravadas { get; set; }
        public Nullable<decimal> TotalMercanciasExentas { get; set; }
        public Nullable<decimal> TotalGravado { get; set; }
        public Nullable<decimal> TotalExento { get; set; }
        public Nullable<decimal> TotalVenta { get; set; }
        public Nullable<decimal> TotalDescuentos { get; set; }
        public Nullable<decimal> TotalVentaNeta { get; set; }
        public Nullable<decimal> TotalImpuesto { get; set; }
        public Nullable<decimal> TotalComprobante { get; set; }
        public string HR_envfecha { get; set; }
        public string HR_envrespcode { get; set; }
        public string HR_envdetails { get; set; }
        public string HR_code { get; set; }
        public string HR_indestado { get; set; }
        public string HR_fecha { get; set; }
        public string Clave { get; set; }
        public string NumeroConsecutivo { get; set; }
        public string FechaEmision { get; set; }
    }
}