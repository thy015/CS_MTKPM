namespace OOPMTKPM.Class._1stSS;

public class Animal
{
  public string name { get; set; }

  public Animal()
  {
  }

  public Animal(string name)
  {
    this.name = name;
  }

  public virtual void Input()
  {
    Console.Write("Enter name for Animal: ");
    this.name = Console.ReadLine();
  }

  public virtual void Output()
  {
    Console.WriteLine("Animal name: " + this.name);
  }

  public void eat()
  {
    Console.WriteLine(this.name + "is eating");
  }
}

public class Lion : Animal
{
  public string lionKind { get; set; }

  public Lion()
  {
  }

  public Lion(string name, string lionKind)
  {
    this.name = name;
    this.lionKind = lionKind;
  }

  public override void Input()
  {
    base.Input();
    Console.Write("Enter kind of Lion: ");
    this.lionKind = Console.ReadLine();
  }

  public override void Output()
  {
    base.Output();
    Console.WriteLine("Lion kind: " + this.lionKind);
  }

  public void hunt()
  {
    Console.WriteLine(this.name + "is hunting");
  }
}

public class Whale : Animal
{
  public string whaleKind { get; set; }

  public Whale()
  {
  }

  public Whale(string name, string whaleKind)
  {
    this.name = name;
    this.whaleKind = whaleKind;
  }

  public override void Input()
  {
    base.Input();
    Console.Write("Enter kind of Whale: ");
    this.whaleKind = Console.ReadLine();
  }

  public override void Output()
  {
    base.Output();
    Console.WriteLine("Whale kind: " + this.whaleKind);
  }

  public void swim()
  {
    Console.WriteLine(this.name + "is swimming");
  }
}