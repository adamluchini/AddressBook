using Nancy;
using AddressBook.Objects;
using System.Collections.Generic;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        var allContacts = Contact.GetAllContacts();
        return View["main.cshtml", allContacts];
      };
      Get["/contact/new"] = _ => {
        return View["form.cshtml"];
      };
      Post["/contact_created"] = _ => {
        var newContact = new Contact(Request.Form["contact-first-name"],
        Request.Form["contact-last-name"],
        Request.Form["contact-phone"],
        Request.Form["contact-address"]);
        return View["contact_created.cshtml", newContact];
      };
      Post["/contacts_deleted"] = _ => {
        Contact.DeleteAll();
        return View["/contacts_deleted.cshtml"];
      };



    }
  }
}
