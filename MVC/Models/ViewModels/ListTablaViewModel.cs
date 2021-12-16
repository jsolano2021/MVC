using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models.ViewModels
{
    public class ListTablaViewModel
    {

        public int Pedido { get; set; }
        public DateTime Fecha { get; set; }
        public string HoraCreado { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string CodCliente { get; set; }
        public string NombreCliente { get; set; }
        public string Vendedor { get; set; }
        public string FormaEntrega { get; set; }
        public string Almacen { get; set; }




    }
}