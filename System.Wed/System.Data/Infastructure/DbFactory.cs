using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemWeb.Data.Infastructure
{
    public class DbFactory: Disposable, IDbFactory
    {
        private SystemDbContext dbContext;

        public SystemDbContext Init()
        {
            return dbContext ?? (dbContext = new SystemDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
