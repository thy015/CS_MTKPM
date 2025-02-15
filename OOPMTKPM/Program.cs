
class Program
{
    static void Main(string[] args)
    {
        RobotDirector director = new RobotDirector();

        // Tạo HelpingRobot
        IRobotBuilder helpingRobotBuilder = new HelpingRobotBuilder();
        director.Construct(helpingRobotBuilder);
        HelpingRobot helpingRobot = (HelpingRobot)helpingRobotBuilder.GetRobot();
        helpingRobot.ID = "H-001";
        helpingRobot.Name = "Helper-X";
        helpingRobot.DisplayInfo();
        Console.WriteLine(helpingRobot.HelpPeople());
        
        Console.WriteLine("\n-----------------------------\n");

        // Tạo WarRobot
        IRobotBuilder warRobotBuilder = new WarRobotBuilder();
        director.Construct(warRobotBuilder);
        WarRobot warRobot = (WarRobot)warRobotBuilder.GetRobot();
        warRobot.ID = "W-101";
        warRobot.Name = "Warrior-Z";
        warRobot.DisplayInfo();
        Console.WriteLine(warRobot.Fighting());
        
        for (int month = 1; month <= 12; month++)
        {
            Console.Write($"Month {month}: ");
            IProduct product = ButterFactory.GetProduct(month);
            product.ShipFrom();
        }
        
        ISinhVien svThuong = new SinhVienThuong("An", 20, "Hà Nội");
        Console.WriteLine(svThuong.DiHoc());

        ISinhVien svChuyenToan = new SinhVienChuyenToan(svThuong, 9.5);
        Console.WriteLine(svChuyenToan.DiHoc());

        ISinhVien svChuyenTin = new SinhVienChuyenTin(svThuong, 8.7);
        Console.WriteLine(svChuyenTin.DiHoc());
    }
}