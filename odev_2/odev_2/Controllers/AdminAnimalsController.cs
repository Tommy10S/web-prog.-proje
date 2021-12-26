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
    public class AdminAnimalsController : Controller
    {
        // GET: AdminAnimals

        AnimalsManager am = new AnimalsManager(new EFAnimalDal());
        public ActionResult Index()
        {

            var animalvalue = am.GetList();
            return View(animalvalue);
        }
        [HttpGet]
        public ActionResult AddAnimal()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAnimal(Animals a)
        {
            AnimalsValidator animalsValidator = new AnimalsValidator();
            ValidationResult result = animalsValidator.Validate(a);
            if(result.IsValid)
            {
                am.AnimalsAdd(a);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public ActionResult DeleteAnimal(int id)
        {
            var animalvalue = am.GetByID(id);
            am.AnimalsDelete(animalvalue);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditAnimals(int id)
        {
            var animalvalue = am.GetByID(id);
         
            return View(animalvalue);
        }

        [HttpPost]
        public ActionResult EditAnimals(Animals a)
        {
            am.AnimalUpdate(a);
            return RedirectToAction("Index");
        }



    }
}