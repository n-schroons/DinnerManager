using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TestdataBuilder;

namespace DinnerManager.Core
{
    public class BuildDataInitializer<TContext> : IDatabaseInitializer<TContext> where TContext : global::System.Data.Entity.DbContext
    {
        public void InitializeDatabase(TContext context)
        {
            //if (!context.Database.CompatibleWithModel(false))
            //{
            context.Database.Initialize(true);
                new DropCreateDatabaseAlways<TContext>().InitializeDatabase(context);
                new ApplicationTestdataBuilder().Build();
            //}
        }
    }
}