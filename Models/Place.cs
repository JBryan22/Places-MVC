using System.Collections.Generic;

namespace Place.Models
{
  public class Place
  {
    private string _city;
    private int _id;

    private static List<Place> _placeList = new List<Place> {};

    public Place (city)
    {
      _city = city;
      _placeList.Add(this);
      _id = _placeList.Count;

    }

    public void SetTitle(string title)
    {
        _city = city;
    }

    public string GetTitle()
    {
        return _city;
    }

    public int GetId()
    {
      return _id;
    }

    public static List<Place> GetAllPlaces()
    {
      return _placeList;
    }

    public static ClearAll()
    {
      _placeList.Clear();
    }

  }
}