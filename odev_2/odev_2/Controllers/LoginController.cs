using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
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
    public class LoginController : Controller
    {
        // GET: Login
        MemberManager am = new MemberManager(new EFMemberDal());

        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult NewSign()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewSign(Member m)
        {
            Context c = new Context();
            
            MembersValidator memberValidator = new MembersValidator();
            ValidationResult result = memberValidator.Validate(m);
            if (result.IsValid)
            {
                am.MemberAdd(m);
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

    }
}