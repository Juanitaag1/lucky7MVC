using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lucky7MVC.Controllers
{
    public class LuckyNumberController : Controller
    {
        // GET: LuckyNumber
        public ActionResult Index(int lucks = 7)
        {
            string display = "none";
            ViewBag.Display = display;
            var _lucky = "7";
            var rnd = new System.Random();
            var Num1 = rnd.Next(5, 9);
            var Num2 = rnd.Next(5, 9);
            var Num3 = rnd.Next(5, 9);
            ViewBag.Num1 = Num1.ToString() ;
            ViewBag.Num2 = Num2.ToString();
            ViewBag.Num3 = Num3.ToString();
            lucks = rnd.Next(5, 9);
            ViewBag.Luck = lucks.ToString();
            // if (ViewBag.Num1 == _lucky || ViewBag.Num2 == _lucky || ViewBag.Num3 == _lucky)
             if (ViewBag.Num1 == ViewBag.Luck || ViewBag.Num2 == ViewBag.Luck || ViewBag.Num3 == ViewBag.Luck)

            {
                display = "Block";
                ViewBag.Display = display;

           }
            return View();
        }

        // GET: LuckyNumber/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LuckyNumber/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LuckyNumber/Create
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

        // GET: LuckyNumber/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LuckyNumber/Edit/5
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

        // GET: LuckyNumber/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LuckyNumber/Delete/5
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
