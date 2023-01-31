using System;

namespace ClassLibrary
{
    public class User
    {
        public string UserName;
        string _password;
        public string Password
        {
            set
            {
                if (CheckPassWord(value))
                {
                    _password = value;
                }
            }
            get
            {
                return _password;
            }
        }

        public  bool CheckPassWord(string str)
        {

            if (string.IsNullOrWhiteSpace(str) || str.Length <8 || str.Length >25)
            {
                return false;
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    return true;
                }
                
                
            }
            return false;
        }
    }
}
