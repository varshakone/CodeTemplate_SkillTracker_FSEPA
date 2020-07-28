﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SkillTracker.BusinessLayer.Interface;
using SkillTracker.Entities;

namespace SkillTracker.API.Controllers
{
   
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        //Rest post api to return success message by creating new user
        [Route("api/user/new")]
        [HttpPost]
        public async Task< ActionResult<String>> CreateNewUser(User user)
        {
           
                //Business logic to call user servic method which returns success message after creating new user
               

        }

        //Rest post api to return 1 after updation of user
        [Route("api/user/edit")]
        [HttpPost]
        public async Task<ActionResult<int>>  ReviseUser(User user)
        {
             //Business logic to call user servic method which returns 1 on successfull updation of user
             

        }

        //Rest post api to return 1 after deletion of user
        [Route("api/user/delete")]
        [HttpPost]
        public async Task< ActionResult<int>> Destroyuser(String firstname, String lastname)
        {
           
                //Business logic to call user servic method which returns 1 on successfull deletion of user
            

        }
    }
}