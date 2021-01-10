using System.ComponentModel.DataAnnotations;

namespace Lab6.Models
{
    public class DB_Intermediate
    {
        [Key]
        public int ID { get; set; }
        public virtual DB_Users DBUsers { get; set; }
        public virtual DB_Roles DBRoles { get; set; }
        public int UsersID { get; set; }
        public int RolesID { get; set; }
    }
}
