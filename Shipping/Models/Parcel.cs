using System.Collections.Generic;

namespace Shipping.Models
{
  public class Parcel
  {
    private int _height;
    private int _width;
    private int _depth;
    private int _weight;
    private int _parcelId;
    private int _currentId = 0;
    private static List<Parcel> _instances = new List<Parcel> {};

    public Parcel (int height, int width, int depth, int weight)
    {
      _height = height;
      _width = width;
      _depth = depth;
      _weight = weight;
      _parcelId = _currentId;
      _currentId ++;
      _instances.Add(this);
    }

    public int Height {get=>_height; set=>_height = value;}
    public int Width {get=>_width; set=>_width = value;}
    public int Depth {get=>_depth; set=>_depth = value;}
    public int Weight {get=>_weight; set=>_weight = value;}

    public static List<Parcel> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public int Volume()
    {
      return (_height * _width * _depth);
    }

    public int CostShip()
    {
      return ((Volume() * weight) / 5);
    }

  }
}
