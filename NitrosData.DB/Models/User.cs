using System;
using System.Collections.Generic;

namespace NitrosData.DB.Models
{
    public class User
    {
        public User()
        {
            UsersUsers = new List<UsersUsers>();
        }
        /// <summary>
        ///     Идентификатор.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///     Имя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Фамилия
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        ///     Отчество.
        /// </summary>
        public string Patronymic { get; set; }

        /// <summary>
        ///     День рождения.
        /// </summary>
        public DateTime Birthday { get; set; }

        /// <summary>
        ///     Адрес.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Связь с Юзером
        /// </summary>
        public List<UsersUsers> UsersUsers { get; set; }
    }
}