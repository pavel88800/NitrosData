namespace NitrosData.DB.Models
{
    public class UsersUsers
    {
        /// <summary>
        ///     Идентификатор.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///     Идентификатор родительского продукта
        /// </summary>
        public int User1Id { get; set; }

        /// <summary>
        ///     Родительская сущность.
        /// </summary>
        public User User1 { get; set; }

        /// <summary>
        ///     Идентификатор дочернего продукта
        /// </summary>
        public int User2Id { get; set; }

        /// <summary>
        ///     Дочерняя сущность
        /// </summary>
        public User User2 { get; set; }
    }
}