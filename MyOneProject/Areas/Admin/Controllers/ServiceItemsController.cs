using Microsoft.AspNetCore.Mvc;
using MyOneProject.Domain;
using MyOneProject.Domain.Entities;

namespace MyOneProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServiceItemsController : Controller
    {
        private readonly DataManager _dataManager;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ServiceItemsController(DataManager dataManager, IWebHostEnvironment webHostEnvironment)
        {
            _dataManager = dataManager;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Edit(int id)
        {
            var entity = id == default ? new ServiceItem() : _dataManager.ServiceItems.GetServiceItemById(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(ServiceItem model, IFormFile titleImageFile)
        {
            if (ModelState.IsValid)
            {
                if (titleImageFile != null)
                {
                    model.TitleImagePath = titleImageFile.FileName;
                    using (var stream = new FileStream(Path.Combine(_webHostEnvironment.WebRootPath, "Images/", titleImageFile.FileName), FileMode.Create))
                    {
                        titleImageFile.CopyTo(stream);
                    }
                }

                _dataManager.ServiceItems.SaveServiceItem(model);
                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _dataManager.ServiceItems.DeleteServiceItem(id);
            return RedirectToAction("Index", "Home");
        }
    }
}
