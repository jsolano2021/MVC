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
    
    public partial class CLVSP_COBROS_DET
    {
        public string Seleccion_Moneda { get; set; }
        public string Cod_Cliente { get; set; }
        public string Cliente { get; set; }
        public string Cliente_en_Factura { get; set; }
        public string Grupo_cliente { get; set; }
        public Nullable<short> Dias_Cliente { get; set; }
        public Nullable<int> Dias_atraso { get; set; }
        public string Cancelado { get; set; }
        public string Estado { get; set; }
        public Nullable<int> Año_Conta { get; set; }
        public Nullable<int> Mes_Conta { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<int> Año_Vence { get; set; }
        public Nullable<int> Mes_Vence { get; set; }
        public Nullable<System.DateTime> Fecha_vencimiento { get; set; }
        public string Serie_Numeracion { get; set; }
        public int C__Pago { get; set; }
        public Nullable<int> C__Factura { get; set; }
        public string Referencia { get; set; }
        public string Moneda { get; set; }
        public string Tipo_de_documento { get; set; }
        public string Tipo_de_Saldo { get; set; }
        public string Cuenta_Contable { get; set; }
        public Nullable<decimal> Balance_Cliente_COL { get; set; }
        public Nullable<decimal> Bruto_COL { get; set; }
        public Nullable<decimal> Aplicado_COL { get; set; }
        public Nullable<decimal> Balance_COL { get; set; }
        public Nullable<decimal> Sin_Vencer_COL { get; set; }
        public Nullable<decimal> C1_30_días_COL { get; set; }
        public Nullable<decimal> C31_60_días_COL { get; set; }
        public Nullable<decimal> C61_90_días_COL { get; set; }
        public Nullable<decimal> C91_120_días_COL { get; set; }
        public Nullable<decimal> C121_150_días_COL { get; set; }
        public Nullable<decimal> C150__días_COL { get; set; }
    }
}
