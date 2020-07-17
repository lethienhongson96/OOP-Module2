using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace ProductManagement
{
    class ServiceProduct
    {
        Product[] products = new Product[0];

        public void Add(Product product)
        {
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = product;
        }

        public int FindProduct(string code)
        {
            for (int i=0;i<products.Length;i++)
            {
                if (products[i].Code.ToUpper()==code.ToUpper())
                {
                    return i;
                }
            }

            return -1;
        }
        public void Edit(Product product)
        {
            var index = FindProduct(product.Code);
            if (index!=-1)
            {
                products[index].Name = product.Name;
                products[index].Price = product.Price;
                products[index].ManuFactory = product.ManuFactory;
                products[index].Date = product.Date;
            }

            else
            {
                Console.WriteLine($"code: {product.Code} is not found");
            }
        }

        public void Delete(string code)
        {
             var index= FindProduct(code);
            if (index!=-1)
            {
                products = products.Where(w => w != products[index]).ToArray();
            }

            else
            {
                Console.WriteLine($"code: {code} is not found");
            }
        }

        public void Show()
        {
            string table = $"name\tcode\tprice\tdate\t\tmanufactory";
            for (int i = 0; i < products.Length; i++)
            {
                table = table + $"\n" + products[i].ProductInfo();
            }
            Console.WriteLine(table);
        }

    }
}
