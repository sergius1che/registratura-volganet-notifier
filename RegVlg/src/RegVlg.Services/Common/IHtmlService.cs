using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RegVlg.Services.Common
{
    public interface IHtmlService
    {
        Task<string> GetHtmlPage(string controller, string action);

        Task<string> GetHtmlPage(string controller, string action, IDictionary<string, object> templateValues);
    }
}
