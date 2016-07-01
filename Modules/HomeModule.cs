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
        return View["addressbook.cshtml", allContacts];
      };
      Get["/contact/new"] = _ => {
        return View["newContact.cshtml"];
      };
      Post["/contactAdded"] = _ => {
        var newContact = new Contact(Request.Form["contact-first-name"],
        Request.Form["contact-last-name"],
        Request.Form["contact-phone"],
        Request.Form["contact-address"]);
        return View["contactAdded.cshtml", newContact];
      };



    }
  }
}
