using Microsoft.AspNetCore.Mvc;
using MyOneProject.Domain;
using MyOneProject.Domain.Entities;

namespace MyOneProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TextFieldsController : Controller
    {
        private readonly DataManager _dataManager;

        public TextFieldsController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        public IActionResult Edit(string codeWord)
        {
            var entity = _dataManager.TextField.GetTextFieldbyName(codeWord);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(TextField model)
        {
            if (ModelState.IsValid)
            {
                _dataManager.TextField.SaveTextField(model);
                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }
    }
}
