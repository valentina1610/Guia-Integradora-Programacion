using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using ProgramacionGUIAej4.Models;
using ProgramacionGUIAej4.Views;
using Repository;

namespace ProgramacionGUIAej4.Controller
{
    public class ProductController
    {
        private List<Product> productList;

        public ProductController()
        {
            productList = new();
            Load();
        }

        private void Load() 
        {
            productList = Repository<Product>.ObtenerTodos(Path.Combine("Repository", "Data", "data"));
        }

        private void Save() 
        {
            Repository<Product>.GuardarLista(Path.Combine("Repository", "Data", "data"), productList);
        }

        public void AddProduct()
        {
            var newProduct = ProductView.AddProduct();
            if (newProduct == null)
            {
                ProductView.ShowMsg("[ERROR]: Null product");
                return;
            }

            productList.Add(newProduct);
            Save();
        }

        public void ShowProducts()
        { 
            if (productList.Count == 0)
            {
                ProductView.ShowMsg("[ERROR]: Empty list");
                return;
            }
     
            ProductView.ShowProducts(productList);
        }

        public void UpdateProduct()
        {
            if (productList.Count == 0)
            {
                ProductView.ShowMsg("[ERROR]: Empty list");
                ProductView.ShowMsg("Press any key to return...");
                return;
            }

            ShowProducts();
            ProductView.ShowMsg(">>>>>>>>>> Enter the ID of the product you want to UPDATE: ");

            int idUpdate = int.Parse(ProductView.GetValidInput(true));
            if (idUpdate < 0)
            {
                ProductView.ShowMsg("[ERROR]: Invalid ID");
                return;
            }

            var productToUpdate = productList.FirstOrDefault(p => p.Id == idUpdate);

            if (productToUpdate == null)
            {
                ProductView.ShowMsg("[ERROR]: No products found with that ID");
                Console.ReadKey();
                return;
            }

            Product newProduct = ProductView.AddProduct();
            if (newProduct == null)
            {
                ProductView.ShowMsg("[ERROR]: Null product");
                Console.ReadKey();
                return;
            }

            productToUpdate.Name = newProduct.Name;
            productToUpdate.Price = newProduct.Price;
            productToUpdate.Stock = newProduct.Stock;

            Save();
        }

        public void DeleteProduct()
        {
            if (productList.Count == 0)
            {
                ProductView.ShowMsg("[ERROR]: Empty list");
                ProductView.ShowMsg("Press any key to return...");
                return;
            }

            ShowProducts();
            ProductView.ShowMsg(">>>>>>>>>> Enter the ID of the product you want to DELETE: ");

            int idDelete = int.Parse(ProductView.GetValidInput(true));
            if (idDelete < 0)
            {
                ProductView.ShowMsg("[ERROR]: Invalid ID");
                return;
            }

            var productToDelete = productList.FirstOrDefault(p => p.Id == idDelete);

            if (productToDelete == null)
            {
                ProductView.ShowMsg("[ERROR]: No products found with that ID");
                Console.ReadKey();
                return;
            }

            productList.Remove(productToDelete);
            Save();
            ProductView.ShowMsg("Product deleted successfully. Press any key to return...");
        }



    }
}
