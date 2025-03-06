namespace OOPMTKPM.Class._1stSS;

public class Car
{
  // Fields
  private int maxSpeed;
  private int seats;
  private int year;

  // Default constructor
  public Car()
  {
    this.maxSpeed = 0;
    this.seats = 0;
    this.year = 0;
  }

  // Parameterized constructor
  public Car(int maxSpeed, int seats, int year)
  {
    this.maxSpeed = maxSpeed;
    this.seats = seats;
    this.year = year;
  }

  // Properties
  public int MaxSpeed
  {
    get { return maxSpeed; }
    set { maxSpeed = value; }
  }

  public int Seats
  {
    get { return seats; }
    set { seats = value; }
  }

  public int Year
  {
    get { return year; }
    set { year = value; }
  }

  // Input method
  public virtual void Input()
  {
    Console.Write("Enter max speed: ");
    this.maxSpeed = int.Parse(Console.ReadLine());
    Console.Write("Enter number of seats: ");
    this.seats = int.Parse(Console.ReadLine());
    Console.Write("Enter year of manufacture: ");
    this.year = int.Parse(Console.ReadLine());
  }

  // Output method
  public virtual void Output()
  {
    Console.WriteLine($"Car Details:");
    Console.WriteLine($"Max Speed: {this.maxSpeed} km/h");
    Console.WriteLine($"Seats: {this.seats}");
    Console.WriteLine($"Year of Manufacture: {this.year}");
  }
}

public class Ford : Car
{
  private int warrantyYears;

  // Default constructor
  public Ford() : base()
  {
    this.warrantyYears = 0;
  }

  // Parameterized constructor
  public Ford(int maxSpeed, int seats, int year, int warrantyYears) : base(maxSpeed, seats, year)
  {
    this.warrantyYears = warrantyYears;
  }

  public int WarrantyYears
  {
    get { return warrantyYears; }
    set { warrantyYears = value; }
  }

  public void FordInput()
  {
    base.Input();
    Console.Write("Enter warranty years: ");
    this.warrantyYears = int.Parse(Console.ReadLine());
  }

  public void FordOutput()
  {
    base.Output();
    Console.WriteLine($"Warranty Years: {this.warrantyYears}");
  }

  public void Run()
  {
    Console.WriteLine("Ford is running");
  }

  public static void CompareFords(Ford ford1, Ford ford2)
  {
    int totalWarranty = ford1.WarrantyYears + ford2.WarrantyYears;
    Console.WriteLine($"Total Warranty Years: {totalWarranty}");

    if (ford1.Seats > ford2.Seats)
    {
      Console.WriteLine("The first Ford has more seats.");
    }
    else if (ford1.Seats < ford2.Seats)
    {
      Console.WriteLine("The second Ford has more seats.");
    }
    else
    {
      Console.WriteLine("Both Fords have the same number of seats.");
    }
  }
}