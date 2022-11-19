using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    public class UserData: ISerialize
    {
        public List<User> AllUsers { get; set; } = new List<User>();

        public string FileName { get; set; } = nameof(UserData);    

        public User Authorization(string login, string password)
        {
            foreach (User user in AllUsers)
            {
                if (user.Login == login && user.Password == password)
                {
                    return user;
                }
            }
            return null;
        }

        public string GetInfo(int index)
        {
            User user = AllUsers[index];

            return $"Имя:{user.FirstName} Фамилия:{user.LastName} \nДолжность:{user.Role}" + 
                $"Почта:{user.Email} Рейтинг:{user.Rate}"; 
        }

        public User GetUser(string lastName)
        {
            foreach (User item in AllUsers)
            {
                if (item.LastName == lastName)
                {
                    return item;
                }
            }
            return null;
        }

        public void SaveUser(User user)
        {
            for (int i = 0; i < AllUsers.Count; i++)
            {
                if (AllUsers[i] == user)
                {
                    AllUsers[i] = user;
                }
            }
        }
    }
}
