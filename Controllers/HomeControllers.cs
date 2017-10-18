using Microsoft.AspNetCore.Mvc;
using AddressBookCS.Models;
using System.Collections.Generic;
// using System;

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

      return View(newContact);
    }

    [HttpGet("/contact/{id}")]
        public ActionResult ContactDetail(int id)
        {
            Contact contact = Contact.Find(id);
            return View(contact);
        }
  }
}


// //index
// Contact newContact = new Contact(Request.Query["new-name"], Request.Query["new-phoneNumber"], Request.Query["new-address"]);
// return View(newContact);
