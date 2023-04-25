using System;

class Program
{    
    static void Main(string[] args)
    {
        bool next = true;
        while (next)
        {
            Console.WriteLine("=== Menu ===");
            Console.WriteLine("1. Giai he phuong trinh bac nhat 2 an");
            Console.WriteLine("2. Kiem tra ma tran doi xung qua duong cheo chinh");

            // Lấy đầu vào từ người dùng
            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");            
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Ban da chon giai phuong trinh bac nhat 2 an");

                    double a1, b1, c1, a2, b2, c2;

                    Console.WriteLine("Nhap vao cac he so cua he phuong trinh a1x + b1y = c1: ");
                    Console.Write("Nhap vao so a1: ");
                    a1 = double.Parse(Console.ReadLine());
                    Console.Write("Nhap vao so b1: ");
                    b1 = double.Parse(Console.ReadLine());
                    Console.Write("Nhap vao so c1: ");
                    c1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("\nNhap vao cac he so cua he phuong trinh a2x + b2y = c2: ");
                    Console.Write("Nhap vao so a2: ");
                    a2 = double.Parse(Console.ReadLine());
                    Console.Write("Nhap vao so b2: ");
                    b2 = double.Parse(Console.ReadLine());
                    Console.Write("Nhap vao so c2: ");
                    c2 = double.Parse(Console.ReadLine());

                    // Tính định thức của ma trận hệ số
                    double D = a1 * b2 - a2 * b1;

                    // Kiểm tra nghiệm
                    if (D == 0)
                    {
                        if (b1 / a1 == b2 / a2 && c1 / a1 == c2 / a2)
                            Console.WriteLine("He phuong trinh co vo so nghiem.");
                        else
                            Console.WriteLine("He phuong trinh vo nghiem.");
                    }
                    else
                    {
                        // Tìm nghiệm của hệ phương trình
                        double x = (c1 * b2 - c2 * b1) / D;
                        double y = (a1 * c2 - a2 * c1) / D;

                        Console.WriteLine("Nghiem cua he phuong trinh la: x = {0}, y = {1}", x, y);
                    }

                    Console.WriteLine();
                    break;

                case 2:
                    Console.WriteLine("Ban da chon kiem tra ma tran doi xung qua duong cheo chinh");                                      
                    int n;

                    // Nhập cấp của ma trận
                    Console.Write("Nhap cap cua ma tran: ");
                    n = int.Parse(Console.ReadLine());

                    int[,] matrix = new int[n, n];

                    // Nhập các giá trị của ma trận
                    Console.WriteLine("Nhap cac phan tu cua ma tran:");
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write("matrix[{0},{1}] = ", i, j);
                            matrix[i, j] = int.Parse(Console.ReadLine());
                        }
                    }

                    // Điều kiện để xét ma trận đó có đối xứng qua đường chéo chính?
                    bool isSymmetric = true;
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if ((i != j && matrix[i, j] != matrix[j, i]) || (i == j && matrix[i, j] != matrix[j, i]))
                            {
                                isSymmetric = false;
                                break;
                            }
                        }
                        if (!isSymmetric)
                        {
                            break;
                        }
                    }

                    // In ra giá trị của ma trận
                    Console.Write("\nDay la gia tri cua ma tran\n");
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(matrix[i, j] + " ");
                        }
                        Console.WriteLine();
                    }

                    // Kết quả của ma trận
                    if (isSymmetric)
                    {
                        Console.WriteLine("\nMa tran nay la ma tran doi xung qua duong cheo chinh.");
                    }
                    else
                    {
                        Console.WriteLine("\nMa tran nay khong la ma tran doi xung qua duong cheo chinh.");
                    }

                    Console.WriteLine();

                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Khong co lua chon nay");                        
                    break;
            }
        }       
    }
}
