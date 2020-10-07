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
            CreateDocument("users", CreateUserDocument(user));

        }

        //written by Egehan Cinarli: gets all the users from the database as a Bson Document and converts it into a List of user objects.
        public List<User> getAllUsers()
        {
            List<BsonDocument> docs = ReadDocuments("users");
            List<User> allUsers = new List<User>();

            foreach (BsonDocument doc in docs)
            {
                User user = new User
                {
                    username = (string)doc["username"],
                    password = (string)doc["password"],
                    firstName = (string)doc["firstName"],
                    lastName = (string)doc["lastName"],
                    email = (string)doc["email"],
                    nrTickets = doc["tickets"].AsInt32,
                    id = doc["user_id"].AsInt32
                };
                allUsers.Add(user);
            }

            return allUsers;
        }

        //Written by Egehan Cinarli: checks if the username is present in the users collection.
        public bool IsUsernamePresent(string username)
        {
            //test
            List<BsonDocument> users = ReadDocuments("users");

            foreach (BsonDocument doc in users)
            {
                BsonValue element = doc.GetValue("username");
                if (element.AsString.ToLower().Equals(username.ToLower()))
                    return true;
            }

            return false;
        }
        private BsonDocument CreateUserDocument(User user)
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
        //Written by Cosmin Ilie: returns a user based on the given ID
        public User GetUserById(int id)
        {
            var userDoc = ReadDocument("users", "user_id", id);

            return new User
            {
                id = (int)userDoc["user_id"],
                username = (string)userDoc["username"],
                password = (string)userDoc["password"],
                firstName = (string)userDoc["firstName"],
                lastName = (string)userDoc["lastName"],
                email = (string)userDoc["email"],
                nrTickets = (int)userDoc["tickets"]
            };
        }
    }
}
