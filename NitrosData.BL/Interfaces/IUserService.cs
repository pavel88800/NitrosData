using System.Collections.Generic;
using NitrosData.BL.DTO;

namespace NitrosData.BL.Interfaces
{
    public interface IUserService
    {
        /// <summary>
        ///     Получить всех пользователей
        /// </summary>
        /// <returns></returns>
        IEnumerable<UserDTO> GetUsers();

        /// <summary>
        ///     Добавить пользователя
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        bool AddUser(UserDTO dto);

        /// <summary>
        ///     Редактировать пользователя
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        bool EditUser(UserDTO dto);

        /// <summary>
        ///     Удалить пользователя
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        bool DeleteUser(int id);

        /// <summary>
        ///     Добавить родственников
        /// </summary>
        /// <returns></returns>
        bool AddRelatives();
    }
}