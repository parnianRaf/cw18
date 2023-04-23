using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppCore.DTO;
using AppService;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace cw18_1.Controllers
{
    public class ButtonController : Controller
    {
        //private readonly IButtonService _service;
        //public ButtonController(ButtonService service)
        //{
        //    _service = service;
        //}
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        //public IActionResult ProvinceMemberList()
        //{
        //    List<ProvinceMemberList> Member = _service.ProvinceMemberList();
        //    return View(Member);
        //}
    }
}

