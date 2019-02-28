
using SystemWeb.Data.Infastructure;
using SystemWeb.Model.Models;

namespace SystemWeb.Data.Repository
{
    public interface IMenuRepository:IRepository<Menu>
    {

    }
    public class MenuRepository:RepositoryBase<Menu>,IMenuRepository
    {
        public MenuRepository(DbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
