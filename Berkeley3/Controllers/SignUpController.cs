using Berkeley3.Models;
using FluentValidation.Results;
using System.Web.Mvc;

namespace Berkeley3.Controllers
{
    public class SignUpController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(SignUpDetails signUpDetails)
        {
            // Fluent Validator separates concerns.
            SignUpDetailsValidator validator = new SignUpDetailsValidator();
            ValidationResult result = validator.Validate(signUpDetails);
            if (!result.IsValid)
            {
                foreach (ValidationFailure failer in result.Errors)
                {
                    ModelState.AddModelError(failer.PropertyName, failer.ErrorMessage);
                }
            }
            return View(signUpDetails);
        }
    }
}