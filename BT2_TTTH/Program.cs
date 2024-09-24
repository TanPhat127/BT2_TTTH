using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2_TTTH
{
    internal class Program
    {
        static void BoSungNV()
        {
            Console.Write("Ho ten NV: ");
            string hoTen = Console.ReadLine();
            Console.Write("Gioi tinh: ");
            string gTinh = Console.ReadLine();
            Console.Write("Ngay sinh: ");
            int ngaySinhI = int.Parse(Console.ReadLine());
            Console.Write("He so luong: ");
            float heSL = float.Parse(Console.ReadLine());
            Console.Write("Luong co ban: ");
            double luongCB = double.Parse(Console.ReadLine());
            Console.Write("So nam lam viec: ");
            int soNam = int.Parse(Console.ReadLine());
            double phuCap;
            if (soNam > 5)
                phuCap = luongCB / 2;
            else phuCap = 0;
            Console.Write("Phu cap NV: {0}", phuCap);
        }
        static void TTHS()
        {
            Console.Write("Ho ten HS: ");
            string hTen = Console.ReadLine();
            Console.Write("Lop: ");
            string lop = Console.ReadLine();
            Console.Write("Diem TB HKI: ");
            double diemHKI = double.Parse(Console.ReadLine());
            Console.Write("Diem TB HKII: ");
            double diemHKII = double.Parse(Console.ReadLine());
            double diemTB = (diemHKI + diemHKII * 2) / 3;
            Console.WriteLine($"Diem TB ca nam: {diemTB}");
        }
        static void Main(string[] args)
        {
            int n;
            int chon = 0;
            do
            {
                Console.WriteLine("Chon bai: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1://bai 1
                        Console.WriteLine("Nhap n: ");
                        n = int.Parse(Console.ReadLine());
                        if (n % 3 == 0)
                            Console.WriteLine("n chia het cho 3");
                        else
                            Console.WriteLine("n khong chia het cho 3");
                        break;
                    case 2://bai 2
                        Console.WriteLine("Nhap n: ");
                        n = int.Parse(Console.ReadLine());
                        for (int i = 1; i <= n; i++)
                        {
                            Console.WriteLine($"bang cuu chuong {i}");
                            for (int j = 1; j < 11; j++)
                            {
                                Console.WriteLine($"{i} * {j} = {i * j}");
                            }
                        }
                        break;
                    case 3://bai 3
                        Console.WriteLine("Nhap n: ");
                        n = int.Parse(Console.ReadLine());
                        int tong = 0;
                        for (int i = 1; i <= n; i++)
                        {
                            int tich = 1;
                            for (int j = 1; j <= i; j++)
                                tich *= j;
                            tong += tich;
                        }
                        Console.WriteLine($"Tong giai thua tu 1 den {n} la: {tong}"); break;
                    case 4: //bai 4
                        TTHS();
                        break;
                    case 5: //bai 5
                        for (int i = 1; i <= 2; i++)
                        {
                            BoSungNV();
                        }
                        break;
                    case 6: //bai 6
                        Console.Write("Nhap vao ngay ban muon: ngay = ");
                        int ngay = int.Parse(Console.ReadLine());
                        Console.Write("Nhap vao thang ban muon: thang = ");
                        int thang = int.Parse(Console.ReadLine());
                        Console.Write("Nhap vao nam ban muon: nam = ");
                        int nam = int.Parse(Console.ReadLine());
                        string tg = ngay + "/" + thang + "/" + nam;
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine($"Ngay hom qua la: {ngay - 1}/{thang}/{nam}");
                        Console.WriteLine($"Ngay nay la: {tg}");
                        Console.WriteLine($"Ngay mai la: {ngay + 1}/{thang}/{nam}");
                        Console.WriteLine("---------------------------------------");
                        break;
                }
            } while (chon == 0);
            Console.ReadKey();
        }
    }
}
