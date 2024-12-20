using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetingApp.Data.Abstract;
using MeetingApp.Models;

namespace MeetingApp.Data.Concrate.EfCore
{
    public class EfUserRepository : IUserRepository
    {
         private BlogContext _context;

        public EfUserRepository(BlogContext context)
        {
                _context = context;
        }
        public IQueryable<User> Users =>_context.Users;

        public void CreateUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}