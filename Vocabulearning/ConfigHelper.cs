using System.Configuration;

namespace Vocabulearning
{
    public class ConfigHelper
    {
        public string getStringAppSetting(string key, string defaulValue = "")
        {
            return ConfigurationManager.AppSettings[key] ?? defaulValue;
        }

        public int getIntAppSetting(string key, int defaulValue = 0)
        {
            string keyValue = ConfigurationManager.AppSettings[key] ?? defaulValue.ToString();
            int retVal;
            int.TryParse(keyValue, out retVal);
            return retVal;
        }
    }
}
