namespace Numbers
{
    public interface IUserRepository
    {
        public User[] GetData();

        public User? GetData(int id);

        public void Add(User user);

        public void Edit(User user, int id);

        public void Delete(int id);

    }
}
