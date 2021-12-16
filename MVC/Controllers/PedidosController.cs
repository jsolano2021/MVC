using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;
using MVC.Models.ViewModels;

namespace MVC.Controllers
{
    public class PedidosController : Controller
    {
        // GET: Pedidos
        public ActionResult Index()
        {
            List<ListTablaViewModel> lst;
            using(ZEBOLEntities db= new ZEBOLEntities())


            {
                lst = (from d in db.Pedido_Alistar
                           select new ListTablaViewModel
                           {

                               Pedido = d.Pedido,
                               Fecha = (DateTime)d.Fecha,
                               HoraCreado = d.HoraCreado,
                               FechaEntrega = (DateTime)d.FechaEntrega,
                               CodCliente = d.CodCliente,
                               NombreCliente = d.NombreCliente,
                               Vendedor = d.Vendedor,
                               FormaEntrega = d.FormaEntrega,
                               Almacen = d.Almacen


                           }).ToList();
            } 

            return View(lst);
        }
    }
}