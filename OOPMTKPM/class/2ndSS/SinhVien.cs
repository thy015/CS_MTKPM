namespace OOPMTKPM.Class._2ndSS;

public class SinhVien
{
  public string name { get; set; }
  public int age { get; set; }
  public string address { get; set; }

  public virtual string DiHoc()
  {
    return "Sinh vien " + name + age + address + " di hoc";
  }

  public virtual SinhVien Clone()
  {
    return (SinhVien)this.MemberwiseClone();
  }
}

public class ChuyenToan : SinhVien
{
  public override string DiHoc()
  {
    return "Sinh vien chuyen toan di hoc";
  }

  public string DiThiChuyenToan()
  {
    return "Sinh vien chuyen toan di thi";
  }

  public override SinhVien Clone()
  {
    return (ChuyenToan)this.MemberwiseClone();
  }
}

public class ChuyenTin : SinhVien
{
  public override string DiHoc()
  {
    return "Sinh vien chuyen tin di hoc";
  }

  public string DiThiChuyenTin()
  {
    return "Sinh vien chuyen tin di thi";
  }

  public override SinhVien Clone()
  {
    return (ChuyenTin)this.MemberwiseClone();
  }
}