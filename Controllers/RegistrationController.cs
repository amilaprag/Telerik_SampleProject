using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telerik_SampleProject.Model;
using Telerik_SampleProject.Repository.Registration;

namespace Telerik_SampleProject.Controllers
{
    public class RegistrationController : Controller
    {
        private IRegistrationRepository _RegistrationCaller;
        private ILogger<RegistrationController> _Logger;

        public RegistrationController(ILogger<RegistrationController> Logger,IRegistrationRepository RegistrationCaller)
        {
            _RegistrationCaller = RegistrationCaller;
            _Logger = Logger;
        }

        // GET: RegistrationController
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<ActionResult> Index(RegistrationModel Model)
        {
            bool Status = false;
            if (ModelState.IsValid)
            {
                Status = await _RegistrationCaller.Registration(Model);
                return View();
            }
            return View();
        }

    }
}
