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
    
    public partial class CLVSP_TRANSITO_MERCADERIAS
    {
        public int N__Documento { get; set; }
        public string Nombre_Proveedor { get; set; }
        public int Orden_de_Venta { get; set; }
        public Nullable<System.DateTime> DocDate { get; set; }
        public string CLIENTE_ { get; set; }
        public string Fecha_Despacho { get; set; }
        public string Fecha_llegada_Zebol { get; set; }
        public string Fecha_Promesa_Entrega { get; set; }
        public string Comentarios { get; set; }
        public string Estatus { get; set; }
        public string Status_Importacion { get; set; }
        public string Estado_de_Llegada { get; set; }
        public string Tipo_OC { get; set; }
        public string Vendedor { get; set; }
        public Nullable<int> Año { get; set; }
        public Nullable<int> Mes { get; set; }
        public string Codigo_Articulo_Compra { get; set; }
        public string Descripción { get; set; }
        public Nullable<decimal> Cantidad { get; set; }
        public string Fabricante { get; set; }
        public string Clientes { get; set; }
        public string U_BOOKING { get; set; }
        public string ReferenciaOV { get; set; }
        public string U_referenciaOF { get; set; }
        public string Etapa_del_Pedido { get; set; }
        public int Factura_de_Reserva { get; set; }
        public string C__Fabricacion { get; set; }
        public Nullable<System.DateTime> Fecha_Factura_Reserva { get; set; }
        public Nullable<short> Hora_Factura_Reserva { get; set; }
        public int C__Preliminar_EM { get; set; }
        public Nullable<System.DateTime> Fecha_Preliminar { get; set; }
        public Nullable<short> Hora_prelimina { get; set; }
        public int C__Entrada_Mercancias { get; set; }
        public Nullable<System.DateTime> Fecha_Entrada { get; set; }
        public Nullable<short> Hora_Entrada { get; set; }
        public int Precio_Entrega { get; set; }
        public Nullable<System.DateTime> Fecha_Precio_Entrega { get; set; }
        public Nullable<short> Hora_Precio_Entrega { get; set; }
    }
}
