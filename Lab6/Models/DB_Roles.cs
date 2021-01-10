using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lab6.Models
{
    public class DB_Roles
    {
        [Key]
        public int RoleID { get; set; }

        public Boolean AdminRights { get; set; }

        public Boolean UserRights { get; set; }

        public Boolean SellerRights { get; set; }

        public Boolean AssistantRights { get; set; }
        public virtual ICollection<DB_Intermediate> DBIntermediate { get; set; }
    }
}
