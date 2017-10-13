using Microsoft.AspNetCore.Mvc;
using AddressBookCS.Models;

namespace AddressBookCS.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      Contact newContact = new Contact(Request.Query["new-name"], Request.Query["new-phoneNumber"], Request.Query["new-address"]);
      return View(newContact);
    }

    [HttpGet("/contact/new")]
    public ActionResult NewConfirm()
    {
      return View();
    }
  }
}
