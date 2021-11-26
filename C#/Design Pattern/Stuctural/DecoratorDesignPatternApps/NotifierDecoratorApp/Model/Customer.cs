using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotifierDecoratorApp.Model
{
    class Customer
    {
        private string _name;
        private int _accountNo;
        private int _mobileNo;
        private string _emailId;
        private string _slackID;
        private string _facebookUserName;
        
        public Customer(int accountNo, string name, string email, string slack, string facebookUID, int mobile)
        {
            _accountNo = accountNo;
            _name = name;
            _emailId = email;
            _slackID = slack;
            _facebookUserName = facebookUID;
            _mobileNo = mobile;
        }

        public string Name 
        { 
            get => _name; 
            set => _name = value; 
        }
        public int AccountNo 
        { 
            get => _accountNo; 
            set => _accountNo = value; 
        }
        public int MobileNo 
        { 
            get => _mobileNo; 
            set => _mobileNo = value; 
        }
        public string EmailId 
        { 
            get => _emailId; 
            set => _emailId = value; 
        }
        public string SlackID 
        { 
            get => _slackID; 
            set => _slackID = value; 
        }
        public string FacebookUserName 
        { 
            get => _facebookUserName; 
            set => _facebookUserName = value; 
        }
    }
}
