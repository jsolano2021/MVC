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
    
    public partial class CLVS_ZEBOL_COMISIONES
    {
        public string Documento { get; set; }
        public string Cancelado { get; set; }
        public string Tipo_doc { get; set; }
        public string Estado { get; set; }
        public Nullable<int> C__Doc { get; set; }
        public Nullable<int> Año_doc { get; set; }
        public Nullable<int> Mes_doc { get; set; }
        public Nullable<int> Dia_doc { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<System.DateTime> Fecha_vencimiento { get; set; }
        public Nullable<int> Año_ult_pago { get; set; }
        public Nullable<int> Mes_ult_pago { get; set; }
        public Nullable<int> Dia_ult_pago { get; set; }
        public Nullable<System.DateTime> Ult_Pago { get; set; }
        public Nullable<int> Atraso { get; set; }
        public string Cliente { get; set; }
        public string Nombre_cliente { get; set; }
        public string Realizada_por { get; set; }
        public Nullable<int> SlpCode { get; set; }
        public string Vendedor { get; set; }
        public string Moneda_doc { get; set; }
        public string Condicion_Credito { get; set; }
        public string Cond__Pago { get; set; }
        public Nullable<decimal> Pago_Rec_Tot { get; set; }
        public Nullable<int> reg_tipoinventario { get; set; }
        public int reg_codarticulo { get; set; }
        public int reg_pagoatiempo { get; set; }
        public string Linea_impuesto { get; set; }
        public string Grupo_Articulo { get; set; }
        public string Marca { get; set; }
        public string Articulo { get; set; }
        public string Nombre_articulo { get; set; }
        public string Proyecto { get; set; }
        public Nullable<decimal> C__Descuento_CAB { get; set; }
        public Nullable<decimal> C__Descuento_LIN { get; set; }
        public Nullable<decimal> C__Margen { get; set; }
        public Nullable<decimal> Total_LOC { get; set; }
        public Nullable<decimal> Descuento_CAB_LOC { get; set; }
        public Nullable<decimal> Descuento_LIN_LOC { get; set; }
        public Nullable<decimal> Total_neto_LOC { get; set; }
        public Nullable<decimal> Costo_total_LOC { get; set; }
        public Nullable<decimal> Margen_LOC { get; set; }
        public Nullable<decimal> Total_USD { get; set; }
        public Nullable<decimal> Descuento_CAB_USD { get; set; }
        public Nullable<decimal> Total_neto_USD { get; set; }
        public Nullable<decimal> Costo_total_USD { get; set; }
        public Nullable<decimal> Margen_USD { get; set; }
        public Nullable<decimal> Factor_comision { get; set; }
        public Nullable<decimal> C__Comision { get; set; }
        public Nullable<decimal> Comision_LOC { get; set; }
        public Nullable<decimal> PAT_Comision_LOC { get; set; }
        public Nullable<decimal> Comision_USD { get; set; }
        public Nullable<decimal> PAT_Comision_USD { get; set; }
        public string Cuenta_ingresos { get; set; }
        public string Cuenta_costos { get; set; }
    }
}