namespace QnABot.Users
{
    /// <summary>
    /// Class keeps information about users
    /// </summary>
    public class UserInfo
    {
        public string Id { get; private set; }
        public int Current { get; set; }  // Number of image, at which user stopped 

        public UserInfo(string id)
        {
            Current = 0;
            Id = id;
        }
    }
}
