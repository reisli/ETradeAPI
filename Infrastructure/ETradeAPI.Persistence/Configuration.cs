﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETradeAPI.Persistence
{
    static class Configuration
    {
        public static string ConnectionString
        {
            get
            {
                ConfigurationManager configuration = new();
                configuration.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/ETradeAPI.API"));
                configuration.AddJsonFile("appsettings.json");

                return configuration.GetConnectionString("PostgreSql");
            }
        }
    }
}
