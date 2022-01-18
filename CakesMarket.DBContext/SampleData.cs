using System;
using System.Diagnostics;
using System.Linq;

namespace CakesMarket.DBContext
{
    public class SampleData
    {
        public static void Initialize(DatabaseContext databaseContext)
        {
            try
            {
                databaseContext.Database.EnsureCreated();
                if (!databaseContext.Ingredients.Any())
                {
                    databaseContext.Ingredients.AddRange(Preconfigurations.PreConfiguration.GetPreConfigurationIngredients());
                    databaseContext.SaveChanges();
                }
                if (!databaseContext.Categories.Any())
                {
                    databaseContext.Categories.AddRange(Preconfigurations.PreConfiguration.GetPreConfigurationCategory());
                    databaseContext.SaveChanges();
                }
                if (!databaseContext.Cakes.Any())
                {
                    databaseContext.Cakes.AddRange(Preconfigurations.PreConfiguration.GetPreConfigurationCakes());
                    databaseContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Trace.Write(ex);
            }
        }
    }
}
