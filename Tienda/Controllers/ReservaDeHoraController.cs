using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tienda.Models;

namespace Tienda.Controllers
{
    public class ReservaDeHoraController : Controller
    {
        // GET: ReservaDeHora
        public ActionResult Reserva()
        {
            string usernameCliente = "" + Session["Cliente"];
            ViewBag.user = usernameCliente;

            return View();
        }

        [HttpPost]
        public ActionResult Reserva(ReservaDeHora reserva)
        {

            if (DAO.ReservaDeHora.GetReservarHora(reserva))
            {


                return RedirectToAction("Reserva", "ReservaDeHora");

            }
            else
            {
                ViewData["Mensaje"] = "No se ha reservado su hora";
                return View();
            }

        }


    }
}
