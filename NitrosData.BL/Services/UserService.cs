using System;
using System.Collections.Generic;
using System.Linq;
using NitrosData.BL.DTO;
using NitrosData.BL.Interfaces;
using NitrosData.DB;
using NitrosData.DB.Models;

namespace NitrosData.BL.Services
{
    public class UserService : IUserService
    {
        private readonly NitrosDbContext _context;

        public UserService(NitrosDbContext context)
        {
            _context = context;
        }

        /// <inheritdoc cref="IUserService" />
        public IEnumerable<UserDTO> GetUsers()
        {
            var users = _context.Users.ToList();

            var listUser = users.Select(x => new UserDTO
            {
                Address = x.Address, Birthday = x.Birthday, Id = x.Id, Patronymic = x.Patronymic, Name = x.Name,
                Surname = x.Surname
            });
            return listUser;
        }

        /// <inheritdoc cref="IUserService" />
        public bool AddUser(UserDTO dto)
        {
            try
            {
                var user = new User
                {
                    Address = dto.Address,
                    Birthday = dto.Birthday,
                    Name = dto.Name,
                    Patronymic = dto.Patronymic,
                    Surname = dto.Surname
                };
                _context.Add(user);
                _context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <inheritdoc cref="IUserService" />
        public bool EditUser(UserDTO dto)
        {
            try
            {
                var currentUser = _context.Users.Find(dto.Id);
                var users = _context.Users.Where(x => dto.UsersId.Contains(x.Id)).ToList();
                var userUsers = users.Select(x => new UsersUsers
                    {User1 = currentUser, User2 = x, User1Id = currentUser.Id, User2Id = x.Id}).ToList();

                var user = new User
                {
                    Address = dto.Address,
                    Birthday = dto.Birthday,
                    Name = dto.Name,
                    Patronymic = dto.Patronymic,
                    Surname = dto.Surname,
                    Id = dto.Id,
                    UsersUsers = userUsers
                };
                _context.Add(user);
                _context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <inheritdoc cref="IUserService" />
        public bool DeleteUser(int id)
        {
            try
            {
                var user = _context.Users.Find(id);
                _context.Remove(user);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <inheritdoc cref="IUserService" />
        public bool AddRelatives()
        {
            throw new NotImplementedException();
        }
    }
}