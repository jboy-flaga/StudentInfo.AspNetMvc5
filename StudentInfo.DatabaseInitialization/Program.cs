using StudentInfo.DatabaseInitialization.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo.DatabaseInitialization
{
    class Program
    {
        static void Main(string[] args)
        {
            // JBOY: Set database initializer for migration (in code) (or use the <entityFramework><contexts><context> 
            //      section in App.config)
            //      In ASP.NET web apps, setting the database initializer will be placed in global.asax
            // NOTE: The Seed method inside the Configuration class will always be called for each database 
            //      initialization (just comment the Database.SetInitializer() method to prevent the 
            //      Configuration.Seed() method from being executed the second time)
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentInfoContext, StudentInfoMigrationsConfiguration>());

            // JBOY: Use this code to turn off database initialization (important/useful in production code)
            //      (or use the disableDatabaseInitialization="true" attribute in <entityFramework><contexts><context> 
            //      section in App.config)
            // Database.SetInitializer<StudentInfoContext>(null);

            CreateDatabase();
            Console.WriteLine("Database created.");

            Console.WriteLine("Press the Enter Key.");
            Console.ReadLine();
        }

        private static void CreateDatabase()
        {
            var context = new StudentInfoContext();
            context.Database.Initialize(true);
        }
    }
}
