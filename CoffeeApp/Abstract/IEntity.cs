using CoffeeAppwithMernis.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeAppwithMernis.Abstract
{
    interface IEntity
    {
        void Save(Customer customer);
    }
}
