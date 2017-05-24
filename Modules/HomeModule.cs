using Nancy;
using Places.Objects;
using System.Collections.Generic;

namespace Places
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>{
        return View["index.cshtml"];
      };
      Get["/form/new"] = _ => {
        return View["form.cshtml"];
      };

      Get["/confirm"] = _ => {
        List<Place> allPlace = Place.GetAll();
        return View["confirm.cshtml"];
      };
      Post["/confirm"] = _ => {
        Place newPlace = new Place(Request.Form["city"], Request.Form["country"], Request.Form["image"], Request.Form["dates"], Request.Form["description"]);
        List<Place> allPlace = Place.GetAll();
        return View["confirm.cshtml", allPlace];
      };
      Get["/place/{id}"] = parameters => {
        Place place = Place.Find(parameters.id);
        return View["place.cshtml", place];
      };
    }
  }
}
