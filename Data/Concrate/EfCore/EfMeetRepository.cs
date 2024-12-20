using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetingApp.Data.Abstract;
using MeetingApp.Models;

namespace MeetingApp.Data.Concrate.EfCore
{
    public class EfMeetRepository : IMeetRepository
    {

        private BlogContext _context;

        public EfMeetRepository(BlogContext context)
        {
                _context = context;
        }

        public IQueryable<Meeting> Meetings => _context.Meetings;

        public void CreateMeet(Meeting meeting)
        {
            _context.Meetings.Add(meeting);
            _context.SaveChanges();
        }
    }
}