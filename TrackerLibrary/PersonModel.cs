using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PersonModel
    {
        /// <summary>
        /// Represents the first name of a Person.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Represents the last name of a Person.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Represent the email addres of a Person.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Represent the cellphone number of a Person.
        /// </summary>
        public string CellphoneNumber { get; set; }
    }
}
