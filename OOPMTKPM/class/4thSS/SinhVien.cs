public interface ISinhVien
{
  string DiHoc();
}

// Lớp Sinh Viên Bình Thường
public class SinhVienThuong : ISinhVien
{
  protected string Ten;
  protected int Tuoi;
  protected string DiaChi;

  public SinhVienThuong(string ten, int tuoi, string diaChi)
  {
    Ten = ten;
    Tuoi = tuoi;
    DiaChi = diaChi;
  }

  public virtual string DiHoc()
  {
    return $"Sinh viên {Ten} đang học bài.";
  }
}

// Lớp Decorator
public abstract class SinhVienDecorator : ISinhVien
{
  protected ISinhVien _sinhVien;

  public SinhVienDecorator(ISinhVien sinhVien)
  {
    _sinhVien = sinhVien;
  }

  public virtual string DiHoc()
  {
    return _sinhVien.DiHoc();
  }
}

// Sinh Viên Chuyên Toán
public class SinhVienChuyenToan : SinhVienDecorator
{
  private double DiemToan;

  public SinhVienChuyenToan(ISinhVien sinhVien, double diemToan) : base(sinhVien)
  {
    DiemToan = diemToan;
  }

  public string DiThiToan()
  {
    return $"Sinh viên {_sinhVien.DiHoc().Split(' ')[2]} đi thi toán.";
  }

  public override string DiHoc()
  {
    return _sinhVien.DiHoc() + " " + DiThiToan();
  }
}

// Sinh Viên Chuyên Tin
public class SinhVienChuyenTin : SinhVienDecorator
{
  private double DiemTinHoc;

  public SinhVienChuyenTin(ISinhVien sinhVien, double diemTinHoc) : base(sinhVien)
  {
    DiemTinHoc = diemTinHoc;
  }

  public string DiThiTinHoc()
  {
    return $"Sinh viên {_sinhVien.DiHoc().Split(' ')[2]} đi thi tin học.";
  }

  public override string DiHoc()
  {
    return _sinhVien.DiHoc() + " " + DiThiTinHoc();
  }
}