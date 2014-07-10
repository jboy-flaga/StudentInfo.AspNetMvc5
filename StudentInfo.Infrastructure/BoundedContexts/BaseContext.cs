using System.Data.Entity;

namespace StudentInfo.Infrastructure.Data.BoundedContexts
{
    /// <summary>
    /// JBOY: The idea of this BaseContext is from Julie Lerman.
    ///      When we create many DbContexts, EF will create a separate database for each DbContext.
    ///      Because we want them to point to the same database, we create this BaseContext class 
    ///            where all out DbContexts will inherit from.
    /// </summary>
    /// <typeparam name="TContext"></typeparam>
    public class BaseContext<TContext> : DbContext where TContext : DbContext
    {
        // JBOY: Notice that we don't have a public constructor 
        //  (so that we will not instantiate BaseContext accidentally)
        static BaseContext()
        {
            Database.SetInitializer<TContext>(null);
        }

        protected BaseContext()
            : base("name=StudentInfoDB") // TODO: you might need to change database name
        { }
    }
}
