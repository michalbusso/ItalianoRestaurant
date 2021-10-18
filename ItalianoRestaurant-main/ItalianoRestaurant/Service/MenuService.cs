using ItalianoRestaurant.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ItalianoRestaurant.Service
{
    public class MenuService
    {

        internal List<Category> GetCategories()
        {
            try
            {
                List<Category> categories = new List<Category>();
                JSONReadWrite readWrite = new JSONReadWrite();
                categories = JsonConvert.DeserializeObject<List<Category>>(readWrite.Read("Categories.json", "data"));
                return (categories);
            }
            catch (Exception)
            {
                return null;
            }

        }
        internal List<Product> GetProducts()
        {
            try
            {
                List<Product> Products = new List<Product>();
                JSONReadWrite readWrite = new JSONReadWrite();
                Products = JsonConvert.DeserializeObject<List<Product>>(readWrite.Read("Products.json", "data"));
                return (Products);

            }
            catch (Exception)
            {

                return null;
            }

        }
        internal List<Product> CreateProduct(Product product)
        {
            try
            {
                List<Product> products = GetProducts().OrderBy(p => p.productId).ToList();
                product.productId = products.LastOrDefault().productId + 1;
                var newProduct = JsonConvert.SerializeObject(product);
                products.Add(product);
                JSONReadWrite readWrite = new JSONReadWrite();
                string jSONString = JsonConvert.SerializeObject(products);
                readWrite.Write("Products.json", "data", jSONString);
                return products;
            }
            catch (Exception)
            {
                return null;
            }
        }
        internal List<Product> UpdateProduct(Product product)
        {
            try
            {
                var products = GetProducts().Where(p => p.productId != product.productId).ToList();
                products.Add(product);
                JSONReadWrite readWrite = new JSONReadWrite();
                string jSONString = JsonConvert.SerializeObject(products);
                readWrite.Write("Products.json", "data", jSONString);
                return products;
            }
            catch (Exception)
            {
                return null;
            }
        }

        internal List<Product> DeleteProduct(int id)
        {
            try
            {
                var products = GetProducts().Where(p => p.productId != id).ToList();
                JSONReadWrite readWrite = new JSONReadWrite();
                string jSONString = JsonConvert.SerializeObject(products);
                readWrite.Write("Products.json", "data", jSONString);
                return products;
            }
            catch (Exception)
            {
                return null;
            }
        }
    



    }
    public class JSONReadWrite
    {
        public JSONReadWrite() { }

        public string Read(string fileName, string location)
        {
            string root = "wwwroot";
            var path = Path.Combine(
            Directory.GetCurrentDirectory(),
            root,
            location,
            fileName);

            string jsonResult;

            using (StreamReader streamReader = new StreamReader(path))
            {
                jsonResult = streamReader.ReadToEnd();
            }
            return jsonResult;
        }

        public void Write(string fileName, string location, string jSONString)
        {
            string root = "wwwroot";
            var path = Path.Combine(
            Directory.GetCurrentDirectory(),
            root,
            location,
            fileName);

            using (var streamWriter = File.CreateText(path))
            {
                streamWriter.Write(jSONString);
            }
        }
    }
}
