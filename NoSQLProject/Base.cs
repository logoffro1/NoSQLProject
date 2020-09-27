using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Threading;
namespace DAO
{
    class Base
    {
        private string connectionString = "mongodb+srv://admin:admin@cluster0.kzqlj.azure.mongodb.net/garden_group?retryWrites=true&w=majority";
        MongoClient dbClient;
        IMongoDatabase database;
        public Base()
        {
            ConnectToDB();
            database = dbClient.GetDatabase("garden_group");
        }
        private void ConnectToDB()
        {
            try
            {
                dbClient = new MongoClient(connectionString);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        protected async void CreateDocument(string collectionName, BsonDocument data)
        {
            var collection = database.GetCollection<BsonDocument>(collectionName);
            await collection.InsertOneAsync(data);
        }
        protected List<BsonDocument> ReadDocuments(string collectionName)
        {
            var collection = database.GetCollection<BsonDocument>(collectionName);
            return collection.Find(new BsonDocument()).ToList();
        }
        protected BsonDocument ReadDocument(string collectionName, string columnName, int id)
        {
            var collection = database.GetCollection<BsonDocument>(collectionName);
            var filter = Builders<BsonDocument>.Filter.Eq(columnName, id);
            return collection.Find(filter).FirstOrDefault();
        }
        protected void UpdateDocument(string collectionName, string columnName, int id, string columnToChange, int newId)
        {
            var collection = database.GetCollection<BsonDocument>(collectionName);
            var filter = Builders<BsonDocument>.Filter.Eq(columnName, id);
            var update = Builders<BsonDocument>.Update.Set(columnToChange, newId);

            collection.UpdateOne(filter, update);

        }
        protected void UpdateDocument(string collectionName, string columnName, int id, string columnToChange, string newString)
        {
            var collection = database.GetCollection<BsonDocument>(collectionName);
            var filter = Builders<BsonDocument>.Filter.Eq(columnName, id);
            var update = Builders<BsonDocument>.Update.Set(columnToChange, newString);

            collection.UpdateOne(filter, update);

        }
        protected void DeleteDocument(string collectionName, string columnName, int id)
        {
            var collection = database.GetCollection<BsonDocument>(collectionName);
            var deleteFilter = Builders<BsonDocument>.Filter.Eq(columnName, id);
            collection.DeleteOne(deleteFilter);

        }


    }
}
