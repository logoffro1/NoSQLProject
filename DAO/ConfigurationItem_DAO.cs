﻿using Model;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
            List<BsonDocument> docsList = ReadDocuments(COLLECTION_NAME);
            return CreateConfigurationItems(docsList);
        }

        public void UpdateConfigItem(ConfigurationItem configItem)
        {
            UpdateDocument(COLLECTION_NAME, "CI_ID", configItem.ID, "name", configItem.Name);

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
                {"importance", configItem.Importance},
            };
        }

        private List<ConfigurationItem> CreateConfigurationItems(List<BsonDocument> docsList)
        {
            List<ConfigurationItem> configurationItems = new List<ConfigurationItem>();

            foreach (BsonDocument doc in docsList)
            {
                configurationItems.Add(
                    new ConfigurationItem(
                        (string) doc["CI_ID"],
                        (string) doc["name"],
                        (string) doc["description"],
                        Convert.ToInt32(doc["owner"]),
                        (string) doc["location"],
                        (TicketPriorityType) Convert.ToInt32(doc["importance"]))
                );
                //MessageBox.Show(configurationItems.Last().ToString());
            }

            return configurationItems;
        }
    }
}