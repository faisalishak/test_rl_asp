using CariRumah.Models;
using MvcFlash.Core;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace CariRumah.Controllers
{
    public class RumahController : Controller
    {
        // GET: Rumah
        public ActionResult Manage()
        {
            return View();
        }

        // GET: Rumah/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Rumah/Create
        public ActionResult Create()
        {
            //Flash.Success("Data Berhasil Ditambah");

            return View();
        }

        // POST: Rumah/Create
        [HttpPost]
        public ActionResult Create(Rumah rumah)
        {
            try
            {
                AppDb.conn.Close();
                AppDb.conn.Open();

                string sql = "INSERT INTO rumah VALUES ("+ rumah.id +", '"+ rumah.tipe +"', '"+ rumah.alamat +"', "+ rumah.latitude +", "+ rumah.longitude +")";
                MySqlCommand cmd = new MySqlCommand(sql, AppDb.conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                return RedirectToAction("Create");
            }
            catch
            {
                return View();
            }
        }

        // GET: Rumah/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Rumah/Edit/5
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

        // GET: Rumah/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Rumah/Delete/5
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
