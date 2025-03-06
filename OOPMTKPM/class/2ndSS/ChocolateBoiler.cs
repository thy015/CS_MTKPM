namespace OOPMTKPM.Class._2ndSS;

public class ChocolateBoiler
{
  private static ChocolateBoiler instance;
  private bool empty;
  private bool boiled;

  private ChocolateBoiler()
  {
    empty = true;
    boiled = false;
  }

  public bool isEmpty()
  {
    return empty;
  }

  public bool isBoiled()
  {
    return boiled;
  }

  public void fill()
  {
    if (isEmpty())
    {
      empty = false;
      boiled = false;
    }
  }

  public void drain()
  {
    if (!isEmpty() && isBoiled())
    {
      empty = true;
    }
  }

  public void boil()
  {
    if (!isEmpty() && !isBoiled())
    {
      boiled = true;
    }
  }

  public static ChocolateBoiler GetInstance()
  {
    if (instance == null)
    {
      instance = new ChocolateBoiler();
    }

    return instance;
  }
}