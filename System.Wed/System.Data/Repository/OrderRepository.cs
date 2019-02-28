using System;
using System.Collections.Generic;
using System.Data.Infastructure;
using System.Linq;
using System.Model.Models;
using System.Text;
using System.Threading.Tasks;

namespace SystemWeb.Data.Repository
{
    public interface IOrderRepository:IRepository<Order>
    {

    }
    public class OrderRepository:RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(DbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
