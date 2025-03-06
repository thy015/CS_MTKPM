namespace Bridge
{
  public interface IAlgorithm
  {
    void Solve();
  }
  
  public class AlgorithmA : IAlgorithm
  {
    public void Solve()
    {
      Console.WriteLine("Giải theo giải thuật A");
    }
  }

  public class AlgorithmB : IAlgorithm
  {
    public void Solve()
    {
      Console.WriteLine("Giải theo giải thuật B");
    }
  }
  
  public class AlgorithmAbstraction
  {
    protected IAlgorithm _algorithm;

    // Constructor để thiết lập giải thuật
    public AlgorithmAbstraction(IAlgorithm algorithm)
    {
      _algorithm = algorithm;
    }

    // Phương thức để thay đổi giải thuật tại thời điểm chạy
    public void SetAlgorithm(IAlgorithm algorithm)
    {
      _algorithm = algorithm;
    }

    // Phương thức giải quyết bài toán
    public void Solve()
    {
      _algorithm.Solve();
    }
  }
}