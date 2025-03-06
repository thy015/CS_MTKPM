namespace Extend_Template
{
  public abstract class Bread
  {
    // Common method: Mixing Ingredients
    public void MixIngredients()
    {
      Console.WriteLine("Mixing ingredients for bread");
    }

    // Common method: Baking
    public void Bake()
    {
      Console.WriteLine("Baking for bread");
    }

    // Abstract method: Slide
    public abstract void Slide();

    // Template Method
    public void Make()
    {
      MixIngredients();
      Bake();
      Slide();
    }
  }

  // SweetBread class inheriting from Bread
  public class SweetBread : Bread
  {
    public override void Slide()
    {
      Console.WriteLine("Slicing the Sweet Bread");
    }
  }

  // SourBread class inheriting from Bread
  public class SourBread : Bread
  {
    public override void Slide()
    {
      Console.WriteLine("Slicing the Sour Bread");
    }
  }

}