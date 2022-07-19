using System.Collections.Generic;

namespace ParcelsCenter.Models
{
  public class Parcel
  {
    public double Width { get; set; }
    public double Height { get; set; }
    public double Length { get; set; }
    public double Weight { get; set; }
    private static List<Parcel> _instances = new List<Parcel> {};

    public Parcel(double width, double height, double length, double weight)
    {
      Width = width;
      Height = height;
      Length = length;
      Weight = weight;
      _instances.Add(this);
    }

    public static List<Parcel> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    
  }
}