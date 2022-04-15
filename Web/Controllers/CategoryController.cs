using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Service;
using Domain.entities;

namespace Web.Controllers
{
    public class CategoryController : Controller
    {
        // GET: CategoryController
        private readonly ICategoryService categoryservice;
        public CategoryController (ICategoryService _categoryservice)
        {
            categoryservice = _categoryservice;

        }
        public ActionResult Index()
        {
            //return View (szervclt.GetAll().ToList());
            var listcategory = categoryservice.GetMany().ToList();
            return View(listcategory);
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = categoryservice.GetMany()
                .FirstOrDefault(c => c.CategorieId == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

            // GET: CategoryController/Create
            public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]

        // public ActionResult Create(IFormCollection collection)
        public ActionResult Create(Categorie category)
        {
            try
            {
                categoryservice.Add(category);
                categoryservice.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int? id)
        {
            if(id==null)
            {
                return NotFound();
            }
            var category = categoryservice.GetById((int)id);
            if(category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Categorie category)
        {
            try
            {
                categoryservice.Update(category);
                categoryservice.Commit();
            }
            catch
            {
                return View(category);
            }
            return View(category);
        }

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var category = categoryservice.GetMany()
                .FirstOrDefault(c => c.CategorieId == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);

        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {

            var category = categoryservice.GetById(id);
            categoryservice.Delete(category);
            categoryservice.Commit();
            if (category == null)
            {
                return NotFound();
            }
           
                return View(category);
            
        }
    }
}
