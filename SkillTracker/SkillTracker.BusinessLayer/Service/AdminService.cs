﻿using MongoDB.Driver;
using SkillTracker.BusinessLayer.Interface;
using SkillTracker.DataLayer;
using SkillTracker.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SkillTracker.BusinessLayer.Service
{
    public class AdminService : IAdminService
    {
        private readonly IMongoDBContext _mongoDBContext;
        private readonly IMongoCollection<User> _mongoCollection;

        public AdminService(IMongoDBContext mongoDBContext)
        {
            _mongoDBContext = mongoDBContext;
            _mongoCollection = _mongoDBContext.GetCollection<User>(typeof(User).Name);
          
        }
        //return list of all users 
        public  IEnumerable<User> GetAllUsers()
        {
            //MongoDB Logic to retrieve all users from database
            return null;
        }
        //Search user by it's email
        public User SearchUserByEmail(string Email)
        {
            // MongoDB Logic to search user by email from database
            return null;
        }
        //Search user by it's first name
        public User SearchUserByFirstName(string firstname)
        {
            // MongoDB Logic to search user by firstname from database
            return null;
        }
        //Search user by it's mobile number
        public User SearchUserByMobile(long mobilenumber)
        {
            //MongoDB Logic to search user by mobilenumber from database
            return null;
        }
        //Search user by it's skill range between start value and end value
        public IEnumerable<User> SearchUserBySkillRange(int startvalue)
        {
            // MongoDB Logic to search user by Map Skill from database
            return null;
        }
    }
}
