using System.Configuration;
using System.Web.Hosting;

namespace PetaPoco
{
    internal static class ConfigurationHelper
    {
        internal static string GetConfigurationValue(string configFileName, string sectionName)
        {
            if (configFileName == null)
            {
                return string.Empty;
            }

            string physicalPath = HostingEnvironment.ApplicationPhysicalPath;
            physicalPath = "@"+physicalPath+ConfigurationManager.AppSettings[configFileName];
            //    string path = HostingEnvironment.MapPath(ConfigurationManager.AppSettings[configFileName]);

            string path = physicalPath;
          ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap {ExeConfigFilename = path};
            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap,
                ConfigurationUserLevel.None);
            AppSettingsSection section = config.GetSection("appSettings") as AppSettingsSection;

            if (section != null)
            {
                if (section.Settings[sectionName] != null)
                {
                    return section.Settings[sectionName].Value;
                }
            }

            return string.Empty;
        }

        internal static string GetDbServerParameter(string key)
        {
            return GetConfigurationValue("DbServerConfigFileLocation", key);
        }
    }
}