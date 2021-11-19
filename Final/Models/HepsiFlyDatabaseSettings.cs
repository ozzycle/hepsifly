using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    // HepsiFlyDatabaseSettings
    public class HepsiFlyDatabaseSettings : IHepsiFlyDatabaseSettings
    {
        public string ProductsCollectionName { get; set; }
        public string CategoriesCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IHepsiFlyDatabaseSettings
    {
        string ProductsCollectionName { get; set; }
        string CategoriesCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
