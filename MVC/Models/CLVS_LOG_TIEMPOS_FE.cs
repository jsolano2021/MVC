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
    
    public partial class CLVS_LOG_TIEMPOS_FE
    {
        public int Id { get; set; }
        public int Situacion { get; set; }
        public Nullable<int> Anio { get; set; }
        public Nullable<int> Mes { get; set; }
        public Nullable<int> Dia { get; set; }
        public string FechaHora { get; set; }
        public string FechaHoraHacienda { get; set; }
        public Nullable<int> Duracion { get; set; }
        public int Status { get; set; }
        public string ErrDetails { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroSAP { get; set; }
        public string Clave { get; set; }
        public string NumeroConsecutivo { get; set; }
        public string RcprIdeNumero { get; set; }
        public string RcprNombre { get; set; }
        public string RcprNombreComercial { get; set; }
        public string RcprCorreoElectronico { get; set; }
        public string CodigoMoneda { get; set; }
        public decimal TipoCambio { get; set; }
        public Nullable<decimal> TotalComprobante { get; set; }
    }
}
