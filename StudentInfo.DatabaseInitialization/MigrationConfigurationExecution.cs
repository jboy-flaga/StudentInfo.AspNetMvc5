using StudentInfo.DatabaseInitialization.Migrations;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Infrastructure;

namespace StudentInfo.DatabaseInitialization
{
    /// <summary>
    /// JBOY: Executing migrations using code, not PowerShell commands
    ///     Julie Lerman implies that this will be placed inside the data layer
    /// </summary>
    public class MigrationConfigurationExecution
    {
        public static void RunMigration()
        {
            var migrationConfig = new StudentInfoMigrationsConfiguration();
            var migrator = new DbMigrator(migrationConfig);

            // JBOY: migrator.Update will look at the startup projects config file for the connection string
            // but you can provide a connection string to migrationConfig using "migrationConfig.TargetDatabase = connString"
            
            migrator.Update();
            //migrator.Update("migrationName");
        }

        /// <summary>
        /// Creates SQL script from migration. 
        /// The script is usually used in production database because you will not be executing migrations with visual studio in your production database.
        /// </summary>
        /// <returns></returns>
        public static string CreateScriptFromMigration()
        {
            var migrationConfig = new StudentInfoMigrationsConfiguration();
            var migrator = new DbMigrator(migrationConfig);
            var scriptor = new MigratorScriptingDecorator(migrator);
            return scriptor.ScriptUpdate(sourceMigration: null, targetMigration: null);
        }
    }
}
