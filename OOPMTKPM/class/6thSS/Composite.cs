namespace Composite
{
  public abstract class SoftDrink
  {
    public int Calories { get; set; }
    public List<SoftDrink> Flavors { get; set; }

    public SoftDrink(int calories)
    {
      Calories = calories;
      Flavors = new List<SoftDrink>();
    }

    public void DisplayCalories()
    {
      Console.WriteLine(this.GetType().Name + ": " +
                        this.Calories.ToString() + " calories.");
      foreach (var drink in this.Flavors)
      {
        drink.DisplayCalories();
      }
    }
  }


  public class VanillaCola : SoftDrink
  {
    public VanillaCola(int calories) : base(calories)
    {
    }
  }

  public class CherryCola : SoftDrink
  {
    public CherryCola(int calories) : base(calories)
    {
    }
  }

  public class StrawberryRootBeer : SoftDrink
  {
    public StrawberryRootBeer(int calories) : base(calories)
    {
    }
  }

  public class VanillaRootBeer : SoftDrink
  {
    public VanillaRootBeer(int calories) : base(calories)
    {
    }
  }

  public class LemonLime : SoftDrink
  {
    public LemonLime(int calories) : base(calories)
    {
    }
  }


  public class Cola : SoftDrink
  {
    public Cola(int calories) : base(calories)
    {
    }
  }

  public class RootBeer : SoftDrink
  {
    public RootBeer(int calories) : base(calories)
    {
    }
  }

  public class SodaWater : SoftDrink
  {
    public SodaWater(int calories) : base(calories)
    {
    }
  }
}