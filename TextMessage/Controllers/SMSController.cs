using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TextMessage.Models;

namespace TextMessage.Controllers
{
    public class SMSController : Controller
    {
        // GET: SMSController/Create
        public ActionResult Send()
        {
            return View();
        }

        // POST: SMSController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Send(SMSMessage message)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Confirm", message);
            }
            else
            {
                return View();
            }
        }

        // GET: SMSController/Edit/5
        public ActionResult Confirm(SMSMessage msg)
        {
            return View(msg);
        }


    }
}
