using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Menu_Pseudocode
{
    public class Owner : User
    {
        /// <summary>
        /// Allows the Owner to assume control of a Restaurant
        /// </summary>
        private Restaurant r;
        /// <summary>
        /// Allows the Owner to assume control of a Restaurant's menus
        /// </summary>
        private Menu m;
        /// <summary>
        /// Allows the Owner to assume control of a Restaurant's timeSlotMenu
        /// </summary>
        private timeSlotMenu t;

        /// <summary>
        /// Clears anything having to do with a non-submitted menu
        /// </summary>
        private string delFromMemory(Restaurant r)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Allows the Owner to create a menu for a given restaurant
        /// </summary>
        public void createMenu()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Allows the Owner to add an Item to a Menu
        /// </summary>
        public void addMenuItem()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Allows the Owner to delete an Item from a Menu
        /// </summary>
        public void delMenuItem()
        {
            throw new System.NotImplementedException();
        }
    }
}