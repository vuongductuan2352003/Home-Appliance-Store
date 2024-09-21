
using DAL;
using BUS;
using DTO;
using NUnit.Framework;
using System;
using System.Globalization;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        //[Test]
        //public void TestGetKhachHang()
        //{
        //    // Khởi tạo đối tượng sut
        //    DAL_KhachHang sut = new DAL_KhachHang();
        //    // Khai báo biến rusult và gán hàm cần kiểm thử
        //    var result = sut.getKHACHHANG();
        //    // Assert
        //    Assert.IsNotNull(result);
        //    Assert.IsTrue(result.Rows.Count > 0);
        //}
        //[Test]
        //public void KiemTraMaKhachHang()
        //{
        //    // Arrange
        //    string maKH = "SFDGFDSGSF";
        //    int expected = 1;

        //    // Act

        //    DAL_KhachHang kh = new DAL_KhachHang();
        //    int actual = kh.kiemtramatrung(maKH);

        //    // Assert
        //    Assert.AreEqual(expected, actual);
        //}
        [Test]
        public void TestThemDung()
        {
            // Sắp xếp
            string ma = "HDN01";
   
            string tenkh = "SP3";
 
            int sl = 1;
            float tt = 5;
            DAL_ChiTietHoaDonNhap kh = new DAL_ChiTietHoaDonNhap();

            DTO_ChiTietHoaDonNhap khH = new DTO_ChiTietHoaDonNhap(ma, tenkh,sl, tt);
            // Thực hiệ
            bool result = kh.themCTHDN(khH);

            // Xác nhận
            Assert.IsTrue(result);
            // Thêm nhiều xác nhận hơn để xác minh thao tác chèn
        }
        //[Test]
        //public void TestThemSai()
        //{
        //    // Sắp xếp
        //    string ma = "KH1";
        //    string ten = "TRAN THANH TAM";

        //    string sdt = "123456789";
        //    string dc = "HUNG YEN";
        //    DAL_KhachHang kh = new DAL_KhachHang();

        //    KhachHang khH = new KhachHang(ma, ten, sdt, dc);
        //    // Thực hiệ
        //    bool result = kh.themKH(khH);

        //    // Xác nhận
        //    Assert.IsTrue(result);
        //    // Thêm nhiều xác nhận hơn để xác minh thao tác chèn
        //}
        //public void TestSua()
        //{
        //    // Sắp xếp
        //    string ma = "KH1";
        //    string ten = "TRAN THANH TAM";

        //    string sdt = "123456789";
        //    string dc = "HUNG YEN";
        //    DAL_KhachHang kh = new DAL_KhachHang();

        //    KhachHang khH = new KhachHang(ma, ten, sdt, dc);
        //    // Thực hiệ
        //    bool result = kh.suaKH(khH);

        //    // Xác nhận
        //    Assert.IsTrue(result);
        //    // Thêm nhiều xác nhận hơn để xác minh thao tác chèn
        //}
        //public void TestXoa()
        //{

        //    string ma = "KH1";

        //    DAL_KhachHang kh = new DAL_KhachHang();
        //    bool result = kh.xoaKH(ma);

        //    Assert.IsTrue(result);
        //}
        //public void TestTimKiem()
        //{
        //    // Arrange
        //    string maKH = "kh1";
        //    int expected = 1;

        //    // Act

        //    DAL_KhachHang kh = new DAL_KhachHang();
        //    int actual = kh.timkiemKH(maKH);

        //    // Assert
        //    Assert.AreEqual(expected, actual);
        //}

        //[Test]
        //public void KiemTraTaiKhoan()
        //{
        //    // Arrange
        //    string tk = "NV21";
        //    string mk = "123";
        //    int expected = 1;

        //    // Act

        //    DAL_Login login = new DAL_Login();
        //    int actual = login.checkLogin(tk, mk);

        //    // Assert
        //    Assert.AreEqual(expected, actual);
        //}

    }
}