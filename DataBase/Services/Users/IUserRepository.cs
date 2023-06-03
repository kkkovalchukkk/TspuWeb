using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataBase.Services.Users
{
 
    public interface IUserRepository
    {
        DbUser[] Get();

        DbUser? Get(int id);

        void Create(DbUser user);

        void Update(DbUser user);

        void Delete(int id);


    }

}
