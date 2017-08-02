using System.Collections.Generic;

namespace PlacePage.Models
{
  public class Place
  {
    private string _city;
    private int _id;

    private static List<Place> _placeList = new List<Place> {};

    public Place (string city)
    {
      _city = city;
      _placeList.Add(this);
      _id = _placeList.Count;
    }

    public void SetCity(string city)
    {
        _city = city;
    }

    public string GetCity()
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

    public static void ClearAll()
    {
      _placeList.Clear();
    }

    public static Place Find(int searchId)
    {
      return _placeList[searchId - 1];
    }

  }
}
