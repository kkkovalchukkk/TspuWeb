namespace Numbers
{
    public class UserRepositoryInMemory : IUserRepository
    {
        private readonly MemoryProvider memoryProvider;
        public static int num = 0;

        public UserRepositoryInMemory(MemoryProvider memoryProvider)
        {
            this.memoryProvider = memoryProvider;
        }


        public  User[] GetData() {
            return memoryProvider.Users.ToArray();
        }

        public  User? GetData(int id) {
            foreach (var user in memoryProvider.Users)
            {
                if (user.Id == id) return user;
            }

            return null;
        }

    

        public void Add(User user) 
        {
            
            user.Id = num++;
            memoryProvider.Users.Add(user);
        }

        public void Edit(User user, int id)
        {
            User? userInList = GetData(id);
            if (userInList == null)
            {
                return;
            }

            userInList.UserName = user.UserName;
            userInList.Login = user.Login;
        }


        public void Delete(int id) 
        {
            User? user = GetData(id);
            if (user == null)
            {
                return;
            }

            memoryProvider.Users.Remove(user);
        }

    }
}
