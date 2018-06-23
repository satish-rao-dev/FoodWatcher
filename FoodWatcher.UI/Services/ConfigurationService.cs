using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodWatcher.UI.Services
{
    public class ConfigurationService : IConfigurationService
    {
        public bool TryGetConfigurationFromAppSettins(string key, out string value, out string message)
        {
            bool result = false;
            value = string.Empty;
            message = string.Empty;
            try
            {
                if (!string.IsNullOrWhiteSpace(key))
                {
                    value = ConfigurationManager.AppSettings[key];
                    result = true;
                }
                else
                {
                    message = "Key is empty";
                }

            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            return result;
        }
    }
}
