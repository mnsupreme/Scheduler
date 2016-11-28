using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CNIT255_Project
{
    public class Database
    {
        private List<User> Users;
        private List<Menu> Menus;
        public int id;

        public User User
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Menu Menu
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public User getUser(string email)
        {
            int i = 0;
     
                while (this.Users[i + 1] != null)
                {
                    if (Users[i].getEmail() == email)
                    {
                        return Users[i];
                    }

                    i++;
                }


            System.Windows.Forms.MessageBox.Show("no user found!");
                return null;
            
        }

        public Menu getMenu(string id)
        {
            throw new System.NotImplementedException();
        }

        public void addMenu()
        {
            throw new System.NotImplementedException();
        }

        public void addUser()
        {
            throw new System.NotImplementedException();
       }
    }
}