namespace Strategy
{
  public interface IChoice
  {
    void MyChoice();
  }
  
  public class FirstChoice : IChoice
  {
    public void MyChoice()
    {
      Console.WriteLine("Traveling to Japan");
    }
  }
  public class SecondChoice : IChoice
  {
    public void MyChoice()
    {
      Console.WriteLine("Traveling to India");
    }
  }

  public class Context
  {
    private IChoice choice;
    public void SetChoice(IChoice choice)
    {
      this.choice = choice;
    }
    public void ShowChoice()
    {
      choice.MyChoice();
    }
  }
}