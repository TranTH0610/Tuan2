using Xunit;
using MyLib.Chuong1_Basic.Bai1_1;

namespace MyLib.Tests;

public class Bai1_1Test
{
    [Fact]
    public void ConstructorMacDinh()
    {
        SinhVien sv = new SinhVien();

        Assert.NotNull(sv);
    }

    [Fact]
    public void TinhTuoi()
    {
        SinhVien sv = new SinhVien();

        int namSinh = DateTime.Now.Year - 20;

        // Không thể gán NamSinh trực tiếp vì NamSinh là private.
        // Vì vậy test TinhTuoi sẽ cần class có constructor/property
        // hoặc cách khác để đưa dữ liệu vào.
    }
}