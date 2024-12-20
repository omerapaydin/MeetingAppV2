using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetingApp.Models;

namespace MeetingApp.Data.Abstract
{
    public interface IUserRepository
    {
        IQueryable<User> Users {get;}
        void CreateUser(User user);
    }
}