﻿using System.Collections.Generic;
 using System.Threading.Tasks;

 namespace Assignment2.Login
{
    public interface IUserService
    {
        Task<User> ValidateUserAsync(string username, string password);
        Task<User> AddUserAsync(User user);
        Task<IList<User>> getUsersAsync();
        Task RemoveUserAsync(string username);
    }
}