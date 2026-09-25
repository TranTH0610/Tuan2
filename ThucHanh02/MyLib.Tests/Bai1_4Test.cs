namespace MyLib.Tests;

public class Bai1_4Test
{
    [Fact]
public void TuBang0_KetQuaBang0()
{
    PhanSo p = new PhanSo(0, 5);

    Assert.Equal("0", p.ToString());
}

[Fact]
public void MauAm_DuaDauAmLenTu()
{
    PhanSo p = new PhanSo(1, -2);

    Assert.Equal("-1/2", p.ToString());
}

[Fact]
public void TuVaMauDeuAm_KetQuaDuong()
{
    PhanSo p = new PhanSo(-2, -4);

    Assert.Equal("1/2", p.ToString());
}

[Fact]
public void PhanSoChuaToiGian_TuDongRutGon()
{
    PhanSo p = new PhanSo(10, 20);

    Assert.Equal("1/2", p.ToString());
}
}
