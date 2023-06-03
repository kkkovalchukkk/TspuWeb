using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Services.Users
{
    public interface IProductRepository
    {
        Product[] Get(int page = 1, int onPage = 20, int min_price = 0, int max_price = int.MaxValue);

        Product? Get(int id);

        void Create(Product product);

        void Update(Product product);

        void Delete(int id);


    }
}
