namespace Numbers.Helper
{
  
        public interface IUserRepository
        {
            User[] GetData();

            User? GetData(int id);

            void Add(User user);

            void Update(User user, int id);

            void Delete(int id);
        }
    




}
