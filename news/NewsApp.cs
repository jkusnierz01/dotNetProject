using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using news.Models;

namespace news
{
    public class NewsApp : DbContext
    {
        // Your context has been configured to use a 'NewsApp' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'news.NewsApp' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'NewsApp' 
        // connection string in the application configuration file.
        public NewsApp()
            : base("name=NewsApp")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserCategory> UserCategories { get; set; }
        public virtual DbSet<Category> CategoryCategories { get; set; }
        public virtual DbSet<Article> Articles { get; set; }
    }

    
    
    

   

    


}