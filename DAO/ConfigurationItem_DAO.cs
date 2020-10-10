using Model;
using System;
using System.Collections.Generic;
using MongoDB.Bson;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ConfigurationItem_DAO : Base
    {
        private const string COLLECTION_NAME = "configitemdb";

        public void AddConfigItem(ConfigurationItem ci)
        {
            CreateDocument(COLLECTION_NAME, CreateConfigurationItemDocument(ci));
        }

        public ConfigurationItem GetConfigItemByID(string id)
        {
            throw new NotImplementedException();
        }

        public List<ConfigurationItem> GetAllConfigItems()
        {
            throw new NotImplementedException();
        }

        public void UpdateConfigItem(ConfigurationItem configItem)
        {
            throw new NotImplementedException();
        }

        public List<ConfigurationItem> GetConfigItemsByLocation(string location)
        {
            throw new NotImplementedException();
        }

        public List<ConfigurationItem> GetConfigItemsByImportance(TicketPriorityType importance)
        {
            throw new NotImplementedException();
        }

        private BsonDocument CreateConfigurationItemDocument(ConfigurationItem configItem)
        {
            return new BsonDocument
            {
                {"CI_ID", configItem.ID},
                {"name", configItem.Name},
                {"description", configItem.Description},
                {"owner", configItem.Owner},
                {"location", configItem.Location},
                {"importance", configItem.Importance}
            };
        }
    }
}