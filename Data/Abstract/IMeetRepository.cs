using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetingApp.Models;

namespace MeetingApp.Data.Abstract
{
    public interface IMeetRepository
    {
        IQueryable<Meeting> Meetings {get;}
        void CreateMeet(Meeting meeting);
    }
}