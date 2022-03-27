using DataLayer.Entityes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuissnesLayer.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<ApplicationUser> GetAllUsers();
        ApplicationUser GetUserById(int userId);
        void SaveUser(ApplicationUser user);
        void DeleteUser(ApplicationUser user);
    }
}
