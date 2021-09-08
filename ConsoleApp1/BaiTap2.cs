using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BaiTap2
    {
        public static double[] NhapMangSoThucTuBanPhim()
        {
            Console.Write("Vui lòng nhập vào số phần tử của mảng: ");
            int soPhanTuMang = int.Parse(Console.ReadLine());
            double[] mangNhapTuBanPhim = new double[soPhanTuMang];
            for (int i = 0; i < soPhanTuMang; i++)
            {
                Console.Write("Nhập vào phần tử thứ {0}:  ", i + 1);
                mangNhapTuBanPhim[i] = double.Parse(Console.ReadLine());
            }
            return mangNhapTuBanPhim;
        }
        public static int[] NhapMangNguyenTuBanPhim()
        {
            Console.Write("Vui lòng nhập vào số phần tử của mảng: ");
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
        public static void XuatMang1Chieu(double[] mang)
        {
            Console.WriteLine("Mảng có {0} phần tử", mang.Length);
            for (int i = 0; i < mang.Length; i++)
            {
                Console.WriteLine("Phần tử thứ {0} của mảng: {1}", i + 1, mang[i]);
            }
        }
        public static bool SoNguyenTo(int intA)
        {
            int count = 0;
            for (int i = 1; i <= intA; i++)
            {
                if (intA % i == 0)
                {
                    count++;
                }
            }
            if (intA == 1 || count > 2)
            {
                return false;
            }
            else return true;

        }
        public static double ViTriMaxMinTrongMang(double[] mang, string giaTriCan)
        {
            /// <summary>
            /// giaTriCan nhận vào các giá trị Max,Min,viTriMax,viTriMin hàm sẽ trả ra giá trị tương ứng với key nhập vào
            double viTriMin = 0;
            double viTriMax = 0;
            double max = mang[0];
            double min = mang[0];
            for (int i = 1; i < mang.Length; i++)
            {
                if (mang[i] > max)
                {
                    max = mang[i];
                    viTriMax = i;
                }
                if (mang[i] < min)
                {
                    min = mang[i];
                    viTriMin = i;
                }
            }
            
            if (giaTriCan == "Max")
            {
                return max;
            }else if (giaTriCan == "Min")
            {
                return min;
            }
            else if (giaTriCan == "viTriMax")
            {
                return viTriMax;
            }
            else if (giaTriCan == "viTriMin")
            {
                return viTriMin;
            }
            else
            {
                return -1;
            }
            /*
            switch (giaTriCan)
            {
                case "Max":
                    return max;
                    break;
                case "Min":
                    return min;
                    break;
                case "viTriMax":
                    return viTriMax;
                    break;
                case "viTriMin":
                    return viTriMin;
                    break;
                default:
                return -1;
                break;
            }*/
        }
        public static double[] SapXepMangTangDan(double[] mang)
        {
            double temp = 0;
            double length = mang.Length;
            while (length > 0 )
            {
                for (int i = 0; i < length; i++)
                {
                    if ((i < length - 1) && (mang[i] > mang[i + 1]))
                    {
                        temp = mang[i];
                        mang[i] = mang[i + 1];
                        mang[i + 1] = temp;
                    }
                }
                length--;

            }

            return mang;
        }
        public static int[] SapXepMangTangDan(int[] mang)
        {
            int temp = 0;
            int length = mang.Length;
            while (length > 0)
            {
                for (int i = 0; i < length; i++)
                {
                    if ((i < length - 1) && (mang[i] > mang[i + 1]))
                    {
                        temp = mang[i];
                        mang[i] = mang[i + 1];
                        mang[i + 1] = temp;
                    }
                }
                length--;

            }

            return mang;
        }
        public static int[] SapXepMangGiamDan(int[] mang)
        {
            int temp = 0;
            int length = mang.Length;
            while (length > 0)
            {
                for (int i = 0; i < length; i++)
                {
                    if ((i < length - 1) && (mang[i] < mang[i + 1]))
                    {
                        temp = mang[i];
                        mang[i] = mang[i + 1];
                        mang[i + 1] = temp;
                    }
                }
                length--;

            }

            return mang;
        }
        public static int DemSoChanTrongMang(int[] mang)
        {
            int count = 0;
            for (int i = 0; i < mang.Length; i++)
            {
                if (mang[i] % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }

        public static int TongUocChung(int intA) // Tổng ước chung của số intA không bao gôm intA
        {
            int sum = 0;
            for (int i = 1; i < intA; i++ )
            {
                if (intA % i == 0)
                {
                    sum += i;
                    
                }
            }
            return sum;
        }

        public static void Bai122()
        {
            Console.WriteLine("Bài 122: Viết hàm tìm giá trị lớn nhất trong mảng 1 chiều các số thực");
            double[] mang = NhapMangSoThucTuBanPhim();
            double max = mang[0];
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
            double[] mang = NhapMangSoThucTuBanPhim();
            double viTriMin = ViTriMaxMinTrongMang(mang,"viTriMin");
            Console.WriteLine("Vi tri của phần tử nhỏ nhất trong mảng là {0}",viTriMin);
        }
        public static void Bai124()
        {
            Console.WriteLine("Bài 124: Viết hàm kiểm tra trong mảng các số nguyên" +
                " có tồn tại giá trị chẵn nhỏ hơn 2004 hay không");
            double[] mang = NhapMangSoThucTuBanPhim();
            double ketQua = -1;
            for (int i = 0; i < mang.Length;i++)
            {
                if (mang[i]%2 == 0 && mang[i] < 2004)
                {
                    ketQua = mang[i];
                    break;
                }
            }
            if (ketQua != -1)
            {
                Console.WriteLine("Trong mảng có tồn tại giá trị chẳn và nhỏ hơn 2004");
            }
            else Console.WriteLine("Trong mảng không tồn tại giá trị cần tìm");
        }
        public static void Bai125()
        {
            Console.WriteLine("Bài 125: Viết hàm đếm số lượng số nguyên tố nhỏ hơn 100 trong mảng");
            double[] mang = NhapMangSoThucTuBanPhim();
            int count = 0;
            for (int i = 0; i < mang.Length; i++)
            {
                if (SoNguyenTo((int)mang[i]) && mang[i] < 100)
                {
                    count++;
                }
            }
            Console.WriteLine("Số lượng số nguyên tố nhỏ hơn 100 trong mảng là: {0}",count);
        }
        public static void Bai126()
        {
            Console.WriteLine("Bài 126: Viết hàm tính tổng các giá trị âm trong mảng 1 chiều các số thực");
            double[] mang = NhapMangSoThucTuBanPhim();
            double sum = 0;
            for (int i = 0; i < mang.Length; i++)
            {
                if (mang[i] < 0)
                {
                    sum += mang[i];
                }
            }
            Console.WriteLine("Tổng các số âm trong mảng là: {0}",sum);
        }
        public static void Bai127()
        {
            Console.WriteLine("Bài 127: Viết hàm sắp xếp mảng 1 chiều các số thực tăng dần");
            double[] mang = NhapMangSoThucTuBanPhim();
            SapXepMangTangDan(mang);
            XuatMang1Chieu(mang);
        }
        public static void Bai128_129_130_131()
        {
            XuatMang1Chieu(NhapMangNguyenTuBanPhim());

            XuatMang1Chieu(NhapMangSoThucTuBanPhim());
        }
        public static void Bai132()
        {
            Console.WriteLine("Bài 132: Viết hàm liệt kê các giá trị chẵn trong mảng 1 chiều các số nguyên");
            int[] mang = NhapMangNguyenTuBanPhim();
            int[] mangKetQua = new int[mang.Length];
            int count = 0;
            for (int i = 0; i < mang.Length; i++)
            {
                if (mang[i] % 2 ==0 )
                {
                    mangKetQua[i] = mang[i];
                    count++;
                }
            }
            SapXepMangGiamDan(mangKetQua);
            Array.Resize(ref mangKetQua, count);
            XuatMang1Chieu(mangKetQua);
        }
        public static void Bai133()
        {
            Console.WriteLine("Bài 133: Viết hàm liệt kê các vị trí mà giá trị " +
                "tại đó là giá trị âm trong mảng 1 chiều các số thực");
            double[] mang = NhapMangSoThucTuBanPhim();
            Console.WriteLine("Vị trí các giá trị âm trong mảng là:");
            for (int i = 0; i < mang.Length; i++)
            {
                if (mang[i] < 0)
                {
                    Console.WriteLine("Vị trí thứ {0} (Phần tử thứ {1})",i,i+1);
                }
            }
        }
        public static void Bai134()
        {
            Console.WriteLine("Bài 134: Viết hàm tìm giá trị lớn nhất trong mảng 1 chiều các số thực");
            double[] mang = NhapMangSoThucTuBanPhim();
            double max = ViTriMaxMinTrongMang(mang,"Max");
            Console.WriteLine("Giá trị lớn nhất trong mảng 1 chiều là: {0}",max);
        }
        public static double Bai135()
        {
            Console.WriteLine("Bài 135: Viết hàm tìm giá trị dương đầu tiên trong mảng 1 chiều các số thực." +
                " Nếu mảng không có giá trị dương thì trả về -1");
            double[] mang = NhapMangSoThucTuBanPhim();
            double ketQua = 0;
            int count = 0;
            for (int i = 0; i <mang.Length; i++)
            {
                if (mang[i] > 0)
                {
                    ketQua = mang[i];
                    break;
                }
                count++;
                if (count == mang.Length)
                {
                    return -1;
                }
            }
            return ketQua;


        }
        public static int Bai136()
        {
            Console.WriteLine("Bài 136: Tìm số chẵn cuối cùng trong mảng 1 chiều các số nguyên. " +
                "Nếu mảng không có giá trị chẵn thì trả về -1");
            int[] mang = NhapMangNguyenTuBanPhim();
            int count = 0;
            int ketQua = 0;
            for (int i = mang.Length - 1; i >= 0; i--)
            {
                if (mang[i] % 2 == 0)
                {
                    ketQua = mang[i];
                    break;
                }
                count++;
                if (count == mang.Length)
                {
                    return -1;
                }
            }
            return ketQua;

        }
        // Bài 137 tương tự như bài 123. Viết mảng số thực dùng cho mảng số nguyên luôn
        public static int Bai138()
        {
            Console.WriteLine("Bài 138: Tìm vị trí của giá trị chẵn đầu tiên trong mảng 1 chiều các số nguyên." +
                " Nếu mảng không có giá trị chẵn thì sẽ trả về -1");
            int[] mang = NhapMangNguyenTuBanPhim();
            int ketQua = 0;
            for (int i = 0; i < mang.Length; i++)
            {
                if (mang[i] % 2 == 0)
                {
                    ketQua = i;
                    break;
                }
                if (i == mang.Length-1)
                {
                    return -1;
                }
            }
            return ketQua;
        }
        public static int Bai139()
        {
            int ketQua = 0;
            Console.WriteLine("Bài 139: Tìm vị trí số hoàn thiện cuối cùng trong mảng 1 chiều các số nguyên." +
                " Nếu mảng không có số hoàn thiện thì trả về giá trị  -1");
            int[] mang = NhapMangNguyenTuBanPhim();
            for (int i = mang.Length -1; i >=0 ; i--)
            {
                if (TongUocChung(mang[i]) == mang[i])
                {
                    ketQua = i;
                    break;
                }
                if (i==0)
                {
                    return -1;
                }
            }
            return ketQua;
        }
        public static void Bai140()
        {
            Console.WriteLine("Bài 140: Hãy tìm giá trị dương nhỏ nhất trong mảng 1 chiều các số thực." +
                " Nếu mảng không có giá trị dương thì sẽ trả về -1");
            double[] mang = NhapMangSoThucTuBanPhim();
            double[] mangSoDuong = new double[mang.Length];
            double ketQua = 0;
            int count = 0;

            while (count < mangSoDuong.Length -1)
            {
                for (int i = 0; i < mang.Length; i++)
                {
                    if (mang[i] > 0)
                    {
                        mangSoDuong[count] = mang[i];
                        count++;
                    }
                }
                break;
            }
            if (count == 0)
            {
                Console.WriteLine("Không có giá trị dương");
            }
            else
            {
                Array.Resize(ref mangSoDuong, count);
                ketQua = ViTriMaxMinTrongMang(mangSoDuong, "Min");
                Console.WriteLine("Giá trị dương nhỏ nhất trong mảng là {0}", ketQua);
            }
        }
        // Bai 141 tương tự bài 140
        // Bai 142 - 154 không làm lại gì các dạng khá giống với những bài trước



    }
}
