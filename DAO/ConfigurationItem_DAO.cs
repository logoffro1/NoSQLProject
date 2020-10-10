using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ConfigurationItem_DAO : Base
    {
        public static void AddConfigItem(ConfigurationItem ci)
        {
            throw new NotImplementedException();
        }

        public static ConfigurationItem GetConfigItemByID(string id)
        {
            throw new NotImplementedException();
        }

        public static List<ConfigurationItem> GetAllConfigItems()
        {
            throw new NotImplementedException();
        }

        public static void UpdateConfigItem(ConfigurationItem configItem)
        {
            throw new NotImplementedException();
        }

        public static List<ConfigurationItem> GetConfigItemsByLocation(string location)
        {
            throw new NotImplementedException();
        }

        public static List<ConfigurationItem> GetConfigItemsByImportance(TicketPriorityType importance)
        {
            throw new NotImplementedException();
        }
    }
}
