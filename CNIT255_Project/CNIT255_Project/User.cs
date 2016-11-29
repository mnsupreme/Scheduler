using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CNIT255_Project
{
    public class User
    {
<<<<<<< HEAD
        int n; //the number that helps to define the number in this particular array
        int[] result = new int[0]; //just the prototype code

        /// <summary>
        /// Iterate through result array
        /// </summary>
        public void displayMenu()
        {
            throw new System.NotImplementedException();
=======
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
>>>>>>> origin/AMCoding
        }
    }
}