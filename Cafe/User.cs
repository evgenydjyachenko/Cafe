using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Cafe
{
    public enum UserRole
    {
        Admin,
        Manager,
        Teller
    }
    public class User
    {
        //TODO: Добавить свойстов Image для хранения фотографии пользователя
        public string Login { get; set; }
        public string Password { get;  set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Rate { get; set; }
        public UserRole Role { get; set; }

        public User() { }
        public User(string login, string password, string firstName, string lastName, string email, UserRole role)
        {
            Login = login;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Role = role;
        }

        public override string ToString()
        {
            return $"Имя:{FirstName} Фамилия:{LastName} Должность:{Role} Рейтинг:{Rate}";
        }
    }
}
