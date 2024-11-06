namespace Bai1;

class Program
{
    static void Main(string[] args)
    {
        //a
        Console.WriteLine("Ve hinh chu nhat");
        Console.Write("Nhap chieu dai: ");
        int dai = Convert.ToInt32(Console.ReadLine());

        Console.Write("Nhap chieu rong: ");
        int rong = Convert.ToInt32(Console.ReadLine());

        for (int row = 1; row <= rong; row++)
        {
            for (int col = 1; col <= dai; col++)
            {
                if (row == 1 || row == rong || col == 1 || col == dai)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    
        
        //b
        Console.WriteLine("Ve hinh tam giac can");
        Console.Write("Nhap do dai canh ben: ");
        int canh = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= canh; i++)
        {
            for (int j = 1; j <= 2*canh - 1; j++)
            {
                if (i == canh || j == canh - i + 1 || j == canh + i - 1)
                    Console.Write("*");
                else Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}