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



    }
  }
}
