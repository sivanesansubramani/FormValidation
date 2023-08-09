using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormValidation.Repository;
using FormValidation.Models;

namespace FormValidation.Controllers
{
    public class ValidationController : Controller
    {

        ValidationRepo repo;
        LocationRepository locRepo;


        public ValidationController()
        {
            repo = new ValidationRepo();
            locRepo = new LocationRepository();
        }



        // GET: ValidationController
        public ActionResult List()
        {
            return View("select", repo.Selectvalidation());
        }

        // GET: ValidationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ValidationController/Create
        public ActionResult Create()
        {
            /*var model = new ValidationRepo();
            model.LocationValues = locRepo.GetAllLocation();*/

            return View("Insert", new ValidationModel());
           
        }


        // POST: ValidationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }

        // GET: ValidationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ValidationController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ValidationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ValidationController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
