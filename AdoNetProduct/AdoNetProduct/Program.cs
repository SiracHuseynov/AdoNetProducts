using AdoNetProduct.Controllers;
using Business.Enums;

namespace AdoNetProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CategoryController categoryController = new CategoryController();
            ProductController productController = new ProductController();

            int answer;
           
            do
            {
                Console.WriteLine("1.AddCategory");
                Console.WriteLine("2.DeleteCategory");
                Console.WriteLine("3.UpdateCategory");
                Console.WriteLine("4.GetCategory");
                Console.WriteLine("5.GetAllCategory");
                Console.WriteLine("6.AddProduct");
                Console.WriteLine("7.DeleteProduct");
                Console.WriteLine("8.UpdateProduct");
                Console.WriteLine("9.GetProduct");
                Console.WriteLine("10.GetAllProduct");
                Console.WriteLine("0.Exit");

                do
                {
                    Console.WriteLine("Secim edin: ");
                }
                while (!int.TryParse(Console.ReadLine(), out answer));

                switch (answer)
                {
                    case (byte)Menu.AddCategory:
                        categoryController.Add();
                        break;
                    case (byte)Menu.DeleteCategory:
                        categoryController.Delete();
                        break;
                    case (byte)Menu.UpdateCategory:
                        categoryController.Update();
                        break;
                    case (byte)Menu.GetCategory:
                        categoryController.Get();
                        break;
                    case (byte)Menu.GetAllCategory:
                        categoryController.GetAll();
                        break;
                    case (byte)Menu.AddProduct:
                        productController.Add();
                        break;
                    case (byte)Menu.DeleteProduct:
                        productController.Delete();
                        break;
                    case (byte)Menu.UpdateProduct:
                        productController.Update();
                        break;
                    case (byte)Menu.GetProduct:
                        productController.Get();
                        break;
                    case (byte)Menu.GetAllProduct:
                        productController.GetAll();
                        break;
                }
            }
            while (answer != 0);
        }
    }
}
