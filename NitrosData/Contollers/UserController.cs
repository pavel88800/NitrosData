using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NitrosData.BL.DTO;
using NitrosData.BL.Interfaces;
using NitrosData.Contollers.Base;

namespace NitrosData.Contollers
{
    public class UserController : BaseApiController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IEnumerable<UserDTO> GetUsers()
        {
            var result = _userService.GetUsers();
            return result;
        }

        [HttpPost]
        [Route("add")]
        public IActionResult AddUser(UserDTO dto)
        {
            try
            {
                _userService.AddUser(dto);
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }

        [HttpPut]
        [Route("edit")]
        public IActionResult EditUser(UserDTO dto)
        {
            try
            {
                _userService.EditUser(dto);
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }

        [HttpDelete]
        [Route("delete")]
        public IActionResult DeleteUser(int id)
        {
            try
            {
                _userService.DeleteUser(id);
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }

        [HttpPost]
        [Route("add-relatives")]
        public IActionResult AddRelatives()
        {
            return Ok();
        }
    }
}