using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace odev_2.Controllers
{
    public class AnimalsController : Controller
    {
        AnimalsManager am = new AnimalsManager(new EFAnimalDal());
        // GET: Animals
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult getAnimalList()
        {
            var animalvalues = am.GetList();
            return View(animalvalues);
        }
        [HttpGet]
        public ActionResult AddAnimals()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAnimals(Animals a)
        {
            // am.AnimalAddBL(a);
            AnimalsValidator animalsValidator = new AnimalsValidator();
            ValidationResult results = animalsValidator.Validate(a);
            if(results.IsValid)
            {
                am.AnimalsAdd(a);
                return RedirectToAction("GetAnimalList");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

    }
}