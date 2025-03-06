
namespace Extend_Strategy
{
  public interface IPayment
  {
    void ProcessPayment();
  }

  // Direct Payment Strategy
  public class ThanhToanTrucTiep : IPayment
  {
    public void ProcessPayment()
    {
      Console.WriteLine("Thanh toán trực tiếp thành công!");
    }
  }

  // Installment Payment Strategy
  public class ThanhToanTraGop : IPayment
  {
    public void ProcessPayment()
    {
      Console.WriteLine("Thanh toán trả góp thành công!");
    }
  }
  
  public class PaymentContext
  {
    private IPayment paymentMethod;

    // Set Payment Strategy
    public void SetPaymentMethod(IPayment paymentMethod)
    {
      this.paymentMethod = paymentMethod;
    }

    // Execute Selected Payment Method
    public void ExecutePayment()
    {
      paymentMethod.ProcessPayment();
    }
  }

}