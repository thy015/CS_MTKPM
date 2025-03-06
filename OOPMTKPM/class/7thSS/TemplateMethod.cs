
namespace TemplateMethod
{
  public abstract class BasicEngineering
  {
    public void Papers()
    {
      Math();
      SoftSkills();
      SpecialPaper();
    }
    private void Math()
    {
      Console.WriteLine("Mathematics");
    }
    private void SoftSkills()
    {
      Console.WriteLine("SoftSkills");
    }
    public abstract void SpecialPaper();
  }
  
  public class Electronics:BasicEngineering
  {
    public override void SpecialPaper()
    {
      Console.WriteLine("Digital Logic and Circuit Theory");
    }
  }
  
  public class ComputerScience:BasicEngineering
  {
    public override void SpecialPaper()
    {
      Console.WriteLine("Object Oriented Programming");
    }
  }
  
}