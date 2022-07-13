using System;
using System.Collections.Generic;

namespace FactoryExercise2
{
    public class MongoDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
         {
             new Product (){Name="Xbox", Price = 350},
             new Product (){Name="Piane", Price = 1350},
             new Product (){Name="Plant", Price = 25},
             new Product (){Name="kite", Price = 25},
         };

        public void SaveData()
        {
            Console.WriteLine("I am saving data from a Mongo Data Access");
        }

        List<Product> IDataAccess.LoadData()
        {
            Console.WriteLine("I am reading data from Mongo Data Access");
            return Products;
        }
    }
}
}
