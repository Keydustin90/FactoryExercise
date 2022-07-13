using System;
using System.Collections.Generic;

namespace FactoryExercise2
{
    public interface IDataAccess
    {
        public void SaveData();
        
        public List<Product> LoadData();
    }

    
}
