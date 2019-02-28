
using SystemWeb.Data.Infastructure;
using SystemWeb.Model.Models;

namespace SystemWeb.Data.Repository
{
    public interface IOrderDetailRepository:IRepository<OrderDetail>
    {

    }
    public class OrderDetailRepository: RepositoryBase<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
