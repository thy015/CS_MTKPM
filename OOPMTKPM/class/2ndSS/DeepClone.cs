namespace OOPMTKPM.Class._2ndSS;

public class Engine
{
  public string Model { get; set; }
  public int HorsePower { get; set; }

  // Phương thức sao chép sâu (Deep Clone)
  public Engine DeepClone()
  {
    return new Engine
    {
      Model = this.Model,
      HorsePower = this.HorsePower
    };
  }
}

// Class Car
public class CarHaveEngine
{
  public string Make { get; set; }
  public string Model { get; set; }
  public Engine Engine { get; set; }

  // Phương thức sao chép sâu (Deep Clone)
  public CarHaveEngine DeepClone()
  {
    return new CarHaveEngine
    {
      Make = this.Make,
      Model = this.Model,
      Engine = this.Engine?.DeepClone()
    };
  }
}