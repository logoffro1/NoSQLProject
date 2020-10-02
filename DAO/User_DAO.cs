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

        //Written by Egehan Cinarli: checks if the username is present in the users collection.
        public bool IsUsernamePresent(string username)
        {
            //test
            List<BsonDocument> users = ReadDocuments("users");
       
            if (users.Count > 0)
            {
                foreach (BsonDocument doc in users)
                {
                    BsonValue element = doc.GetValue("username");
                    if (element.AsString.ToLower().Equals(username.ToLower()))
                    {
                        return true;
                    }
                }
            }
          
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
