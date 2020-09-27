using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using Model;
namespace DAO
{
    public class User_DAO : Base
    {
        public void AddUser(User user)
        {
          CreateDocument("users", createUserDocument(user));

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
