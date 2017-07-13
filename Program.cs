using System;
using System.Linq;
using System.Collections.Generic;

public interface IVehicle
{
    int PassengerCapacity { get; set; }
    string TransmissionType { get; set; }
    double EngineVolume { get; set; }
    void Start();
    void Stop();
    void Drive();
}

public interface IDoors
{
    int Doors { get; set; }

}

public interface IWheels
{
    int Wheels { get; set; }

}
public interface IWaterbased
{
    double MaxWaterSpeed { get; set; }
    void Drive();

}

public interface IGroundbased
{
    double MaxLandSpeed { get; set; }
    void Drive();
}

public interface IAirbased
{
    double MaxAirSpeed { get; set; }
    void Fly();
}

public interface IWinged
{
    bool Winged { get; set; }
}

public class JetSki : IVehicle, IWaterbased
{
    public int PassengerCapacity { get; set; }
    public string TransmissionType { get; set; }
    public double EngineVolume { get; set; }
    public double MaxWaterSpeed { get; set; }

    public void Drive()
    {
        Console.WriteLine("The jetski zips through the waves with the greatest of ease");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class HotAirBalloon : IVehicle, IAirbased, IDoors
{
    public int PassengerCapacity { get; set; }
    public string TransmissionType { get; set; }
    public double EngineVolume { get; set; }
    public double MaxWaterSpeed { get; set; }
    public bool Winged { get; set; }
    public double MaxAirSpeed { get; set; }
    public int Doors { get; set; }

    public void Drive()
    {
        Console.WriteLine("The hot air balloon zips through the air with the greatest of ease");
    }
    public void Fly()
    {
        Console.WriteLine("The hot air balloon zips through the air with the greatest of ease");
    }
    public void Start()
    {
        throw new NotImplementedException();
    }
    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class Motorcycle : IVehicle, IGroundbased, IWheels
{
    public int Wheels { get; set; } = 2;
    public int PassengerCapacity { get; set; }
    public string TransmissionType { get; set; } = "Manual";
    public double EngineVolume { get; set; } = 1.3;
    public double MaxLandSpeed { get; set; } = 160.4;

    public void Drive()
    {
        Console.WriteLine("The motorcycle screams down the highway");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class Cessna : IVehicle, IDoors, IWheels, IGroundbased
{
  public int Wheels { get; set; } = 3;
  public int Doors { get; set; } = 3;
  public int PassengerCapacity { get; set; } = 113;
  public string TransmissionType { get; set; } = "None";
  public double EngineVolume { get; set; } = 31.1;
  public double MaxLandSpeed { get; set; }
  public void Drive()
  {
    Console.WriteLine("Plane car is driving");
  }
  public void Start()
  {
    throw new NotImplementedException();
  }
  public void Stop()
  {
    throw new NotImplementedException();
  }
}

public class Hatchback : IVehicle, IDoors, IWheels, IGroundbased
{
  public int Wheels { get; set; } = 3;
  public int Doors { get; set; } = 3;
  public int PassengerCapacity { get; set; } = 113;
  public string TransmissionType { get; set; } = "None";
  public double EngineVolume { get; set; } = 31.1;
  public double MaxLandSpeed { get; set; }
  public void Drive()
  {
    Console.WriteLine("Hatchback is driving");
  }
  public void Start()
  {
    throw new NotImplementedException();
  }
  public void Stop()
  {
    throw new NotImplementedException();
  }
}

public class Program
{

    public static void Main() {

        // Build a collection of all vehicles that fly
        HotAirBalloon balloon1 = new HotAirBalloon();
        HotAirBalloon balloon2 = new HotAirBalloon();

        List <IAirbased> flyingstuff = new List<IAirbased>();
        flyingstuff.Add(balloon1);
        flyingstuff.Add(balloon2);

        // With a single `foreach`, have each vehicle Fly()
        foreach (IAirbased item in flyingstuff)
        {
            item.Fly();
        }

        // Build a collection of all vehicles that operate on roads
        Motorcycle motorcycle1 = new Motorcycle();
        Motorcycle motorcycle2 = new Motorcycle();
        Hatchback hondafit = new Hatchback();
        Cessna planecar = new Cessna();
        
        List <IGroundbased> groundstuff = new List<IGroundbased>();
        groundstuff.Add(motorcycle1);
        groundstuff.Add(motorcycle2);
        groundstuff.Add(hondafit);
        groundstuff.Add(planecar);

        // With a single `foreach`, have each road vehicle Drive()
        foreach (IGroundbased item in groundstuff)
        {
            item.Drive();
        }

        // Build a collection of all vehicles that operate on water
        JetSki jetski1 = new JetSki();
        JetSki jetski2 = new JetSki();
        
        List <IWaterbased> waterstuff = new List<IWaterbased>();
        waterstuff.Add(jetski1);
        waterstuff.Add(jetski2);

        // With a single `foreach`, have each water vehicle Drive()
        foreach (IWaterbased item in waterstuff)
        {
            item.Drive();
        }
    }

}