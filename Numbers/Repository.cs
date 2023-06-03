namespace Numbers
{
    public class Repository
    {
        private static List<User> Users = new List<User>();
        public static int num = 0;

        public static User[] GetData() {
            return Users.ToArray();
        }

        public static User? GetData(int id) {
            foreach (var user in Users)
            {
                if (user.Id == id) return user;
            }

            return null;
        }

    

        public static void Add(User user) 
        {
            
            user.Id = num++;
            Users.Add(user);
        }

        public static void Edit(User user, int id)
        {
            User? userInList = GetData(id);
            if (userInList == null)
            {
                return;
            }

            userInList.UserName = user.UserName;
            userInList.Login = user.Login;
        }


        public static void Delete(int id) 
        {
            User? user = GetData(id);
            if (user == null)
            {
                return;
            }

            Users.Remove(user);
        }

    }
}
