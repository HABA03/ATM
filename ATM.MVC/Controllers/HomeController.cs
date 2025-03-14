using ATM.BL.IServices;
using ATM.EN.DTOs.ContactMessage.Create;
using ATM.MVC.Models;
using ATM.MVC.Models.ContactMessageModel;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ATM.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IContactMessageService _service;
        public HomeController(ILogger<HomeController> logger, IContactMessageService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ProducesResponseType(typeof(ContactMessageModelResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> CreateContactMessage(ContactMessageModelRequest request)
        {
            var response = await _service.CreateContactMessage(new CreateContactMessageRequest
            {
                Name = request.Name,
                Email = request.Email,
                Message = request.Message
            });

            if (!response.Response)
            {
                return View("Error", new ErrorViewModel
                {
                    RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier,
                });
            }

            return RedirectToAction("Index");
        }

    }
}
