using CSharpEgitimKampi301.DataAccess.Abstract;
using CSharpEgitimKampi301.DataAccess.Repositories;
using CSharpEgitimKampi301.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccess.EntityFramework
{
    public class EfOrderDal:GenericRepository<Order>,IOrderDal
    {
    }
}
