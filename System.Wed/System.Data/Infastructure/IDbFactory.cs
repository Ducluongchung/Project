﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemWeb.Data.Infastructure
{
    public interface IDbFactory : IDisposable
    {
        SystemDbContext Init();
    }
}
