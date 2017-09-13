using DigitalX.GatDataServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalX.Models
{
    interface IProductRepository
    {
        Product find(int id);
    }
}
