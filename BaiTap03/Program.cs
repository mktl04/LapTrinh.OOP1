using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap03
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //Cau a:
            PhanSo p1 = new PhanSo();
            Console.WriteLine("Nhap thong tin phan so thu nhat:");
            Console.Write("Nhap tu so:");
            int tuso = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so:");
            int mauso = int.Parse(Console.ReadLine());

            p1.setTuso(tuso);
            p1.setMauso(mauso);

            Console.WriteLine("Nhap thong tin phan so thu hai:");
            Console.Write("Nhap tu so:");
            tuso = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so:");
            mauso = int.Parse(Console.ReadLine());
            PhanSo p2 = new PhanSo();
            p2.toiGian();
            PhanSo tong = p1.cong(p2);


            Console.WriteLine("Tong hai phan so PS1[{0}/{1}], PS2[{2}/{3}] = KQ[{4}/{5}]",
                p1.getTuso(), p1.getMauso(), p2.getTuso(), p2.getMauso(), tong.getTuso(), tong.getMauso());

            Console.ReadLine();
            //Cau b:
            Console.WriteLine("Tinh toan day phan so:");
            Console.Write("Nhap vao so nguyen duong:");
            int n = int.Parse(Console.ReadLine());

            PhanSo s = new PhanSo(0, 1);
            for (int i = 1; i <= n; i++)
            {
                s = s.cong(new PhanSo(1, i));
            }
            Console.WriteLine("Ket qua day phan so: 1 + 1/2 + 1/3 + ... + 1/n = {0}/{1}", s.getTuso(),s.getMauso());
            Console.ReadLine();
        }
    }
}
