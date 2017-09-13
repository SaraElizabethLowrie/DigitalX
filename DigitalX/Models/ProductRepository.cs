using DigitalX.GatDataServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DigitalX.Models
{
    public class ProductRepository : IProductRepository
    {
        GetDataServiceClient db = new GetDataServiceClient();
        public Product find(int id)
        {
            return db.ProductGetDetails(id);
        }
    }
}