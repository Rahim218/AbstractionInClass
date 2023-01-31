using System;
using ClassLibrary;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Student std = new Student()

           
                Console.WriteLine("UserName Dail edin :");
                string userName = Console.ReadLine();
                string password;
                do
                {
                    Console.WriteLine("Passwordu daxil edin :");
                     password = Console.ReadLine();
                } while (!CheckPassWord(password));
                User user = new User();
                user.UserName = userName;
                user.Password = password;

            
        }
        static  bool CheckPassWord(string str)
        {

            if (string.IsNullOrWhiteSpace(str) || str.Length < 8 || str.Length > 25)
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
