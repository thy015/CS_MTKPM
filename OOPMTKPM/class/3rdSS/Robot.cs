public abstract class Robot
{
  public string ID { get; set; }
  public string Name { get; set; }
  public string Head { get; set; }
  public string Hand { get; set; }
  public string Leg { get; set; }
  public string Body { get; set; }

  public void DisplayInfo()
  {
    Console.WriteLine($"Robot ID: {ID}, Name: {Name}");
    Console.WriteLine($"Head: {Head}, Hand: {Hand}, Leg: {Leg}, Body: {Body}");
  }
}

// 2. HelpingRobot inherit robot
public class HelpingRobot : Robot
{
  public string HelpPeople()
  {
    return "Robot is helping people.";
  }
}

// 3. WarRobot inherit Robot
public class WarRobot : Robot
{
  public string Fighting()
  {
    return "Robot is fighting.";
  }
}

// 4.Interface IRobotBuilder
public interface IRobotBuilder
{
  void BuildHead();
  void BuildHand();
  void BuildLeg();
  void BuildBody();
  Robot GetRobot();
}

// 5. Implement Builder for HelpingRobot
public class HelpingRobotBuilder : IRobotBuilder
{
  private HelpingRobot robot = new HelpingRobot();

  public void BuildHead()
  {
    robot.Head = "Basic Head";
    Console.WriteLine("Helping Robot is installed with Head");
  }

  public void BuildHand()
  {
    robot.Hand = "Helping Hands";
    Console.WriteLine("Helping Robot is installed with Hand");
  }

  public void BuildLeg()
  {
    robot.Leg = "Walking Legs";
    Console.WriteLine("Helping Robot is installed with Leg");
  }

  public void BuildBody()
  {
    robot.Body = "Basic Body";
    Console.WriteLine("Helping Robot is installed with Body");
  }

  public Robot GetRobot()
  {
    return robot;
  }
}

// 6. Implement Builder for WarRobot
public class WarRobotBuilder : IRobotBuilder
{
  private WarRobot robot = new WarRobot();

  public void BuildHead()
  {
    robot.Head = "Warrior Head";
    Console.WriteLine("War Robot is installed with Head");
  }

  public void BuildHand()
  {
    robot.Hand = "Weaponized Hands";
    Console.WriteLine("War Robot is installed with Hand");
  }

  public void BuildLeg()
  {
    robot.Leg = "Steel Legs";
    Console.WriteLine("War Robot is installed with Leg");
  }

  public void BuildBody()
  {
    robot.Body = "Armor Body";
    Console.WriteLine("War Robot is installed with Body");
  }

  public Robot GetRobot()
  {
    return robot;
  }
}

// 7. RobotDirector 
public class RobotDirector
{
  public void Construct(IRobotBuilder builder)
  {
    builder.BuildHead();
    builder.BuildHand();
    builder.BuildLeg();
    builder.BuildBody();
  }
}