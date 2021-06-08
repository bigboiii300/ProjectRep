using System.Collections.Generic;

namespace QnABot.Users
{
    public class Users
    {
        static List<UserInfo> users = new List<UserInfo>();
        public static List<UserInfo> UsersList { get => users; }

        /// <summary>
        /// add new user to list
        /// </summary>
        /// <param name="user">new user</param>
        public static void AddUser(UserInfo user) => users.Add(user);
        
    }
}
