using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace RegVlg.Services.Common
{
    public class HtmlService : IHtmlService
    {
        public const string CONTENT_PATH = "Content";
        public const string VALUE_PATTERN = "!@.+@";

        public async Task<string> GetHtmlPage(string controller, string action)
        {
            var pageBuilder = GetPage(controller, action);
            return 
        }

        public async Task<string> GetHtmlPage(string controller, string action, IDictionary<string, object> templateValues)
        {
            throw new NotImplementedException();
        }

        private async Task<StringBuilder> GetPage(string controller, string action)
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, CONTENT_PATH, action, action + ".html");
            var pageContent = await File.ReadAllTextAsync(path);

            return new StringBuilder(pageContent);
        }

        private void RemoveVars(StringBuilder stringBuilder)
        {
            int index;

            do
            {
                index = stringBuilder.
            } while (index != -1);
        }

    }
}
