using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using Model;
using MongoDB.Driver;

namespace DAO
{
    public class User_DAO : Base
    {
        public void AddUser(User user)
        {
          CreateDocument("users", createUserDocument(user));

        }

        public bool IsUsernamePresent(string username)
        {
            IMongoCollection<BsonDocument> users = GetCollection("users");
         
           /* foreach(BsonDocument doc in users)
            {

            }*/


            return false;
        }
        private BsonDocument createUserDocument(User user)
        {
            return new BsonDocument
            {
                { "user_id", GetLatestId("users","user_id") },
                { "username", user.username },
                {"password",user.password },
                {"firstName", user.firstName },
                {"lastName",user.lastName },
                {"email",user.email },
                {"tickets",user.nrTickets }
            };
        }
    }
}
