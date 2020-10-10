using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Model;

namespace Service
{
    class ConfigurationItem_Service
    {
        static ConfigurationItem_DAO ConfigurationItemDAO = new DAO.ConfigurationItem_DAO();

        void AddConfigItem(ConfigurationItem ci)
        {
            ConfigurationItem_DAO.AddConfigItem(ci);
        }

        void GetConfigItemByID(string id)
        {
            ConfigurationItem_DAO.GetConfigItemByID(id);
        }

        void GetAllConfigItems()
        {
            ConfigurationItem_DAO.GetAllConfigItems();
        }

        void UpdateConfigItem(ConfigurationItem configItem)
        {
            ConfigurationItem_DAO.UpdateConfigItem(configItem);
        }

        void GetConfigItemsByLocation(string location)
        {
            ConfigurationItem_DAO.GetConfigItemsByLocation(location);
        }

        void GetConfigItemsByImportance(TicketPriorityType Importance)
        {
            ConfigurationItem_DAO.GetConfigItemsByImportance(Importance);
        }
    }
}
