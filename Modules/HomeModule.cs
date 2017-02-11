using System;
using System.Collections.Generic;
using Nancy;
using Contact_Book.Objects;

namespace Address_Book
{
  public class HomeModule: NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      Get["/add_contact"] = _ => View["add_contact.cshtml"];
      Get["/add_contact"] + _ => {
        List<Contact> allContacts = Contact.GetAll();
        return View["index.html", allContacts]''
      };
      Get["/add_contact/new"] = _ => {
        return View["contact_added.cshtml"];
      };
      Post["/add_contact"] = _ => {
        Contact newContact = new Contact(Request.Form["contact-name"], Request.Form["contact-phone"]);
        return View["contact_added.cshtml", newContact];
      };
      Get["{id}/contact_info"] = parameter => {
        Dictionary<string, object> model = new Dictionary<string, object>();
        Contact selectedContact = Contact.Find(parameter.id);
        List<Address> contactAddress = selectedContact.GetAddress();
        model.Add("contact", selectedContact);
        model.Add("address", contactAddress);
        return View["contact_info", model];
      };
      Post["{id}/contact_info"] = parameter => {
        Dictionary<string, object> model = new Dictionary<string, object>();
        Contact selectedContact = Contact.Find(parameter.id);
        List<Address> contactAddress = selectedContact.GetAddress();
        string streetAddress = Request.Form["address-street"];
        string cityAddress = Request.Form["address-city"];
        string zipAddress = Request.Form["address-zip"];
        string stateAddress = Request.Form["address-state"];
        Address newAddress = new Address(streetAddress, cityAddress, zipAddress, stateAddress);
        contactAddress.Add(newAddress);
        model.Add("contact", selectedContact);
        model.Add("address", contactAddress);
        return View["contact_info", model];
      };
      Post["/contact_list"] = _ => {
        List<int> contactId = Contact.selectedContact(Request.Form["contact-name"]);
        List<Contact> findContact = new List<Contact> {};
        return View["index.html", findContact];
      };
      Post["/contacts_cleared"] = _ => {
        Contact.Clear();
        return View["page_cleared.cshtml"];
      };
    }
  }
}
