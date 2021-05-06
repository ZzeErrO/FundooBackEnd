﻿using System;
using System.Collections.Generic;
using System.Text;
using CommonLayer;
using CommonLayer.Models;

namespace BusinessManager.Interfaces
{
    public interface IUserBL
    {
        bool UserRegister(UserModel user);
        public IEnumerable<UserModel> GetAll();
        public UserModel Get(long id);
        public bool Update(UserModel user, UserModel entity);
        public void Delete(UserModel user);
        public UserModel Authenticate(string email, string password);
    }
}
