using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityServiceApp.Model
{
    class SecurityService
    {
        Dictionary<string, User> users = new Dictionary<string, User>();
        
        public SecurityService()
        {
            users.Add("SM197", new User("SM197", "Sohel", "Maneri", "smaneri@gmail.com", "Sohel@197"));
            users.Add("VT3012", new User("VT3012", "Vipul", "Thombare", "vthombare@gmail.com", "Vipul@3012"));
            users.Add("SS125", new User("SS125", "Samnit", "Sapkale", "ssapkale@gmail.com", "Samnit@125"));
            users.Add("SP312", new User("SP312", "Sagar", "Pradhan", "spradhan@gmail.com", "Sagar@312"));
            users.Add("PS237", new User("PS237", "Prasad", "Sawant", "psawant@gmail.com", "Prasad@237"));
            try
            {
                users.Add("SM197", new User("SM197", "Sohel", "Maneri", "smaneri@gmail.com", "Sohel@197"));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public User Login(string id, string password)
        {

            bool login = true;
            foreach(var user in users)
            {
                if (user.Key == id && user.Value.CheckPassword(password))
                {
                    login = true;
                    return user.Value;
                }
                login = false;
            }
            if(login == false)
            {
                throw new InvalidUserException();
            }
            return null;
        }
    }
}
