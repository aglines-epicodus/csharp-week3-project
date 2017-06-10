using System.Collections.Generic;
using Nancy;
using Nancy.ViewEngines.Razor;

namespace HairSalon
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };

      Get["/stylists"] = _ => {
        List<Stylist> allStylists = Stylist.GetAll();
        return View["stylists.cshtml", allStylists];
      };

      Get["/clients"] = _ => {
        List<Client> allClients = Client.GetAll();
        return View["clients.cshtml", allClients];
      };

      Get["/stylists/new"] = _ => {
        return View["stylists_form.cshtml"];
      };

      Post["/stylists/new"] = _ => {
        Stylist newStylist = new Stylist(Request.Form["stylist-name"], Request.Form["stylist-contact"], Request.Form["stylist-photolink"]);
        newStylist.Save();
        return View["success.cshtml"];
      };

      Get["/clients/new"] = _ => {
        List<Stylist> AllStylists = Stylist.GetAll();
        return View["clients_form.cshtml", AllStylists];
      };

      Post["/clients/new"] = _ => {
        Client newClient = new Client(Request.Form["client-name"], Request.Form["stylist-id"], Request.Form["client-contact"]);
        newClient.Save();
        return View["success.cshtml"];
      };

    }
  }
}
