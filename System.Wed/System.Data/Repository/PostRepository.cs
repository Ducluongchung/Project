using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemWeb.Data.Infastructure;
using SystemWeb.Model.Models;

namespace SystemWeb.Data.Repository
{
    public interface IPostRepository:IRepository<Post>
    {

    }
    public class PostRepository:RepositoryBase<Post>,IPostRepository
    {
        public PostRepository(DbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
