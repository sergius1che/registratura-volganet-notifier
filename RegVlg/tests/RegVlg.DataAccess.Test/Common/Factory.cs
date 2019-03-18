using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegVlg.DataAccess.Test.Common
{
    public static class Factory
    {
        public static IConfigurationRoot GetConfiguration()
        {
            var curDir = Environment.CurrentDirectory;

            return new ConfigurationBuilder()
                .SetBasePath(curDir)
                .AddJsonFile("appsettings.json")
                .Build();
        }
    }
}
