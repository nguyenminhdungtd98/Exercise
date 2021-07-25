using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Baitap
    {
        public static void bai1(int intNum) //Bài 1: Tính S(n) = 1 + 2 + 3 + … +n
        {
            int intSum = 0;
            for (int i = 1; i <= intNum; i++)
            {
                intSum += i;
            }
            Console.WriteLine("Tổng các số nguyên N là {0}", intSum);
        }
        public static void bai2(int intNum) //Bài 2: Tính S(n) = 1 ^ 2 + 2 ^ 2 + … +n ^ 2
        {

            int intResult = 0;
            for (int i = 1; i <= intNum; i++)
            {
                intResult += i * i;
            }
            Console.WriteLine("Tổng N^2 của các số nguyên N là {0}", intResult);
        }
        public static void bai3(int intNum) //Bài 3: Tính S(n) = 1 + ½ +1 / 3 + … +1 / n
        {

            float result = 0;
            for (int i = 1; i <= intNum; i++)
            {
                result += (float)1 / (float)i;
            }
            Console.WriteLine("Tổng 1/N của các số nguyên N là {0}", result);
        }
        public static void bai4(int intNum) //Bài 4: Tính S(n) = ½ + ¼ + … +1 / 2n
        {

            float result = 0;
            for (int i = 1; i <= intNum; i++)
            {
                result += (float)1 / ((float)i * 2);
            }
            Console.WriteLine("Tổng 1/2N của các số nguyên N là {0}", result);
        }
        public static void bai5(int intNum) //Bài 5: Tính S(n) = 1 + 1/3 + 1/5 + … + 1/(2n + 1)
        {

            float result = 0;
            for (int i = 0; i <= intNum; i++)
            {
                result += (float)1 / (((float)i * 2) + 1);
            }
            Console.WriteLine("Tổng 1/2N+1 của các số nguyên N là {0}", result);
        }
        public static void bai6(int intNum) //Bài 6: Tính S(n) = 1/1×2 + 1/2×3 +…+ 1/ n x (n + 1)
        {

            float result = 0;
            for (int i = 1; i <= intNum; i++)
            {
                result += (float)1 / (i * ((float)i + 1));
            }
            Console.WriteLine("Tổng 1/N(N+1) của các số nguyên N là {0}", result);
        }
        public static void bai7(int intNum) //Bài 7: Tính S(n) = ½ +2 / 3 + ¾ + …. +n / n + 1
        {

            float result = 0;
            for (int i = 0; i <= intNum; i++)
            {
                result += (float)i / ((float)i + 1);
            }
            Console.WriteLine("Tổng n/n+1 của các số nguyên N là {0}", result);
        }
        public static void bai8(int intNum) //Bài 8: Tính S(n) = ½ + ¾ + 5/6 + … + 2n + 1/ 2n + 2
        {
            float result = 0;
            for (int i = 0; i <= intNum; i++)
            {
                result += (((float)i * 2) + 1) / (((float)i * 2) + 2);
            }
            Console.WriteLine("Tổng 2n+1/2n+2 của các số nguyên N là {0}", result);
        }
        public static void bai9(int intNum) //Bài 9: Tính T(n) = 1 x 2 x 3…x N
        {
            int result = 1;
            for (int i = 1; i <= intNum; i++)
            {
                result *= i;
            }
            Console.WriteLine("Tích của các số nguyên N là {0}", result);
        }
        public static void bai10(int intX, int intN) //Bài 10: Tính T(x, n) = x^n
        {
            int result = 1;
            for (int i = 1; i <= intN; i++)
            {
                result *= intX;
            }
            Console.WriteLine("Tích x^n của các số nguyên N là {0}", result);
        }
        public static void bai11(int intNum) //Bài 11: Tính S(n) = 1 + 1.2 + 1.2.3 + … + 1.2.3….N
        {
            int result = 0;
            while (intNum >= 1)
            {
                result += GiaiThua(intNum);
                intNum--;
            }
            Console.WriteLine("Tích của các số nguyên N là {0}", result);
        }
        public static int GiaiThua(int intNum) //Tính giai thừa
        {

            int resultMul = 1;
            for (int i = intNum; i > 0; i--)
            {
                resultMul *= i;
            }

            return resultMul;
        }
        public static int LuyThuaXN(int intX, int intN)
        {
            int resultMul = 1;

            for (int i = 1; i <= intN; i++)
            {
                resultMul *= intX;
            }
            return resultMul;
        }
        public static void bai12(int intX, int intN) //Bài 12: Tính S(x,n) = x + x^2 + x^3 + … + x^n
        {
            int result = 0;
            while (intN >= 1)
            {
                int resultMul = LuyThuaXN(intX, intN);
                result += resultMul;
                intN--;
            }
            Console.WriteLine("Tổng x^n của các số nguyên N là {0}", result);
        }
        public static void bai13(int intX, int intN) //Bài 13: Tính S(x,n) = x^2 + x^4 + … + x^2n
        {
            int result = 0;
            while (intN >= 1)
            {
                int resultMul = 1;
                for (int i = 1; i <= (intN * 2); i++)
                {
                    resultMul *= intX;
                }
                result += resultMul;
                intN--;
            }
            Console.WriteLine("Tổng (x^2n) của các số nguyên N là {0}", result);
        }
        public static void bai14(int intX, int intN) //Bài 14: Tính S(x,n) = x + x^3 + x^5 + … + x^2n + 1
        {
            int result = 0;
            while (intN >= 1)
            {
                int resultMul = 1;
                for (int i = 1; i <= ((intN * 2) + 1); i++)
                {
                    resultMul *= intX;
                }
                result += resultMul;
                intN--;
            }
            Console.WriteLine("Tổng (x^2n+1) của các số nguyên N là {0}", result);
        }
        public static void bai15(int intN) //Bài 15: Tính S(n) = 1 + 1/(1+2) + 1/ (1 + 2 + 3) + ….. + 1/ (1 + 2 + 3) + …. + N
        {
            float result = 0;
            while (intN >= 1)
            {
                int resultSum = 0;
                for (int i = 0; i <= intN; i++)
                {
                    resultSum += i;
                }
                result += (float)1 / (float)resultSum;
                intN--;
            }
            Console.WriteLine("Tổng 1 + 1/(1+2) + 1/ (1 + 2 + 3) + ….. + 1/ (1 + 2 + 3) + …. + N là {0}", result);
        }
        public static void bai16(int intX, int intN) //Bài 16: Tính S(n) = x + x^2/(1+2) + x^3/(1+2+3) + … + x^n/(1+2+3+…. + N)
        {
            float result = 0;
            while (intN >= 1)
            {
                float resultMul = 1;
                int resultSum = 0;
                for (int i = 1; i <= intN; i++)
                {
                    resultMul *= intX;
                }
                for (int i = 0; i <= intN; i++)
                {
                    resultSum += i;
                }
                result += resultMul / (float)resultSum;
                intN--;
            }
            Console.WriteLine("Kết quả :x + x^2/(1+2) + x^3/(1+2+3) + … + x^n/(1+2+3+…. + N) là {0}", result);
        }
        public static void bai17(int intX, int intN) //Bài 17: Tính S(n) = x + x^2/2! + x^3/3! + … + x^n/N!
        {
            float result = 0;

            while (intN >= 1)
            {
                result += ((float)LuyThuaXN(intX, intN)) / (float)(GiaiThua(intN));
                intN--;
            }
            Console.WriteLine("Kết quả:x + x^2/2! + x^3/3! + … + x^n/N! là {0}", result);
        }
        public static void bai18(int intX, int intN) //Bài 18: Tính S(n) = 1 + x^2/2! + x^4/4! + … + x^2n/(2n)!
        {
            float result = 0;

            while (intN >= 0)
            {
                result += ((float)LuyThuaXN(intX, (2 * intN))) / (float)(GiaiThua(2 * intN));
                intN--;
            }
            Console.WriteLine("Kết quả:1 + x^2/2! + x^4/4! + … + x^2n/(2n)! là {0}", result);
        }
        public static void bai19(int intX, int intN) //Bài 19: Tính S(n) = 1 + x + x^3/3! + x^5/5! + … + x^(2n+1)/(2n+1)!
        {
            float result = 0;

            while (intN >= 0)
            {
                result += (float)LuyThuaXN(intX, (2 * intN) + 1) / (float)(GiaiThua((2 * intN) + 1));
                intN--;
            }
            Console.WriteLine("Kết quả: 1 + x + x^3/3! + x^5/5! + … + x^(2n+1)/(2n+1)! là {0}", result);
        }
        public static void bai20(int intN) //Bài 20: Liệt kê tất cả các “ước số” của số nguyên dương n
        {
            List<int> list = new List<int>();
            list = Uocso(intN);
            Console.WriteLine("Ước số của {0} là: ", intN);
            foreach (var items in list)
            {
                Console.Write(items + "  ");
            }
        }
        public static List<int> Uocso(int intN)
        {
            List<int> list = new List<int>();
            for (int i = 1; i <= intN; i++)
            {
                if (intN % i == 0)
                {
                    list.Add(i);
                }
            }
            return list;
        }
        public static void bai21(int intN)//Bài 21: Tính tổng tất cả các “ ước số” của số nguyên dương n
        {
            int result = 0;
            List<int> list = new List<int>();
            list = Uocso(intN);
            foreach (var items in list)
            {
                result += items;
            }
            Console.WriteLine("Tổng ước số của {0} là: {1} ", intN, result);
        }
        public static void bai22(int intN)//Bài 22:Tính tích tất cả các “ước số” của số nguyên dương n
        {
            int result = 1;
            List<int> list = new List<int>();
            list = Uocso(intN);
            foreach (var items in list)
            {
                result *= items;
            }
            Console.WriteLine("Tích ước số của {0} là: {1} ", intN, result);
        }
        public static void bai23(int intN) //Bài 23: Đếm số lượng “ước số” của số nguyên dương n
        {
            List<int> list = new List<int>();
            list = Uocso(intN);
            int result = list.Count();
            Console.WriteLine("Số ước số của {0} là: {1} ", intN, result);
        }
        public static void bai24(int intN)//Bài 24: Liệt kê tất cả các “ước số lẻ” của số nguyên dương n
        {
            List<int> list = new List<int>();
            list = Uocso(intN);
            Console.WriteLine("Ước số lẻ của {0} là: ", intN);
            foreach (var items in list)
            {
                if (items % 2 != 0)
                {
                    Console.Write(items + " ");
                }
            }
        }
        public static void bai25(int intN) //Bài 25: Tính tổng tất cả các “ước số chẵn” của số nguyên dương n
        {
            int result = 0;
            List<int> list = new List<int>();
            list = Uocso(intN);
            foreach (var items in list)
            {
                if (items % 2 == 0)
                {
                    result += items;
                }
            }
            Console.WriteLine("Tổng các ước số chẳn của {0} là: {1} ", intN, result);

        }
        public static void bai26(int intN) //Bài 26: Tính tích tất cả các “ước số lẻ” của số nguyên dương n
        {
            int result = 1;
            List<int> list = new List<int>();
            list = Uocso(intN);
            foreach (var items in list)
            {
                if (items % 2 != 0)
                {
                    result *= items;
                }
            }
            Console.WriteLine("Tích các ước số chẳn của {0} là: {1} ", intN, result);
        }
        public static void bai27(int intN) //Bài 27: Đếm số lượng “ước số chẵn” của số nguyên dương n
        {
            List<int> list = new List<int>();
            List<int> list1 = new List<int>();
            list = Uocso(intN);
            foreach (var items in list)
            {
                if (items % 2 == 0)
                {
                    list1.Add(items);
                }
            }
            int result = list1.Count();
            Console.WriteLine("Số các ước số chẳn của {0} là: {1} ", intN, result);
        }
        public static void bai28(int intN) //Bài 28: Cho số nguyên dương n. Tính tổng các ước số nhỏ hơn chính nó
        {
            int result = 0;
            List<int> list = new List<int>();
            list = Uocso(intN);
            foreach (var items in list)
            {
                if (items < intN)
                {
                    result += items;
                }
            }
            Console.WriteLine("Tổng ước số của {0} là: {1} ", intN, result);
        }
        public static void bai29(int intN) //Bài 29: Tìm ước số lẻ lớn nhất của số nguyên dương n. Ví dụ n = 100 ước lẻ lớn nhất là 25
        {
            int[] list = uocSoInt(intN);
            int[] list1 = new int[200];
            int j = 0;
            int k = 0;
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] % 2 != 0)
                {

                    Console.WriteLine(list[i]);
                    list1[k] = list[i];
                    k++;
                }
            }
            int max = list1[0];
            for (int i = 0; i < list1.Length / 2; i++)
            {
                if (i < (list1.Length - 1) / 2)
                {
                    if (max < list1[i + 1])
                    {
                        max = list1[i + 1];
                    }
                }
            }
            Console.WriteLine("Ước số lẻ lớn nhất của số nguyên dương {0} là {1}", intN, max);

        }
        public static int[] uocSoInt(int intN)
        {
            int[] list = new int[200];
            int j = 0;
            for (int i = 1; i <= intN; i++)
            {
                if (intN % i == 0)
                {
                    list[j] = i;
                    j++;
                }
            }
            return list;
        }
        public static void bai30(int intN) //Bài 30: Cho số nguyên dương n. Kiểm tra xem n có phải là số hoàn thiện hay không
        {
            int sum = 0;
            int[] list = uocSoInt(intN);
            for (int i = 0; i < list.Length - 1; i++)
            {
                if (list[i] == intN)
                {
                    break;
                }
                sum += list[i];
            }
            if (sum == intN)
            {
                Console.WriteLine("Số nguyên dương {0} là số hoàn thiện", intN);
            }
            else
            {
                Console.WriteLine("Số nguyên dương {0} không phải là số hoàn thiện", intN);
            }

        }
        public static void bai31(int intN) //Bài 31: Cho số nguyên dương n.Kiểm tra xem n có phải là số nguyên tố hay không
        {
            int[] list = uocSoInt(intN);
            int count = 0;

            for (int i = 1; i <= list.Length; i++)
            {
                if (intN % i == 0)
                {
                    count++;
                }
                if (count > 2)
                { break; }
            }
            if (count > 2)
            {
                Console.WriteLine("Số nguyên dương {0} không phải là số nguyên tố", intN);
            }
            else Console.WriteLine("Số nguyên dương {0} là số nguyên tố", intN);
        }
        public static void bai32(int intN) //Bài 32: Cho số nguyên dương n. Kiểm tra xem n có phải là số chính phương hay không
        {
            int value;
            Boolean result = int.TryParse(Math.Sqrt(intN).ToString(), out value);
            if (result == false)
            {
                Console.WriteLine("Số nguyên dương {0} không phải là số chính phương", intN);
            } else Console.WriteLine("Số nguyên dương {0} là số chính phương", intN);


            /*
             *Cách 2 
            int value;
            Boolean result = int.TryParse(Math.Sqrt(intN).ToString(), out value);
            if(value*value != intN)
            {
                Console.WriteLine("Số nguyên dương {0} không phải là số chính phương",intN);
            }else Console.WriteLine("Số nguyên dương {0} là số chính phương", intN);*/





        }
        public static double sqrtOfN(int intN)
        {
            double result = Math.Sqrt(2);
            for (int i = 2; i <= intN; i++)
            {
                result = Math.Sqrt((float)2 + result);
            }
            return result;
        }
        public static void bai33(int intN) // Bài 33: S(n)=CanBac2(2+CanBac2(2+….+CanBac2(2 + CanBac2(2)))) có n dấu căn
        {
            double result = sqrtOfN(intN);
            Console.WriteLine(result);

        }
        public static void bai34(int intN) //Bài 34: Tính S(n) = CanBac2(n+CanBac2(n – 1 + CanBac2( n – 2 + … + CanBac2(2 + CanBac2(1)  có n dấu căn
        {
            double result = Math.Sqrt(1);
            for (int i = 2; i <= intN; i++)
            {
                result = Math.Sqrt(result + i);
            }
            Console.WriteLine(result);

        }
        public static void bai36(int intN)//Bài 36: Tính S(n) = CanBac2(n! + CanBac2((n-1)! +CanBac2((n – 2)! + … + CanBac2(2!) + CanBac2(1!)))) có n dấu căn

        {
            double result = Math.Sqrt(GiaiThua(0));
            for (int i = 1; i <= intN; i++)
            {
                result = Math.Sqrt(GiaiThua(i) + result);
            }
            Console.WriteLine(result);

        }
        public static void bai37(int intN) // Bài 37: Tính S(n) = CanBac N(N + CanBac N – 1(N – 1 + … + CanBac3(3 + CanBac2(2))) có n – 1 dấu căn
        {
            double result = Math.Sqrt(2);
            for (int i = 3; i <= intN; i++)
            {
                result = Math.Pow(i + result, (float)1 / (float)i); // Pow(2,1/2) = SQRT(2)
            }
            Console.WriteLine(result);
        }
        public static void bai38(int intN) //Bài 38: Tính S(n) = CanBac N + 1(N + CanBac N(N – 1 +…+CanBac3(2 + CanBac2(1)))) có n dấu căn(Nhờ thầy check)
        {
            double result = 1; // SQRT(1) = 1
            for (int i = 2; i <= intN; i++)
            {
                result = Math.Pow(i + 1, (float)1 / (i + 1));
            }
            Console.WriteLine(result);
        }
        public static void bai39(int intN)//Bài 39: Tính S(n) = CanBac N + 1(N! + CanBacN((N – 1)! + … + CanBac3(2! + CanBac2(1!))) có n dấu căn
        {
            double result = 1; // SQRT(1!) =1
            for (int i = 2; i <= intN; i++)
            {
                result = Math.Pow(GiaiThua(i) + 1, (float)1 / (i + 1));
            }
            Console.WriteLine(result);
        }
        public static void bai40(int intX, int intN) //Bài 40: Tính S(n) = CanBac2(x^n + CanBac2(x^n-1 + … + CanBac2(x^2 + CanBac2(x)))) có n dấu căn
        {
            double result = Math.Sqrt(intX);
            for (int i = 2; i <= intN; i++)
            {
                result = Math.Sqrt(result + LuyThuaXN(intX, i));
            }
            Console.WriteLine(result);
        }
        public static void bai41(int intN) //Bài 41: Tính S(n) = 1 / (1 + 1 / ( 1 + 1 / (…. 1 + 1 / 1 + 1))) có n dấu phân số. 
        {
            double result = 2;
            for (int i =intN-1; i>= 1;i--)
            {
                result = 1+ 1/result;
            }
            result = (double)1/result;
            Console.WriteLine(result);
        }
        public static void bai42(int intN) //Bài 42: Cho n là số nguyên dương. Hãy tìm giá trị nguyên dương k lớn nhất sao cho S(k)  < n. Trong đó chuỗi k được định nghĩa như sau: S(k) = 1 + 2 + 3 + … + k
        {
            int result=0;
            for (int i = 0; i< intN;i++)
            {
                result += i;
                if (result >= intN)
                {
                    Console.WriteLine("Giá trị k cần tìm để thỏa mản yêu cầu đề là: {0}",i-1);
                    break;
                }
            }
        }
        public static int[] danhSachChuSo(int intN) // Trả về danh sách các chữ số của số nguyên dương n
        {
            int[] list = new int[100];
            int j = 0;

            while (intN > 0)
            {
                list[j] = intN % 10;
                intN /= 10;
                j++;
            }
            return list;
        }
        public static int soLuongChuSo(int intN) // Trả về số lượng các chữ số của số nguyên dương n
        {
            int  j = 0;

            while (intN > 0)
            {
                intN /= 10;
                j++;
            }
            return j;
        }
        public static void bai43(int intN) //Bài 43: Hãy đếm số lượng chữ số của số nguyên dương n
        {
                Console.Write("Số lương chữ số của số nguyên dương {0} là: {1}", intN,soLuongChuSo(intN)); 
        }            
        public static void bai44(int intN) //Bài 44: Hãy tính tổng các chữ số của số nguyên dương n
        {
            int[] list = danhSachChuSo(intN);
            int result = 0;
            for (int i = 0; i< soLuongChuSo(intN); i++)
            {
                result += list[i];
            }
            Console.WriteLine("Tổng các chữ số của số nguyên dương {0} là: {1}",intN,result);
        }
        public static void bai45(int intN) //Bài 45: Hãy tính tích các chữ số của số nguyên dương n
        {
            int[] list = danhSachChuSo(intN);
            int result = 1;
            for (int i = 0; i < soLuongChuSo(intN); i++)
            {
                result *= list[i];
            }
            Console.WriteLine("Tích các chữ số của số nguyên dương {0} là: {1}", intN, result);
        }
        public static void bai46(int intN) //Bài 46: Hãy đếm số lượng chữ số lẻ của số nguyên dương n
        {
            int[] list = danhSachChuSo(intN);
            int count = 0;
            for (int i = 0; i < soLuongChuSo(intN); i++)
            {
                if (list[i]%2!=0)
                {
                    count++;
                }
            }
            Console.WriteLine("Số các chữ số lẻ của số nguyên dương {0} là: {1}", intN,count);
        }
        public static void bai47(int intN) //Bài 47: Hãy tính tổng các chữ số chẵn của số nguyên dương n
        {
            int[] list = danhSachChuSo(intN);
            int result = 0;
            for (int i = 0; i < soLuongChuSo(intN); i++)
            {
                if (list[i] % 2 == 0)
                {
                    result += list[i];
                }
            }
            Console.WriteLine("Tổng các chữ số chẳn của số nguyên dương {0} là: {1}", intN, result);
        }
        public static void bai48(int intN) //Bài 48: Hãy tính tích các chữ số lẻ của số nguyên dương n
        {
            int[] list = danhSachChuSo(intN);
            int result = 1;
            for (int i = 0; i < soLuongChuSo(intN); i++)
            {
                if (list[i]%2!=0)
                {
                    result *= list[i];
                }
            }
            Console.WriteLine("Tích các chữ số lẻ của số nguyên dương {0} là: {1}", intN, result);
        }
        public static void bai49(int intN) //Bài 49: Cho số nguyên dương n. Hãy tìm chữ số đầu tiên của n
        {
            int[] list = danhSachChuSo(intN);
            Console.WriteLine("Chữ số đầu tiên của số nguyên dương {0} là: {1}", intN, list[soLuongChuSo(intN)-1]);
        }
        public static void bai50(int intN) //Bài 50: Hãy tìm số đảo ngược của số nguyên dương n
        {
            int[] list = danhSachChuSo(intN);
            int result = 0;
            int j = soLuongChuSo(intN);
            for (int i = 0; i < soLuongChuSo(intN); i++)
            {
                result += (list[i] * LuyThuaXN(10, j-1));
                j--;
            }
            Console.WriteLine(" Số đảo ngược của số nguyên dương {0} là: {1}", intN, result);
        }
        public static void bai51(int intN) //Bài 51: Tìm chữ số lớn nhất của số nguyên dương n
        {
            int[] list = danhSachChuSo(intN);
            int j = soLuongChuSo(intN);
            int max = list[0];
            for (int i = 0; i < soLuongChuSo(intN); i++)
            {
                    if (i < (list.Length - 1) / 2)
                    {
                        if (max < list[i + 1])
                        {
                            max = list[i + 1];
                        }
                    }
            }
            Console.WriteLine(" Chữ số lớn nhất của số nguyên dương {0} là: {1}", intN, max);
        }
    }
}
