
using SystemWeb.Data.Infastructure;
using SystemWeb.Model.Models;

namespace SystemWeb.Data.Repository
{
    public interface IPostCategoryRepository : IRepository<PostCategory>
    {

    }
    public class PostCategoryRepository : RepositoryBase<PostCategory>
    {
        public PostCategoryRepository(DbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
