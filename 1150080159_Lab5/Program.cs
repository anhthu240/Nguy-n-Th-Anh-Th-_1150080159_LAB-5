using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main()
    {
        // Bật đúng 1 dòng bên dưới để chạy bài tương ứng:
        // ThucHanh1.Run();
        // ThucHanh2.Run();
        // ThucHanh3.Run();
        // ThucHanh4.Run();
        // ThucHanh5.Run();
        // ThucHanh6.Run();
        // ThucHanh7.Run();
        // ThucHanh8.Run();
        // ThucHanh9.Run();
        // ThucHanh10.Run();
         ThucHanh11.Run();
    }
}

/* ================== Helpers ================== */
public static class IOHelper
{
    public static int ReadInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string s = Console.ReadLine();
            if (int.TryParse(s, out int v)) return v;
            Console.WriteLine("Gia tri khong hop le. Vui long nhap so nguyen!");
        }
    }

    public static double ReadDouble(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string s = Console.ReadLine();

            // Chap nhan ca '.' va ','
            if (double.TryParse(s, out double v) ||
                double.TryParse(s, NumberStyles.Float, CultureInfo.InvariantCulture, out v) ||
                double.TryParse(s, NumberStyles.Float, new CultureInfo("vi-VN"), out v))
                return v;

            Console.WriteLine("Gia tri khong hop le. Vui long nhap so (vd: 5 hoac 5.2)!");
        }
    }

    public static double ReadPositiveDouble(string prompt)
    {
        while (true)
        {
            double v = ReadDouble(prompt);
            if (v > 0) return v;
            Console.WriteLine("Vui long nhap so thuc DUONG (> 0)!");
        }
    }
}

/* ================== TH1 ================== */
// Tinh chu vi & dien tich HCN
public static class ThucHanh1
{
    public static void Run()
    {
        double a = IOHelper.ReadDouble("Nhap chieu dai a: ");
        double b = IOHelper.ReadDouble("Nhap chieu rong b: ");

        double P = 2 * (a + b);
        double S = a * b;

        Console.WriteLine("Chu vi la: {0:0.##}", P);
        Console.WriteLine("Dien tich la: {0:0.##}", S);
    }
}

/* ================== TH2 ================== */
// Max trong 2 so nguyen
public static class ThucHanh2
{
    public static void Run()
    {
        int a = IOHelper.ReadInt("Nhap vao so nguyen a: ");
        int b = IOHelper.ReadInt("Nhap vao so nguyen b: ");

        if (a > b) Console.WriteLine("So lon hon trong 2 so la: " + a);
        else if (b > a) Console.WriteLine("So lon hon trong 2 so la: " + b);
        else Console.WriteLine("Hai so bang nhau: " + a);
    }
}

/* ================== TH3 ================== */
// Max trong 3 so nguyen
public static class ThucHanh3
{
    public static void Run()
    {
        int a = IOHelper.ReadInt("Nhap vao so nguyen a: ");
        int b = IOHelper.ReadInt("Nhap vao so nguyen b: ");
        int c = IOHelper.ReadInt("Nhap vao so nguyen c: ");

        int max = a;
        if (b > max) max = b;
        if (c > max) max = c;

        if (a == b && b == c)
            Console.WriteLine("Ba so bang nhau: {0}", a);
        else
            Console.WriteLine("So lon nhat trong 3 so la: {0}", max);
    }
}

/* ================== TH4 ================== */
// Thang co bao nhieu ngay
public static class ThucHanh4
{
    public static void Run()
    {
        int nam = IOHelper.ReadInt("Nhap nam: ");
        int thang = IOHelper.ReadInt("Nhap thang (1-12): ");

        switch (thang)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                Console.WriteLine("Thang co 31 ngay!");
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                Console.WriteLine("Thang co 30 ngay!");
                break;
            case 2:
                Console.WriteLine(IsLeap(nam) ? "Thang co 29 ngay!" : "Thang co 28 ngay!");
                break;
            default:
                Console.WriteLine("Thang khong hop le!");
                break;
        }
    }

    static bool IsLeap(int y) => (y % 400 == 0) || (y % 4 == 0 && y % 100 != 0);
}

/* ================== TH5 ================== */
// Nhap n: (a) chan/le, (b) am/khong am
public static class ThucHanh5
{
    public static void Run()
    {
        int n = IOHelper.ReadInt("Nhap so nguyen n: ");

        Console.WriteLine(n % 2 == 0 ? "n la so chan" : "n la so le");
        Console.WriteLine(n >= 0 ? "n la so khong am" : "n la so am");
    }
}

/* ================== TH6 ================== */
// Nhap a,b duong -> P, S HCN
public static class ThucHanh6
{
    public static void Run()
    {
        double a = IOHelper.ReadPositiveDouble("Nhap chieu dai a (>0): ");
        double b = IOHelper.ReadPositiveDouble("Nhap chieu rong b (>0): ");

        double P = 2 * (a + b);
        double S = a * b;

        Console.WriteLine("Chu vi = {0:0.##}", P);
        Console.WriteLine("Dien tich = {0:0.##}", S);
    }
}

/* ================== TH7 ================== */
// Nhap 3 canh; neu tao thanh tam giac -> in P, S (Heron)
public static class ThucHanh7
{
    public static void Run()
    {
        double a = IOHelper.ReadPositiveDouble("Nhap canh a (>0): ");
        double b = IOHelper.ReadPositiveDouble("Nhap canh b (>0): ");
        double c = IOHelper.ReadPositiveDouble("Nhap canh c (>0): ");

        bool valid = a + b > c && a + c > b && b + c > a;

        if (!valid)
        {
            Console.WriteLine("Ba doan thang KHONG lap thanh tam giac hop le!");
            return;
        }

        double P = a + b + c;
        double p = P / 2.0;
        double areaTerm = p * (p - a) * (p - b) * (p - c);
        double S = Math.Sqrt(Math.Max(0, areaTerm)); // tranh sai so am nho

        Console.WriteLine("Chu vi tam giac = {0:0.##}", P);
        Console.WriteLine("Dien tich tam giac = {0:0.##}", S);
    }
}

