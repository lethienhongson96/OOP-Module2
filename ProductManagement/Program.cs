using System;
using System.Linq;
namespace ProductManagement
{
    class Program
    {
        public static ServiceProduct serviceProduct = new ServiceProduct();
        static void Main(string[] args)
        {
            CreateProduct();
            CreateProduct();
            CreateProduct();

            int typeCode = -1;

            do
            {
                Console.WriteLine("Nhap 0 de Dung");
                Console.WriteLine("Nhap 1 de Show");
                Console.WriteLine("Nhap 2 de Sua");
                Console.WriteLine("Nhap 3 de Xoa");
                Console.Write("Nhap thao tac:");

                typeCode = int.Parse(Console.ReadLine());

                if (typeCode == 0)
                {
                    break;
                }

                switch (typeCode)
                {
                    case 1:
                        serviceProduct.Show();
                        break;
                    case 2:
                        UpdateProduct();
                        break;
                    case 3:
                        RemoveProduct();
                        break;
                }
            }
            while (true);
            
        }

        public static void UpdateProduct()
        {
            Console.Write("Nhap code can sua: ");
            string code = Console.ReadLine();

            Console.Write("Nhap name moi: ");
            string name = Console.ReadLine();

            Console.Write("Nhap price moi: ");
            string price = Console.ReadLine();

            Console.Write("Nhap Manu moi: ");
            string manu = Console.ReadLine();

            Product newP = new Product()
            {
                Name = name,
                Code = code,
                Price = price,
                ManuFactory = manu,
                Date = DateTime.Now
            };

            serviceProduct.Edit(newP);
        }

        public static void CreateProduct()
        {
            Random rnd = new Random();
            Product product = new Product()
            {
                Code = rnd.Next(1000, 9999).ToString(),
                Date = DateTime.Parse("2020/07/07"),
                ManuFactory= "USA",
                Name = "IP6",
                Price = "5000000"
            };

            serviceProduct.Add(product);
        }

        public static void RemoveProduct()
        {
            Console.Write("Enter code: ");
            var code = Console.ReadLine();
            serviceProduct.Delete(code);
        }

    }
}
