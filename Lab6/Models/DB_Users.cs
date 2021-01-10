using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lab6.Models
{
    public class DB_Users
    {
        [Key]
        public int UserID { get; set; }

        public String Name { get; set; }

        public String Surname { get; set; }

        public String Login { get; set; }

        public String Password { get; set; }
        public String Email { get; set; }

        public virtual ICollection<DB_Intermediate> DBIntermediate { get; set; }

    }
}