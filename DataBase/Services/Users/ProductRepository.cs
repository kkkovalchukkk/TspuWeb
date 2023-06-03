using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataBase.Services.Users
{
    public class ProductRepository : IProductRepository
    {

        private readonly ApplicationDbContext dbContext;

        public ProductRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        Product[] IProductRepository.Get(int page = 1, int onPage = 20, int min_price = 0, int max_price = int.MaxValue)
        {
            
            var products = dbContext.Products.OrderBy(p => p.Id).Skip(onPage * (page-1)).Take(onPage);   //Take Skip
            return products.ToArray();
        }

        public Product? Get(int id)
        {
            return dbContext.Products.Find(id);
        }

     


        void IProductRepository.Create(Product product)
        {
            product.Isdeleted = false;
            dbContext.Products.Add(product);
            dbContext.SaveChanges();
        }


        public void Update(Product product)
        {

            Product? Product = Get(product.Id);

            if ( Product == null)
            {
                return;
            }

            Product.Name = product.Name;
            Product.Description = product.Description;
            Product.Price= product.Price;

            dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            Product? dbProduct= Get(id);

            if (dbProduct == null)
            {
                return;
            }

            dbProduct.Isdeleted = true;
            dbContext.SaveChanges();
        }


    }
}

