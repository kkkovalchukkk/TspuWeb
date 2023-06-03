using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Services.Users
{
    public class UserPurchaseRepository: IUserPurchaseRepository
    {
        private readonly ApplicationDbContext dbContext;

        public UserPurchaseRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

       

        public UserPurchase[] Get(int userId)
        {

            return dbContext.UserPurchases
                .Where(purchase => purchase.UserId == userId)
                .ToArray();
        }


        void IUserPurchaseRepository.Create(UserPurchase userpurchase)
        {
            dbContext.UserPurchases.Add(userpurchase);
            dbContext.SaveChanges();
        }
    }
}
