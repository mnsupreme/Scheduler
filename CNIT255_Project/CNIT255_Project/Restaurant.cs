using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CNIT255_Project
{
    public class Restaurant
    {
<<<<<<< HEAD
        /// <summary>
        /// This may be removed--or at least changed from a string
        /// </summary>
        private string location;
        /// <summary>
        /// Keeps track of the number of Menus a given Restaurant has
        /// </summary>
        private int menuCount;
        private string name;
        /// <summary>
        /// A rate of "x out of y stars," for example; will be set to zero ONLY if ratingCount = 0
        /// </summary>
        private double rating;
        /// <summary>
        /// The number of times something has been rated on Yelp
        /// </summary>
        private int ratingCount;

        public Owner Owner
=======
        public Menu Menu
>>>>>>> origin/AMCoding
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