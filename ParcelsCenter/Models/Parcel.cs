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

    public Parcel(double length, double width, double height, double weight)
    {
      Length = length;
      Width = width;
      Height = height;
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

    public double Volume()
    {
      double volume = Length * Width * Height;
      return volume;
    }

    public double CostToShip()
    {
      double volumeCost, weightCost; 
      weightCost = Weight * 2;
      volumeCost = 20;
      double costToShip = weightCost + volumeCost;
      return costToShip;
    }
  }
}