using System.Collections.Generic;

namespace StoreManager
{
    public class ClientData
    {
        public string Name;
        public string PhoneNumber;
        public string Login;
        public string Password;
        
        public ClientData(string name, string phone, string login, string password)
        {
            Name = name;
            PhoneNumber = phone;
            Login = login;
            Password = password;
            StoreManager.clientDatas.Add(this);
        }
    }
}
