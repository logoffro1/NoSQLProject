using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;
using MongoDB.Bson;

namespace DAO
{
    public class Base
    {
        //password: admin  |  dbName: garden_group
        private const string CONNECTION_STRING =
            "mongodb+srv://admin:admin@cluster0.kzqlj.azure.mongodb.net/garden_group?retryWrites=true&w=majority";

        private const string CONNECTION_STRING_ARCHIVE =
            "mongodb+srv://admin:admin@cluster0.kzqlj.azure.mongodb.net/garden_group_archive?retryWrites=true&w=majority";

        private MongoClient dbClient;
        private IMongoDatabase database;

        public Base()
        {
            ConnectToDB();
            database = dbClient.GetDatabase("garden_group");
        }

        private void ConnectToDB()
        {
            try
            {
                dbClient = new MongoClient(CONNECTION_STRING);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        private IMongoCollection<BsonDocument>
            GetCollection(string collectionName) //gets the specified collection(table) from the DB
        {
            return database.GetCollection<BsonDocument>(collectionName);
        }

        protected async void
            CreateDocument(string collectionName, BsonDocument data) //Inserts the data into the specified collection
        {
            data = AddTimeStamp(data);
            await GetCollection(collectionName).InsertOneAsync(data);
        }

        protected List<BsonDocument> ReadDocuments(string collectionName) //reads an entire collection from the DB
        {
            return GetCollection(collectionName).Find(new BsonDocument()).ToList();
        }

        protected BsonDocument
            ReadDocument(string collectionName, string columnName,
                int id) //reads only one document from the DB based on the filter
        {
            var filter = Builders<BsonDocument>.Filter.Eq(columnName, id);
            return GetCollection(collectionName).Find(filter).FirstOrDefault();
        }

        protected async void UpdateDocument(string collectionName, string idColumnName, int id, string columnToChange,
            int newId) //updates a document in the DB (changes an int)
        {
            var filter = Builders<BsonDocument>.Filter.Eq(idColumnName, id);
            var update = Builders<BsonDocument>.Update.Set(columnToChange, newId);

            await GetCollection(collectionName).UpdateOneAsync(filter, update);

            var updateTimeStamp = Builders<BsonDocument>.Update.Set("updated_on", DateTime.Now);
            await GetCollection(collectionName).UpdateOneAsync(filter, updateTimeStamp);
        }

        protected async void UpdateDocument(string collectionName, string idColumnName, int id, string columnToChange,
            string newString) //updates a document in the DB (changes a string)
        {
            var filter = Builders<BsonDocument>.Filter.Eq(idColumnName, id);
            var update = Builders<BsonDocument>.Update.Set(columnToChange, newString);


            await GetCollection(collectionName).UpdateOneAsync(filter, update);
            var updateTimeStamp = Builders<BsonDocument>.Update.Set("updated_on", DateTime.Now);
            await GetCollection(collectionName).UpdateOneAsync(filter, updateTimeStamp);
        }

        protected async void UpdateDocument(string collectionName, string idColumnName, string id,
            string columnToChange, string newString) //updates a document in the DB (changes a string) with string ID
        {
            var filter = Builders<BsonDocument>.Filter.Eq(idColumnName, id);
            var update = Builders<BsonDocument>.Update.Set(columnToChange, newString);

            await GetCollection(collectionName).UpdateOneAsync(filter, update);

            var updateTimeStamp = Builders<BsonDocument>.Update.Set("updated_on", DateTime.Now);
            await GetCollection(collectionName).UpdateOneAsync(filter, updateTimeStamp);
        }

        protected async void UpdateDocument(string collectionName, string idColumnName, string id,
            string columnToChange, int newId) //updates a document in the DB (changes an int)
        {
            var filter = Builders<BsonDocument>.Filter.Eq(idColumnName, id);
            var update = Builders<BsonDocument>.Update.Set(columnToChange, newId);

            await GetCollection(collectionName).UpdateOneAsync(filter, update);

            var updateTimeStamp = Builders<BsonDocument>.Update.Set("updated_on", DateTime.Now);
            await GetCollection(collectionName).UpdateOneAsync(filter, updateTimeStamp);
        }

        protected async void
            DeleteDocument(string collectionName, string columnName,
                int id) // deletes document from the specified collectiion
        {
            var deleteFilter = Builders<BsonDocument>.Filter.Eq(columnName, id);
            await GetCollection(collectionName).DeleteOneAsync(deleteFilter);
        }

        protected async void DeleteDocument(string collectionName, string columnName,
            string id) // deletes document from the specified collectiion
        {
            var deleteFilter = Builders<BsonDocument>.Filter.Eq(columnName, id);
            await GetCollection(collectionName).DeleteOneAsync(deleteFilter);
        }

        protected int
            GetLatestId(string collectionName,
                string columnName) //gets the ID of the latest document added in the specified collection
        {
            List<BsonDocument> documents = GetCollection(collectionName).Find(new BsonDocument()).ToList();

            int id = 1;

            if (documents.Count != 0)
                id = documents[documents.Count - 1][columnName].AsInt32 + 1;

            return id;
        }

        private BsonDocument AddTimeStamp(BsonDocument bsonDocument)
        {
            return bsonDocument.Add("updated_on",
                DateTime.Now);
        }


        protected void ArchiveDatabase(string collectionName, int daysOldArchive)
        {
            if (daysOldArchive < 10)
            {
                throw new Exception("Can't deleted files less than 10 days old");
            }

            DateTime archiveCutoff = DateTime.Now.AddDays(-daysOldArchive);

            var dbArchiveClient = new MongoClient(CONNECTION_STRING_ARCHIVE);
            IMongoDatabase archiveDb = dbArchiveClient.GetDatabase("garden_group_archive");

            var collection = ReadDocuments(collectionName); // Main Collection
            //var archiveCollection = archiveDb.GetCollection<BsonDocument>(collectionName).Find(new BsonDocument()).ToList(); // Archive collection

            foreach (BsonDocument bsonDoc in collection)
            {
                DateTime updated = (DateTime) bsonDoc["updated_on"];
                if (DateTime.Compare(updated, archiveCutoff) == -1)
                {
                    string columnName;
                    string id;
                    if ((string) bsonDoc["CI_ID"] != null) // 
                    {
                        id = (string) bsonDoc["CI_ID"];
                        columnName = "CI_ID";
                    }
                    else if ((string) bsonDoc["ticket_id"] != null)
                    {
                        id = (string) bsonDoc["ticket_id"];
                        columnName = "ticket_id";
                    }
                    else if ((string) bsonDoc["user_id"] != null)
                    {
                        id = (string) bsonDoc["user_id"];
                        columnName = "user_id";
                    }
                    else
                    {
                        throw new Exception("Different ID");
                    }


                    archiveDb.GetCollection<BsonDocument>(collectionName).InsertOne(bsonDoc);
                    DeleteDocument(collectionName, columnName, id);
                }
            }


            var Filter = Builders<BsonDocument>.Filter.Lte("updated_at", DateTime.Now.AddDays(-daysOldArchive));
        }
    }
}