using Microsoft.AspNetCore.Mvc;
using AddressBookCS.Models;
using System.Collections.Generic;


namespace AddressBookCS.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      List<Contact> allContacts = Contact.GetAll();
      return View(allContacts);
    }

    [HttpGet("/contact/form")]
    public ActionResult ContactForm()
    {
      return View();
    }

    [HttpPost("/contact/new")]
    public ActionResult NewConfirm()
    {
      Contact newContact = new Contact (Request.Form["new-name"], Request.Form["new-phoneNumber"], Request.Form["new-address"]);

      newContact.Save();
      return View(newContact);
    }
  }
}


// //index
// Contact newContact = new Contact(Request.Query["new-name"], Request.Query["new-phoneNumber"], Request.Query["new-address"]);
// return View(newContact);
