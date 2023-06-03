namespace Numbers.Helper
{
    public class Repository : IUserRepository //: IUserRepository
    {

        private List<User> Users = new List<User>();//Приватное поле список пользователей  
        User user = new User();


        public User[] GetData() //Метод получения массива пользователей 
        {
            return Users.ToArray();//преобразование в массив листа 
        }

        public User? GetData(int id)
        {
            for (int i = 0; i <= Users.Count - 1; i++)
            {
                if (Users[i].Id == id) return Users[i];// или Users.Id 
            }

            return null;
        }


        public void Add(User user)//Метод добавления пользователя;//При добавлении каждому новому пользователю (User) должен выставляться новый id.
        {

            user.Id = Users.Count;
            Users.Add(user);

        }


        public void Delete(int id)//Метод удаления пользователя по id;//Добавить проверку на наличие пользователя с таким id.  
        {
            User? user = GetData(id);
            if (user == null)
            {
                return;
            }

            Users.Remove(user);
        }


        public void Update(User user, int id) //Метод изменения пользователя по id//Добавить проверку на наличие пользователя с таким id. Редактировать можно только UserName и Login.
        {
            User? userInList = GetData(id);
            if (userInList == null)
            {
                return;
            }

            userInList.UserName = user.UserName;
            userInList.Login = user.Login;
        }

    }
}