/* ================== TH8 ================== */
// Giai phuong trinh bac 2: a x^2 + b x + c = 0 (ca truong hop suy bien)
public static class ThucHanh8
{
    public static void Run()
    {
        double a = IOHelper.ReadDouble("Nhap a: ");
        double b = IOHelper.ReadDouble("Nhap b: ");
        double c = IOHelper.ReadDouble("Nhap c: ");

        const double EPS = 1e-9;

        if (Math.Abs(a) < EPS)
        {
            // Bac 1: b x + c = 0
            if (Math.Abs(b) < EPS)
            {
                Console.WriteLine(Math.Abs(c) < EPS
                    ? "Vo so nghiem"
                    : "Vo nghiem");
            }
            else
            {
                double x = -c / b;
                Console.WriteLine("Nghiem duy nhat: x = {0:0.###}", x);
            }
            return;
        }

        double delta = b * b - 4 * a * c;

        if (delta > EPS)
        {
            double sqrtD = Math.Sqrt(delta);
            double x1 = (-b + sqrtD) / (2 * a);
            double x2 = (-b - sqrtD) / (2 * a);
            Console.WriteLine("Hai nghiem phan biet:");
            Console.WriteLine("x1 = {0:0.###}", x1);
            Console.WriteLine("x2 = {0:0.###}", x2);
        }
        else if (Math.Abs(delta) <= EPS)
        {
            double x = -b / (2 * a);
            Console.WriteLine("Nghiem kep: x = {0:0.###}", x);
        }
        else
        {
            Console.WriteLine("Vo nghiem thuc");
            // Neu muon nghiem phuc:
            // double real = -b / (2*a);
            // double imag = Math.Sqrt(-delta) / (2*a);
            // Console.WriteLine($"x1 = {real} + {imag}i, x2 = {real} - {imag}i");
        }
    }
}

/* ================== TH9 ================== */
public static class ThucHanh9
{
    public static void Run()
    {
        Console.Write("Nhap so luong phan tu n: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = IOHelper.ReadInt($"Nhap arr[{i}]: ");
        }

        int sum = 0;
        foreach (int x in arr) sum += x;

        Console.WriteLine("Tong cac phan tu trong mang = " + sum);
    }
}

/* ================== TH10 ================== */
public static class ThucHanh10
{
    public static void Run()
    {
        string path = "input_array.txt";
        if (!System.IO.File.Exists(path))
        {
            Console.WriteLine("Khong tim thay file " + path);
            return;
        }

        string content = System.IO.File.ReadAllText(path);
        string[] tokens = content.Split(new[] { ' ', '\t', '\n', '\r', ',' }, StringSplitOptions.RemoveEmptyEntries);
        int[] arr = Array.ConvertAll(tokens, int.Parse);

        Console.WriteLine("Mang ban dau: " + string.Join(" ", arr));

        SelectionSort(arr);

        Console.WriteLine("Mang sau khi sap xep tang dan: " + string.Join(" ", arr));
    }

    private static void SelectionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIdx = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIdx]) minIdx = j;
            }
            // đổi chỗ
            int tmp = arr[i];
            arr[i] = arr[minIdx];
            arr[minIdx] = tmp;
        }
    }
}

/* ================== TH11 ================== */
public static class ThucHanh11
{
    public static void Run()
    {
        Console.Write("Nhap so luong phan tu n: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = IOHelper.ReadInt($"Nhap arr[{i}] (mang da sap xep tang dan): ");
        }

        // 1) Kiểm tra mảng có tăng dần (không giảm) hay chưa
        if (!IsNonDecreasing(arr))
        {
            Console.WriteLine("Loi: Mang chua duoc sap xep tang dan. Vui long nhap dung de bai.");
            return;
        }

        Console.WriteLine("Mang hien tai (tang dan): " + string.Join(" ", arr));

        // 2) Nhập x cần chèn
        int x = IOHelper.ReadInt("Nhap so nguyen can chen: ");

        // 3) Tìm vị trí chèn: chèn TRƯỚC phần tử đầu tiên >= x
        int pos = LowerBound(arr, x);

        // 4) Tạo mảng mới và chèn x vào đúng vị trí, không làm mất tính tăng dần
        int[] result = new int[n + 1];
        Array.Copy(arr, 0, result, 0, pos);          // copy [0..pos-1]
        result[pos] = x;                              // đặt x tại pos
        Array.Copy(arr, pos, result, pos + 1, n - pos); // copy phần còn lại

        Console.WriteLine("Mang sau khi chen: " + string.Join(" ", result));
    }

    // Kiểm tra mảng không giảm (tăng dần cho phép bằng nhau)
    private static bool IsNonDecreasing(int[] a)
    {
        for (int i = 1; i < a.Length; i++)
            if (a[i] < a[i - 1]) return false;
        return true;
    }

    // LowerBound: vị trí đầu tiên có giá trị >= x (tìm bằng tìm kiếm nhị phân)
    private static int LowerBound(int[] a, int x)
    {
        int l = 0, r = a.Length; // [l, r)
        while (l < r)
        {
            int m = l + (r - l) / 2;
            if (a[m] >= x) r = m;
            else l = m + 1;
        }
        return l; // vị trí chèn
    }
}
