using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RecipeProject.WPF.Models
{
    public interface IUserRepository
    {
        bool AuthenticateUser(NetworkCredential credential);
        void Add(UserModel userModel);
        void Remove(Guid id);
        void Edit(UserModel userModel);
        UserModel GetById(Guid id);
        UserModel GetByUsername(string username);
        IEnumerable<UserModel> GetByAll();
        

    }
}
