using System;
using System.Collections.Generic;

class ChuyenXe
{
    public string MaSoChuyen { get; set; }
    public string HoTenTaiXe { get; set; }
    public string SoXe { get; set; }
    public double DoanhThu { get; set; }

    public virtual void XuatThongTin()
    {
        Console.WriteLine("Ma so chuyen: {0}", MaSoChuyen);
        Console.WriteLine("Ho ten tai xe: {0}", HoTenTaiXe);
        Console.WriteLine("So xe: {0}", SoXe);
        Console.WriteLine("Doanh thu: {0} VNĐ", DoanhThu);
    }
}

class ChuyenXeNoiThanh : ChuyenXe
{
    public int SoTuyen { get; set; }
    public double SoKmDiDuoc { get; set; }

    public override void XuatThongTin()
    {
        base.XuatThongTin();
        Console.WriteLine("So tuyen: {0}", SoTuyen);
        Console.WriteLine("So km đi đuoc: {0} km", SoKmDiDuoc);
    }
}

class ChuyenXeNgoaiThanh : ChuyenXe
{
    public string NoiDen { get; set; }
    public int SoNgayDiDuoc { get; set; }

    public override void XuatThongTin()
    {
        base.XuatThongTin();
        Console.WriteLine("Noi đen: {0}", NoiDen);
        Console.WriteLine("So ngay di duoc: {0} ngay", SoNgayDiDuoc);
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<ChuyenXe> danhSachChuyenXe = new List<ChuyenXe>();

        ChuyenXeNoiThanh noiThanh1 = new ChuyenXeNoiThanh
        {
            MaSoChuyen = "NT001",
            HoTenTaiXe = "Nguyễn Văn A",
            SoXe = "X001",
            SoTuyen = 1,
            SoKmDiDuoc = 50,
            DoanhThu = 5000000
        };
        danhSachChuyenXe.Add(noiThanh1);

        ChuyenXeNoiThanh noiThanh2 = new ChuyenXeNoiThanh
        {
            MaSoChuyen = "NT002",
            HoTenTaiXe = "Trần Thị B",
            SoXe = "X002",
            SoTuyen = 2,
            SoKmDiDuoc = 60,
            DoanhThu = 5500000
        };
        danhSachChuyenXe.Add(noiThanh2);

        ChuyenXeNgoaiThanh ngoaiThanh1 = new ChuyenXeNgoaiThanh
        {
            MaSoChuyen = "NT001",
            HoTenTaiXe = "Lê Văn C",
            SoXe = "X003",
            NoiDen = "Hà Nội",
            SoNgayDiDuoc = 2,
            DoanhThu = 8000000
        };
        danhSachChuyenXe.Add(ngoaiThanh1);

        ChuyenXeNgoaiThanh ngoaiThanh2 = new ChuyenXeNgoaiThanh
        {
            MaSoChuyen = "NT002",
            HoTenTaiXe = "Phạm Thị D",
            SoXe = "X004",
            NoiDen = "Đà Nẵng",
            SoNgayDiDuoc = 3,
            DoanhThu = 10000000
        };
        danhSachChuyenXe.Add(ngoaiThanh2);

        double tongDoanhThuToanBoChuyenXe = 0;
        double tongDoanhThuNoiThanh = 0;
        double tongDoanhThuNgoaiThanh = 0;

        foreach (var chuyenXe in danhSachChuyenXe)
        {
            tongDoanhThuToanBoChuyenXe += chuyenXe.DoanhThu;

            if (chuyenXe is ChuyenXeNoiThanh)
            {
                tongDoanhThuNoiThanh += chuyenXe.DoanhThu;
            }
            else if (chuyenXe is ChuyenXeNgoaiThanh)
            {
                tongDoanhThuNgoaiThanh += chuyenXe.DoanhThu;
            }

            chuyenXe.XuatThongTin();
            Console.WriteLine("==========================");
        }

        Console.WriteLine("Tong doanh thu tat ca cac chuyen xe: {0} VNĐ", tongDoanhThuToanBoChuyenXe);
        Console.WriteLine("Tong doanh thu chuyen xe noi thanh: {0} VNĐ", tongDoanhThuNoiThanh);
        Console.WriteLine("Tong doanh thu chuyen xe ngoai thanh: {0} VNĐ", tongDoanhThuNgoaiThanh);

        Console.ReadKey();
    }
}
