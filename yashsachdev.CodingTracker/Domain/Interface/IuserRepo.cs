using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yashsachdev.CodingTracker.Domain.Model;

namespace yashsachdev.CodingTracker.Domain.Interface
{
    internal interface IuserRepo
    {
        User GetUser(int userId);
        List<User> GetUsers();
        User AddUser(User user);
        User UpdateUser(User user);
        void DeleteUser(int userId);
    }
}
