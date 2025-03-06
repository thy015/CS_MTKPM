using Adapter;
using Bridge;
using Command;
using Composite;
using Extend_Strategy;
using Extend_Template;
using FacadePattern;
using Flyweight;
using Strategy;
using TemplateMethod;


namespace OOPMTKPM;

public class Program
{
  static void Main(string[] args)
  {
    if (args.Length == 0)
    {
      Console.WriteLine("Please enter the argument");
      return;
    }

    switch (args[0])
    {
      case "5.1":
        Android android = new Android();
        Iphone iPhone = new Iphone();

        Console.WriteLine("Recharging Android with MicroUSB");
        rechargeMicroUsbPhone(android);

        Console.WriteLine("\nRecharging iPhone with Lightning");
        rechargeLightningPhone(iPhone);

        Console.WriteLine("\nRecharging iPhone with MicroUSB (using Adapter)");
        rechargeMicroUsbPhone(new LightningToMicroUsbAdapter(iPhone));


        static void rechargeMicroUsbPhone(MicroUsbPhone phone)
        {
          phone.useMicroUsb();
          phone.recharge();
        }

        static void rechargeLightningPhone(LightningPhone phone)
        {
          phone.useLightning();
          phone.recharge();
        }

        break;
      case "5.2":
        Facade facade = new Facade();
        facade.Operation1();
        facade.Operation2();
        break;
      case "Composite":
        var colas = new Cola(210);
        colas.Flavors.Add(new VanillaCola(215));
        colas.Flavors.Add(new CherryCola(210));
        var lemonLime = new LemonLime(185);
        var rootBeers = new RootBeer(195);
        rootBeers.Flavors.Add(new VanillaRootBeer(200));
        rootBeers.Flavors.Add(new StrawberryRootBeer(200));
        SodaWater sodaWater = new SodaWater(180);
        sodaWater.Flavors.Add(colas);
        sodaWater.Flavors.Add(lemonLime);
        sodaWater.Flavors.Add(rootBeers);
        sodaWater.DisplayCalories();
        Console.ReadKey();
        break;
      case "Bridge":
        // Tạo các giải thuật
        IAlgorithm algorithmA = new AlgorithmA();
        IAlgorithm algorithmB = new AlgorithmB();

        // Tạo đối tượng AlgorithmAbstraction và thiết lập giải thuật ban đầu là AlgorithmA
        AlgorithmAbstraction abstraction = new AlgorithmAbstraction(algorithmA);

        // Giải bài toán bằng giải thuật A
        abstraction.Solve(); // Output: Giải theo giải thuật A

        // Thay đổi giải thuật thành AlgorithmB
        abstraction.SetAlgorithm(algorithmB);

        // Giải bài toán bằng giải thuật B
        abstraction.Solve(); // Output: Giải theo giải thuật B
        break;
      case "Strategy":
        Console.WriteLine("Strategy");
        IChoice ic = null;
        Context cxt = new Context();
        for (int i = 1; i <= 2; i++)
        {
          Console.WriteLine("Enter Choice (1 or 2)");
          string c = Console.ReadLine();
          if (c.Equals("1"))
          {
            ic = new FirstChoice();
          }
          else
          {
            ic = new SecondChoice();
          }
          cxt.SetChoice(ic);
          cxt.ShowChoice();
        }
        Console.ReadKey();
        break;
      case "Extend_Strategy":
        Console.WriteLine("Chọn phương thức thanh toán: ");
        Console.WriteLine("1. Thanh toán trực tiếp");
        Console.WriteLine("2. Thanh toán trả góp");

        PaymentContext paymentContext = new PaymentContext();
        IPayment paymentMethod = null;

        string choice = Console.ReadLine();
        if (choice == "1")
        {
          paymentMethod = new ThanhToanTrucTiep();
        }
        else if (choice == "2")
        {
          paymentMethod = new ThanhToanTraGop();
        }
        else
        {
          Console.WriteLine("Lựa chọn không hợp lệ.");
          return;
        }

        // Set the payment strategy and execute
        paymentContext.SetPaymentMethod(paymentMethod);
        paymentContext.ExecutePayment();

        Console.ReadKey();
        break;
      case "Template":
        Console.WriteLine("Template");
        BasicEngineering bs= new ComputerScience();
        Console.WriteLine("Computer Sc Papers:");
        bs.Papers();
        Console.WriteLine();
        bs = new Electronics();
        Console.WriteLine("Electronics Papers:");
        bs.Papers();
        Console.ReadLine();
        break;
      case "Extend_Template":
        Console.WriteLine("Making Sweet Bread:");
        Bread sweetBread = new SweetBread();
        sweetBread.Make();

        Console.WriteLine("\nMaking Sour Bread:");
        Bread sourBread = new SourBread();
        sourBread.Make();

        Console.ReadLine();
        break;
      case "Command":
        Robot2 robot = new Robot2();
        RobotController controller = new RobotController();

        // Command: Move Forward
        ICommand moveForward = new MoveForwardCommand(robot);
        controller.SetCommand(moveForward);
        controller.ExecuteCommand();

        // Command: Move Backward
        ICommand moveBackward = new MoveBackwardCommand(robot);
        controller.SetCommand(moveBackward);
        controller.ExecuteCommand();

        Console.ReadLine();
        break;
      default:
        Console.WriteLine("Invalid argument");
        break;
    }
  }
}