using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// Represent a college advisor
    /// </summary>
    public class Advisor
    {
        /// <summary>
        /// The legal first and last name
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// The work email of the Advisor
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The location of the advisor on campus
        /// </summary>
        public string OfficeLocation { get; set; }
    }

}
