﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Evolve.Core.Driver
{
    public class SqlClientDriver : IDriver
    {
        public IDbConnection CreateConnection()
        {
            throw new NotImplementedException();
        }
    }
}