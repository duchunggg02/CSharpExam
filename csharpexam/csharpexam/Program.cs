namespace MyProject;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        const int size = 10;
        int[] a = new int[size];
        Console.Write("Nhap n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        taoMang(a, n, rand);
        Console.Write("Mang ban dau: ");
        inMang(a, n);
        Console.Write("Mang sau khi da sap xep: ");
        sapXepChanLeTangGiam(a, n);
        inMang(a, n);
        //int x = 5, y = 10;
        //hoanVi(ref x, ref y);
        //Console.WriteLine(x + " " + y);
    }
    static void taoMang(int[] a, int n, Random rand)
    {
        for (int i = 0; i < n; i++) 
        {
            a[i] = rand.Next(100);
        }
    }
    static void inMang(int[] a, int n)
    {
        for (int i = 0; i < n; i++)
            Console.Write(a[i] + " ");
        Console.WriteLine();
    }
    static void hoanVi(ref int a, ref int b)
    {
        int tam = a;
        a = b;
        b = tam;
    }
    static void sapXepChanLeTangGiam(int[] a, int n)
    {
        int i = 0, j = n - 1;
        while (i < j)
        {
            if (a[i] % 2 == 0)
                i++;
            if (a[j] % 2 != 0)
                j--;
            if (i < j)
            {
                if (a[i] % 2 != 0 && a[j] % 2 ==0)
                {
                    hoanVi(ref a[i++], ref a[j--]);
                }
            }
        }

        int mid = a[i] % 2 != 0 ? i - 1 : i;

        for (i = 0; i < mid; i++)
            for (j = i + 1; j < mid + 1; j++)
            {
                if (a[i] > a[j])
                    hoanVi(ref a[i], ref a[j]);
            }

        for (i = mid + 1; i < n - 1; i++)
            for (j = i + 1; j < n; j++)
            {
                if (a[i] < a[j])
                    hoanVi(ref a[i], ref a[j]);
            }
    }
}