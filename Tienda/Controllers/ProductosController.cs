using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tienda.Controllers
{
    public class ProductosController : Controller
    {
        //----------------------------VISTA CON LA LISTA DE PRODUCTOS AGREGADOS POR EL EMPLEADO----------------------------
        public ActionResult IndexProductos()
        {


            List<Models.Productos> lstProductos = DAO.Productos.GetAll();
            return View(lstProductos);
        }

      
    }
}
