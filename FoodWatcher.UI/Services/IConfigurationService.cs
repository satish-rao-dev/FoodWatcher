using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodWatcher.UI.Services
{
    public interface IConfigurationService
    {
        bool TryGetConfigurationFromAppSettins(string key, out string value, out string message);
    }
}
