using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CNIT255_Project
{
    public class User
    {
        private string firstName;
        private string lastName;
        private string MI;
        private string email;
        private string phoneNum;
        private string PUID;

        public string getEmail()
        {
            return this.email;
        }
        public Restaurant Restaurant
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}