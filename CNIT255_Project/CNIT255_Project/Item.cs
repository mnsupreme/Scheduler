using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CNIT255_Project
{
    public class Item
    {
        /// <summary>
        /// This string will be a copy of what the restaurant menu already says about a given item
        /// </summary>
        private string description;
        /// <summary>
        /// The name of the Item
        /// </summary>
        private string itemName;
        /// <summary>
        /// A given item's price in USD
        /// </summary>
        private double price;

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

        private void createItem()
        {
            throw new System.NotImplementedException();
        }

        private void delItem()
        {
            throw new System.NotImplementedException();
        }
    }
}