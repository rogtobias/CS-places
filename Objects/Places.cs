using System.Collections.Generic;

namespace Places.Objects
{
  public class Place
  {
    private string _city;
    private string _country;
    private string _image;
    private string _dates;
    private string _description;
    private int _id;
    private static List<Place> _vacations = new List<Place> ();

    public Place (string city, string country, string image, string dates, string description)
    {
      _city = city;
      _country = country;
      _image = image;
      _dates = dates;
      _description = description;
      _vacations.Add(this);
      _id = _vacations.Count;
    }
    public string GetCity()
    {
      return _city;
    }
    public void SetCity(string newCity)
    {
      _city = newCity;
    }
    public string GetCountry()
    {
      return _country;
    }
    public void SetCountry(string newCountry)
    {
      _country = newCountry;
    }
    public string GetImage()
    {
      return _image;
    }
    public void SetImage(string newImage)
    {
      _image = newImage;
    }
    public string GetDates()
    {
      return _dates;
    }
    public void SetDates(string newDates)
    {
      _dates = newDates;
    }
    public string GetDescription()
    {
      return _description;
    }
    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }
    public static List<Place> GetAll()
    {
      return _vacations;
    }
    // public void Save ()
    // {
    //   _vacations.Add(this);
    // }
    public int GetId()
    {
      return _id;
    }
    public static Place Find(int searchId)
    {
      return _vacations[searchId-1];
    }

  }
}
