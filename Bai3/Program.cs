namespace Bai3;

class Program
{
    private static Dictionary<string, Dictionary<string, int>> salesData = new Dictionary<string, Dictionary<string, int>>();
    static void Main(string[] args)
    {
        AddSalesData("Nguyen Van A", "SanPham1", 5);
        AddSalesData("Nguyen Van A", "SanPham2", 3);
        AddSalesData("Le Thi B", "SanPham1", 8);
        AddSalesData("Le Thi B", "SanPham3", 2);
        AddSalesData("Tran Van C", "SanPham2", 10);

        // Tìm nhân viên bán hàng xuất sắc nhất
        string topEmployee = FindTopSalesPerson();
        Console.WriteLine("Nhan vien ban nhieu nhat: " + topEmployee);

        // Tìm sản phẩm bán chạy nhất
        string bestSellingProduct = FindBestSellingProduct();
        Console.WriteLine("San pham ban chay nhat: " + bestSellingProduct);
    }

    static void AddSalesData(string employeeName, string productName, int quantity)
    {
        if (!salesData.ContainsKey(employeeName))
        {
            salesData[employeeName] = new Dictionary<string, int>();
        }

        if (!salesData[employeeName].ContainsKey(productName))
        {
            salesData[employeeName][productName] = 0;
        }

        salesData[employeeName][productName] += quantity;
    }

    static string FindTopSalesPerson()
    {
        string employeeName = "";
        int maxQuanity = 0;
        
        foreach (var employee in salesData)
        {
            int totalQuantity = employee.Value.Values.Sum();
            if (totalQuantity > maxQuanity)
            {
                maxQuanity = totalQuantity;
                employeeName = employee.Key;
            }
        }

        return employeeName;
    }

    static string FindBestSellingProduct()
    {
        Dictionary<string, int> productSales = new Dictionary<string, int>();

        foreach (var employee in salesData)
        {
            foreach (var product in employee.Value)
            {
                if (!productSales.ContainsKey(product.Key))
                {
                    productSales[product.Key] = 0;
                }
                productSales[product.Key] += product.Value;
            }
        }

        string bestProduct = "";
        int maxSales = 0;
        foreach (var product in productSales)
        {
            if (product.Value > maxSales)
            {
                maxSales = product.Value;
                bestProduct = product.Key;
            }
        }

        return bestProduct;

    }
}