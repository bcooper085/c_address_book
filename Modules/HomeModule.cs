using System;
using System.Collections.Generic;
using Nancy;
using Contact_Book.Objects;

namespace Address
{
  public class HomeModule: NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      Get["/add_contact"] = _ => View["add_contact.cshtml"];
      Post["/add_contact"] = _ => {
        Contact newContact = new Contact(Request.Form["contact-name"], Request.Form["contact-phone"]);
        return View["contact_added.cshtml", newContact];
      };
    }
  }
}
