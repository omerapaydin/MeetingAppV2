using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetingApp.Data.Abstract;
using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController:Controller
    {
        private IMeetRepository _meetRepository;
        private IUserRepository _userRepository;

        public HomeController(IMeetRepository meetRepository,IUserRepository userRepository)
        {
            _meetRepository = meetRepository;
            _userRepository = userRepository;
        }
        public IActionResult Index()
        {
            return View(_meetRepository.Meetings.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Meeting meeting)
        {
            if(ModelState.IsValid)
            {
                _meetRepository.CreateMeet(meeting);

                return RedirectToAction("Index");
            }
            return View(meeting);
        }
       
         public IActionResult Join()
        {
            return View();
        }
        [HttpPost]
         public IActionResult Join(User user)
        {

             if(ModelState.IsValid)
            {
                ViewBag.UserCount = _userRepository.Users.Where(u => u.IsOkey == true).Count();
               
               _userRepository.CreateUser(user);
                return View("Thanks",user);
            }
            return View(user);
        }
         public IActionResult List()
        {
            return View(_userRepository.Users.ToList());
        }

        
        
    }
}