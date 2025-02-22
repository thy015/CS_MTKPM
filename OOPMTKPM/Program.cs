using Adapter;
using FacadePattern;
using Flyweight;


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
            // case "5.3":
            //     Animal lion1 = AnimalFactory.GetAnimalFromFactory("Carnivore", "Lion");
            //     lion1.Age = 5;
            //     lion1.Eat();
            //
            //     Animal lion2 = AnimalFactory.GetAnimalFromFactory("Carnivore", "Lion");
            //     lion2.Age = 7;
            //     lion2.Eat();
            //
            //     Animal deer = AnimalFactory.GetAnimalFromFactory("Herbivore", "Deer");
            //     deer.Age = 3;
            //     deer.Eat();
            //
            //     Console.WriteLine($"\nSame lion object? {ReferenceEquals(lion1, lion2)}");
            //     break;
            default:
                Console.WriteLine("Invalid argument");
                break;
        }
    }
}