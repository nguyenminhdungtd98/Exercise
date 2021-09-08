using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BaiTap2
    {
        public static float[] NhapMangSoThucTuBanPhim()
        {
            Console.Write("Vui lòng nhập vào số phần tử của mảng");
            int soPhanTuMang = int.Parse(Console.ReadLine());
            float[] mangNhapTuBanPhim = new float[soPhanTuMang];
            for (int i = 0; i < soPhanTuMang; i++)
            {
                Console.Write("Nhập vào phần tử thứ {0}:  ", i + 1);
                mangNhapTuBanPhim[i] = float.Parse(Console.ReadLine());
            }
            return mangNhapTuBanPhim;
        }
        public static int[] NhapMangNguyenTuBanPhim()
        {
            Console.Write("Vui lòng nhập vào số phần tử của mảng");
            int soPhanTuMang = int.Parse(Console.ReadLine());
            int[] mangNhapTuBanPhim = new int[soPhanTuMang];
            for (int i = 0; i < soPhanTuMang; i++)
            {
                Console.Write("Nhập vào phần tử thứ {0}:  ", i + 1);
                mangNhapTuBanPhim[i] = int.Parse(Console.ReadLine());
            }
            return mangNhapTuBanPhim;
        }
        public static void XuatMang1Chieu(int[] mang)
        {
            Console.WriteLine("Mảng có {0} phần tử", mang.Length);
            for (int i = 0; i < mang.Length; i++)
            {
                Console.WriteLine("Phần tử thứ {0} của mảng: {1}", i + 1, mang[i]);
            }
        }
        public static void XuatMang1Chieu(float[] mang)
        {
            Console.WriteLine("Mảng có {0} phần tử", mang.Length);
            for (int i = 0; i < mang.Length; i++)
            {
                Console.WriteLine("Phần tử thứ {0} của mảng: {1}", i + 1, mang[i]);
            }
        }
        public static void HamDaNang()
        {
            
        }
        public static void Bai122()
        {
            Console.WriteLine("Bài 122: Viết hàm tìm giá trị lớn nhất trong mảng 1 chiều các số thực");
            float[] mang = NhapMangSoThucTuBanPhim();
            float max = mang[0];
            for (int i = 1; i < mang.Length; i++)
            {
                if (mang[i] > max)
                {
                    max = mang[i];
                }
            }
            Console.WriteLine("Giá trị lớn nhất trong mảng là: {0}", max);
        }
        public static void Bai123()
        {
            Console.WriteLine("Bài 123: Viết hàm tìm 1 vị trí mà giá " +
                "trị tại vị trí đó là giá trị nhỏ nhất trong mảng 1 chiều các số nguyên");
            int[] mang = NhapMangNguyenTuBanPhim();

        }
    }
}
