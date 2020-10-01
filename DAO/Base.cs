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
        private const string CONNECTION_STRING = "mongodb+srv://admin:admin@cluster0.kzqlj.azure.mongodb.net/garden_group?retryWrites=true&w=majority";
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
        protected IMongoCollection<BsonDocument> GetCollection(string collectionName) //gets the specified collection(table) from the DB
        {
            return database.GetCollection<BsonDocument>(collectionName);
        }
        protected async void CreateDocument(string collectionName, BsonDocument data) //Inserts the data into the specified collection
        {
            await GetCollection(collectionName).InsertOneAsync(data);
        }
        protected List<BsonDocument> ReadDocuments(string collectionName) //reads an entire collection from the DB
        {
            return GetCollection(collectionName).Find(new BsonDocument()).ToList();
        }
        protected BsonDocument ReadDocument(string collectionName, string columnName, int id) //reads only one document from the DB based on the filter
        {
            var filter = Builders<BsonDocument>.Filter.Eq(columnName, id);
            return GetCollection(collectionName).Find(filter).FirstOrDefault();
        }
        protected async void UpdateDocument(string collectionName, string columnName, int id, string columnToChange, int newId) //updates a document in the DB (changes an int)
        {
            var filter = Builders<BsonDocument>.Filter.Eq(columnName, id);
            var update = Builders<BsonDocument>.Update.Set(columnToChange, newId);

            await GetCollection(collectionName).UpdateOneAsync(filter, update);

        }
        protected async void UpdateDocument(string collectionName, string columnName, int id, string columnToChange, string newString)//updates a document in the DB (changes a string)
        {
            var filter = Builders<BsonDocument>.Filter.Eq(columnName, id);
            var update = Builders<BsonDocument>.Update.Set(columnToChange, newString);

           await GetCollection(collectionName).UpdateOneAsync(filter, update);

        }
        protected async void DeleteDocument(string collectionName, string columnName, int id) // deletes document from the specified collectiion
        {
            var deleteFilter = Builders<BsonDocument>.Filter.Eq(columnName, id);
           await GetCollection(collectionName).DeleteOneAsync(deleteFilter);
        }
        protected int GetLatestId(string collectionName, string columnName) //gets the ID of the latest document added in the specified collection
        {
            List<BsonDocument> documents = GetCollection(collectionName).Find(new BsonDocument()).ToList();

            int id = 1;

            if (documents.Count != 0)
                id = documents[documents.Count - 1][columnName].AsInt32 + 1;

            return id;
            
        }


    }
}
