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

    }
  }
}
