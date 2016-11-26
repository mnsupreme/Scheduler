using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Menu_Pseudocode
{
    public class Restaurant
    {
        private string name;
        /// <summary>
        /// Keeps track of the number of Menus a given Restaurant has
        /// </summary>
        private int menuCount;
        /// <summary>
        /// A rate of "x out of y stars," for example; will be set to zero ONLY if ratingCount = 0
        /// </summary>
        private double rating;
        /// <summary>
        /// This may be removed--or at least changed from a string
        /// </summary>
        private string location;
        /// <summary>
        /// The number of times something has been rated on Yelp
        /// </summary>
        private int ratingCount;

        public Owner Owner
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