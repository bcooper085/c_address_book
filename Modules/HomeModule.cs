using System;
using System.Collections.Generic;
using Nancy;
using Contact.Objects;

namespace Address
{
  public class HomeModule: NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      Post["/add_contact"] = _ => {
        Contact newContact = new Contact(Request.Form["contact-name"], Request.Form["contact-phone"]);
        return View["contact_added.cshtml", newContact];
      };
    }
  }
}
