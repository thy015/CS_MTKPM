// See https://aka.ms/new-console-template for more information
using OOPMTKPM.Class._1stSS;
using OOPMTKPM.Class._2ndSS;
class Program
{
    static void Main(string[] args)
    {
        // // B1, B2
        //
        //     List<Car> cars = new List<Car>();
        //
        //     for (int i = 0; i < 2; i++)
        //     {
        //         Console.WriteLine($"Enter details for Car {i + 1}:");
        //         Car car = new Car();
        //         car.Input();
        //         cars.Add(car);
        //     }
        //
        //     Console.WriteLine("\nDetails of the Cars Entered:");
        //     foreach (var car in cars)
        //     {
        //         car.Output();
        //     }
        //     
        //
        // // B2
        // Ford ford1 = new Ford();
        // Console.WriteLine("Enter details for the first Ford:");
        // ford1.FordInput();
        //
        // Ford ford2 = new Ford();
        // Console.WriteLine("Enter details for the second Ford:");
        // ford2.FordInput();
        //
        // Console.WriteLine("\nDetails of the first Ford:");
        // ford1.FordOutput();
        //
        // Console.WriteLine("\nDetails of the second Ford:");
        // ford2.FordOutput();
        //
        // Console.WriteLine("\nComparison of the two Fords:");
        // Ford.CompareFords(ford1, ford2);
        //
        // Console.WriteLine("\nRunning the first Ford:");
        // ford1.Run();
        // // B3, B4
        // Lion lion = new Lion();
        // lion.Input(); 
        // lion.Output(); 
        // lion.eat(); 
        // lion.hunt(); 
        //
        // Console.WriteLine(); 
        //
        // // Create a Whale instance
        // Whale whale = new Whale();
        // whale.Input(); 
        // whale.Output(); 
        // whale.eat(); 
        // whale.swim(); 
        //
        // Console.ReadLine();
        // // Tạo sinh viên Chuyên Toán
        // ChuyenToan sv1 = new ChuyenToan();
        // Console.Write("Enter name for Chuyen Toan student: ");
        // sv1.name = Console.ReadLine();
        // Console.Write("Enter address for Chuyen Toan student: ");
        // sv1.address = Console.ReadLine();
        // Console.Write("Enter age for Chuyen Toan student: ");
        // sv1.age = int.Parse(Console.ReadLine());
        //
        // // Tạo sinh viên Chuyên Tin
        // ChuyenTin sv2 = new ChuyenTin
        // {
        //     name = "Tran Thi B",
        //     address = "Da Nang",
        //     age = 21
        // };
        //
        // Console.WriteLine(sv1.DiHoc());
        // Console.WriteLine(sv1.DiThiChuyenToan());
        // Console.WriteLine(sv2.DiHoc());
        // Console.WriteLine(sv2.DiThiChuyenTin());
        //
        // ChuyenToan sv1Clone = (ChuyenToan)sv1.Clone();
        // ChuyenTin sv2Clone = (ChuyenTin)sv2.Clone();
        //
        // Console.WriteLine($"Sinh viên sao chép 1: {sv1Clone.name}, {sv1Clone.age}, {sv1Clone.address}");
        // Console.WriteLine($"Sinh viên sao chép 2: {sv2Clone.name}, {sv2Clone.age}, {sv2Clone.address}");
        
        // Tạo đối tượng Car ban đầu với một Engine
        var originalCar = new CarHaveEngine
        {
            Make = "Tesla",
            Model = "Model S",
            Engine = new Engine { Model = "Electric", HorsePower = 1020 }
        };

        // Sử dụng phương thức DeepClone để tạo một bản sao của Car
        var clonedCar = originalCar.DeepClone();

        // Thay đổi giá trị trong bản sao, không ảnh hưởng đến bản gốc
        clonedCar.Make = "Ford";
        clonedCar.Engine.HorsePower = 800;

        // Hiển thị thông tin của Car gốc và Car đã sao chép
        Console.WriteLine("Original Car: ");
        Console.WriteLine($"Make: {originalCar.Make}, Model: {originalCar.Model}, Engine: {originalCar.Engine.Model}, HorsePower: {originalCar.Engine.HorsePower}");

        Console.WriteLine("\nCloned Car: ");
        Console.WriteLine($"Make: {clonedCar.Make}, Model: {clonedCar.Model}, Engine: {clonedCar.Engine.Model}, HorsePower: {clonedCar.Engine.HorsePower}");
    }
}