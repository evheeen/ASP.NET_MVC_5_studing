using System.Data.Entity;

namespace Lab6.Models
{
    public class DB_Content : DbContext
    {
        public DbSet<DB_Users> DB_Users { get; set; }
        public DbSet<DB_Roles> DB_Roles { get; set; }
        public DbSet<DB_Intermediate> DB_Intermediates { get; set; }

        public class DBContent : DropCreateDatabaseAlways<DB_Content>
        {
            protected override void Seed(DB_Content context)
            {
                //Users
                context.DB_Users.Add(new DB_Users
                {
                    Name = "Jason",
                    Surname = "Bell",
                    Login = "Jason_Bell",
                    Password = "yAE2tg7T78",
                    Email = "Jason_Bell@gmail.com"
                });
                context.DB_Users.Add(new DB_Users
                {
                    Name = "Eric",
                    Surname = "Hill",
                    Login = "Eric_Hill",
                    Password = "EFMner3836",
                    Email = "Eric_Hill@gmail.com"
                });
                context.DB_Users.Add(new DB_Users
                {
                    Name = "Noah",
                    Surname = "Turner",
                    Login = "Noah_Turner",
                    Password = "P49dHxSj33",
                    Email = "Noah_Turner@gmail.com"
                });
                //Roles
                context.DB_Roles.Add(new DB_Roles
                {
                    RoleID = 1, //User
                    AdminRights = false,
                    UserRights = true,
                    SellerRights = true,
                    AssistantRights = false
                });
                context.DB_Roles.Add(new DB_Roles
                {
                    RoleID = 2, //Admin
                    AdminRights = true,
                    UserRights = true,
                    SellerRights = true,
                    AssistantRights = true
                });
                context.DB_Roles.Add(new DB_Roles
                {
                    RoleID = 3, //Seller
                    AdminRights = false,
                    UserRights = true,
                    SellerRights = true,
                    AssistantRights = false
                });
                context.DB_Roles.Add(new DB_Roles
                {
                    RoleID = 4, //Assistant
                    AdminRights = false,
                    UserRights = true,
                    SellerRights = true,
                    AssistantRights = true
                });
                //Intermediate
                context.DB_Intermediates.Add(new DB_Intermediate
                {
                    UsersID = 0,
                    RolesID = 1
                });
                context.DB_Intermediates.Add(new DB_Intermediate
                {
                    UsersID = 1,
                    RolesID = 2
                });
                context.DB_Intermediates.Add(new DB_Intermediate
                {
                    UsersID = 2,
                    RolesID = 3
                });

                base.Seed(context);
            }
        }
    }
}
