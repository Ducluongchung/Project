using System;
using System.Collections.Generic;
using System.Data.Infastructure;
using System.Linq;
using System.Model.Models;
using System.Text;
using System.Threading.Tasks;

namespace System.Data.Repository
{
    public interface IProductRepository : IRepository<Product>
    {

    }
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

    }
}
