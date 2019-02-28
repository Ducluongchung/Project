
using SystemWeb.Data.Infastructure;
using SystemWeb.Model.Models;

namespace SystemWeb.Data.Repository
{
    public interface IProductCategoryRepositoty:IRepository<ProductCategory>
    {

    }
    public class ProductCategoryRepositoty:RepositoryBase<ProductCategory>, IProductCategoryRepositoty
    {
        public ProductCategoryRepositoty(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
