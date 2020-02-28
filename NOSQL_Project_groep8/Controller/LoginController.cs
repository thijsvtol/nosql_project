using NOSQL_Project_groep8.Model;
using NOSQL_Project_groep8.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOSQL_Project_groep8.Controller
{
    class LoginController
    {
        private static UserRepository repository = new UserRepository();

        public UsersModel GetByUsername(string username)
        {
            UsersModel user = repository.GetUserPasswordByName(username);
            return user;
        }
    }
}
