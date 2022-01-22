using System;
using System.Data.Entity;
using System.Linq;

namespace PassManager2._0
{
    public class PassManagerDB : DbContext
    {
        // Your context has been configured to use a 'PassManagerDB' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'PassManager2._0.PassManagerDB' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'PassManagerDB' 
        // connection string in the application configuration file.
        public PassManagerDB()
            : base("name=PassManagerDB")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Password> Passwords { get; set; }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}