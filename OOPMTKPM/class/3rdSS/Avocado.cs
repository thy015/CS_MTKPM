public interface IProduct
{
  void ShipFrom();
}

// (Bơ từ Nhật Bản)
public class ProductA : IProduct
{
  public void ShipFrom()
  {
    Console.WriteLine("Shipping from Japan");
  }
}

// (Bơ từ Brazil)
public class ProductB : IProduct
{
  public void ShipFrom()
  {
    Console.WriteLine("Shipping from Brazil");
  }
}

public class ButterFactory
{
  public static IProduct GetProduct(int month)
  {
    if (month >= 1 && month <= 4)
      return new ProductA(); // Japan (Jan - Apr)
    else
      return new ProductB(); // Brazil (May - Dec)
  }
}