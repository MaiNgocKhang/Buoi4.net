using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ToaDo Kt = new ToaDo();
            Kt.Ten = "O";
            Kt.X = 5;
            Kt.Y = 5;
            HinhTron ht = new HinhTron(Kt, 10.5);
            Console.WriteLine("Hinh tron co tam {0}({1},{2})voi ban kinh {3} co dien tich va chu vi lan luot la {4}va {5}", Kt.Ten, Kt.X, Kt.Y, ht.BanKinh, Math.Round(ht.tinhChuVi(), 3), Math.Round(ht.tinhDienTich(), 3));
            Console.ReadLine();
        }
    }
}
