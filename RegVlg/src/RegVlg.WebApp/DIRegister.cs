using Microsoft.Extensions.DependencyInjection;
using RegVlg.Services.Auth;
using RegVlg.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegVlg.WebApp
{
    public static class DIRegister
    {
        public static void RegisterComponents(IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IHtmlService, HtmlService>();
        }
    }
}
