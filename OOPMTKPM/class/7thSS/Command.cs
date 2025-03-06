namespace Command
{
  // Command Interface
  public interface ICommand
  {
    void Execute();
  }

  // Receiver - Robot class
  public class Robot2
  {
    public void MoveForward()
    {
      Console.WriteLine("Robot is moving forward");
    }

    public void MoveBackward()
    {
      Console.WriteLine("Robot is moving backward");
    }
  }

  // Concrete Command - Move Forward
  public class MoveForwardCommand : ICommand
  {
    private Robot2 _robot;

    public MoveForwardCommand(Robot2 robot)
    {
      this._robot = robot;
    }

    public void Execute()
    {
      _robot.MoveForward();
    }
  }

  // Concrete Command - Move Backward
  public class MoveBackwardCommand : ICommand
  {
    private Robot2 _robot;

    public MoveBackwardCommand(Robot2 robot)
    {
      this._robot = robot;
    }

    public void Execute()
    {
      _robot.MoveBackward();
    }
  }

  // Invoker - RobotController
  public class RobotController
  {
    private ICommand _command;

    public void SetCommand(ICommand command)
    {
      this._command = command;
    }

    public void ExecuteCommand()
    {
      _command.Execute();
    }
  }
}