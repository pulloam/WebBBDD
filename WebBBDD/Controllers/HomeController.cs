using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBBDD.Models;

namespace WebBBDD.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Empleado> losEmpleados = new List<Empleado>();

            List<Clientes> losClientes = new List<Clientes>();
            //Base datos entity
            using(BBDDEntities bd = new BBDDEntities()) {
                //Buscar por ID
                //Clientes cliente = bd.Clientes.Find(3);

                //Buscar por clausula where
                //Clientes cliente = bd.Clientes.Where(c => c.Apellido == "Perez").First();

                //Elimina cliente de la tabla (Delete)
                //bd.Clientes.Remove(cliente);
                //bd.SaveChanges();


                //Agregar cliente a la tabla (Insert)
                //Clientes cliente = new Clientes();

                //cliente.Nombre = "Renato";
                //cliente.Apellido = "Prelle";
                //cliente.Edad = 55;
                //bd.Clientes.Add(cliente);
                //bd.SaveChanges();


                //Modificar un cliente (Update)
                //Clientes cliente = bd.Clientes.Find(2);
                //cliente.Edad = 23;
                //cliente.Nombre = "Marcelo";
                //bd.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
                //bd.SaveChanges();


                //Listar clientes (Select)
                losClientes = bd.Clientes.ToList();
                foreach (Clientes cli in losClientes) {
                    losEmpleados.Add(new Empleado(cli.Id, cli.Nombre,cli.Apellido,cli.Edad.GetValueOrDefault()));
                }
            }


            return View(losEmpleados);
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
           Empleado empleado =  new Empleado(1, "Carlitos", "Garrido", 0);

            return View(empleado);
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            Empleado empleado = new Empleado(2, "Joel", "Soto", 0);
            return View(empleado);
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            Empleado empleado = new Empleado(1, "Carlitos", "Garrido", 0);
            return View(empleado);
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
